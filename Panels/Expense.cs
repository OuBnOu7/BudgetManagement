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
        }


        private void expAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void addExpense_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter1.Fill(this.database1DataSet2.expense);
            // TODO: This line of code loads data into the 'database1DataSet1.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.database1DataSet1.expense);

        }

        private void totLogement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
