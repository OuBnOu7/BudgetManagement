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
    public partial class Alarm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");

        public Alarm()
        {
            InitializeComponent();
            timer1.Start();
            getAll();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void getExp()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // Assuming you have a SqlConnection object named 'connection' already established

            DateTime today = DateTime.Today;
            string tableName = "YourTableName"; // Replace with the actual table name

            // Create a SQL command to query the system views
            string query = @"SELECT COUNT(*) FROM sys.dm_db_index_usage_stats AS us INNER JOIN sys.tables AS t ON us.object_id = t.object_id WHERE t.name = @tableName AND DATEDIFF(DAY, us.last_user_update, @today) = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tableName", "expense");
            command.Parameters.AddWithValue("@today", today);
            

            int rowCount = (int)command.ExecuteScalar();

            if (rowCount > 0)
            {
                // Table has been modified today
                exp.Text = "Vous avez pas inseré vos depenses aujourd'hui.";
            }
            else
            {
                // Table has not been modified today
                exp.Text = "Vous avez inseré vos depenses aujourd'hui.";
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void getInc()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // Assuming you have a SqlConnection object named 'connection' already established

            DateTime today = DateTime.Today;
            string tableName = "YourTableName"; // Replace with the actual table name

            // Create a SQL command to query the system views
            string query = @"SELECT COUNT(*) FROM sys.dm_db_index_usage_stats AS us INNER JOIN sys.tables AS t ON us.object_id = t.object_id WHERE t.name = @tableName AND DATEDIFF(DAY, us.last_user_update, @today) = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tableName", "income");
            command.Parameters.AddWithValue("@today", today);

            int rowCount = (int)command.ExecuteScalar();

            if (rowCount > 0)
            {
                // Table has been modified today
                inc.Text = "Vous avez inseré vos revenus aujourd'hui";
            }
            else
            {
                // Table has not been modified today
                inc.Text = "Vous avez pas inseré vos revenus aujourd'hui";
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void getDateI()
        {
            connection.Open();


            string columnName = "Date";
            string tableName = "income"; // Replace with the actual table name

            // Create a SQL command to query the table
            string query = @"SELECT MAX("+ columnName + ") FROM " + tableName;

            SqlCommand command = new SqlCommand(query, connection);

            DateTime lastInsertionTime = (DateTime)command.ExecuteScalar();

            // Use the lastInsertionTime as needed
            dateInc.Text = lastInsertionTime.ToString();

            connection.Close();
        }

        private void getDateE()
        {
            connection.Open();


            string columnName = "Date";
            string tableName = "expense"; // Replace with the actual table name

            // Create a SQL command to query the table
            string query = @"SELECT MAX(" + columnName + ") FROM " + tableName;

            SqlCommand command = new SqlCommand(query, connection);

            DateTime lastInsertionTime = (DateTime)command.ExecuteScalar();

            // Use the lastInsertionTime as needed
            dateExp.Text = lastInsertionTime.ToString();

            connection.Close();
        }

        private void getAll()
        {
            getExp();
            getInc();
            getDateI();
            getDateE();
        }

    }
}
