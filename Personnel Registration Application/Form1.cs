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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-KJPHA09\SQLEXPRESS;Initial Catalog=PERSONEL_VERİTABANI;Integrated Security=True");

        void clear()
        {
            TxtPerİd.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            CmbCity.Text = "";
            MaskWage.Text = "";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            TxtPerJob.Text = "";
            TxtName.Focus();
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pERSONEL_VERİTABANIDataSet.Tbl_Personnel' table. You can move, or remove it, as needed.
            this.tbl_PersonnelTableAdapter.Fill(this.pERSONEL_VERİTABANIDataSet.Tbl_Personnel);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("INSERT INTO Tbl_Personnel (PerName,PerSurname,PerCity,PerWage,PerJob,PerStatus) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
            kmt.Parameters.AddWithValue("@p1", TxtName.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSurname.Text);
            kmt.Parameters.AddWithValue("@p3", CmbCity.Text);
            kmt.Parameters.AddWithValue("@p4", MaskWage.Text);
            kmt.Parameters.AddWithValue("@p5", TxtPerJob.Text);
            kmt.Parameters.AddWithValue("@p6", label8.Text);
            kmt.ExecuteNonQuery();

            bgl.Close();
            MessageBox.Show("Personnel Added" );


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand delete = new SqlCommand("Delete From Tbl_Personnel Where Perİd=@p1", bgl);
            delete.Parameters.AddWithValue("@p1", TxtPerİd.Text);
            delete.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Personnel Deleted");
        }
        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("Update Tbl_Personel Set PerName=@p1,PerSurname=@p2,PerCity=@p3,PerWage=@p4,PerStatus=@p5,PerJob=@p6 WHERE Perİd=@p7 ", bgl);
            kmt2.Parameters.AddWithValue("@p1", TxtName.Text);
            kmt2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            kmt2.Parameters.AddWithValue("@p3", CmbCity.Text);
            kmt2.Parameters.AddWithValue("@p4", MaskWage.Text);
            kmt2.Parameters.AddWithValue("@p5", label8.Text);
            kmt2.Parameters.AddWithValue("@p6", TxtPerJob.Text);
            kmt2.Parameters.AddWithValue("@p7", TxtPerİd.Text);
            kmt2.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Personnel Updated");

        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics fr = new FrmStatistics();
            fr.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;

            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int  scl= dataGridView1.SelectedCells[0].RowIndex;
            TxtPerİd.Text = dataGridView1.Rows[scl].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[scl].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[scl].Cells[2].Value.ToString();
            TxtPerJob.Text = dataGridView1.Rows[scl].Cells[3].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[scl].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[scl].Cells[5].Value.ToString();
            MaskWage.Text = dataGridView1.Rows[scl].Cells[6].Value.ToString();
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            FrmChart fr = new FrmChart();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
            fr.Show();
        }
    }
}
