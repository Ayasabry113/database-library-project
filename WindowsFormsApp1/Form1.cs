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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");
        private int userId;
        public Form1(int userId = 1)
        {
            InitializeComponent();
            this.userId = userId;
            LoadBooks();
        }

        private void LoadBooks()
        {
            string connectionString = "Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ISBN, Title, Price FROM Book";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string isbn = reader["ISBN"].ToString();
                    string title = reader["Title"].ToString();
                    float price = float.Parse(reader["Price"].ToString());

                    // Create a panel to hold book info and button
                    Panel panel = new Panel();
                    panel.Width = 300;
                    panel.Height = 100;

                    // Create and configure the label
                    Label lblBookInfo = new Label();
                    lblBookInfo.Text = $"Title: {title}, Price: {price:C}";
                    lblBookInfo.Width = 200;
                    lblBookInfo.Location = new Point(10, 10);

                    // Create and configure the button
                    Button btnDetails = new Button();
                    btnDetails.Text = "Details";
                    btnDetails.Width = 70;
                    btnDetails.Location = new Point(220, 10);
                    btnDetails.Click += (s, e) => BtnBorrow_Click(s, e, isbn);

                    // Add the label and button to the panel
                    panel.Controls.Add(lblBookInfo);
                    panel.Controls.Add(btnDetails);

                    // Add the panel to the form
                    this.Controls.Add(panel);
                }

                reader.Close();
            }
        }

        private void BtnBorrow_Click(object sender, EventArgs e, string isbn)
        {
          
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetailsForm books = new BookDetailsForm(1, "9780590353427");
            books.Show();
            this.Hide();
        }

        private void detaliesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_LibraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.university_LibraryDataSet.Book);
            // TODO: This line of code loads data into the 'university_LibraryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.university_LibraryDataSet.Author);
            // TODO: This line of code loads data into the 'university_LibraryDataSet.Book_Category' table. You can move, or remove it, as needed.
            this.book_CategoryTableAdapter.Fill(this.university_LibraryDataSet.Book_Category);

        }

        
    }
}
