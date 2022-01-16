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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void Giris_Load(object sender, EventArgs e)
        {
            build.Server = "127.0.0.1";
            build.UserID = "root";
            build.Database = "stok";
            build.Password = "1234";
            baglanti = new MySqlConnection(build.ToString());
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

        private void KaydolBtn_Click(object sender, EventArgs e)
        {
            ESG("insert into kayit values('"+int.Parse(IDKayittxt.Text)+"','"+AdKayittxt.Text+"','"+SoyadKayittxt.Text+"','"+CinsiyetCmbBox.Text+"','"+KullaniciAdiKayittxt.Text+"','"+EMailKayittxt.Text+"','"+SifreKayittxt.Text+"','"+SifreTekrarKayittxt.Text+"')");
            MessageBox.Show("Kayıt Başarılı");
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            MySqlDataReader read;
            komut.Connection = baglanti;
            komut.CommandText = "select *from kayit where kayitKullaniciAdi='" + KullaniciAdiGiristxt.Text + "'";
            read = komut.ExecuteReader();
            
            if (read.Read() == true)
            {
                if (SifreGiristxt.Text == read["kayitSifre"].ToString())
                {
                    if (read["kayitKullaniciAdi"].ToString()=="admin")
                    {
                        YöneticiPaneli YöneticiP = new YöneticiPaneli();
                        YöneticiP.ShowDialog();  
                    }
                    else
                    {
                        KullaniciPaneli KullaniciP = new KullaniciPaneli();
                        KullaniciP.ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz.", "Hatalı Şifre");
                }
            }
            else
            {
                MessageBox.Show("Bilgileriniz kontrol ediniz.", "Hatalı Kullanıcı Adı");
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }

        private void groupBoxKayit_Enter(object sender, EventArgs e)
        {
            CinsiyetCmbBox.Items.Add("Kadın");
            CinsiyetCmbBox.Items.Add("Erkek");
        }
    }
}
