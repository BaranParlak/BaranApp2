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
    public partial class Diyagram : Form
    {
        public Diyagram()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\baran\OneDrive\Belgeler\MuzikShpDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Diyagram_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            // SQL sorgusu VIEW kullandım
            string query = "SELECT * FROM vwSilinenEnstrümanlar";

            
            using (SqlConnection connection = new SqlConnection(baglanti.ConnectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    
                    SilikDGV.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Veri çekme hatası: " + ex.Message);
                }
            }
        }
    }
}
