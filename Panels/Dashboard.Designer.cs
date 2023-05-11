namespace BudgetManagement.Panels
{
    partial class Dashboard
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
            this.bunifuRadialGauge1 = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.SuspendLayout();
            // 
            // bunifuRadialGauge1
            // 
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.bunifuRadialGauge1.LighteningFactor = 70;
            this.bunifuRadialGauge1.Location = new System.Drawing.Point(16, 16);
            this.bunifuRadialGauge1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuRadialGauge1.Maximum = 100;
            this.bunifuRadialGauge1.Minimum = 0;
            this.bunifuRadialGauge1.Name = "bunifuRadialGauge1";
            this.bunifuRadialGauge1.Prefix = "";
            this.bunifuRadialGauge1.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressHighValueMark = 70;
            this.bunifuRadialGauge1.RangeEnd = 100;
            this.bunifuRadialGauge1.RangeLabelsColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge1.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuRadialGauge1.RangeStart = 0;
            this.bunifuRadialGauge1.ShowRangeLabels = true;
            this.bunifuRadialGauge1.ShowValueLabel = true;
            this.bunifuRadialGauge1.Size = new System.Drawing.Size(361, 289);
            this.bunifuRadialGauge1.Suffix = "%";
            this.bunifuRadialGauge1.TabIndex = 0;
            this.bunifuRadialGauge1.Thickness = 30;
            this.bunifuRadialGauge1.Value = 40;
            this.bunifuRadialGauge1.ValueByTransition = 40;
            this.bunifuRadialGauge1.ValueLabelColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge1.WarningMark = 70;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1503, 736);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuRadialGauge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge1;
    }
}