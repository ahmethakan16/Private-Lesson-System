namespace Etüt_Ders_Sistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEtutOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDersEkle = new System.Windows.Forms.Button();
            this.textBoxDers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.maskedTextBoxOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxOgrenciMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOgrenciSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOgrenciAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonFotografYukle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonOgretmenEkle = new System.Windows.Forms.Button();
            this.textBoxOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOgretmenAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(84, 59);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(223, 26);
            this.comboBoxDers.TabIndex = 1;
            this.comboBoxDers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen:";
            // 
            // comboBoxOgretmen
            // 
            this.comboBoxOgretmen.FormattingEnabled = true;
            this.comboBoxOgretmen.Location = new System.Drawing.Point(83, 104);
            this.comboBoxOgretmen.Name = "comboBoxOgretmen";
            this.comboBoxOgretmen.Size = new System.Drawing.Size(224, 26);
            this.comboBoxOgretmen.TabIndex = 3;
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(83, 152);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(224, 25);
            this.maskedTextBoxTarih.TabIndex = 4;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(84, 193);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(223, 25);
            this.maskedTextBoxSaat.TabIndex = 5;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // buttonEtutOlustur
            // 
            this.buttonEtutOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEtutOlustur.Location = new System.Drawing.Point(107, 240);
            this.buttonEtutOlustur.Name = "buttonEtutOlustur";
            this.buttonEtutOlustur.Size = new System.Drawing.Size(160, 31);
            this.buttonEtutOlustur.TabIndex = 8;
            this.buttonEtutOlustur.Text = "Etüt Oluştur";
            this.buttonEtutOlustur.UseVisualStyleBackColor = false;
            this.buttonEtutOlustur.Click += new System.EventHandler(this.buttonEtutOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEtutOlustur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox1.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox1.Controls.Add(this.comboBoxOgretmen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 360);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etüt Oluştur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.buttonEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(423, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 215);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etüt Detayları";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(105, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 25);
            this.textBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Etüt Id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 25);
            this.textBox1.TabIndex = 10;
            // 
            // buttonEtutVer
            // 
            this.buttonEtutVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEtutVer.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEtutVer.Location = new System.Drawing.Point(126, 146);
            this.buttonEtutVer.Name = "buttonEtutVer";
            this.buttonEtutVer.Size = new System.Drawing.Size(160, 31);
            this.buttonEtutVer.TabIndex = 9;
            this.buttonEtutVer.Text = "Etüt Ver";
            this.buttonEtutVer.UseVisualStyleBackColor = false;
            this.buttonEtutVer.Click += new System.EventHandler(this.buttonEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(18, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 311);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Etüt Listeleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDersEkle);
            this.groupBox4.Controls.Add(this.textBoxDers);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(423, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 139);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ders İşlemleri";
            // 
            // buttonDersEkle
            // 
            this.buttonDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDersEkle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDersEkle.Location = new System.Drawing.Point(78, 73);
            this.buttonDersEkle.Name = "buttonDersEkle";
            this.buttonDersEkle.Size = new System.Drawing.Size(160, 31);
            this.buttonDersEkle.TabIndex = 12;
            this.buttonDersEkle.Text = "Ders Ekle";
            this.buttonDersEkle.UseVisualStyleBackColor = false;
            this.buttonDersEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
            // 
            // textBoxDers
            // 
            this.textBoxDers.Location = new System.Drawing.Point(69, 39);
            this.textBoxDers.Name = "textBoxDers";
            this.textBoxDers.Size = new System.Drawing.Size(181, 25);
            this.textBoxDers.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ders:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonOgrenciEkle);
            this.groupBox5.Controls.Add(this.maskedTextBoxOgrenciTelefon);
            this.groupBox5.Controls.Add(this.textBoxOgrenciMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBoxOgrenciSinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.textBoxOgrenciSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBoxOgrenciAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(772, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 360);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Öğrenci İşlemleri";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOgrenciEkle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(95, 254);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(160, 31);
            this.buttonOgrenciEkle.TabIndex = 22;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = false;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // maskedTextBoxOgrenciTelefon
            // 
            this.maskedTextBoxOgrenciTelefon.Location = new System.Drawing.Point(75, 173);
            this.maskedTextBoxOgrenciTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxOgrenciTelefon.Name = "maskedTextBoxOgrenciTelefon";
            this.maskedTextBoxOgrenciTelefon.Size = new System.Drawing.Size(180, 25);
            this.maskedTextBoxOgrenciTelefon.TabIndex = 21;
            // 
            // textBoxOgrenciMail
            // 
            this.textBoxOgrenciMail.Location = new System.Drawing.Point(75, 213);
            this.textBoxOgrenciMail.Name = "textBoxOgrenciMail";
            this.textBoxOgrenciMail.Size = new System.Drawing.Size(181, 25);
            this.textBoxOgrenciMail.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Telefon:";
            // 
            // textBoxOgrenciSinif
            // 
            this.textBoxOgrenciSinif.Location = new System.Drawing.Point(74, 128);
            this.textBoxOgrenciSinif.Name = "textBoxOgrenciSinif";
            this.textBoxOgrenciSinif.Size = new System.Drawing.Size(181, 25);
            this.textBoxOgrenciSinif.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sınıf:";
            // 
            // textBoxOgrenciSoyad
            // 
            this.textBoxOgrenciSoyad.Location = new System.Drawing.Point(74, 85);
            this.textBoxOgrenciSoyad.Name = "textBoxOgrenciSoyad";
            this.textBoxOgrenciSoyad.Size = new System.Drawing.Size(181, 25);
            this.textBoxOgrenciSoyad.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Soyadı:";
            // 
            // textBoxOgrenciAd
            // 
            this.textBoxOgrenciAd.Location = new System.Drawing.Point(74, 44);
            this.textBoxOgrenciAd.Name = "textBoxOgrenciAd";
            this.textBoxOgrenciAd.Size = new System.Drawing.Size(181, 25);
            this.textBoxOgrenciAd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adı:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonFotografYukle);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1139, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 360);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fotoğraf İşlemleri";
            // 
            // buttonFotografYukle
            // 
            this.buttonFotografYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFotografYukle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFotografYukle.Location = new System.Drawing.Point(59, 294);
            this.buttonFotografYukle.Name = "buttonFotografYukle";
            this.buttonFotografYukle.Size = new System.Drawing.Size(160, 31);
            this.buttonFotografYukle.TabIndex = 23;
            this.buttonFotografYukle.Text = "Fotoğraf Yükle";
            this.buttonFotografYukle.UseVisualStyleBackColor = false;
            this.buttonFotografYukle.Click += new System.EventHandler(this.buttonFotografYukle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.buttonOgretmenEkle);
            this.groupBox7.Controls.Add(this.textBoxOgretmenSoyad);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.textBoxOgretmenAd);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(1058, 389);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(369, 308);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Öğretmen İşlemleri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 26);
            this.comboBox1.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ders:";
            // 
            // buttonOgretmenEkle
            // 
            this.buttonOgretmenEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOgretmenEkle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgretmenEkle.Location = new System.Drawing.Point(112, 177);
            this.buttonOgretmenEkle.Name = "buttonOgretmenEkle";
            this.buttonOgretmenEkle.Size = new System.Drawing.Size(160, 31);
            this.buttonOgretmenEkle.TabIndex = 21;
            this.buttonOgretmenEkle.Text = "Öğretmen Ekle";
            this.buttonOgretmenEkle.UseVisualStyleBackColor = false;
            this.buttonOgretmenEkle.Click += new System.EventHandler(this.buttonOgretmenEkle_Click);
            // 
            // textBoxOgretmenSoyad
            // 
            this.textBoxOgretmenSoyad.Location = new System.Drawing.Point(81, 90);
            this.textBoxOgretmenSoyad.Name = "textBoxOgretmenSoyad";
            this.textBoxOgretmenSoyad.Size = new System.Drawing.Size(219, 25);
            this.textBoxOgretmenSoyad.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "Soyadı:";
            // 
            // textBoxOgretmenAd
            // 
            this.textBoxOgretmenAd.Location = new System.Drawing.Point(81, 49);
            this.textBoxOgretmenAd.Name = "textBoxOgretmenAd";
            this.textBoxOgretmenAd.Size = new System.Drawing.Size(219, 25);
            this.textBoxOgretmenAd.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Adı:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1439, 739);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etüt Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOgretmen;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEtutOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEtutVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOgrenciTelefon;
        private System.Windows.Forms.TextBox textBoxOgrenciMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOgrenciSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxOgrenciSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOgrenciAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonDersEkle;
        private System.Windows.Forms.TextBox textBoxDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonFotografYukle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonOgretmenEkle;
        private System.Windows.Forms.TextBox textBoxOgretmenSoyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOgretmenAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

