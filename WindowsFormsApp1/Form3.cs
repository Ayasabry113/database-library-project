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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Sign_UP : Form
    {
        public Sign_UP()
        {
            InitializeComponent();
        }



        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (U_ID,First_Name,Last_Name,E_mail,Gender,Password,Age) VALUES('" + textBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox5.Text.ToString() + "'," + textBox8.Text.ToString() + "); " +
            "INSERT INTO Student (S_ID,City,No_Building,Country,Street) values(" + textBox3.Text.ToString() + ",'" + textBox10.Text.ToString() + "'," + textBox11.Text.ToString() + ",'" + textBox9.Text.ToString() + "','" + textBox12.Text.ToString() + "');", con);
            cmd.ExecuteNonQuery();
            Log_in form2 = new Log_in();
            form2.Show();
            this.Hide();


        }
    }
}
