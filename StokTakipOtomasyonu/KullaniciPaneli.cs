using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StokTakipOtomasyonu
{
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
       
        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            build.Server = "127.0.0.1";
            build.UserID = "root";
            build.Database = "stok";
            build.Password = "1234";
            baglanti = new MySqlConnection(build.ToString());
            KListele("Select *from urunler");
        }
        public DataTable KListele(string sql)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, baglanti);
            adapter.Fill(table);
            KDataGridView.DataSource = table;
            baglanti.Close();
            return table;
        }
        public void ESG(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void CikisBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.ShowDialog();
            this.Dispose();
        }

        private void KEkleBtn_Click(object sender, EventArgs e)
        {
            ESG("insert into urunler values('" + int.Parse(KBarkodTxt.Text) + "','" + KKategori.Text + "','" + KUrunAdiTxt.Text + "','" + KUrunMiktariTxt.Text + "','" + KUrunAlisFiyatiTxt.Text + "','" + KUrunSatisFiyatiTxt.Text + "', '"+DateTime.Now+"')");
            KListele("select *from urunler");
            MessageBox.Show("İşlem Başarılı");
        }

        private void KGuncelleBtn_Click(object sender, EventArgs e)
        {
            ESG("update urunler set urunKategori='" + KKategori.Text + "', urunAdi='" + KUrunAdiTxt.Text + "', urunMiktari='" + KUrunMiktariTxt.Text + "', urunAlisFiyati='" + KUrunAlisFiyatiTxt.Text + "', urunSatisFiyati='" + KUrunSatisFiyatiTxt.Text + "', tarih='"+DateTime.Now+"' where urunBarkod='" + KBarkodTxt.Text + "'");
            KListele("select *from urunler");
            MessageBox.Show("İşlem Başarılı");
        }

        private void KUrunAraTxt_TextChanged(object sender, EventArgs e)
        {
            KListele("select *from urunler where urunAdi like '%" + KUrunAraTxt.Text + "%'");
        }


        private void KBarkodNumFiltrele_CheckedChanged(object sender, EventArgs e)
        {
            KListele("select urunBarkod from urunler ");
        }

        private void KUrunAdinaFiltrele_CheckedChanged(object sender, EventArgs e)
        {
            KListele("select urunAdi from urunler ");
        }

        private void KUrunKategoriCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KListele("select *from urunler where urunKategori like '%" + KUrunKategoriCmbBox.Text + "%' ");
        }



        private void KgroupBox2_Enter(object sender, EventArgs e)
        {
            KKategori.Items.Add("Bilgisayar");
            KKategori.Items.Add("Telefon");
            KKategori.Items.Add("Tablet");
            KKategori.Items.Add("Aksesuar");
        }

        private void KDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int clck = KDataGridView.SelectedCells[0].RowIndex;

            KBarkodTxt.Text = KDataGridView.Rows[clck].Cells[0].Value.ToString();
            KKategori.Text = KDataGridView.Rows[clck].Cells[1].Value.ToString();
            KUrunAdiTxt.Text = KDataGridView.Rows[clck].Cells[2].Value.ToString();
            KUrunMiktariTxt.Text = KDataGridView.Rows[clck].Cells[3].Value.ToString();
            KUrunAlisFiyatiTxt.Text = KDataGridView.Rows[clck].Cells[4].Value.ToString();
            KUrunSatisFiyatiTxt.Text = KDataGridView.Rows[clck].Cells[5].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            KUrunKategoriCmbBox.Items.Add("Bilgisayar");
            KUrunKategoriCmbBox.Items.Add("Telefon");
            KUrunKategoriCmbBox.Items.Add("Tablet");
            KUrunKategoriCmbBox.Items.Add("Aksesuar");
        }

        
    }
}
