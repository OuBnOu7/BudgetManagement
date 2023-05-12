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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIncome_category = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IncomeLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeLine)).BeginInit();
            this.SuspendLayout();
            // 
            // chartExpense
            // 
            this.chartExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartExpense.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExpense.Legends.Add(legend1);
            this.chartExpense.Location = new System.Drawing.Point(16, 15);
            this.chartExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartExpense.Name = "chartExpense";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Expenses";
            this.chartExpense.Series.Add(series1);
            this.chartExpense.Size = new System.Drawing.Size(359, 369);
            this.chartExpense.TabIndex = 0;
            this.chartExpense.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Exepense Tracker";
            this.chartExpense.Titles.Add(title1);
            // 
            // chartIncome
            // 
            this.chartIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea2.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIncome.Legends.Add(legend2);
            this.chartIncome.Location = new System.Drawing.Point(16, 391);
            this.chartIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartIncome.Name = "chartIncome";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartIncome.Series.Add(series2);
            this.chartIncome.Size = new System.Drawing.Size(1339, 369);
            this.chartIncome.TabIndex = 1;
            this.chartIncome.Text = "chart1";
            // 
            // chartIncome_category
            // 
            this.chartIncome_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Name = "ChartArea1";
            this.chartIncome_category.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartIncome_category.Legends.Add(legend3);
            this.chartIncome_category.Location = new System.Drawing.Point(403, 15);
            this.chartIncome_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartIncome_category.Name = "chartIncome_category";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Expenses";
            this.chartIncome_category.Series.Add(series3);
            this.chartIncome_category.Size = new System.Drawing.Size(367, 369);
            this.chartIncome_category.TabIndex = 2;
            this.chartIncome_category.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Exepense Tracker";
            this.chartIncome_category.Titles.Add(title2);
            // 
            // IncomeLine
            // 
            this.IncomeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea4.Name = "ChartArea1";
            this.IncomeLine.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.IncomeLine.Legends.Add(legend4);
            this.IncomeLine.Location = new System.Drawing.Point(791, 15);
            this.IncomeLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IncomeLine.Name = "IncomeLine";
            series4.ChartArea = "ChartArea1";
            series4.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.IncomeLine.Series.Add(series4);
            this.IncomeLine.Size = new System.Drawing.Size(564, 369);
            this.IncomeLine.TabIndex = 3;
            this.IncomeLine.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1371, 772);
            this.ControlBox = false;
            this.Controls.Add(this.IncomeLine);
            this.Controls.Add(this.chartIncome_category);
            this.Controls.Add(this.chartIncome);
            this.Controls.Add(this.chartExpense);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.chartExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome_category;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeLine;
    }
}