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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Books : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");

        public Books()
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Book", con);
            DataTable d = new DataTable();
            adapter.Fill(d);
            dataGridView1.DataSource = d;
        }

      

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void add_Click(object sender, EventArgs e)
        {
            addBook book = new addBook();
            book.Show();
            this.Hide();
            
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("delete from Book where ISBN='" + dataGridView1.CurrentRow.Cells[0].Value + "'", con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted !");
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Book", con);
            DataTable d = new DataTable();
            adapter1.Fill(d);
            dataGridView1.DataSource = d;

        }
    }
}
