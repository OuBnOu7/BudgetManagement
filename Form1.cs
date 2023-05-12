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
using FontAwesome.Sharp;
using BudgetManagement.Panels;


namespace BudgetManagement
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Constructor
        public Form1()
        {
            InitializeComponent();
     
            incType.SelectedIndex = 1;
            getAll();
            this.StartPosition = FormStartPosition.CenterScreen;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(197, 7);
            leftBorderBtn.Location = new Point(0, 100);
            leftBorderBtn.Dock = DockStyle.None;
            leftBorderBtn.BringToFront();
            panelMenu.Controls.Add(leftBorderBtn);
        //Form

    }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.Size = desktopPanel.Size;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(childForm);
            desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Name;
        }
        private void reset()
        {
            DisableButton();
            //leftborderbtn.visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "home";
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //private void btnMaximize_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //        WindowState = FormWindowState.Maximized;
        //    else
        //        WindowState = FormWindowState.Normal;
        //}
        //private void btnMinimize_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}
        ////Remove transparent border in maximized state
        //private void FormMainMenu_Resize(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Maximized)
        //        FormBorderStyle = FormBorderStyle.None;
        //    else
        //        FormBorderStyle = FormBorderStyle.Sizable;
        //}

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Dashboard());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Wallet());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Income());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Expense());
        }


        private void logoBtn_Click(object sender, EventArgs e)
        {
            reset();
            leftBorderBtn.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Alarm());
        }
        private void getAll()
        {
            Login.getIncomeM();
            Income_Total.Text = Login.IncomeM.ToString();
            Login.getExpenseM();
            Expense_Total.Text = Login.ExpenseM.ToString();
            Login.getBalance();
            Balance_Total.Text = Login.solde.ToString();
        }

        private void incType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (incType.Text == "Mensuel") {Login.bilan = "Mensuel"; Login.getExpenseM(); Login.getIncomeM(); Expense_Total.Text = Login.ExpenseM.ToString(); Income_Total.Text = Login.IncomeM.ToString(); }
            else if (incType.Text == "Annuel") { Login.bilan = "Annuel"; Login.getExpenseA(); Login.getIncomeA(); Expense_Total.Text = Login.ExpenseA.ToString(); Income_Total.Text = Login.IncomeA.ToString(); }
            else if (incType.Text == "Hebdomadaire") { Login.bilan = "Hebdomadaire"; Login.getExpenseW(); Login.getIncomeW(); Expense_Total.Text = Login.ExpenseW.ToString(); Income_Total.Text = Login.IncomeW.ToString(); }

            dashBtn.PerformClick();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Opens directly the dashboard
            dashBtn.PerformClick();
        }
    }
}