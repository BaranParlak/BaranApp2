using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaranApp2
{
    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\baran\OneDrive\Belgeler\MuzikShpDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Bilgi_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "" || EnsUcretTb.Text == "" || EnsMiktarTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into EnstrümanTbl (EnsAd, EnsMarka, EnsMiktar, EnsUcret, EnsKategori) values (@EnsAd, @EnsMarka, @EnsMiktar, @EnsUcret, @EnsKategori)";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@EnsAd", EnsAdTb.Text);
                    komut.Parameters.AddWithValue("@EnsMarka", EnsMarkaCb.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@EnsMiktar", EnsMiktarTb.Text);
                    komut.Parameters.AddWithValue("@EnsUcret", EnsUcretTb.Text);
                    komut.Parameters.AddWithValue("@EnsKategori", EnsKateCb.SelectedItem.ToString());
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Enstrüman Başarıyla Eklendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from EnstrümanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilgiDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void Filter()
        {
            if (FilterCb.SelectedItem != null)
            {
                baglanti.Open();
                string query = "select * from EnstrümanTbl where EnsMarka=@EnsMarka";
                SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
                sda.SelectCommand.Parameters.AddWithValue("@EnsMarka", FilterCb.SelectedItem.ToString());
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BilgiDGV.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir marka seçin.");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int EnsKey;
        private void button3_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "")
            {
                MessageBox.Show("Silinecek Enstrümanı Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from EnstrümanTbl where EnsId=@EnsId";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@EnsId", EnsKey);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Enstrüman Başarıyla Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BilgiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BilgiDGV.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    EnsKey = Convert.ToInt32(row.Cells[0].Value.ToString());
                    EnsAdTb.Text = row.Cells[1].Value?.ToString();
                    EnsMarkaCb.Text = row.Cells[2].Value?.ToString();
                    EnsMiktarTb.Text = row.Cells[3].Value?.ToString();
                    EnsUcretTb.Text = row.Cells[4].Value?.ToString();
                    EnsKateCb.Text = row.Cells[5].Value?.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "" || EnsUcretTb.Text == "" || EnsMiktarTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update EnstrümanTbl set EnsAd=@EnsAd, EnsMarka=@EnsMarka, EnsMiktar=@EnsMiktar, EnsUcret=@EnsUcret, EnsKategori=@EnsKategori where EnsId=@EnsId";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@EnsAd", EnsAdTb.Text);
                    komut.Parameters.AddWithValue("@EnsMarka", EnsMarkaCb.SelectedItem?.ToString());
                    komut.Parameters.AddWithValue("@EnsMiktar", EnsMiktarTb.Text);
                    komut.Parameters.AddWithValue("@EnsUcret", EnsUcretTb.Text);
                    komut.Parameters.AddWithValue("@EnsKategori", EnsKateCb.SelectedItem?.ToString());
                    komut.Parameters.AddWithValue("@EnsId", EnsKey);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Enstrüman Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FilterCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Filtreyi temizleyin ve tüm verileri geri getiriyorum
            FilterCb.SelectedItem = null;
            uyeler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (BilgiSifreTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    // SAKLI YORDAM
                    SqlCommand cmd = new SqlCommand("UpdateAdminPassword", baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdminId", 1); 
                    cmd.Parameters.AddWithValue("@AdminSifre", BilgiSifreTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Şifre Güncellendi");
                    baglanti.Close();

                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string arananVeri = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(arananVeri))
            {
                try
                {
                    baglanti.Open();
                    string query = "select count(*) from EnstrümanTbl where EnsAd=@EnsAd";
                    SqlCommand cmd = new SqlCommand(query, baglanti);
                    cmd.Parameters.AddWithValue("@EnsAd", arananVeri);
                    int count = (int)cmd.ExecuteScalar();
                    baglanti.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Aramanız mevcut.");
                    }
                    else
                    {
                        MessageBox.Show("Aramanız bulunamadı.");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir Enstrüman adı girin.");
            }
        }

        private void FilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
