
namespace StokTakipOtomasyonu
{
    partial class MusteriDuzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriDuzenle));
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.idkayit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitKullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitSifreTekrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MusteriSifreTekrarTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MusteriSifreTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MusteriSilBtn = new System.Windows.Forms.Button();
            this.MusteriGuncelleBtn = new System.Windows.Forms.Button();
            this.MusteriEkleBtn = new System.Windows.Forms.Button();
            this.MusteriEmailTxt = new System.Windows.Forms.TextBox();
            this.MusteriKullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.MusteriCinsiyetTxt = new System.Windows.Forms.TextBox();
            this.MusteriSoyadTxt = new System.Windows.Forms.TextBox();
            this.MusteriAdTxt = new System.Windows.Forms.TextBox();
            this.MusteriIdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MusteriAraTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkayit,
            this.kayitAdi,
            this.kayitSoyadi,
            this.kayitCinsiyet,
            this.kayitKullaniciAdi,
            this.kayitEmail,
            this.kayitSifre,
            this.kayitSifreTekrar});
            this.DataGridView2.Location = new System.Drawing.Point(16, 8);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.Size = new System.Drawing.Size(821, 131);
            this.DataGridView2.TabIndex = 0;
            this.DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // idkayit
            // 
            this.idkayit.DataPropertyName = "idkayit";
            this.idkayit.HeaderText = "TC";
            this.idkayit.Name = "idkayit";
            // 
            // kayitAdi
            // 
            this.kayitAdi.DataPropertyName = "kayitAdi";
            this.kayitAdi.HeaderText = "Adı";
            this.kayitAdi.Name = "kayitAdi";
            // 
            // kayitSoyadi
            // 
            this.kayitSoyadi.DataPropertyName = "kayitSoyadi";
            this.kayitSoyadi.HeaderText = "Soyadı";
            this.kayitSoyadi.Name = "kayitSoyadi";
            // 
            // kayitCinsiyet
            // 
            this.kayitCinsiyet.DataPropertyName = "kayitCinsiyet";
            this.kayitCinsiyet.HeaderText = "Cinsiyeti";
            this.kayitCinsiyet.Name = "kayitCinsiyet";
            // 
            // kayitKullaniciAdi
            // 
            this.kayitKullaniciAdi.DataPropertyName = "kayitKullaniciAdi";
            this.kayitKullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.kayitKullaniciAdi.Name = "kayitKullaniciAdi";
            // 
            // kayitEmail
            // 
            this.kayitEmail.DataPropertyName = "kayitEmail";
            this.kayitEmail.HeaderText = "E-Mail";
            this.kayitEmail.Name = "kayitEmail";
            // 
            // kayitSifre
            // 
            this.kayitSifre.DataPropertyName = "kayitSifre";
            this.kayitSifre.HeaderText = "Şifre";
            this.kayitSifre.Name = "kayitSifre";
            // 
            // kayitSifreTekrar
            // 
            this.kayitSifreTekrar.DataPropertyName = "kayitSifreTekrar";
            this.kayitSifreTekrar.HeaderText = "ŞifreTekrar";
            this.kayitSifreTekrar.Name = "kayitSifreTekrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(38, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(38, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MusteriSifreTekrarTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MusteriSifreTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MusteriSilBtn);
            this.groupBox1.Controls.Add(this.MusteriGuncelleBtn);
            this.groupBox1.Controls.Add(this.MusteriEkleBtn);
            this.groupBox1.Controls.Add(this.MusteriEmailTxt);
            this.groupBox1.Controls.Add(this.MusteriKullaniciAdiTxt);
            this.groupBox1.Controls.Add(this.MusteriCinsiyetTxt);
            this.groupBox1.Controls.Add(this.MusteriSoyadTxt);
            this.groupBox1.Controls.Add(this.MusteriAdTxt);
            this.groupBox1.Controls.Add(this.MusteriIdTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Düzenle";
            // 
            // MusteriSifreTekrarTxt
            // 
            this.MusteriSifreTekrarTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriSifreTekrarTxt.Location = new System.Drawing.Point(130, 269);
            this.MusteriSifreTekrarTxt.Multiline = true;
            this.MusteriSifreTekrarTxt.Name = "MusteriSifreTekrarTxt";
            this.MusteriSifreTekrarTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriSifreTekrarTxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(38, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Şifre Tekrar";
            // 
            // MusteriSifreTxt
            // 
            this.MusteriSifreTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriSifreTxt.Location = new System.Drawing.Point(130, 234);
            this.MusteriSifreTxt.Multiline = true;
            this.MusteriSifreTxt.Name = "MusteriSifreTxt";
            this.MusteriSifreTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriSifreTxt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(38, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Şifre";
            // 
            // MusteriSilBtn
            // 
            this.MusteriSilBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.MusteriSilBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriSilBtn.Location = new System.Drawing.Point(370, 202);
            this.MusteriSilBtn.Name = "MusteriSilBtn";
            this.MusteriSilBtn.Size = new System.Drawing.Size(125, 59);
            this.MusteriSilBtn.TabIndex = 15;
            this.MusteriSilBtn.Text = "Kullanıcıyı Sil";
            this.MusteriSilBtn.UseVisualStyleBackColor = false;
            this.MusteriSilBtn.Click += new System.EventHandler(this.MusteriSilBtn_Click);
            // 
            // MusteriGuncelleBtn
            // 
            this.MusteriGuncelleBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.MusteriGuncelleBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriGuncelleBtn.Location = new System.Drawing.Point(370, 116);
            this.MusteriGuncelleBtn.Name = "MusteriGuncelleBtn";
            this.MusteriGuncelleBtn.Size = new System.Drawing.Size(125, 59);
            this.MusteriGuncelleBtn.TabIndex = 14;
            this.MusteriGuncelleBtn.Text = "Kullanıcıyı Güncelle";
            this.MusteriGuncelleBtn.UseVisualStyleBackColor = false;
            this.MusteriGuncelleBtn.Click += new System.EventHandler(this.MusteriGuncelleBtn_Click);
            // 
            // MusteriEkleBtn
            // 
            this.MusteriEkleBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.MusteriEkleBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MusteriEkleBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriEkleBtn.ForeColor = System.Drawing.Color.Black;
            this.MusteriEkleBtn.Location = new System.Drawing.Point(370, 30);
            this.MusteriEkleBtn.Name = "MusteriEkleBtn";
            this.MusteriEkleBtn.Size = new System.Drawing.Size(125, 59);
            this.MusteriEkleBtn.TabIndex = 13;
            this.MusteriEkleBtn.Text = "Kullanıcı Ekle";
            this.MusteriEkleBtn.UseVisualStyleBackColor = false;
            this.MusteriEkleBtn.Click += new System.EventHandler(this.MusteriEkleBtn_Click);
            // 
            // MusteriEmailTxt
            // 
            this.MusteriEmailTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriEmailTxt.Location = new System.Drawing.Point(130, 199);
            this.MusteriEmailTxt.Multiline = true;
            this.MusteriEmailTxt.Name = "MusteriEmailTxt";
            this.MusteriEmailTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriEmailTxt.TabIndex = 12;
            // 
            // MusteriKullaniciAdiTxt
            // 
            this.MusteriKullaniciAdiTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriKullaniciAdiTxt.Location = new System.Drawing.Point(130, 164);
            this.MusteriKullaniciAdiTxt.Multiline = true;
            this.MusteriKullaniciAdiTxt.Name = "MusteriKullaniciAdiTxt";
            this.MusteriKullaniciAdiTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriKullaniciAdiTxt.TabIndex = 11;
            // 
            // MusteriCinsiyetTxt
            // 
            this.MusteriCinsiyetTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriCinsiyetTxt.Location = new System.Drawing.Point(130, 129);
            this.MusteriCinsiyetTxt.Multiline = true;
            this.MusteriCinsiyetTxt.Name = "MusteriCinsiyetTxt";
            this.MusteriCinsiyetTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriCinsiyetTxt.TabIndex = 10;
            // 
            // MusteriSoyadTxt
            // 
            this.MusteriSoyadTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriSoyadTxt.Location = new System.Drawing.Point(130, 94);
            this.MusteriSoyadTxt.Multiline = true;
            this.MusteriSoyadTxt.Name = "MusteriSoyadTxt";
            this.MusteriSoyadTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriSoyadTxt.TabIndex = 9;
            // 
            // MusteriAdTxt
            // 
            this.MusteriAdTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriAdTxt.Location = new System.Drawing.Point(130, 59);
            this.MusteriAdTxt.Multiline = true;
            this.MusteriAdTxt.Name = "MusteriAdTxt";
            this.MusteriAdTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriAdTxt.TabIndex = 8;
            // 
            // MusteriIdTxt
            // 
            this.MusteriIdTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriIdTxt.Location = new System.Drawing.Point(130, 24);
            this.MusteriIdTxt.Multiline = true;
            this.MusteriIdTxt.Name = "MusteriIdTxt";
            this.MusteriIdTxt.Size = new System.Drawing.Size(191, 25);
            this.MusteriIdTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(38, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-Mail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MusteriAraTxt);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(558, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Ara";
            // 
            // MusteriAraTxt
            // 
            this.MusteriAraTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusteriAraTxt.Location = new System.Drawing.Point(50, 41);
            this.MusteriAraTxt.Name = "MusteriAraTxt";
            this.MusteriAraTxt.Size = new System.Drawing.Size(191, 22);
            this.MusteriAraTxt.TabIndex = 0;
            this.MusteriAraTxt.TextChanged += new System.EventHandler(this.MusteriAraTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MusteriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(856, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Düzenle";
            this.Load += new System.EventHandler(this.MusteriDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MusteriEmailTxt;
        private System.Windows.Forms.TextBox MusteriKullaniciAdiTxt;
        private System.Windows.Forms.TextBox MusteriCinsiyetTxt;
        private System.Windows.Forms.TextBox MusteriSoyadTxt;
        private System.Windows.Forms.TextBox MusteriAdTxt;
        private System.Windows.Forms.TextBox MusteriIdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MusteriSilBtn;
        private System.Windows.Forms.Button MusteriGuncelleBtn;
        private System.Windows.Forms.Button MusteriEkleBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MusteriAraTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MusteriSifreTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MusteriSifreTekrarTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitKullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitSifreTekrar;
    }
}