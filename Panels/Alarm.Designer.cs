
namespace BudgetManagement.Panels
{
    partial class Alarm
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
            this.components = new System.ComponentModel.Container();
            this.totLogement = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.Label();
            this.inc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInc = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateExp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totLogement
            // 
            this.totLogement.BackColor = System.Drawing.Color.Transparent;
            this.totLogement.Dock = System.Windows.Forms.DockStyle.Top;
            this.totLogement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLogement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totLogement.Location = new System.Drawing.Point(0, 0);
            this.totLogement.Name = "totLogement";
            this.totLogement.Size = new System.Drawing.Size(1083, 75);
            this.totLogement.TabIndex = 12;
            this.totLogement.Text = "Alarme";
            this.totLogement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exp
            // 
            this.exp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exp.BackColor = System.Drawing.Color.Transparent;
            this.exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exp.Location = new System.Drawing.Point(28, 186);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(493, 153);
            this.exp.TabIndex = 13;
            this.exp.Text = "Vous avez pas inseré vos depenses aujourd\'hui";
            this.exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inc
            // 
            this.inc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inc.BackColor = System.Drawing.Color.Transparent;
            this.inc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inc.Location = new System.Drawing.Point(580, 186);
            this.inc.Name = "inc";
            this.inc.Size = new System.Drawing.Size(493, 153);
            this.inc.TabIndex = 14;
            this.inc.Text = "Vous avez pas inseré vos revenus aujourd\'hui";
            this.inc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-2, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1085, 118);
            this.label3.TabIndex = 15;
            this.label3.Text = "Derniere Insertion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateInc
            // 
            this.dateInc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateInc.BackColor = System.Drawing.Color.Transparent;
            this.dateInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateInc.Location = new System.Drawing.Point(568, 509);
            this.dateInc.Name = "dateInc";
            this.dateInc.Size = new System.Drawing.Size(493, 50);
            this.dateInc.TabIndex = 16;
            this.dateInc.Text = "12 / 2 / 2222";
            this.dateInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(296, 105);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(493, 50);
            this.time.TabIndex = 17;
            this.time.Text = "12 : 00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateExp
            // 
            this.dateExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateExp.BackColor = System.Drawing.Color.Transparent;
            this.dateExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateExp.Location = new System.Drawing.Point(28, 509);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(493, 50);
            this.dateExp.TabIndex = 18;
            this.dateExp.Text = "12 / 2 / 2222";
            this.dateExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1083, 598);
            this.ControlBox = false;
            this.Controls.Add(this.dateExp);
            this.Controls.Add(this.time);
            this.Controls.Add(this.dateInc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inc);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.totLogement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Alarm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totLogement;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Label inc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateInc;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateExp;
    }
}