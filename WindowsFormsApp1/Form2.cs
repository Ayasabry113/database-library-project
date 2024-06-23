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
using WindowsFormsApp4;

namespace WindowsFormsApp1
{
    public partial class BookDetailsForm : Form
    {
        private int userId;
        private string isbn;

        public BookDetailsForm(int userId, string isbn)
        {
            InitializeComponent();
            this.userId = userId;
            this.isbn = isbn;
            LoadBookDetails();
        }

      

        private void LoadBookDetails()
        {
            string connectionString = "Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title, Price, Publishing_Year FROM Book WHERE ISBN = @ISBN";
                SqlCommand cmd = new SqlCommand(query, conn);
                long myInt = long.Parse(isbn);
                cmd.Parameters.AddWithValue("@ISBN", myInt);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTitle.Text = reader["Title"].ToString();
                    lblPrice.Text = reader["Price"].ToString();
                    lblYear.Text = Convert.ToDateTime(reader["Publishing_Year"]).ToShortDateString();
                }
                reader.Close();
            }
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-TKCSHU9\\MSSQLSERVER1;DataBase=University_Library;Integrated Security=true;TrustServerCertificate=true";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                long myInt = long.Parse(isbn);
                conn.Open();
                string query = "UPDATE No_Copies SET ID = @UserID WHERE ISBN = @ISBN AND Statue = 'Available'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ISBN", myInt);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book borrowed successfully!");
                }
                else
                {
                    MessageBox.Show("No available copies to borrow.");
                }
            }
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }
    }
}
