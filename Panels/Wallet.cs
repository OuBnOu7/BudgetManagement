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
    public partial class Wallet : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Wallet()
        {
            InitializeComponent();
            getAll();
        }

        private void getAll()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT [number], [exp], [balance], [hasDebt], [debt], [moisR], [interet] FROM creditcard WHERE [user] = @userId", connection);
            cmd.Parameters.AddWithValue("@userId", Login.id);


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string number = reader["number"].ToString();
                    string exp = reader["exp"].ToString();
                    float balance = float.Parse(reader["balance"].ToString());
                    bool hasDebt = Convert.ToBoolean(reader["hasDebt"]);
                    float debt = float.Parse(reader["debt"].ToString());
                    int moisR = Convert.ToInt32(reader["moisR"]);
                    float interet = (float)Math.Round(float.Parse(reader["interet"].ToString()), 2);



                    // Update the labels with the retrieved values

                    bankId.Text = number;
                    bankExp.Text = exp;
                    solde.Text = balance.ToString();
                    rev.Text = Login.MonthlySalary.ToString();
                    dep.Text = Login.MonthlyExpense.ToString();


                    bool wachDebt = Convert.ToBoolean(reader["hasDebt"]);
                    if (wachDebt) { ;
                    pret.Text = debt.ToString();
                    time.Text = moisR.ToString();
                    interetMoins.Text = interet.ToString();
                    }
                    else
                    {
                        ;
                        pret.Text = "0";
                        time.Text = "0";
                        interetMoins.Text = "0";
                    }
                }

                reader.Close();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
