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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-KJPHA09\SQLEXPRESS;Initial Catalog=PERSONEL_VERİTABANI;Integrated Security=True");

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt1 = new SqlCommand("Select Tbl_Manager Where UserName=@p1 And Password=@p2", bgl);

            kmt1.Parameters.AddWithValue("@p1", TxtUserName.Text);
            kmt1.Parameters.AddWithValue("@p2", TxtPassword.Text);

            SqlDataReader dr = kmt1.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Login Error!");
            }
            bgl.Close();
        }
    }
}
