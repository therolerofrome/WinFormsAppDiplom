using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsAppDiplom
{
    public partial class Form1 : Form
    {
        button cl1 = new button();
        Button btn1;
        public Form1()
        {
            InitializeComponent();
            cl1.CreateMyButton(btn1, "не тыкай", this, 50, 50, 120, 50, Click_My_Button);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=port;Database=database,User ID=postgres;Password=password");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM Test ";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            comm.Dispose();
            conn.Close();
        }

        public void Click_My_Button(object sender, EventArgs e)
        {
        MessageBox.Show("зачем тыкнул");
        }
 
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
