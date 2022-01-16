
namespace StokTakipOtomasyonu
{
    partial class YöneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MüsteriDuzenleBtn = new System.Windows.Forms.Button();
            this.boxAra = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UrunAraTxt = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UrunKategoriCmbBox = new System.Windows.Forms.ComboBox();
            this.BarkodNumFiltrele = new System.Windows.Forms.RadioButton();
            this.UrunAdinaFiltrele = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UrunSatisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.SilBtn = new System.Windows.Forms.Button();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.UrunAlisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.UrunMiktariTxt = new System.Windows.Forms.TextBox();
            this.UrunAdiTxt = new System.Windows.Forms.TextBox();
            this.BarkodTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CikisBtn1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.boxAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MüsteriDuzenleBtn);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 85);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diğer İşlemler";
            // 
            // MüsteriDuzenleBtn
            // 
            this.MüsteriDuzenleBtn.BackColor = System.Drawing.Color.Silver;
            this.MüsteriDuzenleBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MüsteriDuzenleBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MüsteriDuzenleBtn.Location = new System.Drawing.Point(42, 36);
            this.MüsteriDuzenleBtn.Name = "MüsteriDuzenleBtn";
            this.MüsteriDuzenleBtn.Size = new System.Drawing.Size(165, 28);
            this.MüsteriDuzenleBtn.TabIndex = 9;
            this.MüsteriDuzenleBtn.Text = "Kullanıcı Düzenle";
            this.MüsteriDuzenleBtn.UseVisualStyleBackColor = false;
            this.MüsteriDuzenleBtn.Click += new System.EventHandler(this.MüsteriDuzenleBtn_Click);
            // 
            // boxAra
            // 
            this.boxAra.Controls.Add(this.label4);
            this.boxAra.Controls.Add(this.UrunAraTxt);
            this.boxAra.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAra.Location = new System.Drawing.Point(587, 9);
            this.boxAra.Name = "boxAra";
            this.boxAra.Size = new System.Drawing.Size(170, 94);
            this.boxAra.TabIndex = 16;
            this.boxAra.TabStop = false;
            this.boxAra.Text = "Ürün Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ürünün Adını Giriniz";
            // 
            // UrunAraTxt
            // 
            this.UrunAraTxt.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAraTxt.Location = new System.Drawing.Point(6, 56);
            this.UrunAraTxt.Multiline = true;
            this.UrunAraTxt.Name = "UrunAraTxt";
            this.UrunAraTxt.Size = new System.Drawing.Size(157, 25);
            this.UrunAraTxt.TabIndex = 15;
            this.UrunAraTxt.TextChanged += new System.EventHandler(this.UrunAraTxt_TextChanged);
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunBarkod,
            this.urunKategori,
            this.urunAdi,
            this.urunMiktari,
            this.urunAlisFiyati,
            this.urunSatisFiyati,
            this.tarih});
            this.DataGridView1.Location = new System.Drawing.Point(264, 109);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(587, 331);
            this.DataGridView1.TabIndex = 15;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // urunBarkod
            // 
            this.urunBarkod.DataPropertyName = "urunBarkod";
            this.urunBarkod.HeaderText = "Barkod";
            this.urunBarkod.Name = "urunBarkod";
            // 
            // urunKategori
            // 
            this.urunKategori.DataPropertyName = "urunKategori";
            this.urunKategori.HeaderText = "Kategori";
            this.urunKategori.Name = "urunKategori";
            // 
            // urunAdi
            // 
            this.urunAdi.DataPropertyName = "urunAdi";
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            // 
            // urunMiktari
            // 
            this.urunMiktari.DataPropertyName = "urunMiktari";
            this.urunMiktari.HeaderText = "Ürün Miktarı";
            this.urunMiktari.Name = "urunMiktari";
            // 
            // urunAlisFiyati
            // 
            this.urunAlisFiyati.DataPropertyName = "urunAlisFiyati";
            this.urunAlisFiyati.HeaderText = "Alış Fiyatı";
            this.urunAlisFiyati.Name = "urunAlisFiyati";
            // 
            // urunSatisFiyati
            // 
            this.urunSatisFiyati.DataPropertyName = "urunSatisFiyati";
            this.urunSatisFiyati.HeaderText = "Satış Fiyatı";
            this.urunSatisFiyati.Name = "urunSatisFiyati";
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.UrunKategoriCmbBox);
            this.groupBox3.Controls.Add(this.BarkodNumFiltrele);
            this.groupBox3.Controls.Add(this.UrunAdinaFiltrele);
            this.groupBox3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(264, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 94);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrele";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategori Seçiniz";
            // 
            // UrunKategoriCmbBox
            // 
            this.UrunKategoriCmbBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunKategoriCmbBox.FormattingEnabled = true;
            this.UrunKategoriCmbBox.Location = new System.Drawing.Point(118, 55);
            this.UrunKategoriCmbBox.Name = "UrunKategoriCmbBox";
            this.UrunKategoriCmbBox.Size = new System.Drawing.Size(152, 24);
            this.UrunKategoriCmbBox.TabIndex = 11;
            this.UrunKategoriCmbBox.SelectedIndexChanged += new System.EventHandler(this.UrunKategoriCmbBox_SelectedIndexChanged);
            // 
            // BarkodNumFiltrele
            // 
            this.BarkodNumFiltrele.AutoSize = true;
            this.BarkodNumFiltrele.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarkodNumFiltrele.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BarkodNumFiltrele.Location = new System.Drawing.Point(143, 26);
            this.BarkodNumFiltrele.Name = "BarkodNumFiltrele";
            this.BarkodNumFiltrele.Size = new System.Drawing.Size(167, 18);
            this.BarkodNumFiltrele.TabIndex = 1;
            this.BarkodNumFiltrele.TabStop = true;
            this.BarkodNumFiltrele.Text = "Barkod Numarasına Göre";
            this.BarkodNumFiltrele.UseVisualStyleBackColor = true;
            this.BarkodNumFiltrele.CheckedChanged += new System.EventHandler(this.BarkodNumFiltrele_CheckedChanged);
            // 
            // UrunAdinaFiltrele
            // 
            this.UrunAdinaFiltrele.AutoSize = true;
            this.UrunAdinaFiltrele.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAdinaFiltrele.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UrunAdinaFiltrele.Location = new System.Drawing.Point(16, 26);
            this.UrunAdinaFiltrele.Name = "UrunAdinaFiltrele";
            this.UrunAdinaFiltrele.Size = new System.Drawing.Size(121, 18);
            this.UrunAdinaFiltrele.TabIndex = 0;
            this.UrunAdinaFiltrele.TabStop = true;
            this.UrunAdinaFiltrele.Text = "Ürün Adına Göre";
            this.UrunAdinaFiltrele.UseVisualStyleBackColor = true;
            this.UrunAdinaFiltrele.CheckedChanged += new System.EventHandler(this.UrunAdinaFiltrele_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Kategori);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.UrunSatisFiyatiTxt);
            this.groupBox2.Controls.Add(this.SilBtn);
            this.groupBox2.Controls.Add(this.lblAlisFiyati);
            this.groupBox2.Controls.Add(this.GuncelleBtn);
            this.groupBox2.Controls.Add(this.UrunAlisFiyatiTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EkleBtn);
            this.groupBox2.Controls.Add(this.UrunMiktariTxt);
            this.groupBox2.Controls.Add(this.UrunAdiTxt);
            this.groupBox2.Controls.Add(this.BarkodTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(7, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 341);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Kategori
            // 
            this.Kategori.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Location = new System.Drawing.Point(107, 61);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(131, 24);
            this.Kategori.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Satış Fiyatı";
            // 
            // UrunSatisFiyatiTxt
            // 
            this.UrunSatisFiyatiTxt.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunSatisFiyatiTxt.Location = new System.Drawing.Point(107, 191);
            this.UrunSatisFiyatiTxt.Multiline = true;
            this.UrunSatisFiyatiTxt.Name = "UrunSatisFiyatiTxt";
            this.UrunSatisFiyatiTxt.Size = new System.Drawing.Size(131, 27);
            this.UrunSatisFiyatiTxt.TabIndex = 16;
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.SilBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilBtn.Location = new System.Drawing.Point(40, 303);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(165, 29);
            this.SilBtn.TabIndex = 12;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lblAlisFiyati.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlisFiyati.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAlisFiyati.Location = new System.Drawing.Point(12, 165);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(68, 15);
            this.lblAlisFiyati.TabIndex = 12;
            this.lblAlisFiyati.Text = "Alış Fiyatı";
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.GuncelleBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuncelleBtn.Location = new System.Drawing.Point(40, 268);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(165, 29);
            this.GuncelleBtn.TabIndex = 11;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // UrunAlisFiyatiTxt
            // 
            this.UrunAlisFiyatiTxt.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAlisFiyatiTxt.Location = new System.Drawing.Point(107, 158);
            this.UrunAlisFiyatiTxt.Multiline = true;
            this.UrunAlisFiyatiTxt.Name = "UrunAlisFiyatiTxt";
            this.UrunAlisFiyatiTxt.Size = new System.Drawing.Size(131, 27);
            this.UrunAlisFiyatiTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Miktarı";
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.EkleBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EkleBtn.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkleBtn.ForeColor = System.Drawing.Color.Black;
            this.EkleBtn.Location = new System.Drawing.Point(40, 234);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(165, 28);
            this.EkleBtn.TabIndex = 7;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // UrunMiktariTxt
            // 
            this.UrunMiktariTxt.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunMiktariTxt.Location = new System.Drawing.Point(107, 125);
            this.UrunMiktariTxt.Multiline = true;
            this.UrunMiktariTxt.Name = "UrunMiktariTxt";
            this.UrunMiktariTxt.Size = new System.Drawing.Size(131, 27);
            this.UrunMiktariTxt.TabIndex = 9;
            // 
            // UrunAdiTxt
            // 
            this.UrunAdiTxt.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAdiTxt.Location = new System.Drawing.Point(107, 92);
            this.UrunAdiTxt.Multiline = true;
            this.UrunAdiTxt.Name = "UrunAdiTxt";
            this.UrunAdiTxt.Size = new System.Drawing.Size(131, 27);
            this.UrunAdiTxt.TabIndex = 7;
            // 
            // BarkodTxt
            // 
            this.BarkodTxt.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarkodTxt.Location = new System.Drawing.Point(107, 26);
            this.BarkodTxt.Multiline = true;
            this.BarkodTxt.Name = "BarkodTxt";
            this.BarkodTxt.Size = new System.Drawing.Size(131, 27);
            this.BarkodTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barkod No";
            // 
            // CikisBtn1
            // 
            this.CikisBtn1.BackColor = System.Drawing.Color.LightPink;
            this.CikisBtn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CikisBtn1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CikisBtn1.ForeColor = System.Drawing.Color.Black;
            this.CikisBtn1.Location = new System.Drawing.Point(766, 42);
            this.CikisBtn1.Name = "CikisBtn1";
            this.CikisBtn1.Size = new System.Drawing.Size(85, 28);
            this.CikisBtn1.TabIndex = 19;
            this.CikisBtn1.Text = "Çıkış Yap";
            this.CikisBtn1.UseVisualStyleBackColor = false;
            this.CikisBtn1.Click += new System.EventHandler(this.CikisBtn1_Click);
            // 
            // YöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.CikisBtn1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxAra);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YöneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YöneticiPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.boxAra.ResumeLayout(false);
            this.boxAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MüsteriDuzenleBtn;
        private System.Windows.Forms.GroupBox boxAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrunAraTxt;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UrunKategoriCmbBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UrunSatisFiyatiTxt;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.TextBox UrunAlisFiyatiTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.TextBox UrunMiktariTxt;
        private System.Windows.Forms.TextBox UrunAdiTxt;
        private System.Windows.Forms.TextBox BarkodTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton BarkodNumFiltrele;
        private System.Windows.Forms.RadioButton UrunAdinaFiltrele;
        private System.Windows.Forms.Button CikisBtn1;
        private System.Windows.Forms.ComboBox Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}