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
        public static string name;
        public static string phone;
        public static string mail;
        public static DateTime birthday;

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security = True");
        public Login()
        {
            InitializeComponent();
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
            else if (username.Text.Length < 6 || mdp.Text.Length < 6)
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
                    name = reader["Name"].ToString();
                    phone = reader["Phone"].ToString();
                    mail = reader["Adresse"].ToString();
                    birthday = DateTime.Parse(reader["Birthday"].ToString());
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();



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
    }
}
