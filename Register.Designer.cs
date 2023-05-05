namespace BudgetManagement
{
    partial class Register
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
            this.username = new System.Windows.Forms.TextBox();
            this.validate = new System.Windows.Forms.Button();
            this.mdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.username.Location = new System.Drawing.Point(175, 254);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(240, 22);
            this.username.TabIndex = 54;
            // 
            // validate
            // 
            this.validate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.validate.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validate.Location = new System.Drawing.Point(175, 633);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(240, 46);
            this.validate.TabIndex = 53;
            this.validate.Text = "Register";
            this.validate.UseVisualStyleBackColor = false;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // mdp
            // 
            this.mdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mdp.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mdp.Location = new System.Drawing.Point(175, 330);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(240, 22);
            this.mdp.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(127, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mot De Passe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(127, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(347, 27);
            this.label12.TabIndex = 48;
            this.label12.Text = "Login";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BudgetManagement.Properties.Resources.Logo_UseCWwaT6_transformed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.phone.Location = new System.Drawing.Point(175, 414);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(240, 22);
            this.phone.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(127, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 27);
            this.label2.TabIndex = 56;
            this.label2.Text = "Numero Telephone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adresse
            // 
            this.adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adresse.ImeMode = System.Windows.Forms.ImeMode.On;
            this.adresse.Location = new System.Drawing.Point(175, 497);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(240, 22);
            this.adresse.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(127, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 27);
            this.label3.TabIndex = 58;
            this.label3.Text = "Adresse";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(127, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 27);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mot De Passe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(175, 582);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(240, 22);
            this.date.TabIndex = 61;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(591, 712);
            this.ControlBox = false;
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
    }
}