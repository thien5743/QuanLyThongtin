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
using System.Drawing.Text;
namespace QuanLyThongtin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAB1-MAY11\\MISASME2022;Initial Catalog=QuanLiThongTin;Integrated Security=True;Encrypt=False");

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void openCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }
        private void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private Boolean Exe(string cmd)
        {
            closeCon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
                throw;
            }
            openCon();
            return check;

        }
        private DataTable Red(string cmd)
        {
            openCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            closeCon();
            return dt;

        }
        private void load()
        {
            DataTable dt = Red("SELECT * FROM QuanLyThongtin");
            if(dt!=null)
            {
                dataGridView1.DataSource = dt;
            }    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmaten.ResetText();
            txthoten.ResetText();
            txtnamsinh.ResetText();
            txtquequan.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO quanlythongtin(maten,hoten,namsinh,quequan) VALUES(N'" + txtmaten.Text + "',N'" + txthoten.Text + "',N'" + txtnamsinh.Text + "',N'" + txtquequan.Text + "')");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exe("UPDATE quanlythongtin SET maten = N'" + txtmaten.Text + "',hoten =N'" + txthoten.Text + "',namsinh = N'" + txtnamsinh.Text + "',quequan =N'" + txtquequan.Text + "')");

        }
    }

}
