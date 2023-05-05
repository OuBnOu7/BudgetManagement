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

namespace BudgetManagement.Panels
{
    public partial class Income : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Income()
        {
            
            InitializeComponent();
            display_data();
        }

        private void display_data()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select Name,Amount,Category,Date,Description from [income]";

            cmd3.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd3.CommandText, connection); ;
            dataadp.Fill(dta);
            incomeDataGrid.DataSource = dta;

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void incAdd_Click(object sender, EventArgs e)
        {
            if (incAmount.Text == "" || incName.Text == "" || incType.Text == "" || incDate.Text == "" || incDes.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs");
            }
            else
            {

                connection.Open();
                string sql = "insert into income(Name,Amount,Category,Date,Description,[User]) values (@val1, @val2, @val3, @val4, @val5, @val6)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@val1", incName.Text);
                cmd.Parameters.AddWithValue("@val2", float.Parse(incAmount.Text));
                cmd.Parameters.AddWithValue("@val3", incType.Text);
                cmd.Parameters.AddWithValue("@val4", DateTime.Parse(incDate.Text));
                cmd.Parameters.AddWithValue("@val5", incDes.Text);
                cmd.Parameters.AddWithValue("@val6", "Omar");
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    display_data();
                    MessageBox.Show("Ajout Avec Succes !");
                }
                else
                {
                    MessageBox.Show("Erreur ! Ressayer Plus Tard .");
                }

            }
        }
    }
}
