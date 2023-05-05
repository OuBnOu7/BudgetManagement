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

namespace BudgetManagement
{
    public partial class Register : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Register()
        {
            InitializeComponent();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || mdp.Text == "" || phone.Text == "" || adresse.Text == "" || date.Text == "")
            {
                MessageBox.Show("Veuillez Remplir Les Champs");
            }
            else if (username.Text.Length < 6 || mdp.Text.Length < 6)
            {
                MessageBox.Show("Login et Le MDP doivent avoir au mois 6 Caracters !");
            }
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
                    MessageBox.Show("Nouveau Utilisateur Creé avec succes!");
                }
                else
                {
                    MessageBox.Show("Erreur Lors de la creation changer le username.");
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
