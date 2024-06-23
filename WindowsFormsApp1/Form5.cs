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
    public partial class A_login : Form
    {
        public A_login()
        {
            InitializeComponent();
        }

       

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM [Admin],[User] where [Admin].A_ID = [User].U_ID and [Admin].A_ID="+ textBox1.Text+ " and [User].[Password] =" + textBox2.Text, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("User ID and password are correct\n\t\tWelcome");
                Form10 form10 = new Form10();
                form10.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user ID or password");
            }
            con.Close();
        }
    }
}
