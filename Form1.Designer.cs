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
            this.dashBtn = new FontAwesome.Sharp.IconButton();
            this.walletBtn = new FontAwesome.Sharp.IconButton();
            this.incomeBtn = new FontAwesome.Sharp.IconButton();
            this.expenseBtn = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelMenu.Controls.Add(this.logoutBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 830);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 140);
            this.panelLogo.TabIndex = 0;
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
            this.logoutBtn.Location = new System.Drawing.Point(3, 767);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 380, 3, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutBtn.Size = new System.Drawing.Size(197, 50);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1585, 100);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.desktopPanel);
            this.panelDesktop.Controls.Add(this.shadowPanel);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1585, 730);
            this.panelDesktop.TabIndex = 3;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 9);
            this.desktopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(1585, 721);
            this.desktopPanel.TabIndex = 1;
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(1585, 9);
            this.shadowPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BudgetManagement.Properties.Resources.Logo_UseCWwaT6_transformed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 830);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private FontAwesome.Sharp.IconButton dashBtn;
        private FontAwesome.Sharp.IconButton walletBtn;
        private FontAwesome.Sharp.IconButton incomeBtn;
        private FontAwesome.Sharp.IconButton expenseBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Panel shadowPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

