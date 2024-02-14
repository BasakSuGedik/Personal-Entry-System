using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace İZİN_İSTEME_SAYFASI
{
    public partial class yonetici_izin : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel_takip;Uid='root';Pwd='oguz';");
        MySqlCommand cmd;
        DataTable dt;
        public yonetici_izin()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yonetici_izin_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT*FROM izin_tablosu", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            adapter.Fill(ds, "izin_tablosu");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "UPDATE izin_tablosu SET durum=@izin;";
                MySqlCommand kmt = new MySqlCommand(sql, baglanti);
                kmt.Parameters.AddWithValue("@izin", comboBox1.SelectedItem);
                kmt.ExecuteNonQuery();
                MessageBox.Show("İzin Verildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
