namespace BudgetManagement.Panels
{
    partial class Expense
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
            this.expAdd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addExpense = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.expType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.expensesGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.expensesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logementPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.nourrituresPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.transportPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.abonementPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.loisirsPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.expDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Logement = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.expType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logementPanel)).BeginInit();
            this.logementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nourrituresPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonementPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loisirsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // expAdd
            // 
            this.expAdd.Location = new System.Drawing.Point(201, 22);
            this.expAdd.Name = "expAdd";
            this.expAdd.Size = new System.Drawing.Size(174, 27);
            this.expAdd.TabIndex = 0;
            this.expAdd.TextChanged += new System.EventHandler(this.expAdd_TextChanged);
            // 
            // addExpense
            // 
            this.addExpense.Location = new System.Drawing.Point(12, 25);
            this.addExpense.Name = "addExpense";
            this.addExpense.Size = new System.Drawing.Size(157, 24);
            this.addExpense.TabIndex = 1;
            this.addExpense.Values.Text = "Ajouter Une Depense";
            this.addExpense.Paint += new System.Windows.Forms.PaintEventHandler(this.addExpense_Paint);
            // 
            // expType
            // 
            this.expType.DropDownWidth = 174;
            this.expType.Location = new System.Drawing.Point(201, 55);
            this.expType.Name = "expType";
            this.expType.Size = new System.Drawing.Size(174, 25);
            this.expType.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(12, 55);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(131, 24);
            this.Type.TabIndex = 3;
            this.Type.Values.Text = "Type De Depense";
            // 
            // expensesGrid
            // 
            this.expensesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesGrid.Location = new System.Drawing.Point(12, 303);
            this.expensesGrid.Name = "expensesGrid";
            this.expensesGrid.RowHeadersWidth = 51;
            this.expensesGrid.RowTemplate.Height = 24;
            this.expensesGrid.Size = new System.Drawing.Size(500, 295);
            this.expensesGrid.TabIndex = 4;
            // 
            // expensesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.expensesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.expensesChart.Legends.Add(legend1);
            this.expensesChart.Location = new System.Drawing.Point(532, 303);
            this.expensesChart.Name = "expensesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.expensesChart.Series.Add(series1);
            this.expensesChart.Size = new System.Drawing.Size(508, 295);
            this.expensesChart.TabIndex = 5;
            this.expensesChart.Text = "chart1";
            // 
            // logementPanel
            // 
            this.logementPanel.Controls.Add(this.Logement);
            this.logementPanel.Location = new System.Drawing.Point(12, 160);
            this.logementPanel.Name = "logementPanel";
            this.logementPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.logementPanel.Size = new System.Drawing.Size(169, 127);
            this.logementPanel.TabIndex = 6;
            // 
            // nourrituresPanel
            // 
            this.nourrituresPanel.Location = new System.Drawing.Point(231, 160);
            this.nourrituresPanel.Name = "nourrituresPanel";
            this.nourrituresPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCalendar;
            this.nourrituresPanel.Size = new System.Drawing.Size(169, 127);
            this.nourrituresPanel.TabIndex = 7;
            // 
            // transportPanel
            // 
            this.transportPanel.Location = new System.Drawing.Point(449, 160);
            this.transportPanel.Name = "transportPanel";
            this.transportPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCalendar;
            this.transportPanel.Size = new System.Drawing.Size(169, 127);
            this.transportPanel.TabIndex = 8;
            // 
            // abonementPanel
            // 
            this.abonementPanel.Location = new System.Drawing.Point(658, 160);
            this.abonementPanel.Name = "abonementPanel";
            this.abonementPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCalendar;
            this.abonementPanel.Size = new System.Drawing.Size(169, 127);
            this.abonementPanel.TabIndex = 9;
            // 
            // loisirsPanel
            // 
            this.loisirsPanel.Location = new System.Drawing.Point(871, 160);
            this.loisirsPanel.Name = "loisirsPanel";
            this.loisirsPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCalendar;
            this.loisirsPanel.Size = new System.Drawing.Size(169, 127);
            this.loisirsPanel.TabIndex = 10;
            // 
            // expDate
            // 
            this.expDate.Location = new System.Drawing.Point(201, 86);
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(174, 25);
            this.expDate.TabIndex = 11;
            this.expDate.ValueChanged += new System.EventHandler(this.expDate_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 87);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(114, 24);
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "Date Depenses";
            // 
            // Logement
            // 
            this.Logement.BackColor = System.Drawing.Color.Transparent;
            this.Logement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logement.ForeColor = System.Drawing.Color.Transparent;
            this.Logement.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Logement.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logement.Location = new System.Drawing.Point(3, 3);
            this.Logement.Name = "Logement";
            this.Logement.Size = new System.Drawing.Size(45, 41);
            this.Logement.TabIndex = 0;
            this.Logement.UseVisualStyleBackColor = false;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 610);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.loisirsPanel);
            this.Controls.Add(this.abonementPanel);
            this.Controls.Add(this.transportPanel);
            this.Controls.Add(this.nourrituresPanel);
            this.Controls.Add(this.logementPanel);
            this.Controls.Add(this.expensesChart);
            this.Controls.Add(this.expensesGrid);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.expType);
            this.Controls.Add(this.addExpense);
            this.Controls.Add(this.expAdd);
            this.Name = "Expense";
            ((System.ComponentModel.ISupportInitialize)(this.expType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logementPanel)).EndInit();
            this.logementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nourrituresPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonementPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loisirsPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox expAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel addExpense;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox expType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Type;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView expensesGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart expensesChart;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel logementPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel nourrituresPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel transportPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel abonementPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel loisirsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker expDate;
        private FontAwesome.Sharp.IconButton Logement;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}