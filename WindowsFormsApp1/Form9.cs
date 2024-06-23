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

namespace WindowsFormsApp4
{
    public partial class Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6BBNEFE\\SQLEXPRESS;Initial Catalog=University_Library;Integrated Security=True");
        public Report()
        {
            InitializeComponent();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT    U.U_ID,  U.First_Name,   U.Last_Name,   U.E_mail,    U.Gender, U.Password,    U.Age,   S.City,  S.No_Building,    S.Country,    S.Street,    Age_Categorization.Age_Group FROM      [University_Library].[dbo].[User] U INNER JOIN    [University_Library].[dbo].[Student] S ON S.S_ID = U.U_ID INNER JOIN (   SELECT   U_ID,   CASE           WHEN Age < 18 THEN 'Minor'          WHEN Age BETWEEN 18 AND 24 THEN 'Young Adult'        WHEN Age BETWEEN 25 AND 64 THEN 'Adult'        ELSE 'Senior'   END AS Age_Group FROM         [University_Library].[dbo].[User]) AS Age_Categorization ON U.U_ID = Age_Categorization.U_ID ORDER BY     U.Last_Name, U.First_Name;", con);
            DataTable d = new DataTable();
            adapter1.Fill(d);
            dataGridView1.DataSource = d;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}