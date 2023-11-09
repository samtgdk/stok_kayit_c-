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

namespace satis
{
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"Data Source=LAPTOP-41S7NGID\MSSQLSERVER01;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satisListele()
        {
            Baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", Baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            Baglanti.Close();
        }
        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            satisListele();
        }
    }
}
