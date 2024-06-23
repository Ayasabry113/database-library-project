using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");

        public Form10()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.Show();
            this.Hide();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBook book = new addBook();
            book.Show();
            this.Hide();

        }
    }
}