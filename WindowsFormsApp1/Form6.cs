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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

       

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Sign_UP form = new Sign_UP();

            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_in form = new Log_in();

            this.Hide();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A_login form = new A_login();

            this.Hide();
            form.ShowDialog();
        }

        
    }
}
