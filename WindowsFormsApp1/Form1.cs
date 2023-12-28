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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        private void cleardata()
        {
            name.Clear();
            address.Clear();
            id.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=school;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            displaydata();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"insert into student(Name,Address) values('{name.Text.ToString()}','{address.Text.ToString()}')";
            cmd.CommandText = query ;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
           displaydata();
            

        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void update_Click(object sender, EventArgs e)
        {
            string update = $"update student set Name='" + name.Text.ToString() + "',Address='"+address.Text.ToString()+"'where id='"+id.Text.ToString()+"'";
            cmd.CommandText = update;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cleardata();
            displaydata();


        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "	select * from student";
            cmd.ExecuteNonQuery();  
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
        private void showall_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string delete = $"delete student where id='{id.Text.ToString()}'";
            cmd.CommandText= delete;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource= delete;
            conn.Close();
            displaydata();
        }
    }
    
}
