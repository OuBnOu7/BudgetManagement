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
using System.IO;



namespace BudgetManagement.Panels
{
    public partial class Income : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Income()
        {
            
            InitializeComponent();
            getAll();
        }

        private void display_data()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select Name,Amount,Category,Date,Description from [income] where [User] = '"+Login.name+"'";
            ///cmd3.Parameters.AddWithValue("@username", Login.name);

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

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sql = "insert into income(Name,Amount,Category,Date,Description,[User]) values (@val1, @val2, @val3, @val4, @val5, @val6)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@val1", incName.Text);
                float amount;
                try
                {
                    amount = float.Parse(incAmount.Text);
                    // Conversion successful, use the result

                }
                catch (FormatException)
                {
                    // Conversion failed
                    MessageBox.Show("Erreur , veuillez saisir un montant exacte !");
                    return;
          
                }
                cmd.Parameters.AddWithValue("@val2", amount);
                cmd.Parameters.AddWithValue("@val3", incType.Text);
                cmd.Parameters.AddWithValue("@val4", DateTime.Parse(incDate.Text));
                cmd.Parameters.AddWithValue("@val5", incDes.Text);
                cmd.Parameters.AddWithValue("@val6", Login.name);
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void getIncomeWeekly()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM income  WHERE [User] = '" + Login.name + "'AND Date >= DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) AND Date<DATEADD(DAY, 8 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))";
            ;
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            incheb.Text = dta.Rows[0][0].ToString();
            if (dta.Rows[0][0].ToString() == "")
            {
                incheb.Text = "0";
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void getIncomeMonthly()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM income WHERE [User] = '" + Login.name + "'AND YEAR(Date) = YEAR(GETDATE()) AND MONTH(Date) = MONTH(GETDATE())";
;
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            incMon.Text = dta.Rows[0][0].ToString();
            incMon2.Text = dta.Rows[0][0].ToString();

            if (dta.Rows[0][0].ToString() == "")
            {
                incMon.Text = "0";
                incMon2.Text = "0";
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void getIncomeAnnually()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM income WHERE [User] = '" + Login.name + "'AND YEAR(Date) = YEAR(GETDATE())";
            ;
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            incAn.Text = dta.Rows[0][0].ToString();
            if (dta.Rows[0][0].ToString() == "")
            {
                incAn.Text = "0";
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void getTranche()
        {
            float x = float.Parse(incMon2.Text);
            switch (x)
            {
                case float n when n < 2501:
                    incTax.Text = "0%";
                    break;
                case float n when n >= 2501 && n<4166 :
                    incTax.Text = "10%";
                    break;
                case float n when n >= 4166 && n < 5000:
                    incTax.Text = "20%";
                    break;
                case float n when n >= 5000 && n < 6666:
                    incTax.Text = "30%";
                    break;
                case float n when n >= 6666 && n < 15000:
                    incTax.Text = "34%";
                    break;
                case float n when n >= 15000:
                    incTax.Text = "38%";
                    break;
                default:
                    incTax.Text = "";
                    break;

            }
        }

        private void getAll()
        {
            display_data();
            getIncomeWeekly();  
            getIncomeMonthly();
            getIncomeAnnually();
            getTranche();
            Login.MonthlyIncome();
            Login.getBalance();

        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save Downloaded Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write the headers
                        for (int i = 0; i < incomeDataGrid.Columns.Count; i++)
                        {
                            streamWriter.Write(incomeDataGrid.Columns[i].HeaderText);
                            if (i < incomeDataGrid.Columns.Count - 1)
                                streamWriter.Write(",");
                        }
                        streamWriter.WriteLine();

                        // Write the data
                        for (int row = 0; row < incomeDataGrid.Rows.Count - 1; row++)
                        {
                            for (int col = 0; col < incomeDataGrid.Columns.Count; col++)
                            {
                                streamWriter.Write(incomeDataGrid.Rows[row].Cells[col].Value);
                                if (col < incomeDataGrid.Columns.Count - 1)
                                    streamWriter.Write(",");
                            }
                            streamWriter.WriteLine();
                        }
                    }

                    MessageBox.Show("Data downloaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading data: " + ex.Message);
                }
            }
        }
    }
    }

