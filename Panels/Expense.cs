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
using System.Text.RegularExpressions;

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
            else if (!Regex.IsMatch(expAmount.Text, @"^[0-9]+([,.][0-9]+)?$"))
            {
                MessageBox.Show("Le montant doit être un nombre valide.");
            }
            else
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sql = "insert into expense(Name,Amount,Category,Date,Description,[User]) values (@val1, @val2, @val3, @val4, @val5, @val6)";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                float amount;
                try
                {
                    amount = float.Parse(expAmount.Text);
                    // Conversion successful, use the result

                }
                catch (FormatException)
                {
                    // Conversion failed
                    MessageBox.Show("Erreur , veuillez saisir un montant exacte !");
                    return;

                }

                cmd.Parameters.AddWithValue("@val1", expName.Text);
                    cmd.Parameters.AddWithValue("@val2", amount);
                    cmd.Parameters.AddWithValue("@val3", expType.Text);
                    cmd.Parameters.AddWithValue("@val4", DateTime.Parse(expDate.Text));
                    cmd.Parameters.AddWithValue("@val5", expDes.Text);
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

        //Get Monthly Weekly or Yearly Details

        //Weekly

        private void getDetailsW(string type, System.Windows.Forms.Label Label, System.Windows.Forms.Label LabelPer)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            //Petit Algo pour calculer des donnée dans la semaine actuelle
            DateTime currentDate = DateTime.Now;
            DateTime startOfWeek = currentDate.AddDays(-1 * (int)currentDate.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM expense WHERE [User] = @user AND Category = @category AND Date >= @startDate AND Date <= @endDate";
            cmd.Parameters.AddWithValue("@user", Login.name);
            cmd.Parameters.AddWithValue("@category", type);
            cmd.Parameters.AddWithValue("@startDate", startOfWeek.Date);
            cmd.Parameters.AddWithValue("@endDate", endOfWeek.Date);

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            Label.Text = dta.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(Label.Text))
            {
                Label.Text = "0";
            }


            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT (SUM(Amount) / (SELECT SUM(Amount) FROM expense WHERE [User] = @userName)) * 100 AS Percentage FROM expense WHERE[User] = @userName AND Category = @category AND Date >= @startDate AND Date <= @endDate";
            cmd2.Parameters.AddWithValue("@userName", Login.name);
            cmd2.Parameters.AddWithValue("@category", type);
            cmd2.Parameters.AddWithValue("@startDate", startOfWeek.Date);
            cmd2.Parameters.AddWithValue("@endDate", endOfWeek.Date);
            object result = cmd2.ExecuteScalar();
            if (result != DBNull.Value)
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

        // Monthly
        private void getDetailsM(string type,System.Windows.Forms.Label Label, System.Windows.Forms.Label LabelPer)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM expense WHERE [User] = '" + Login.name + "' AND Category = '" + type+ "' AND YEAR(Date) = YEAR(GETDATE()) AND MONTH(Date) = MONTH(GETDATE())";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            Label.Text = dta.Rows[0][0].ToString();
            if (dta.Rows[0][0].ToString() == "")
            {
                Label.Text = "0";
            }


            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT (SUM(Amount) / (SELECT SUM(Amount) FROM expense WHERE [User] = @userName)) * 100 AS Percentage FROM expense WHERE[User] = @userName AND Category = @category AND YEAR(Date) = YEAR(GETDATE()) AND MONTH(Date) = MONTH(GETDATE())";
            cmd2.Parameters.AddWithValue("@userName", Login.name);
            cmd2.Parameters.AddWithValue("@category", type);
            object result = cmd2.ExecuteScalar();
            if (result != DBNull.Value)
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

        // Yearly
        private void getDetailsA(string type, System.Windows.Forms.Label Label, System.Windows.Forms.Label LabelPer)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Amount) FROM expense WHERE [User] = '" + Login.name + "' AND Category = '" + type + "' AND YEAR(Date) = YEAR(GETDATE())";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            Label.Text = dta.Rows[0][0].ToString();
            if (dta.Rows[0][0].ToString() == "")
            {
                Label.Text = "0";
            }


            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT (SUM(Amount) / (SELECT SUM(Amount) FROM expense WHERE [User] = @userName)) * 100 AS Percentage FROM expense WHERE[User] = @userName AND Category = @category AND YEAR(Date) = YEAR(GETDATE())";
            cmd2.Parameters.AddWithValue("@userName", Login.name);
            cmd2.Parameters.AddWithValue("@category", type);
            object result = cmd2.ExecuteScalar();
            if (result != DBNull.Value)
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

        // Display data in the datagrid

        private void display_data()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select Name,Amount,Category,Date,Description from [expense] WHERE [User] = '" + Login.name + "'";

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

        private void getState()
        {
            if (int.Parse(totLogement.Text)> 0.5 * Login.IncomeM)
            {
                bilLogement.Text = ">50%";
                bilLogement.ForeColor = Color.Red;
            }
            if (int.Parse(totTransport.Text) > 0.1 * Login.IncomeM)
            {
                bilTransport.Text = ">10%";
                bilTransport.ForeColor = Color.Red;
            }
            if (int.Parse(totAbonement.Text) > 0.1 * Login.IncomeM)
            {
                bilAbonement.Text = ">10%";
                bilAbonement.ForeColor = Color.Red;
            }
            if (int.Parse(totNourriture.Text) > 0.15 * Login.IncomeM)
            {
                bilNourriture.Text = ">15%";
                bilNourriture.ForeColor = Color.Red;
            }
            if (int.Parse(totLoisirs.Text) > 0.5 * Login.IncomeM)
            {
                bilLoisirs.Text = ">5%";
                bilLoisirs.ForeColor = Color.Red;
            }
        }

        private void getAll()
        {
            display_data();

            if (Login.bilan == "Mensuel")
            {
                getDetailsM("Logement", totLogement, pouLogement);
                getDetailsM("Nourriture", totNourriture, pouNourriture);
                getDetailsM("Transport", totTransport, pouTransport);
                getDetailsM("Abonement", totAbonement, pouAbonement);
                getDetailsM("Loisirs", totLoisirs, pouLoisirs);
            }

            else if (Login.bilan == "Annuel") {
                getDetailsA("Logement", totLogement, pouLogement);
                getDetailsA("Nourriture", totNourriture, pouNourriture);
                getDetailsA("Transport", totTransport, pouTransport);
                getDetailsA("Abonement", totAbonement, pouAbonement);
                getDetailsA("Loisirs", totLoisirs, pouLoisirs);
            }
            else if (Login.bilan == "Hebdomadaire") {
                getDetailsW("Logement", totLogement, pouLogement);
                getDetailsW("Nourriture", totNourriture, pouNourriture);
                getDetailsW("Transport", totTransport, pouTransport);
                getDetailsW("Abonement", totAbonement, pouAbonement);
                getDetailsW("Loisirs", totLoisirs, pouLoisirs);
            }

            getState();
            Login.getExpenseM();
            Login.getExpenseA();
            Login.getExpenseW();
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
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            streamWriter.Write(dataGridView1.Columns[i].HeaderText);
                            if (i < dataGridView1.Columns.Count - 1)
                                streamWriter.Write(",");
                        }
                        streamWriter.WriteLine();

                        // Write the data
                        for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
                        {
                            for (int col = 0; col < dataGridView1.Columns.Count; col++)
                            {
                                streamWriter.Write(dataGridView1.Rows[row].Cells[col].Value);
                                if (col < dataGridView1.Columns.Count - 1)
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
