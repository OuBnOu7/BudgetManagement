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
    public partial class Expense : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Expense()

        {
            InitializeComponent();
            getAll();

        }

        private void Expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter1.Fill(this.database1DataSet2.expense);
            // TODO: This line of code loads data into the 'database1DataSet1.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.database1DataSet1.expense);

        }
        private void expAdd_Click(object sender, EventArgs e)
        {
            if(expAmount.Text == "" || expName.Text == "" || expType.Text == "" || expDate.Text == "" || expDes.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs");
            }
            else
            {

                    connection.Open();
                    string sql = "insert into expense(Name,Amount,Category,Date,Description,[User]) values (@val1, @val2, @val3, @val4, @val5, @val6)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@val1", expName.Text);
                    cmd.Parameters.AddWithValue("@val2", float.Parse(expAmount.Text));
                    cmd.Parameters.AddWithValue("@val3", expType.Text);
                    cmd.Parameters.AddWithValue("@val4", DateTime.Parse(expDate.Text));
                    cmd.Parameters.AddWithValue("@val5", expDes.Text);
                    cmd.Parameters.AddWithValue("@val6", "Omar");
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    getAll();
                    MessageBox.Show("Ajout Avec Succes !");
                }
                else
                {
                    MessageBox.Show("Erreur ! Ressayer Plus Tard .");
                }

            }
        }

        private void getDetails(string type,System.Windows.Forms.Label Label, System.Windows.Forms.Label LabelPer)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM expense WHERE Category = '"+ type+"'";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            Label.Text = dta.Rows[0][0].ToString();
            if(dta.Rows[0][0].ToString() == "")
            {
                Label.Text = "0";
            }


            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT (SUM(Amount)/(SELECT SUM(Amount) FROM expense)) * 100 AS Percentage FROM expense WHERE Category = '"+ type +"'";
            object result = cmd2.ExecuteScalar();
            if (result != null)
            {
                double percentage = (double)result;
                LabelPer.Text = Math.Round(percentage, 2).ToString();
            }
            else
            {
                LabelPer.Text = "0";
            }


            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void display_data()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select Name,Amount,Category,Date,Description from [expense]";

            cmd3.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd3.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void getAll()
        {
            display_data();    
            getDetails("Logement", totLogement, pouLogement);
            getDetails("Nourriture", totNourriture, pouNourriture);
            getDetails("Transport", totTransport, pouTransport);
            getDetails("Abonement", totAbonement, pouAbonement);
            getDetails("Loisirs", totLoisirs, pouLoisirs);
        }

    }
}
