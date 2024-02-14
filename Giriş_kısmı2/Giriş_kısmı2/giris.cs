using MySql.Data.MySqlClient;
using Proje;
using System;
using System.Data;
using System.Windows.Forms;

namespace Giriş_kısmı2
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=personel_takip;Uid=root;Pwd='oguz';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT*FROM yonetici where id=@isim AND sifre=@sifre";
                    MySqlParameter prm1 = new MySqlParameter("isim", textBox1.Text.Trim());
                    MySqlParameter prm2 = new MySqlParameter("sifre", textBox2.Text.Trim());
                    MySqlCommand komut = new MySqlCommand(sql, conn);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        anamenu form = new anamenu();
                        form.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("HATALI GİRİŞ");
                }
            }
            else if (radioButton2.Checked == true)
            {
                try
                {
                    conn.Open();
                    string sql2 = "SELECT*FROM kullanici where id=@adi AND Parola=@sifresi";
                    MySqlParameter prm1 = new MySqlParameter("adi", textBox1.Text.Trim());
                    MySqlParameter prm2 = new MySqlParameter("sifresi", textBox2.Text.Trim());
                    MySqlCommand komut = new MySqlCommand(sql2, conn);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    da.Fill(dt);
                    string kullanici = textBox1.Text.Trim();
                    if (dt.Rows.Count > 0)
                    {
                        personel_anamenu form = new personel_anamenu(kullanici);
                        form.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("HATALI GİRİŞ");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar =true;
            }
            else if(checkBox1.CheckState==CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar =false;
            }
        }
    }
}
