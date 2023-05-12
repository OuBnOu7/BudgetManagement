namespace BudgetManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashBtn = new FontAwesome.Sharp.IconButton();
            this.walletBtn = new FontAwesome.Sharp.IconButton();
            this.incomeBtn = new FontAwesome.Sharp.IconButton();
            this.expenseBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Balance = new System.Windows.Forms.Label();
            this.Balance_Total = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.total_Expense = new System.Windows.Forms.Label();
            this.Expense_Total = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_Income = new System.Windows.Forms.Label();
            this.Income_Total = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.incType = new System.Windows.Forms.ComboBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.dashBtn);
            this.panelMenu.Controls.Add(this.walletBtn);
            this.panelMenu.Controls.Add(this.incomeBtn);
            this.panelMenu.Controls.Add(this.expenseBtn);
            this.panelMenu.Controls.Add(this.iconButton9);
            this.panelMenu.Controls.Add(this.logoutBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(205, 902);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::BudgetManagement.Properties.Resources.Logo_UseCWwaT6_transformed;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // dashBtn
            // 
            this.dashBtn.FlatAppearance.BorderSize = 0;
            this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBtn.ForeColor = System.Drawing.Color.White;
            this.dashBtn.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.dashBtn.IconColor = System.Drawing.Color.White;
            this.dashBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBtn.Location = new System.Drawing.Point(3, 166);
            this.dashBtn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dashBtn.Size = new System.Drawing.Size(197, 50);
            this.dashBtn.TabIndex = 1;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashBtn.UseVisualStyleBackColor = true;
            this.dashBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // walletBtn
            // 
            this.walletBtn.FlatAppearance.BorderSize = 0;
            this.walletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.walletBtn.ForeColor = System.Drawing.Color.White;
            this.walletBtn.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.walletBtn.IconColor = System.Drawing.Color.White;
            this.walletBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.walletBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.walletBtn.Location = new System.Drawing.Point(3, 222);
            this.walletBtn.Name = "walletBtn";
            this.walletBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.walletBtn.Size = new System.Drawing.Size(197, 50);
            this.walletBtn.TabIndex = 2;
            this.walletBtn.Text = "Wallet";
            this.walletBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.walletBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.walletBtn.UseVisualStyleBackColor = true;
            this.walletBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // incomeBtn
            // 
            this.incomeBtn.FlatAppearance.BorderSize = 0;
            this.incomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeBtn.ForeColor = System.Drawing.Color.White;
            this.incomeBtn.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.incomeBtn.IconColor = System.Drawing.Color.White;
            this.incomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.incomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeBtn.Location = new System.Drawing.Point(3, 278);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.incomeBtn.Size = new System.Drawing.Size(197, 50);
            this.incomeBtn.TabIndex = 3;
            this.incomeBtn.Text = "Income";
            this.incomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incomeBtn.UseVisualStyleBackColor = true;
            this.incomeBtn.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // expenseBtn
            // 
            this.expenseBtn.FlatAppearance.BorderSize = 0;
            this.expenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseBtn.ForeColor = System.Drawing.Color.White;
            this.expenseBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.expenseBtn.IconColor = System.Drawing.Color.White;
            this.expenseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.expenseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseBtn.Location = new System.Drawing.Point(3, 334);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.expenseBtn.Size = new System.Drawing.Size(197, 50);
            this.expenseBtn.TabIndex = 4;
            this.expenseBtn.Text = "Expenses";
            this.expenseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.expenseBtn.UseVisualStyleBackColor = true;
            this.expenseBtn.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.ForeColor = System.Drawing.Color.White;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconButton9.IconColor = System.Drawing.Color.White;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(3, 390);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton9.Size = new System.Drawing.Size(197, 50);
            this.iconButton9.TabIndex = 5;
            this.iconButton9.Text = "Alarm";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = true;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(3, 823);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 380, 3, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutBtn.Size = new System.Drawing.Size(197, 50);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.desktopPanel);
            this.panelDesktop.Controls.Add(this.shadowPanel);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(205, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1165, 814);
            this.panelDesktop.TabIndex = 3;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 10);
            this.desktopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(1165, 804);
            this.desktopPanel.TabIndex = 1;
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(1165, 10);
            this.shadowPanel.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(205, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1165, 88);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(168, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 85);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.incType, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.Balance);
            this.panel4.Controls.Add(this.Balance_Total);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(497, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 76);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BudgetManagement.Properties.Resources.justice;
            this.pictureBox4.Location = new System.Drawing.Point(16, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Balance
            // 
            this.Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Balance.Location = new System.Drawing.Point(151, 9);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(96, 32);
            this.Balance.TabIndex = 4;
            this.Balance.Text = "Balance";
            // 
            // Balance_Total
            // 
            this.Balance_Total.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_Total.ForeColor = System.Drawing.Color.Gainsboro;
            this.Balance_Total.Location = new System.Drawing.Point(78, 34);
            this.Balance_Total.Name = "Balance_Total";
            this.Balance_Total.Size = new System.Drawing.Size(160, 41);
            this.Balance_Total.TabIndex = 5;
            this.Balance_Total.Text = "0.00";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.total_Expense);
            this.panel3.Controls.Add(this.Expense_Total);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 76);
            this.panel3.TabIndex = 1;
            // 
            // total_Expense
            // 
            this.total_Expense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total_Expense.AutoSize = true;
            this.total_Expense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Expense.ForeColor = System.Drawing.Color.Gainsboro;
            this.total_Expense.Location = new System.Drawing.Point(149, 9);
            this.total_Expense.Name = "total_Expense";
            this.total_Expense.Size = new System.Drawing.Size(101, 32);
            this.total_Expense.TabIndex = 4;
            this.total_Expense.Text = "Expense";
            // 
            // Expense_Total
            // 
            this.Expense_Total.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Total.ForeColor = System.Drawing.Color.Gainsboro;
            this.Expense_Total.Location = new System.Drawing.Point(65, 34);
            this.Expense_Total.Name = "Expense_Total";
            this.Expense_Total.Size = new System.Drawing.Size(171, 41);
            this.Expense_Total.TabIndex = 5;
            this.Expense_Total.Text = "0.00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BudgetManagement.Properties.Resources.expenses;
            this.pictureBox3.Location = new System.Drawing.Point(3, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.total_Income);
            this.panel2.Controls.Add(this.Income_Total);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 76);
            this.panel2.TabIndex = 0;
            // 
            // total_Income
            // 
            this.total_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total_Income.AutoSize = true;
            this.total_Income.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Income.ForeColor = System.Drawing.Color.Gainsboro;
            this.total_Income.Location = new System.Drawing.Point(154, 9);
            this.total_Income.Name = "total_Income";
            this.total_Income.Size = new System.Drawing.Size(93, 32);
            this.total_Income.TabIndex = 2;
            this.total_Income.Text = "Income";
            // 
            // Income_Total
            // 
            this.Income_Total.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Total.ForeColor = System.Drawing.Color.Gainsboro;
            this.Income_Total.Location = new System.Drawing.Point(65, 34);
            this.Income_Total.Name = "Income_Total";
            this.Income_Total.Size = new System.Drawing.Size(176, 41);
            this.Income_Total.TabIndex = 3;
            this.Income_Total.Text = "0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BudgetManagement.Properties.Resources.salary;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // incType
            // 
            this.incType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.incType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incType.FormattingEnabled = true;
            this.incType.Items.AddRange(new object[] {
            "Hebdomadaire",
            "Mensuel",
            "Annuel"});
            this.incType.Location = new System.Drawing.Point(755, 35);
            this.incType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 20);
            this.incType.Name = "incType";
            this.incType.Size = new System.Drawing.Size(219, 27);
            this.incType.TabIndex = 37;
            this.incType.SelectedIndexChanged += new System.EventHandler(this.incType_SelectedIndexChanged);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(72, 32);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(79, 32);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 43;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 45);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 902);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private FontAwesome.Sharp.IconButton dashBtn;
        private FontAwesome.Sharp.IconButton incomeBtn;
        private FontAwesome.Sharp.IconButton expenseBtn;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Panel shadowPanel;
        private FontAwesome.Sharp.IconButton walletBtn;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label total_Income;
        private System.Windows.Forms.Label Income_Total;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Balance_Total;
        private System.Windows.Forms.Label total_Expense;
        private System.Windows.Forms.Label Expense_Total;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox incType;
    }
}

