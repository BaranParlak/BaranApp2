using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaranApp2
{
    public partial class Satıs : Form
    {
        public Satıs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\baran\OneDrive\Belgeler\MuzikShpDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select EnsAd, EnsUcret from EnstrümanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilgiDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Filter()
        {
            baglanti.Open();
            string query = "select EnsAd, EnsUcret from EnstrümanTbl where EnsMarka='" + FilterCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilgiDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Satıs_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void BilgiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < BilgiDGV.Rows.Count)
            {
                DataGridViewRow row = BilgiDGV.Rows[e.RowIndex];
                // Ensure the row is not null and contains the required cells
                if (row != null && row.Cells.Count > 1)
                {
                    EnsAdTb.Text = row.Cells[0].Value?.ToString();
                    EnsUcretTb.Text = row.Cells[1].Value?.ToString();
                }
            }
        }

        private void FilterCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (FilterCb.SelectedItem != null)
            {
                Filter();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            EnsAdTb.Text = "";
            EnsMiktarTb.Text = "";
            EnsUcretTb.Text = "";

            // Clear the DataGridView
            SatisDGV.Rows.Clear();

            // Optionally reset the total amount and update the label
            TutarToplam = 0;
            UcretLbl.Text = "0";
        }

        private void insertFatura()
        {
            string Bugun;
            Bugun = DateTime.Today.Date.ToString();
            try
            {
                baglanti.Open();
                string query = "insert into FaturaTbl values(" + TutarToplam + ",'" + Bugun + "')";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Fatura Başarıyla Eklendi");
                baglanti.Close();
                uyeler();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0, TutarToplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "" || EnsMiktarTb.Text == "" || EnsUcretTb.Text == "")
            {
                MessageBox.Show("Enstrüman seçiniz ve miktarını giriniz");
            }
            else
            {
                int Toplam = Convert.ToInt32(EnsMiktarTb.Text) * Convert.ToInt32(EnsUcretTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(SatisDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = EnsAdTb.Text;
                newRow.Cells[2].Value = EnsUcretTb.Text;
                newRow.Cells[3].Value = EnsMiktarTb.Text;
                newRow.Cells[4].Value = Toplam;
                SatisDGV.Rows.Add(newRow);
                n++;
                TutarToplam = TutarToplam + Toplam;
                UcretLbl.Text = "" + TutarToplam;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 330, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            insertFatura();
        }

        int ensid, ensmiktar, ensucret, topplam, pos = 60;
        string ensad;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EnstrümanAGA", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkOliveGreen, new Point(80));
            e.Graphics.DrawString("ID   ENSTRÜMAN   ÜCRET   MİKTAR   TOPLAM", new Font("Times Ner Roman", 10, FontStyle.Regular), Brushes.DarkCyan, new Point(5, 20));
            foreach (DataGridViewRow row in SatisDGV.Rows)
            {
                ensid = Convert.ToInt32(row.Cells["Column1"].Value);
                ensad = "" + row.Cells["Column2"].Value;
                ensucret = Convert.ToInt32(row.Cells["Column3"].Value);
                ensmiktar = Convert.ToInt32(row.Cells["Column4"].Value);
                topplam = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + ensid, new Font("Times Ner Roman", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(5, pos));
                e.Graphics.DrawString("" + ensad, new Font("Times Ner Roman", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(25, pos));
                e.Graphics.DrawString("" + ensucret, new Font("Times Ner Roman", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(125, pos));
                e.Graphics.DrawString("" + ensmiktar, new Font("Times Ner Roman", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(190, pos));
                e.Graphics.DrawString("" + topplam, new Font("Times Ner Roman", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(250, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Ödenecek Toplam Tutar" + TutarToplam, new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkOliveGreen, new Point(60, 200));
            e.Graphics.DrawString("EnstrümanAGA", new Font("Times New Roman", 8, FontStyle.Bold), Brushes.DarkOliveGreen, new Point(20, 230));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SatisDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
