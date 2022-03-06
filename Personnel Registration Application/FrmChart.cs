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

namespace Personnel_Registration_Application
{
    public partial class FrmChart : Form
    {
        public FrmChart()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-KJPHA09\SQLEXPRESS;Initial Catalog=PERSONEL_VERİTABANI;Integrated Security=True");
        private void FrmChart_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt1 = new SqlCommand("Select PerCity,Count(*) FROM Tbl_Personnel Group By PerCity", bgl);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dr1[0],dr1[1]);
            }
            bgl.Close();
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("Select PerJob,Avg(PerWage) From Tbl_Personnel Group By PerJob", bgl);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Job-Wage"].Points.AddXY(dr2[0], dr2[1]);

            }
            bgl.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
