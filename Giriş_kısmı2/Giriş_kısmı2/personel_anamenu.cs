using İZİN_İSTEME_SAYFASI;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace Giriş_kısmı2
{
    public partial class personel_anamenu : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=personel_takip;Uid=root;Pwd='oguz';");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter;
        DataTable dt;
        MySqlDataReader dr = null;
        public personel_anamenu(string kullanici)
        {
            InitializeComponent();
            Verilerigoster(kullanici);
        }

        private void buttoncikis_Click(object sender, EventArgs e)
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
        private void Verilerigoster(string kullanici)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM kullanici where id='" + kullanici + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                label2.Text = dr["id"].ToString();
                label4.Text = dr["Isim"].ToString();
                label8.Text = dr["Maas"].ToString();
                label10.Text = dr["Ise Alim Tarihi"].ToString();
                label12.Text = dr["Telefon"].ToString();
                label18.Text = dr["Adres"].ToString();
                label20.Text = dr["Mail"].ToString();
                label22.Text = dr["Parola"].ToString();
            }
            conn.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void buttonizin_Click(object sender, EventArgs e)
        {
            personel_izin izin = new personel_izin();
            izin.Show();
            this.Hide();
        }

        private void lblparola_Click(object sender, EventArgs e)
        {

        }
    }
}
