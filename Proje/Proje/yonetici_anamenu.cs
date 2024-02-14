using İZİN_İSTEME_SAYFASI;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proje
{
    public partial class anamenu : Form
    {
        //iki kişi yapıldığı için farklı veritabanı bağlama yöntemleri var
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel_takip;Uid=root;Pwd='oguz';");
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        string sqlQuery;
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
            dataGridView1.DataSource = ds.Tables[0];
        }
        public anamenu()
        {
            InitializeComponent();
        }
        public void uploadData()//verileri datagriedview içine çeken metod
        {
            sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + username + ";"
                + "password =" + password + ";"
                + "database =" + Database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from personel_takip.kullanici;";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde personellerin listesi direkt ekrana yansınması için bu metod kullanıldı
            uploadData();
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            //çıkış butonu için gerekli kodlar
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //yeni personel kadında kullanılacak kodlar
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + username + ";"
                + "password =" + password + ";"
                + "database =" + Database;

                sqlConn.Open();
                //textbox dan gelen verileri veritabanına ekleyen kod
                sqlQuery = "insert into personel_takip.kullanici(id,Isim,Maas,`Ise Alim Tarihi`,Telefon,Cinsiyet,Adres,Mail,Parola)" +
                    "values('" + txtid.Text + "', '" + txtname.Text + "', '" + txtpay.Text + "', '" + dateTimePicker1.Text + "', '" + txtphone.Text + "', '" +
                     cmbgender.Text + "', '" + txtaddress.Text + "', '" + txtmail.Text + "', '" + txtparola.Text + "')";
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();
                txtid.Clear();
                txtname.Clear();
                txtphone.Clear();
                txtaddress.Clear();
                txtpay.Clear();
                txtmail.Clear();
                txtparola.Clear();
                txtid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            uploadData();
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //personel listesinde herhangi bir  satıra tıklaınca o personelin bütün bilgileri gelir
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtname.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtpay.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txtphone.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                cmbgender.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                txtaddress.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                txtmail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                txtparola.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            //personeli silme işlemi kodları
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + username + ";"
                + "password =" + password + ";"
                + "database =" + Database;
                sqlConn.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM kullanici where id=@id", sqlConn);
                komut.Parameters.AddWithValue("@id", txtid.Text);
                komut.ExecuteNonQuery();
                sqlConn.Close();
                verigetir("select*from kullanici");
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //personel arama işlemi
            try
            {
                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Isim like '%{0}%'", txtara.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            //personel bilgilerini güncelleme için gerekli kodlar
            try
            {
                sqlConn.Open();
                string updateQuery = "UPDATE kullanici SET Isim = @name, Maas = @hourly_pay, Telefon = @phone_number, Adres = @address, Mail = @mail, Parola = @parola WHERE id = @id";
                MySqlCommand komut = new MySqlCommand(updateQuery, sqlConn);
                komut.Parameters.AddWithValue("@name", txtname.Text);
                komut.Parameters.AddWithValue("@hourly_pay", decimal.Parse(txtpay.Text.Replace(",", ".")));
                komut.Parameters.AddWithValue("@phone_number", txtphone.Text);
                komut.Parameters.AddWithValue("@address", txtaddress.Text);
                komut.Parameters.AddWithValue("@mail", txtmail.Text);
                komut.Parameters.AddWithValue("@parola", txtparola.Text);
                komut.Parameters.AddWithValue("@id", txtid.Text);
                komut.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                verigetir("select*from kullanici");
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbuser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yöneticinin izin isteyenlerin listesini görmesi için izin sayfasına geçişi
            yonetici_izin form = new yonetici_izin();
            form.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
