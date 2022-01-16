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
    public partial class MusteriDuzenle : Form
    {
        public MusteriDuzenle()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void MusteriDuzenle_Load(object sender, EventArgs e)
        {
            build.Server = "127.0.0.1";
            build.UserID = "root";
            build.Database = "stok";
            build.Password = "1234";
            baglanti = new MySqlConnection(build.ToString());
            Listele("Select *from kayit");
        }
        public DataTable Listele(string sql)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, baglanti);
            adapter.Fill(table);
            DataGridView2.DataSource = table;
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

        public DataTable MusteriListele(string sql)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, baglanti);
            adapter.Fill(table);
            DataGridView2.DataSource = table;
            baglanti.Close();
            return table;
        }

        private void MusteriEkleBtn_Click(object sender, EventArgs e)
        {
            ESG("insert into kayit values('" + int.Parse(MusteriIdTxt.Text) + "','" + MusteriAdTxt.Text + "','" + MusteriSoyadTxt.Text + "','" + MusteriCinsiyetTxt.Text + "','" + MusteriKullaniciAdiTxt.Text + "','" + MusteriEmailTxt.Text + "','" + MusteriSifreTxt.Text + "','" + MusteriSifreTekrarTxt.Text + "')");
            MusteriListele("select *from kayit");
            MessageBox.Show("İşlem Başarılı");
        }

        private void MusteriGuncelleBtn_Click(object sender, EventArgs e)
        {
            ESG("update kayit set kayitAdi='" + MusteriAdTxt.Text + "', kayitSoyadi='" + MusteriSoyadTxt.Text + "', kayitCinsiyet='" + MusteriCinsiyetTxt.Text + "', kayitKullaniciAdi='" + MusteriKullaniciAdiTxt.Text + "', kayitEmail='" + MusteriEmailTxt.Text + "', kayitSifre='" + MusteriSifreTxt.Text + "', kayitSifreTekrar='" + MusteriSifreTekrarTxt.Text + "' where idkayit='"+MusteriIdTxt.Text+"'");
            MusteriListele("select *from kayit");
            MessageBox.Show("İşlem Başarılı");
        }

        private void MusteriSilBtn_Click(object sender, EventArgs e)
        {
            ESG("delete from kayit where idkayit='" + DataGridView2.CurrentRow.Cells["idkayit"].Value.ToString() + "'");
            MusteriListele("select *from kayit");
            MessageBox.Show("İşlem Başarılı");
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int click = DataGridView2.SelectedCells[0].RowIndex;

            MusteriIdTxt.Text = DataGridView2.Rows[click].Cells[0].Value.ToString();
            MusteriAdTxt.Text = DataGridView2.Rows[click].Cells[1].Value.ToString();
            MusteriSoyadTxt.Text= DataGridView2.Rows[click].Cells[2].Value.ToString();
            MusteriCinsiyetTxt.Text= DataGridView2.Rows[click].Cells[3].Value.ToString();
            MusteriKullaniciAdiTxt.Text= DataGridView2.Rows[click].Cells[4].Value.ToString();
            MusteriEmailTxt.Text= DataGridView2.Rows[click].Cells[5].Value.ToString();
            MusteriSifreTxt.Text= DataGridView2.Rows[click].Cells[6].Value.ToString();
            MusteriSifreTekrarTxt.Text= DataGridView2.Rows[click].Cells[7].Value.ToString();
        }

        private void MusteriAraTxt_TextChanged(object sender, EventArgs e)
        {
            MusteriListele("select *from kayit where kayitAdi like '%"+MusteriAraTxt.Text+"%'");
        }
    }
}
