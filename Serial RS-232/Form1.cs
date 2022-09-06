using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Serial_RS_232
{
    public partial class Form1 : Form
    {
        string output; //Output string
        string input; //Input string
        string patternRSSI = @"^a-*\w*a"; //паттерн строки уровня RSSi
        char[] query = { 'f', 'b', 's', 'p', 'c', 'r', 'i', 'j', 'k', 'l' }; //команды запроса
        bool flagReq = false; //флаг запроса
        //bool flagFill = false;
        short iter; //номер итерации запроса

        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_Send(string message)//отправка строки открытия порта и установки
        {
            if (serialPort1.IsOpen)
            {
                flagReq = false;
                message += "\r\n";
                serialPort1.Write(message);
                byte[] bb = Encoding.GetEncoding(1251).GetBytes(message);
                output = BitConverter.ToString(bb);
                output = output.Replace("-", "");
            }
        }

        private void serialPort1_SendRequest(string message) //отправка строки
        {
            if (serialPort1.IsOpen)
            {
                flagReq = true;
                message += "\r\n";
                serialPort1.Write(message);
                //System.Threading.Thread.Sleep(1000);
                //serialPort1.DataReceived += serialPort1_DataReceived;
                //richTextBox1.Text += message + "\n";
                byte[] bb = Encoding.GetEncoding(1251).GetBytes(message);
                output = BitConverter.ToString(bb);
                output = output.Replace("-", "");
                //output += "0D0A";
                //System.Threading.Thread.Sleep(500);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //прием строки
        {
            try
            {
                input = serialPort1.ReadExisting();               
                this.Invoke(new EventHandler(DoUpdate));
                //string input = serialPort1.ReadLine(); 
                //richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: " + serialPort1.ReadLine() + "\n";

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //this.Invoke(new EventHandler(DoUpdate));
            }
        }

        private void DoUpdate(object sender, EventArgs e)
        {
            if (Regex.IsMatch(input, patternRSSI, RegexOptions.IgnoreCase))
            {
                //input.Replace("\r\n", "");
                label23.Text = input.Replace("a", "");
            }
            else
            {
                if (flagReq == false) richTextBox1.Text += input;
                else
                {
                    buffer.Text += input;
                    FillLabel();
                    //iter++;
                    //System.Threading.Thread.Sleep(100);
                }
            }
            
           /* if (iter >= 10)
            {
                FillLabel();
                iter = 0;
            }
            /*if (flagFill == true)
            {
                Tim();
                flagFill = false;
            }*/
        }

        private void FillLabel() //Вывод разультата запроса
        {
            short inn = 0;
            List<string> mas = new List<string>();
            foreach (string i in buffer.Lines)
                mas.Add(i);
            buffer.Text = null;
            //for (short i = 0; i < 10; i++) richTextBox1.Text += mas[i];
            foreach (Label lbl in panel1.Controls.OfType<Label>().Reverse())
            {
                //System.Threading.Thread.Sleep(10);
                lbl.Text = mas[inn];
                inn++;
            }

        }

        private void buttonRequest_Click(object sender, EventArgs e) //запрос параметров
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    flagReq = true;
                    serialPort1_SendRequest("A");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*
            iter = 0;
            flagReq = true;
            foreach (Label lbl in panel1.Controls.OfType<Label>().Reverse())
            {
                System.Threading.Thread.Sleep(500);
                serialPort1_SendRequest(query[iter].ToString());               
                System.Threading.Thread.Sleep(500);
                iter++;
            }
            iter = 0;
            //flagFill = true;*/
        }

        private void Form1_Load(object sender, EventArgs e) //загрузка формы
        {
            string[] port = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(port);
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет доступных последовательных портов", "Message", MessageBoxButtons.OK);
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
        }

        private void buttonOpen_Click(object sender, EventArgs e) //выбор, открытие, закрытие порта
        {
            if (serialPort1.IsOpen)
            {
                buttonOpen.Text = "Открыть";
                serialPort1.Close();
                richTextBox1.Text += DateTime.Now.ToString() + ": Порт " + comboBox1.Text + " закрыт.\n";
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    //serialPort1.ReadTimeout = 10;
                    //serialPort1.WriteTimeout = 10;
                    serialPort1.Open();
                    richTextBox1.Text += DateTime.Now.ToString() + ": Порт " + comboBox1.Text + " открыт.\n";
                    output = "U";
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": Устройство готово к работе. " + "Hex: ";// + HexIn;// + "\n";
                    buttonOpen.Text = "Закрыть";              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonOpen.Text = "Открыть";
                }
            }
        }

        private void Fbutton_Click(object sender, EventArgs e) //установка частоты
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    int Freq = int.Parse(textBox1.Text);
                    if (Freq >= 100000000 && Freq <= 999999999)
                    {
                        output = "F" + Freq.ToString();
                    }
                    else
                    {
                        textBox1.Text = "100000000";
                        output = "F" + "100000000";
                    }
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Flabel.Text + ": " + textBox1.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                    textBox1.Text = null;
                }
                catch
                {
                    MessageBox.Show("Введите частоту от 100000000 до 999999999.", "Message", MessageBoxButtons.OK);
                }
            }
        }  
       
        private void Bbutton_Click(object sender, EventArgs e) //установка полосы
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string Band = "B" + comboBox5.Text;
                    output = Band;
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Blabel.Text + ": " + comboBox5.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                    //output = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void Sbutton_Click(object sender, EventArgs e) //Установка коэффициента расширения спектра
        {
            if (serialPort1.IsOpen)
            {
                try 
                { 
                    output = "S" + comboBox6.Text;
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Slabel.Text + ": " + comboBox6.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void Cbutton_Click(object sender, EventArgs e) //Установка коэффициента кодирования
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string Code = "C";
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: Code += 69; break;
                        case 1: Code += 70; break;
                        case 2: Code += 71; break;
                        case 3: Code += 72; break;
                    }
                    output = Code;
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Clabel.Text + ": " + comboBox2.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                    //output = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pbutton_Click(object sender, EventArgs e) //Установка мощности
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string Pwr = "P" + comboBox7.Text;
                    output = Pwr;
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Plabel.Text + ": " + comboBox7.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                    //output = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Rbutton_Click(object sender, EventArgs e) //Установка наличия поля CRC
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string CRC = "R" + comboBox3.Text;
                    output = CRC;
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Rlabel.Text + ": " + comboBox3.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                    //output = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Ibutton_Click(object sender, EventArgs e) //Установка наличия режима фиксированной длины пакета
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    int Imp = comboBox4.SelectedIndex;
                    if (Imp == 0) output = "I0";                    
                    else  output = "I1";
                    serialPort1_Send(output);
                    richTextBox1.Text += DateTime.Now.ToString() + ": " + Ilabel.Text + ": " + comboBox4.Text + ". Hex: " + output + "\n";
                    richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                    //output = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void buttonDrop_Click(object sender, EventArgs e) //сброс запрошенных параметров
        {
            foreach (Label lbl in panel1.Controls.OfType<Label>().Reverse()) lbl.Text = "";          
        }

        private void сбросНастроекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] port = SerialPort.GetPortNames();
                comboBox1.Items.AddRange(port);
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
                comboBox7.SelectedIndex = 0;
                richTextBox1.Text = null;
                buttonOpen.Text = "Открыть";
                serialPort1.Close();
                //short iter = 0;
                flagReq = false;
                foreach (Label lbl in panel1.Controls.OfType<Label>().Reverse()) lbl.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSet_Click(object sender, EventArgs e) //Передача данных
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if(textBox2.Text != null)
                    {
                        //int Freq = int.Parse(textBox2.Text);
                        output = /*"D"+*/  textBox2.Text; //+ D
                        serialPort1_Send(output);
                        richTextBox1.Text += DateTime.Now.ToString() + ": " + labelSet.Text + ": " + textBox2.Text + ". Hex: " + output + "\n";
                        //HexIn = null;
                        //serialPort1.DataReceived += serialPort1_DataReceived;
                        //output = null;
                        //if (HexIn != null)
                        //{
                        richTextBox1.Text += DateTime.Now.ToString() + ": Принят Hex: ";// + HexIn + "\n";
                        //}
                        //else
                        //{

                        //}
                        textBox1.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 || tabControl1.SelectedIndex == 2) flagReq = false;
            else flagReq = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(port);
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch 
            {
                MessageBox.Show("Нет доступных последовательных портов", "Message", MessageBoxButtons.OK);
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(port);
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Нет доступных последовательных портов", "Message", MessageBoxButtons.OK);
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
        }
    }
}
