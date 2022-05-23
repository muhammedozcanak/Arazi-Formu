
namespace AraziTakip
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
            this.components = new System.ComponentModel.Container();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PersonelAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPersonel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtsicil = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.KonumId = new System.Windows.Forms.TextBox();
            this.UpdateLocation = new System.Windows.Forms.Button();
            this.DeleteLocation = new System.Windows.Forms.Button();
            this.txtmah = new System.Windows.Forms.TextBox();
            this.SaveLocation = new System.Windows.Forms.Button();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.KonumAra = new System.Windows.Forms.TextBox();
            this.dgvKonum = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.IdFull = new System.Windows.Forms.Label();
            this.comboFull = new System.Windows.Forms.ComboBox();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.fullAra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.excell = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.fullUpdate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.aciklamaFull = new System.Windows.Forms.RichTextBox();
            this.fullDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.fullSave = new System.Windows.Forms.Button();
            this.amirId = new System.Windows.Forms.Label();
            this.amirFull = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gorevFull = new System.Windows.Forms.TextBox();
            this.personId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.personelFull = new System.Windows.Forms.ComboBox();
            this.konumFull = new System.Windows.Forms.ComboBox();
            this.tblilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araziDBDataSet = new AraziTakip.AraziDBDataSet();
            this.tbl_ilTableAdapter = new AraziTakip.AraziDBDataSetTableAdapters.tbl_ilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.tabPersonel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonum)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araziDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AllowUserToAddRows = false;
            this.dgvPersonel.AllowUserToDeleteRows = false;
            this.dgvPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(0, 34);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.ReadOnly = true;
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(734, 560);
            this.dgvPersonel.TabIndex = 8;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPersonel_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(198, 244);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 49);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(317, 244);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 49);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtBirim
            // 
            this.txtBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirim.Location = new System.Drawing.Point(153, 210);
            this.txtBirim.MaxLength = 50;
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(229, 28);
            this.txtBirim.TabIndex = 4;
            this.txtBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(79, 244);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 49);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(153, 74);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(229, 28);
            this.txtId.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PersonelAra
            // 
            this.PersonelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAra.Location = new System.Drawing.Point(57, 6);
            this.PersonelAra.Name = "PersonelAra";
            this.PersonelAra.Size = new System.Drawing.Size(195, 27);
            this.PersonelAra.TabIndex = 5;
            this.PersonelAra.TextChanged += new System.EventHandler(this.PersonelAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ara:";
            // 
            // tabPersonel
            // 
            this.tabPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPersonel.Controls.Add(this.tabPage1);
            this.tabPersonel.Controls.Add(this.tabPage2);
            this.tabPersonel.Controls.Add(this.tabPage3);
            this.tabPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPersonel.Location = new System.Drawing.Point(0, 0);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.SelectedIndex = 0;
            this.tabPersonel.Size = new System.Drawing.Size(1260, 627);
            this.tabPersonel.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvPersonel);
            this.tabPage1.Controls.Add(this.PersonelAra);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnEkle);
            this.groupBox4.Controls.Add(this.txtId);
            this.groupBox4.Controls.Add(this.txtBirim);
            this.groupBox4.Controls.Add(this.txtsicil);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtSoyad);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtAd);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(740, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 564);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PERSONEL KAYIT SAYFASI";
            // 
            // txtsicil
            // 
            this.txtsicil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsicil.Location = new System.Drawing.Point(153, 176);
            this.txtsicil.MaxLength = 50;
            this.txtsicil.Name = "txtsicil";
            this.txtsicil.Size = new System.Drawing.Size(229, 28);
            this.txtsicil.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(56, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 32);
            this.label15.TabIndex = 13;
            this.label15.Text = "Sicil No:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(153, 142);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(229, 28);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(84, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birim:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Soyad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(153, 108);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(229, 28);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 28);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.KonumAra);
            this.tabPage2.Controls.Add(this.dgvKonum);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1252, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Konum Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.KonumId);
            this.groupBox3.Controls.Add(this.UpdateLocation);
            this.groupBox3.Controls.Add(this.DeleteLocation);
            this.groupBox3.Controls.Add(this.txtmah);
            this.groupBox3.Controls.Add(this.SaveLocation);
            this.groupBox3.Controls.Add(this.txtilce);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtil);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(781, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 564);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADRES KAYIT SAYFASI";
            // 
            // KonumId
            // 
            this.KonumId.Cursor = System.Windows.Forms.Cursors.No;
            this.KonumId.Enabled = false;
            this.KonumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KonumId.Location = new System.Drawing.Point(137, 82);
            this.KonumId.Name = "KonumId";
            this.KonumId.ReadOnly = true;
            this.KonumId.Size = new System.Drawing.Size(229, 28);
            this.KonumId.TabIndex = 20;
            // 
            // UpdateLocation
            // 
            this.UpdateLocation.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateLocation.ForeColor = System.Drawing.Color.Black;
            this.UpdateLocation.Location = new System.Drawing.Point(277, 229);
            this.UpdateLocation.Name = "UpdateLocation";
            this.UpdateLocation.Size = new System.Drawing.Size(113, 49);
            this.UpdateLocation.TabIndex = 19;
            this.UpdateLocation.Text = "Güncelle";
            this.UpdateLocation.UseVisualStyleBackColor = false;
            this.UpdateLocation.Click += new System.EventHandler(this.UpdateLocation_Click);
            // 
            // DeleteLocation
            // 
            this.DeleteLocation.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteLocation.ForeColor = System.Drawing.Color.Black;
            this.DeleteLocation.Location = new System.Drawing.Point(158, 229);
            this.DeleteLocation.Name = "DeleteLocation";
            this.DeleteLocation.Size = new System.Drawing.Size(113, 49);
            this.DeleteLocation.TabIndex = 18;
            this.DeleteLocation.Text = "Sil";
            this.DeleteLocation.UseVisualStyleBackColor = false;
            this.DeleteLocation.Click += new System.EventHandler(this.DeleteLocation_Click);
            // 
            // txtmah
            // 
            this.txtmah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmah.Location = new System.Drawing.Point(138, 184);
            this.txtmah.Name = "txtmah";
            this.txtmah.Size = new System.Drawing.Size(228, 28);
            this.txtmah.TabIndex = 3;
            // 
            // SaveLocation
            // 
            this.SaveLocation.BackColor = System.Drawing.Color.Transparent;
            this.SaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveLocation.ForeColor = System.Drawing.Color.Black;
            this.SaveLocation.Location = new System.Drawing.Point(39, 229);
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.Size = new System.Drawing.Size(113, 49);
            this.SaveLocation.TabIndex = 17;
            this.SaveLocation.Text = "Kaydet";
            this.SaveLocation.UseVisualStyleBackColor = false;
            this.SaveLocation.Click += new System.EventHandler(this.SaveLocation_Click);
            // 
            // txtilce
            // 
            this.txtilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilce.Location = new System.Drawing.Point(138, 150);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(228, 28);
            this.txtilce.TabIndex = 2;
            this.txtilce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(85, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtil
            // 
            this.txtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtil.Location = new System.Drawing.Point(138, 116);
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(228, 28);
            this.txtil.TabIndex = 1;
            this.txtil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(82, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "İlçe:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mahalle:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(85, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "İl:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Ara:";
            // 
            // KonumAra
            // 
            this.KonumAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KonumAra.Location = new System.Drawing.Point(57, 6);
            this.KonumAra.Name = "KonumAra";
            this.KonumAra.Size = new System.Drawing.Size(241, 27);
            this.KonumAra.TabIndex = 4;
            this.KonumAra.TextChanged += new System.EventHandler(this.KonumAra_TextChanged);
            // 
            // dgvKonum
            // 
            this.dgvKonum.AllowUserToAddRows = false;
            this.dgvKonum.AllowUserToDeleteRows = false;
            this.dgvKonum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKonum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonum.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvKonum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonum.Location = new System.Drawing.Point(3, 34);
            this.dgvKonum.Name = "dgvKonum";
            this.dgvKonum.ReadOnly = true;
            this.dgvKonum.RowHeadersWidth = 51;
            this.dgvKonum.RowTemplate.Height = 24;
            this.dgvKonum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonum.Size = new System.Drawing.Size(772, 560);
            this.dgvKonum.TabIndex = 26;
            this.dgvKonum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonum_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.IdFull);
            this.tabPage3.Controls.Add(this.comboFull);
            this.tabPage3.Controls.Add(this.dgvFull);
            this.tabPage3.Controls.Add(this.fullAra);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1252, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kayıt Sayfası";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(8, 276);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 32);
            this.label18.TabIndex = 29;
            this.label18.Text = "ARA:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(490, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "ID:";
            // 
            // IdFull
            // 
            this.IdFull.AutoSize = true;
            this.IdFull.ForeColor = System.Drawing.Color.Black;
            this.IdFull.Location = new System.Drawing.Point(520, 280);
            this.IdFull.Name = "IdFull";
            this.IdFull.Size = new System.Drawing.Size(0, 20);
            this.IdFull.TabIndex = 5;
            this.IdFull.Tag = "Id";
            // 
            // comboFull
            // 
            this.comboFull.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFull.FormattingEnabled = true;
            this.comboFull.Items.AddRange(new object[] {
            "Tüm Aylar",
            "01/(Ocak)",
            "02/(Şubat)",
            "03/(Mart)",
            "04/(Nisan)",
            "05/(Mayıs)",
            "06/(Haziran)",
            "07/(Temmuz)",
            "08/(Ağustos)",
            "09/(Eylül)",
            "10/(Ekim)",
            "11/(Kasım)",
            "12/(Aralık)"});
            this.comboFull.Location = new System.Drawing.Point(1016, 280);
            this.comboFull.Name = "comboFull";
            this.comboFull.Size = new System.Drawing.Size(178, 28);
            this.comboFull.TabIndex = 22;
            this.comboFull.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dgvFull
            // 
            this.dgvFull.AllowUserToAddRows = false;
            this.dgvFull.AllowUserToDeleteRows = false;
            this.dgvFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFull.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFull.Location = new System.Drawing.Point(8, 310);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.RowHeadersWidth = 51;
            this.dgvFull.RowTemplate.Height = 24;
            this.dgvFull.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFull.Size = new System.Drawing.Size(1186, 284);
            this.dgvFull.TabIndex = 27;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFull_CellClick_1);
            // 
            // fullAra
            // 
            this.fullAra.Location = new System.Drawing.Point(63, 280);
            this.fullAra.Name = "fullAra";
            this.fullAra.Size = new System.Drawing.Size(203, 27);
            this.fullAra.TabIndex = 21;
            this.fullAra.TextChanged += new System.EventHandler(this.fullAra_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.excell);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.fullUpdate);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.aciklamaFull);
            this.groupBox2.Controls.Add(this.fullDelete);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.fullSave);
            this.groupBox2.Controls.Add(this.amirId);
            this.groupBox2.Controls.Add(this.amirFull);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(604, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÖREVLENDİREN BİRİM AMİRİ";
            // 
            // excell
            // 
            this.excell.BackColor = System.Drawing.SystemColors.ControlDark;
            this.excell.Location = new System.Drawing.Point(454, 169);
            this.excell.Name = "excell";
            this.excell.Size = new System.Drawing.Size(105, 55);
            this.excell.TabIndex = 21;
            this.excell.Text = "button1";
            this.excell.UseVisualStyleBackColor = false;
            this.excell.Click += new System.EventHandler(this.excell_Click);
            this.excell.MouseEnter += new System.EventHandler(this.enter);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm:tt";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(367, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(217, 28);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // fullUpdate
            // 
            this.fullUpdate.BackColor = System.Drawing.Color.Transparent;
            this.fullUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullUpdate.ForeColor = System.Drawing.Color.Black;
            this.fullUpdate.Location = new System.Drawing.Point(256, 210);
            this.fullUpdate.Name = "fullUpdate";
            this.fullUpdate.Size = new System.Drawing.Size(115, 49);
            this.fullUpdate.TabIndex = 20;
            this.fullUpdate.Text = "Güncelle";
            this.fullUpdate.UseVisualStyleBackColor = false;
            this.fullUpdate.Click += new System.EventHandler(this.fullUpdate_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Açıklama";
            // 
            // aciklamaFull
            // 
            this.aciklamaFull.Location = new System.Drawing.Point(10, 108);
            this.aciklamaFull.Name = "aciklamaFull";
            this.aciklamaFull.Size = new System.Drawing.Size(361, 96);
            this.aciklamaFull.TabIndex = 3;
            this.aciklamaFull.Text = "";
            // 
            // fullDelete
            // 
            this.fullDelete.BackColor = System.Drawing.Color.Transparent;
            this.fullDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullDelete.ForeColor = System.Drawing.Color.Black;
            this.fullDelete.Location = new System.Drawing.Point(135, 210);
            this.fullDelete.Name = "fullDelete";
            this.fullDelete.Size = new System.Drawing.Size(115, 49);
            this.fullDelete.TabIndex = 19;
            this.fullDelete.Text = "Sil";
            this.fullDelete.UseVisualStyleBackColor = false;
            this.fullDelete.Click += new System.EventHandler(this.fullDelete_Click);
            this.fullDelete.MouseEnter += new System.EventHandler(this.enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(237, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ad Soyad - Birim - Sicil No";
            // 
            // fullSave
            // 
            this.fullSave.BackColor = System.Drawing.Color.Transparent;
            this.fullSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullSave.ForeColor = System.Drawing.Color.Black;
            this.fullSave.Location = new System.Drawing.Point(10, 210);
            this.fullSave.Name = "fullSave";
            this.fullSave.Size = new System.Drawing.Size(119, 49);
            this.fullSave.TabIndex = 18;
            this.fullSave.Text = "Kaydet";
            this.fullSave.UseVisualStyleBackColor = false;
            this.fullSave.Click += new System.EventHandler(this.fullSave_Click);
            this.fullSave.MouseEnter += new System.EventHandler(this.enter);
            this.fullSave.MouseLeave += new System.EventHandler(this.leave);
            // 
            // amirId
            // 
            this.amirId.AutoSize = true;
            this.amirId.Location = new System.Drawing.Point(259, 31);
            this.amirId.Name = "amirId";
            this.amirId.Size = new System.Drawing.Size(36, 20);
            this.amirId.TabIndex = 1;
            this.amirId.Text = "IdA";
            this.amirId.Visible = false;
            // 
            // amirFull
            // 
            this.amirFull.FormattingEnabled = true;
            this.amirFull.Location = new System.Drawing.Point(10, 54);
            this.amirFull.Name = "amirFull";
            this.amirFull.Size = new System.Drawing.Size(361, 28);
            this.amirFull.TabIndex = 0;
            this.amirFull.SelectedIndexChanged += new System.EventHandler(this.comboAmir_SelectedIndexChanged);
            this.amirFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfull);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.gorevFull);
            this.groupBox1.Controls.Add(this.personId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.personelFull);
            this.groupBox1.Controls.Add(this.konumFull);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GÖREVLİ PERSONELİN";
            // 
            // gorevFull
            // 
            this.gorevFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorevFull.Location = new System.Drawing.Point(12, 196);
            this.gorevFull.Name = "gorevFull";
            this.gorevFull.Size = new System.Drawing.Size(361, 28);
            this.gorevFull.TabIndex = 4;
            // 
            // personId
            // 
            this.personId.AutoSize = true;
            this.personId.Location = new System.Drawing.Point(205, 36);
            this.personId.Name = "personId";
            this.personId.Size = new System.Drawing.Size(36, 20);
            this.personId.TabIndex = 2;
            this.personId.Text = "IdP";
            this.personId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Görevin Türü";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Gideceği Yer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ad Soyad - Sicil No";
            // 
            // personelFull
            // 
            this.personelFull.FormattingEnabled = true;
            this.personelFull.Location = new System.Drawing.Point(12, 59);
            this.personelFull.Name = "personelFull";
            this.personelFull.Size = new System.Drawing.Size(361, 28);
            this.personelFull.TabIndex = 0;
            this.personelFull.SelectedIndexChanged += new System.EventHandler(this.comboPerson_SelectedIndexChanged);
            this.personelFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfull);
            // 
            // konumFull
            // 
            this.konumFull.FormattingEnabled = true;
            this.konumFull.Location = new System.Drawing.Point(12, 127);
            this.konumFull.Name = "konumFull";
            this.konumFull.Size = new System.Drawing.Size(361, 28);
            this.konumFull.TabIndex = 0;
            this.konumFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyfull);
            // 
            // tblilBindingSource
            // 
            this.tblilBindingSource.DataMember = "tbl_il";
            this.tblilBindingSource.DataSource = this.araziDBDataSet;
            // 
            // araziDBDataSet
            // 
            this.araziDBDataSet.DataSetName = "AraziDBDataSet";
            this.araziDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ilTableAdapter
            // 
            this.tbl_ilTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1210, 627);
            this.Controls.Add(this.tabPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arazi Takip Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.tabPersonel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonum)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araziDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox PersonelAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabPersonel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKonum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveLocation;
        private System.Windows.Forms.Button DeleteLocation;
        private System.Windows.Forms.Button UpdateLocation;
        private System.Windows.Forms.TextBox KonumId;
        private AraziDBDataSet araziDBDataSet;
        private System.Windows.Forms.BindingSource tblilBindingSource;
        private AraziDBDataSetTableAdapters.tbl_ilTableAdapter tbl_ilTableAdapter;
        private System.Windows.Forms.TextBox txtmah;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox KonumAra;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox konumFull;
        private System.Windows.Forms.Label personId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsicil;
        private System.Windows.Forms.TextBox gorevFull;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox amirFull;
        private System.Windows.Forms.Label amirId;
        private System.Windows.Forms.ComboBox personelFull;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox aciklamaFull;
        private System.Windows.Forms.Button fullUpdate;
        private System.Windows.Forms.Button fullDelete;
        private System.Windows.Forms.Button fullSave;
        private System.Windows.Forms.Label IdFull;
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboFull;
        private System.Windows.Forms.TextBox fullAra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button excell;
    }
}

