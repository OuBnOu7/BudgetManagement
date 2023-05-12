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
using System.Text.RegularExpressions;

namespace BudgetManagement
{
    public partial class Register : Form
    {


        private readonly FontAwesome.Sharp.IconPictureBox iconBack = new FontAwesome.Sharp.IconPictureBox(); SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void validate_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || mdp.Text == "" || phone.Text == "" || adresse.Text == "" || date.Text == "" || creditcard.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Tous Les Champs");
            }
            else if (!Regex.IsMatch(phone.Text, @"^(\+[0-9]{1,3})?[0-9]{10}$"))
            {
                MessageBox.Show("Numéro de téléphone Invalide");
            }

            else if (username.Text.Length < 4 || mdp.Text.Length < 4)
            {
                MessageBox.Show("Login et Le MDP doivent avoir au mois 6 Caracters !");
            }
            //else if (!Regex.IsMatch(creditcard.Text, @"^(4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$"))
            //{
            //    MessageBox.Show("Entrez carte bancaire Valide ! ");
            //}

            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string insertQuery = "INSERT INTO [user] (Name, Birthday, Phone, Password, Adresse) VALUES (@name, @birthday, @phone, @password, @adresse)";
                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@name", username.Text);
                command.Parameters.AddWithValue("@birthday", DateTime.Parse(date.Text));
                command.Parameters.AddWithValue("@phone", phone.Text);
                command.Parameters.AddWithValue("@password", mdp.Text);
                command.Parameters.AddWithValue("@adresse", adresse.Text);

                int rowsInserted = command.ExecuteNonQuery();


                if (rowsInserted > 0)
                {
                    //Select the id inserted in the user table
                    SqlCommand getIdCommand = new SqlCommand("SELECT MAX(Id) FROM [user]", connection);
                    object result = getIdCommand.ExecuteScalar();
                    int userId = Convert.ToInt32(result);

                    string insertCreditCardQuery = "INSERT INTO [creditcard] ([number], [exp], [balance], [hasDebt], [debt], [moisR], [interet], [user]) VALUES (@number, @exp, @balance, @hasDebt, @debt, @monthsRemaining, @interestRate, @userId)";
                    SqlCommand creditCardCommand = new SqlCommand(insertCreditCardQuery, connection);

                    creditCardCommand.Parameters.AddWithValue("@number", creditcard.Text);
                    creditCardCommand.Parameters.AddWithValue("@exp", "10/27");
                    creditCardCommand.Parameters.AddWithValue("@balance", float.Parse("0"));

                    //Simulate an original credit card with debt or not

                    Random random = new Random();
                    Boolean hasDebt = random.Next(2) == 0;
                    float debtAmount = hasDebt ? random.Next(10000, 100001) : 0;
                    int monthsRemaining = hasDebt ? random.Next(12, 49) : 0;
                    float interestRate = hasDebt ? (float)random.NextDouble() * (0.4f - 0.05f) + 0.05f : 0;

                    creditCardCommand.Parameters.AddWithValue("@hasDebt", hasDebt);
                    creditCardCommand.Parameters.AddWithValue("@debt", debtAmount);
                    creditCardCommand.Parameters.AddWithValue("@monthsRemaining", monthsRemaining);
                    creditCardCommand.Parameters.AddWithValue("@interestRate", interestRate);
                    creditCardCommand.Parameters.AddWithValue("@userId", userId);

                    int rowsInsertedCreditCard = creditCardCommand.ExecuteNonQuery();

                    if (rowsInsertedCreditCard > 0)
                    {
                        MessageBox.Show("Nouveau Utilisateur Créé avec succès!");
                        Login login1 = new Login();
                        this.Hide();
                        login1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création de la carte de crédit.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur Lors de la creation ! changer le username.");
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            this.Hide();
            login1.Show();
        }
    }
}
