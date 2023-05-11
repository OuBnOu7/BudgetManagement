using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;



namespace BudgetManagement
{
    public partial class Login : Form
    {
        public static int id;
        public static string name;
        public static string phone;
        public static string mail;
        public static DateTime birthday;
        public static float MonthlySalary = 0;
        public static float MonthlyExpense = 0;
        public static float solde = 0;

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = validate;

        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void DragMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void validate_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || mdp.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs");
            }
            else if (username.Text.Length < 4 || mdp.Text.Length < 4)
            {
                MessageBox.Show("Login et Le MDP doivent avoir au mois 6 Caracters !");
            }
            else
            {
                string user = username.Text;
                string password = mdp.Text;

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText  = "SELECT * FROM [user] WHERE Name=@username AND Password=@password";
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", password);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.Read())
                {
                    
                    MessageBox.Show("Login successful!");
                    id = int.Parse(reader["Id"].ToString());
                    name = reader["Name"].ToString();
                    phone = reader["Phone"].ToString();
                    mail = reader["Adresse"].ToString();
                    birthday = DateTime.Parse(reader["Birthday"].ToString());
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                    reader.Close(); // I closed reader because it will be open again in the next method call
                    MonthlyIncome();
                    reader.Close(); // I closed reader because it will be open again in the next method call
                    getMonthlyExpense();
                    reader.Close(); // I closed reader because it will be open again in the next method call
                    getBalance();



                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }



                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }



        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        static public void getMonthlyExpense()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT SUM(Amount) FROM income WHERE [User] = '" + Login.name + "'AND YEAR(Date) = YEAR(GETDATE()) AND MONTH(Date) = MONTH(GETDATE())";
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.Read())
                {
                            if (!reader.IsDBNull(0))
        {
            Login.MonthlySalary = float.Parse(reader[0].ToString());
        }
        else
        {
            Login.MonthlySalary = 0;
        }
                }

                reader.Close();
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        static public void MonthlyIncome()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT SUM(Amount) FROM expense WHERE [User] = '" + Login.name + "'AND YEAR(Date) = YEAR(GETDATE()) AND MONTH(Date) = MONTH(GETDATE())";
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        Login.MonthlyExpense = float.Parse(reader[0].ToString());
                    }
                    else
                    {
                        Login.MonthlyExpense = 0;
                    }
                }

                reader.Close();
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        static public void getBalance()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            float totalIncome = 0;
            float totalExpense = 0;


            // Retrieve the total income
            string incomeQuery = "SELECT SUM(Amount) FROM income WHERE [User] = @userId";
            SqlCommand incomeCommand = new SqlCommand(incomeQuery, connection);
            incomeCommand.Parameters.AddWithValue("@userId", Login.name);
            object incomeResult = incomeCommand.ExecuteScalar();

            if (incomeResult != DBNull.Value)
            {
                 totalIncome = Convert.ToSingle(incomeResult);
            }
            

            // Retrieve the total expense
            string expenseQuery = "SELECT SUM(Amount) FROM expense WHERE [User] = @userId";
            SqlCommand expenseCommand = new SqlCommand(expenseQuery, connection);
            expenseCommand.Parameters.AddWithValue("@userId", Login.name);
            object expenseResult = expenseCommand.ExecuteScalar();

            if (expenseResult != DBNull.Value)
            {
                 totalExpense = Convert.ToSingle(expenseResult);
            }
            

            // Calculate the balance

            Login.solde = totalIncome - totalExpense ;

            // Update Balance in DB

            string updateCreditCardQuery = "UPDATE [creditcard] SET [balance] = @newBalance WHERE [user] = @userId";
            SqlCommand updateCreditCardCommand = new SqlCommand(updateCreditCardQuery, connection);

            // Set the parameter values
            updateCreditCardCommand.Parameters.AddWithValue("@newBalance", Login.solde);
            updateCreditCardCommand.Parameters.AddWithValue("@userId", Login.id);

            int rowsUpdated = updateCreditCardCommand.ExecuteNonQuery();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }

}
