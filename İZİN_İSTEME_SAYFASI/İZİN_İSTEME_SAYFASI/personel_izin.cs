using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace İZİN_İSTEME_SAYFASI
{
    public partial class personel_izin : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel_takip;Uid=root;Pwd='oguz';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        string sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        string server = "localhost";
        string username = "root";
        string password = "oguz";
        string Database = "personel_takip";
        public void verigetir(string veriler)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
        public personel_izin()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + username + ";"
                + "password =" + password + ";"
                + "database =" + Database;
                sqlConn.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM izin_tablosu where `Personel ID`=@id", sqlConn);
                komut.Parameters.AddWithValue("@id",textBox1.Text);
                komut.ExecuteNonQuery();
                sqlConn.Close();
                verigetir("select*from izin_tablosu");
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri başarıyla silindi");
                //MessageBox.Show(ex.Message);
            }
        }

        private void izin_iste_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql ="SELECT*FROM kullanici where id=@personelid AND Isim=@personeladi";
                MySqlParameter prm1 = new MySqlParameter("personelid",textBox1.Text.Trim());
                MySqlParameter prm2 = new MySqlParameter("personeladi",textBox2.Text.Trim());
                MySqlCommand komut2 = new MySqlCommand(sql,baglanti);
                komut2.Parameters.Add(prm1);
                komut2.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut2);
                da.Fill(dt);
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                baglanti.Open();
                string sql = "INSERT INTO izin_tablosu (`Personel ID`, `Personel Adı`, `İzin Başlangıç`, `İzin Bitiş`, `Açıklama`,`İşlem Tarihi`,`İzin Türü`) " +
                             "VALUES ( @personelid, @personeladi, @baslangic, @bitis, @aciklama,@islem_tarihi,@izinturu)";
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@personelid", textBox1.Text.Trim());
                komut.Parameters.AddWithValue("@izinturu", comboBox1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@personeladi", textBox2.Text.Trim());
                komut.Parameters.AddWithValue("@baslangic", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@bitis", dateTimePicker2.Value);
                komut.Parameters.AddWithValue("@aciklama", textBox3.Text.Trim());
                komut.Parameters.AddWithValue("@islem_tarihi", DateTime.Now);
                komut.ExecuteNonQuery();
                MessageBox.Show("Veri başarıyla eklendi.");
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Daha önce izin kaydınız bulunmaktadır");
                MessageBox.Show(ex2.Message);
            }
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Çıkmak istiyor musunuz?", "MySql connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string baglan = "SELECT*FROM izin_tablosu WHERE durum=@durum";
            MySqlCommand cmd = new MySqlCommand(baglan,baglanti);

            MessageBox.Show("İzin durumunuz:");


        }
    }
}
