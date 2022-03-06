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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-KJPHA09\SQLEXPRESS;Initial Catalog=PERSONEL_VERİTABANI;Integrated Security=True");
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Total Number of Personnel
            bgl.Open();
            SqlCommand kmt1 = new SqlCommand("Select Count(*) FROM Tbl_Personnel", bgl);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                LblTotalNumberPersonnel.Text = dr1[0].ToString();
            }
            bgl.Close();
            //Number of Married Personnel
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("Select Count(*) FROM Tbl_Personnel Where PerStatus=1", bgl);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                LblNumberMarriedPersonnel.Text = dr2[0].ToString();
            }
            bgl.Close();
            //Number of Single Personnel
            bgl.Open();
            SqlCommand kmt3 = new SqlCommand("Select Count(*) FROM Tbl_Personnel Where PerStatus=0", bgl);
            SqlDataReader dr3 = kmt3.ExecuteReader();
            while (dr3.Read())
            {
                LblNumberSinglePersonnel.Text = dr3[0].ToString();
            }
            bgl.Close();
            //Number of Cities
            bgl.Open();
            SqlCommand kmt4 = new SqlCommand("Select Count(Distinct(PerCity)) FROM Tbl_Personnel ", bgl);
            SqlDataReader dr4 = kmt4.ExecuteReader();
            while (dr4.Read())
            {
                LblNumberCities.Text = dr4[0].ToString();
            }
            bgl.Close();
            //Total Salary
            bgl.Open();
            SqlCommand kmt5 = new SqlCommand("Select Sum(PerWage) FROM Tbl_Personnel", bgl);
            SqlDataReader dr5 = kmt5.ExecuteReader();
            while (dr5.Read())
            {
                LblTotalSalary.Text = dr5[0].ToString();
            }
            bgl.Close();
            //Average Salary
            bgl.Open();
            SqlCommand kmt6 = new SqlCommand("Select Avg(PerWage) FROM Tbl_Personnel", bgl);
            SqlDataReader dr6 = kmt6.ExecuteReader();
            while (dr6.Read())
            {
                LblAverageSalary.Text = dr6[0].ToString();
            }
            bgl.Close();
        }
    }
}
