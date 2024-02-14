namespace İZİN_İSTEME_SAYFASI
{
    partial class personel_izin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_izin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelıd = new System.Windows.Forms.Label();
            this.labelpermission_type = new System.Windows.Forms.Label();
            this.labelizin_baslangic = new System.Windows.Forms.Label();
            this.labelizin_bitis = new System.Windows.Forms.Label();
            this.labelcomment = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.izin_iste = new System.Windows.Forms.Button();
            this.izin_kaydi_sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Controls.Add(this.labelıd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 30);
            this.textBox1.TabIndex = 3;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(6, 101);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(129, 25);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Personel Adı:";
            // 
            // labelıd
            // 
            this.labelıd.AutoSize = true;
            this.labelıd.Location = new System.Drawing.Point(16, 46);
            this.labelıd.Name = "labelıd";
            this.labelıd.Size = new System.Drawing.Size(119, 25);
            this.labelıd.TabIndex = 1;
            this.labelıd.Text = "Personel ID:";
            // 
            // labelpermission_type
            // 
            this.labelpermission_type.AutoSize = true;
            this.labelpermission_type.Location = new System.Drawing.Point(41, 72);
            this.labelpermission_type.Name = "labelpermission_type";
            this.labelpermission_type.Size = new System.Drawing.Size(94, 25);
            this.labelpermission_type.TabIndex = 3;
            this.labelpermission_type.Text = "İzin Türü:";
            // 
            // labelizin_baslangic
            // 
            this.labelizin_baslangic.AutoSize = true;
            this.labelizin_baslangic.Location = new System.Drawing.Point(-5, 124);
            this.labelizin_baslangic.Name = "labelizin_baslangic";
            this.labelizin_baslangic.Size = new System.Drawing.Size(142, 25);
            this.labelizin_baslangic.TabIndex = 4;
            this.labelizin_baslangic.Text = "İzin Başlangıcı:";
            // 
            // labelizin_bitis
            // 
            this.labelizin_bitis.AutoSize = true;
            this.labelizin_bitis.Location = new System.Drawing.Point(37, 177);
            this.labelizin_bitis.Name = "labelizin_bitis";
            this.labelizin_bitis.Size = new System.Drawing.Size(98, 25);
            this.labelizin_bitis.TabIndex = 5;
            this.labelizin_bitis.Text = "İzim Bitişi:";
            this.labelizin_bitis.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelcomment
            // 
            this.labelcomment.AutoSize = true;
            this.labelcomment.Location = new System.Drawing.Point(37, 235);
            this.labelcomment.Name = "labelcomment";
            this.labelcomment.Size = new System.Drawing.Size(98, 25);
            this.labelcomment.TabIndex = 6;
            this.labelcomment.Text = "Açıklama:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.labelpermission_type);
            this.groupBox2.Controls.Add(this.labelcomment);
            this.groupBox2.Controls.Add(this.labelizin_baslangic);
            this.groupBox2.Controls.Add(this.labelizin_bitis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(23, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 404);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İzin Bilgileri";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(141, 235);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(279, 142);
            this.textBox3.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(141, 177);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yillik Izin",
            "Haftalik Izin",
            "Gunluk Izin"});
            this.comboBox1.Location = new System.Drawing.Point(141, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // izin_iste
            // 
            this.izin_iste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izin_iste.Location = new System.Drawing.Point(671, 79);
            this.izin_iste.Name = "izin_iste";
            this.izin_iste.Size = new System.Drawing.Size(261, 59);
            this.izin_iste.TabIndex = 8;
            this.izin_iste.Text = "İzin İste";
            this.izin_iste.UseVisualStyleBackColor = true;
            this.izin_iste.Click += new System.EventHandler(this.izin_iste_Click);
            // 
            // izin_kaydi_sil
            // 
            this.izin_kaydi_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izin_kaydi_sil.Location = new System.Drawing.Point(671, 184);
            this.izin_kaydi_sil.Name = "izin_kaydi_sil";
            this.izin_kaydi_sil.Size = new System.Drawing.Size(261, 58);
            this.izin_kaydi_sil.TabIndex = 9;
            this.izin_kaydi_sil.Text = "İzin Kaydı Sil";
            this.izin_kaydi_sil.UseVisualStyleBackColor = true;
            this.izin_kaydi_sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.Location = new System.Drawing.Point(671, 285);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(261, 58);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Çıkış";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(671, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "İzin Durumu Öğren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personel_izin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.izin_kaydi_sil);
            this.Controls.Add(this.izin_iste);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personel_izin";
            this.Text = "Personel İzlence Sistemi-İzin İsteme Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelpermission_type;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelıd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelizin_baslangic;
        private System.Windows.Forms.Label labelizin_bitis;
        private System.Windows.Forms.Label labelcomment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button izin_iste;
        private System.Windows.Forms.Button izin_kaydi_sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button button1;
    }
}

