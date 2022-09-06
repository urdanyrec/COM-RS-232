
namespace Serial_RS_232
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.Ibutton = new System.Windows.Forms.Button();
            this.Rbutton = new System.Windows.Forms.Button();
            this.Pbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.Sbutton = new System.Windows.Forms.Button();
            this.Bbutton = new System.Windows.Forms.Button();
            this.Fbutton = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ilabel = new System.Windows.Forms.Label();
            this.Rlabel = new System.Windows.Forms.Label();
            this.Plabel = new System.Windows.Forms.Label();
            this.Clabel = new System.Windows.Forms.Label();
            this.Slabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.Flabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSet = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросНастроекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buffer = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 290);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox7);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.Ibutton);
            this.tabPage1.Controls.Add(this.Rbutton);
            this.tabPage1.Controls.Add(this.Pbutton);
            this.tabPage1.Controls.Add(this.Cbutton);
            this.tabPage1.Controls.Add(this.Sbutton);
            this.tabPage1.Controls.Add(this.Bbutton);
            this.tabPage1.Controls.Add(this.Fbutton);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Ilabel);
            this.tabPage1.Controls.Add(this.Rlabel);
            this.tabPage1.Controls.Add(this.Plabel);
            this.tabPage1.Controls.Add(this.Clabel);
            this.tabPage1.Controls.Add(this.Slabel);
            this.tabPage1.Controls.Add(this.Blabel);
            this.tabPage1.Controls.Add(this.Flabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Установка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox7.Location = new System.Drawing.Point(230, 161);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(107, 21);
            this.comboBox7.TabIndex = 22;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.comboBox6.Location = new System.Drawing.Point(230, 83);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(107, 21);
            this.comboBox6.TabIndex = 21;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "7000",
            "7800",
            "10400",
            "15600",
            "31200",
            "41700",
            "62500",
            "125000",
            "250000",
            "500000"});
            this.comboBox5.Location = new System.Drawing.Point(230, 45);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(107, 21);
            this.comboBox5.TabIndex = 20;
            // 
            // Ibutton
            // 
            this.Ibutton.Location = new System.Drawing.Point(365, 227);
            this.Ibutton.Name = "Ibutton";
            this.Ibutton.Size = new System.Drawing.Size(90, 21);
            this.Ibutton.TabIndex = 19;
            this.Ibutton.Text = "Установить";
            this.Ibutton.UseVisualStyleBackColor = true;
            this.Ibutton.Click += new System.EventHandler(this.Ibutton_Click);
            // 
            // Rbutton
            // 
            this.Rbutton.Location = new System.Drawing.Point(365, 191);
            this.Rbutton.Name = "Rbutton";
            this.Rbutton.Size = new System.Drawing.Size(90, 21);
            this.Rbutton.TabIndex = 18;
            this.Rbutton.Text = "Установить";
            this.Rbutton.UseVisualStyleBackColor = true;
            this.Rbutton.Click += new System.EventHandler(this.Rbutton_Click);
            // 
            // Pbutton
            // 
            this.Pbutton.Location = new System.Drawing.Point(365, 161);
            this.Pbutton.Name = "Pbutton";
            this.Pbutton.Size = new System.Drawing.Size(90, 21);
            this.Pbutton.TabIndex = 17;
            this.Pbutton.Text = "Установить";
            this.Pbutton.UseVisualStyleBackColor = true;
            this.Pbutton.Click += new System.EventHandler(this.Pbutton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.Location = new System.Drawing.Point(365, 125);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(90, 21);
            this.Cbutton.TabIndex = 16;
            this.Cbutton.Text = "Установить";
            this.Cbutton.UseVisualStyleBackColor = true;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // Sbutton
            // 
            this.Sbutton.Location = new System.Drawing.Point(365, 82);
            this.Sbutton.Name = "Sbutton";
            this.Sbutton.Size = new System.Drawing.Size(90, 21);
            this.Sbutton.TabIndex = 15;
            this.Sbutton.Text = "Установить";
            this.Sbutton.UseVisualStyleBackColor = true;
            this.Sbutton.Click += new System.EventHandler(this.Sbutton_Click);
            // 
            // Bbutton
            // 
            this.Bbutton.Location = new System.Drawing.Point(365, 44);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.Size = new System.Drawing.Size(90, 21);
            this.Bbutton.TabIndex = 14;
            this.Bbutton.Text = "Установить";
            this.Bbutton.UseVisualStyleBackColor = true;
            this.Bbutton.Click += new System.EventHandler(this.Bbutton_Click);
            // 
            // Fbutton
            // 
            this.Fbutton.Location = new System.Drawing.Point(365, 14);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(90, 21);
            this.Fbutton.TabIndex = 6;
            this.Fbutton.Text = "Установить";
            this.Fbutton.UseVisualStyleBackColor = true;
            this.Fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox4.Location = new System.Drawing.Point(230, 228);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(107, 21);
            this.comboBox4.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox3.Location = new System.Drawing.Point(230, 192);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(107, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0x45",
            "0x46",
            "0x47",
            "0x48"});
            this.comboBox2.Location = new System.Drawing.Point(230, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(230, 15);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Ilabel
            // 
            this.Ilabel.AutoSize = true;
            this.Ilabel.Location = new System.Drawing.Point(48, 224);
            this.Ilabel.MaximumSize = new System.Drawing.Size(160, 50);
            this.Ilabel.Name = "Ilabel";
            this.Ilabel.Size = new System.Drawing.Size(160, 26);
            this.Ilabel.TabIndex = 6;
            this.Ilabel.Text = "Установка наличия режима фиксированной длины пакета";
            this.Ilabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Rlabel
            // 
            this.Rlabel.AutoSize = true;
            this.Rlabel.Location = new System.Drawing.Point(48, 194);
            this.Rlabel.MaximumSize = new System.Drawing.Size(160, 50);
            this.Rlabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.Rlabel.Name = "Rlabel";
            this.Rlabel.Size = new System.Drawing.Size(160, 13);
            this.Rlabel.TabIndex = 5;
            this.Rlabel.Text = "Установка наличия поля";
            this.Rlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Plabel
            // 
            this.Plabel.AutoSize = true;
            this.Plabel.Location = new System.Drawing.Point(48, 164);
            this.Plabel.MaximumSize = new System.Drawing.Size(160, 50);
            this.Plabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.Plabel.Name = "Plabel";
            this.Plabel.Size = new System.Drawing.Size(160, 13);
            this.Plabel.TabIndex = 4;
            this.Plabel.Text = "Установка мощности";
            this.Plabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Clabel
            // 
            this.Clabel.AutoSize = true;
            this.Clabel.Location = new System.Drawing.Point(48, 121);
            this.Clabel.MaximumSize = new System.Drawing.Size(160, 50);
            this.Clabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.Clabel.Name = "Clabel";
            this.Clabel.Size = new System.Drawing.Size(160, 26);
            this.Clabel.TabIndex = 3;
            this.Clabel.Text = "Установка коэффициента кодирования";
            this.Clabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Slabel
            // 
            this.Slabel.AutoSize = true;
            this.Slabel.Location = new System.Drawing.Point(48, 78);
            this.Slabel.MaximumSize = new System.Drawing.Size(160, 50);
            this.Slabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.Slabel.Name = "Slabel";
            this.Slabel.Size = new System.Drawing.Size(160, 26);
            this.Slabel.TabIndex = 2;
            this.Slabel.Text = "Установка коэффициента расширения спектра";
            this.Slabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Location = new System.Drawing.Point(48, 48);
            this.Blabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(160, 13);
            this.Blabel.TabIndex = 1;
            this.Blabel.Text = "Установка полосы";
            this.Blabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Flabel
            // 
            this.Flabel.AutoSize = true;
            this.Flabel.Location = new System.Drawing.Point(48, 18);
            this.Flabel.MaximumSize = new System.Drawing.Size(160, 0);
            this.Flabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.Flabel.Name = "Flabel";
            this.Flabel.Size = new System.Drawing.Size(160, 13);
            this.Flabel.TabIndex = 0;
            this.Flabel.Text = "Установка частоты";
            this.Flabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.buttonDrop);
            this.tabPage2.Controls.Add(this.buttonRequest);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запрос";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(264, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 252);
            this.panel1.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(0, 229);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(0, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 0;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(433, 135);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(75, 21);
            this.buttonDrop.TabIndex = 21;
            this.buttonDrop.Text = "Сбросить";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(433, 102);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 21);
            this.buttonRequest.TabIndex = 6;
            this.buttonRequest.Text = "Запрос";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 210);
            this.label11.MaximumSize = new System.Drawing.Size(300, 0);
            this.label11.MinimumSize = new System.Drawing.Size(160, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "SNR последнего принятого пакета:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 185);
            this.label10.MaximumSize = new System.Drawing.Size(300, 0);
            this.label10.MinimumSize = new System.Drawing.Size(160, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "RSSI последнего принятого пакета:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 235);
            this.label9.MaximumSize = new System.Drawing.Size(300, 0);
            this.label9.MinimumSize = new System.Drawing.Size(160, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Текущий уровень RSSI:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.MaximumSize = new System.Drawing.Size(300, 0);
            this.label8.MinimumSize = new System.Drawing.Size(160, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Наличие режима фиксированной длины пакета:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 135);
            this.label7.MaximumSize = new System.Drawing.Size(300, 0);
            this.label7.MinimumSize = new System.Drawing.Size(160, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Наличие режима CRC:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 110);
            this.label5.MaximumSize = new System.Drawing.Size(300, 0);
            this.label5.MinimumSize = new System.Drawing.Size(160, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коэффициент кодирования:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 60);
            this.label4.MaximumSize = new System.Drawing.Size(300, 0);
            this.label4.MinimumSize = new System.Drawing.Size(160, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Коэффициент расширения спектра:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 35);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.MinimumSize = new System.Drawing.Size(160, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Полоса:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 10);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.MinimumSize = new System.Drawing.Size(160, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Частота:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 85);
            this.label6.MaximumSize = new System.Drawing.Size(300, 0);
            this.label6.MinimumSize = new System.Drawing.Size(160, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Мощность:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSet);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.labelSet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(598, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Передача и прием данных";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(367, 115);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(90, 21);
            this.buttonSet.TabIndex = 9;
            this.buttonSet.Text = "Отправить";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(232, 116);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 10;
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Location = new System.Drawing.Point(50, 119);
            this.labelSet.MaximumSize = new System.Drawing.Size(160, 0);
            this.labelSet.MinimumSize = new System.Drawing.Size(160, 0);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(160, 13);
            this.labelSet.TabIndex = 8;
            this.labelSet.Text = "Передача данных";
            this.labelSet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.сбросНастроекToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // сбросНастроекToolStripMenuItem
            // 
            this.сбросНастроекToolStripMenuItem.Name = "сбросНастроекToolStripMenuItem";
            this.сбросНастроекToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сбросНастроекToolStripMenuItem.Text = "Сброс настроек";
            this.сбросНастроекToolStripMenuItem.Click += new System.EventHandler(this.сбросНастроекToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 356);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(602, 151);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Порт:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(177, 33);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 21);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buffer
            // 
            this.buffer.Location = new System.Drawing.Point(348, 33);
            this.buffer.Name = "buffer";
            this.buffer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.buffer.Size = new System.Drawing.Size(31, 40);
            this.buffer.TabIndex = 7;
            this.buffer.Text = "";
            this.buffer.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(489, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "RSSI:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(530, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 13);
            this.label23.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 519);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.buffer);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS-232";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label Flabel;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Ilabel;
        private System.Windows.Forms.Label Rlabel;
        private System.Windows.Forms.Label Plabel;
        private System.Windows.Forms.Label Clabel;
        private System.Windows.Forms.Label Slabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.ToolStripMenuItem сбросНастроекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button Ibutton;
        private System.Windows.Forms.Button Rbutton;
        private System.Windows.Forms.Button Pbutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button Sbutton;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.RichTextBox buffer;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

