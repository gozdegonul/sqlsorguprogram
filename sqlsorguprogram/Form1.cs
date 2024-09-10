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
using System.Data.Common;

namespace sqlsorguprogram
{
    public partial class sorgu : Form
    {
        public sorgu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Gozde_Huawei;Initial Catalog=sqlsorgu;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
           






        }

        private void btncalis_Click(object sender, EventArgs e)
        {
            
            string sorgu = richBox.Text;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;





            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen sorgunuzu kontrol edin" , "Uyarı" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngüncel_Click(object sender, EventArgs e)
        {

            string sorgu = richBox.Text;
            try
            {
               
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu , baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from sorgu", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


               

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sorgunuzu kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

           

        }
    }
}
