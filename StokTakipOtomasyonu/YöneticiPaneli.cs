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
    public partial class YöneticiPaneli : Form
    {
        public YöneticiPaneli()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        private void YöneticiPaneli_Load(object sender, EventArgs e)
        {
            build.Server = "127.0.0.1";
            build.UserID = "root";
            build.Database = "stok";
            build.Password = "1234";
            baglanti = new MySqlConnection(build.ToString());
            Listele("Select *from urunler");
        }

        public DataTable Listele(string sql)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, baglanti);
            adapter.Fill(table);
            DataGridView1.DataSource = table;
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

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            ESG("insert into urunler values('"+int.Parse(BarkodTxt.Text)+"','"+Kategori.Text+"','"+UrunAdiTxt.Text+"','"+UrunMiktariTxt.Text+"','"+UrunAlisFiyatiTxt.Text+"','"+UrunSatisFiyatiTxt.Text+"', '"+DateTime.Now+"')");
            Listele("select *from urunler");
            MessageBox.Show("İşlem Başarılı");
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            ESG("update urunler set urunKategori='" + Kategori.Text + "', urunAdi='" + UrunAdiTxt.Text + "', urunMiktari='"+UrunMiktariTxt.Text+"', urunAlisFiyati='"+UrunAlisFiyatiTxt.Text+"', urunSatisFiyati='"+UrunSatisFiyatiTxt.Text+"', tarih='"+DateTime.Now+"' where urunBarkod='"+BarkodTxt.Text+"'");
            Listele("select *from urunler");
            MessageBox.Show("İşlem Başarılı");
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            ESG("delete from urunler where urunBarkod='" + DataGridView1.CurrentRow.Cells["urunBarkod"].Value.ToString() + "'");
            Listele("select *from urunler");
            MessageBox.Show("İşlem Başarılı");
        }

        private void UrunAraTxt_TextChanged(object sender, EventArgs e)
        {
            Listele("select *from urunler where urunAdi like '%" + UrunAraTxt.Text + "%'");
        }

        private void MüsteriDuzenleBtn_Click(object sender, EventArgs e)
        {
            MusteriDuzenle Musteri = new MusteriDuzenle();
            Musteri.ShowDialog();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int click = DataGridView1.SelectedCells[0].RowIndex;

            BarkodTxt.Text= DataGridView1.Rows[click].Cells[0].Value.ToString();
            Kategori.Text= DataGridView1.Rows[click].Cells[1].Value.ToString();
            UrunAdiTxt.Text= DataGridView1.Rows[click].Cells[2].Value.ToString();
            UrunMiktariTxt.Text= DataGridView1.Rows[click].Cells[3].Value.ToString();
            UrunAlisFiyatiTxt.Text= DataGridView1.Rows[click].Cells[4].Value.ToString();
            UrunSatisFiyatiTxt.Text= DataGridView1.Rows[click].Cells[5].Value.ToString();
        }

        private void UrunAdinaFiltrele_CheckedChanged(object sender, EventArgs e)
        {
            Listele("select urunAdi from urunler ");
        }

        private void UrunKategoriCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele("select *from urunler where urunKategori like '%"+UrunKategoriCmbBox.Text+"%' ");
        }
        private void BarkodNumFiltrele_CheckedChanged(object sender, EventArgs e)
        {
            Listele("select urunBarkod from urunler ");
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            UrunKategoriCmbBox.Items.Add("Bilgisayar");
            UrunKategoriCmbBox.Items.Add("Telefon");
            UrunKategoriCmbBox.Items.Add("Tablet");
            UrunKategoriCmbBox.Items.Add("Aksesuar");
        }

        private void CikisBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.ShowDialog();
            this.Dispose();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            Kategori.Items.Add("Bilgisayar");
            Kategori.Items.Add("Telefon");
            Kategori.Items.Add("Tablet");
            Kategori.Items.Add("Aksesuar");
        }

       
    }
}
