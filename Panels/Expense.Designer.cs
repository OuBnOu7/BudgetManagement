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
            this.components = new System.ComponentModel.Container();
            this.expName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.expDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.expDes = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.expAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.database1DataSet1 = new BudgetManagement.Database1DataSet1();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTableAdapter = new BudgetManagement.Database1DataSet1TableAdapters.expenseTableAdapter();
            this.expenseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new BudgetManagement.Database1DataSet2();
            this.expenseTableAdapter1 = new BudgetManagement.Database1DataSet2TableAdapters.expenseTableAdapter();
            this.expAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.expType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logementPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pouLogement = new System.Windows.Forms.Label();
            this.totLogement = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.totTransport = new System.Windows.Forms.Label();
            this.pouTransport = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.transportPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.totLoisirs = new System.Windows.Forms.Label();
            this.pouLoisirs = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.loisirsPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.totNourriture = new System.Windows.Forms.Label();
            this.pouNourriture = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nourrituresPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.bilLogement = new System.Windows.Forms.Label();
            this.bilNourriture = new System.Windows.Forms.Label();
            this.bilTransport = new System.Windows.Forms.Label();
            this.bilAbonement = new System.Windows.Forms.Label();
            this.bilLoisirs = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.totAbonement = new System.Windows.Forms.Label();
            this.pouAbonement = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelwsf = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.download = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logementPanel)).BeginInit();
            this.logementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportPanel)).BeginInit();
            this.transportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loisirsPanel)).BeginInit();
            this.loisirsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nourrituresPanel)).BeginInit();
            this.nourrituresPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelwsf)).BeginInit();
            this.panelwsf.SuspendLayout();
            this.SuspendLayout();
            // 
            // expName
            // 
            this.expName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expName.Location = new System.Drawing.Point(173, 59);
            this.expName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expName.Name = "expName";
            this.expName.Size = new System.Drawing.Size(213, 27);
            this.expName.TabIndex = 0;
            // 
            // expDate
            // 
            this.expDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expDate.CalendarTodayDate = new System.DateTime(2023, 5, 2, 0, 0, 0, 0);
            this.expDate.Location = new System.Drawing.Point(173, 143);
            this.expDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expDate.Name = "expDate";
            this.expDate.ShowUpDown = true;
            this.expDate.Size = new System.Drawing.Size(213, 25);
            this.expDate.TabIndex = 11;
            // 
            // expDes
            // 
            this.expDes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expDes.Location = new System.Drawing.Point(405, 47);
            this.expDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expDes.Name = "expDes";
            this.expDes.Size = new System.Drawing.Size(277, 58);
            this.expDes.TabIndex = 13;
            this.expDes.Text = "";
            // 
            // expAmount
            // 
            this.expAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expAmount.Location = new System.Drawing.Point(173, 16);
            this.expAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expAmount.Name = "expAmount";
            this.expAmount.Size = new System.Drawing.Size(213, 27);
            this.expAmount.TabIndex = 15;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";
            this.expenseBindingSource.DataSource = this.database1DataSet1;
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // expenseBindingSource1
            // 
            this.expenseBindingSource1.DataMember = "expense";
            this.expenseBindingSource1.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTableAdapter1
            // 
            this.expenseTableAdapter1.ClearBeforeFill = true;
            // 
            // expAdd
            // 
            this.expAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expAdd.Location = new System.Drawing.Point(405, 125);
            this.expAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expAdd.Name = "expAdd";
            this.expAdd.Size = new System.Drawing.Size(277, 43);
            this.expAdd.TabIndex = 18;
            this.expAdd.Values.Text = "Ajouter Depenses";
            this.expAdd.Click += new System.EventHandler(this.expAdd_Click);
            // 
            // expType
            // 
            this.expType.AllowDrop = true;
            this.expType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.expType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expType.FormattingEnabled = true;
            this.expType.Items.AddRange(new object[] {
            "Logement",
            "Nourriture",
            "Transport",
            "Abonement",
            "Loisirs"});
            this.expType.Location = new System.Drawing.Point(173, 101);
            this.expType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expType.Name = "expType";
            this.expType.Size = new System.Drawing.Size(215, 24);
            this.expType.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(113, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logementPanel
            // 
            this.logementPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logementPanel.Controls.Add(this.label9);
            this.logementPanel.Controls.Add(this.label8);
            this.logementPanel.Controls.Add(this.pouLogement);
            this.logementPanel.Controls.Add(this.totLogement);
            this.logementPanel.Controls.Add(this.iconButton5);
            this.logementPanel.Controls.Add(this.label1);
            this.logementPanel.Location = new System.Drawing.Point(39, 187);
            this.logementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logementPanel.Name = "logementPanel";
            this.logementPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuOuter;
            this.logementPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logementPanel.Size = new System.Drawing.Size(431, 261);
            this.logementPanel.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 41);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 41);
            this.label8.TabIndex = 13;
            this.label8.Text = "MAD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pouLogement
            // 
            this.pouLogement.BackColor = System.Drawing.Color.Transparent;
            this.pouLogement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pouLogement.Location = new System.Drawing.Point(219, 97);
            this.pouLogement.Name = "pouLogement";
            this.pouLogement.Size = new System.Drawing.Size(211, 41);
            this.pouLogement.TabIndex = 12;
            this.pouLogement.Text = "0";
            this.pouLogement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totLogement
            // 
            this.totLogement.BackColor = System.Drawing.Color.Transparent;
            this.totLogement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLogement.Location = new System.Drawing.Point(3, 97);
            this.totLogement.Name = "totLogement";
            this.totLogement.Size = new System.Drawing.Size(211, 41);
            this.totLogement.TabIndex = 11;
            this.totLogement.Text = "0";
            this.totLogement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton5.IconColor = System.Drawing.Color.Red;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(40, 18);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(88, 63);
            this.iconButton5.TabIndex = 10;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(757, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 167);
            this.dataGridView1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(39, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Montant";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(39, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nom";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(39, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 27);
            this.label12.TabIndex = 22;
            this.label12.Text = "Type";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(39, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 27);
            this.label13.TabIndex = 23;
            this.label13.Text = "Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(403, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 27);
            this.label16.TabIndex = 24;
            this.label16.Text = "Description";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totTransport
            // 
            this.totTransport.BackColor = System.Drawing.Color.Transparent;
            this.totTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totTransport.Location = new System.Drawing.Point(3, 97);
            this.totTransport.Name = "totTransport";
            this.totTransport.Size = new System.Drawing.Size(211, 41);
            this.totTransport.TabIndex = 15;
            this.totTransport.Text = "0";
            this.totTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pouTransport
            // 
            this.pouTransport.BackColor = System.Drawing.Color.Transparent;
            this.pouTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pouTransport.Location = new System.Drawing.Point(219, 97);
            this.pouTransport.Name = "pouTransport";
            this.pouTransport.Size = new System.Drawing.Size(211, 41);
            this.pouTransport.TabIndex = 16;
            this.pouTransport.Text = "0";
            this.pouTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconButton3.IconColor = System.Drawing.Color.Yellow;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(40, 18);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(88, 63);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 41);
            this.label11.TabIndex = 17;
            this.label11.Text = "MAD";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(113, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transport";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 41);
            this.label10.TabIndex = 18;
            this.label10.Text = "%";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transportPanel
            // 
            this.transportPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transportPanel.Controls.Add(this.label10);
            this.transportPanel.Controls.Add(this.label3);
            this.transportPanel.Controls.Add(this.label11);
            this.transportPanel.Controls.Add(this.iconButton3);
            this.transportPanel.Controls.Add(this.pouTransport);
            this.transportPanel.Controls.Add(this.totTransport);
            this.transportPanel.Location = new System.Drawing.Point(533, 187);
            this.transportPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transportPanel.Name = "transportPanel";
            this.transportPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuOuter;
            this.transportPanel.Size = new System.Drawing.Size(431, 261);
            this.transportPanel.TabIndex = 8;
            // 
            // totLoisirs
            // 
            this.totLoisirs.BackColor = System.Drawing.Color.Transparent;
            this.totLoisirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLoisirs.Location = new System.Drawing.Point(3, 98);
            this.totLoisirs.Name = "totLoisirs";
            this.totLoisirs.Size = new System.Drawing.Size(211, 41);
            this.totLoisirs.TabIndex = 27;
            this.totLoisirs.Text = "0";
            this.totLoisirs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pouLoisirs
            // 
            this.pouLoisirs.BackColor = System.Drawing.Color.Transparent;
            this.pouLoisirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pouLoisirs.Location = new System.Drawing.Point(219, 98);
            this.pouLoisirs.Name = "pouLoisirs";
            this.pouLoisirs.Size = new System.Drawing.Size(211, 41);
            this.pouLoisirs.TabIndex = 28;
            this.pouLoisirs.Text = "0";
            this.pouLoisirs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(40, 18);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(88, 63);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 181);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(211, 41);
            this.label23.TabIndex = 29;
            this.label23.Text = "MAD";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(113, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loisirs";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(219, 181);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(211, 41);
            this.label22.TabIndex = 30;
            this.label22.Text = "%";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loisirsPanel
            // 
            this.loisirsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loisirsPanel.Controls.Add(this.label22);
            this.loisirsPanel.Controls.Add(this.label5);
            this.loisirsPanel.Controls.Add(this.label23);
            this.loisirsPanel.Controls.Add(this.iconButton4);
            this.loisirsPanel.Controls.Add(this.pouLoisirs);
            this.loisirsPanel.Controls.Add(this.totLoisirs);
            this.loisirsPanel.Location = new System.Drawing.Point(533, 464);
            this.loisirsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loisirsPanel.Name = "loisirsPanel";
            this.loisirsPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuOuter;
            this.loisirsPanel.Size = new System.Drawing.Size(431, 261);
            this.loisirsPanel.TabIndex = 10;
            // 
            // totNourriture
            // 
            this.totNourriture.BackColor = System.Drawing.Color.Transparent;
            this.totNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totNourriture.Location = new System.Drawing.Point(-3, 98);
            this.totNourriture.Name = "totNourriture";
            this.totNourriture.Size = new System.Drawing.Size(211, 41);
            this.totNourriture.TabIndex = 23;
            this.totNourriture.Text = "0";
            this.totNourriture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pouNourriture
            // 
            this.pouNourriture.BackColor = System.Drawing.Color.Transparent;
            this.pouNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pouNourriture.Location = new System.Drawing.Point(213, 98);
            this.pouNourriture.Name = "pouNourriture";
            this.pouNourriture.Size = new System.Drawing.Size(211, 41);
            this.pouNourriture.TabIndex = 24;
            this.pouNourriture.Text = "0";
            this.pouNourriture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BowlRice;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(40, 18);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(88, 63);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(-5, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(211, 41);
            this.label19.TabIndex = 25;
            this.label19.Text = "MAD";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nourriture";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(213, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(211, 41);
            this.label18.TabIndex = 26;
            this.label18.Text = "%";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nourrituresPanel
            // 
            this.nourrituresPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nourrituresPanel.Controls.Add(this.label18);
            this.nourrituresPanel.Controls.Add(this.label2);
            this.nourrituresPanel.Controls.Add(this.label19);
            this.nourrituresPanel.Controls.Add(this.iconButton1);
            this.nourrituresPanel.Controls.Add(this.pouNourriture);
            this.nourrituresPanel.Controls.Add(this.totNourriture);
            this.nourrituresPanel.Location = new System.Drawing.Point(39, 464);
            this.nourrituresPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nourrituresPanel.Name = "nourrituresPanel";
            this.nourrituresPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuOuter;
            this.nourrituresPanel.Size = new System.Drawing.Size(431, 261);
            this.nourrituresPanel.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(5, 78);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(211, 41);
            this.label25.TabIndex = 19;
            this.label25.Text = "Situation";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Lime;
            this.label24.Location = new System.Drawing.Point(219, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(211, 41);
            this.label24.TabIndex = 20;
            this.label24.Text = "Good";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Transparent;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ScaleUnbalanced;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(40, 18);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(88, 63);
            this.iconButton6.TabIndex = 2;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(211, 25);
            this.label21.TabIndex = 21;
            this.label21.Text = "Logement";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(113, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 41);
            this.label20.TabIndex = 5;
            this.label20.Text = "Bilan";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(211, 25);
            this.label17.TabIndex = 22;
            this.label17.Text = "Transport";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 171);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(211, 25);
            this.label26.TabIndex = 23;
            this.label26.Text = "Abonement";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(4, 196);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(211, 25);
            this.label27.TabIndex = 24;
            this.label27.Text = "Nourriture";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(4, 222);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(211, 25);
            this.label28.TabIndex = 25;
            this.label28.Text = "Loisirs";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilLogement
            // 
            this.bilLogement.BackColor = System.Drawing.Color.Transparent;
            this.bilLogement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilLogement.ForeColor = System.Drawing.Color.Lime;
            this.bilLogement.Location = new System.Drawing.Point(251, 121);
            this.bilLogement.Name = "bilLogement";
            this.bilLogement.Size = new System.Drawing.Size(144, 25);
            this.bilLogement.TabIndex = 26;
            this.bilLogement.Text = "<50%";
            this.bilLogement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilNourriture
            // 
            this.bilNourriture.BackColor = System.Drawing.Color.Transparent;
            this.bilNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilNourriture.ForeColor = System.Drawing.Color.Lime;
            this.bilNourriture.Location = new System.Drawing.Point(251, 197);
            this.bilNourriture.Name = "bilNourriture";
            this.bilNourriture.Size = new System.Drawing.Size(144, 25);
            this.bilNourriture.TabIndex = 27;
            this.bilNourriture.Text = "<15%";
            this.bilNourriture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilTransport
            // 
            this.bilTransport.BackColor = System.Drawing.Color.Transparent;
            this.bilTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilTransport.ForeColor = System.Drawing.Color.Lime;
            this.bilTransport.Location = new System.Drawing.Point(251, 146);
            this.bilTransport.Name = "bilTransport";
            this.bilTransport.Size = new System.Drawing.Size(144, 25);
            this.bilTransport.TabIndex = 27;
            this.bilTransport.Text = "<10%";
            this.bilTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilAbonement
            // 
            this.bilAbonement.BackColor = System.Drawing.Color.Transparent;
            this.bilAbonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilAbonement.ForeColor = System.Drawing.Color.Lime;
            this.bilAbonement.Location = new System.Drawing.Point(251, 171);
            this.bilAbonement.Name = "bilAbonement";
            this.bilAbonement.Size = new System.Drawing.Size(144, 25);
            this.bilAbonement.TabIndex = 28;
            this.bilAbonement.Text = "<10%";
            this.bilAbonement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bilLoisirs
            // 
            this.bilLoisirs.BackColor = System.Drawing.Color.Transparent;
            this.bilLoisirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilLoisirs.ForeColor = System.Drawing.Color.Lime;
            this.bilLoisirs.Location = new System.Drawing.Point(251, 222);
            this.bilLoisirs.Name = "bilLoisirs";
            this.bilLoisirs.Size = new System.Drawing.Size(144, 25);
            this.bilLoisirs.TabIndex = 29;
            this.bilLoisirs.Text = "<5%";
            this.bilLoisirs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonPanel1.Controls.Add(this.bilLoisirs);
            this.kryptonPanel1.Controls.Add(this.bilAbonement);
            this.kryptonPanel1.Controls.Add(this.bilTransport);
            this.kryptonPanel1.Controls.Add(this.bilNourriture);
            this.kryptonPanel1.Controls.Add(this.bilLogement);
            this.kryptonPanel1.Controls.Add(this.label28);
            this.kryptonPanel1.Controls.Add(this.label27);
            this.kryptonPanel1.Controls.Add(this.label26);
            this.kryptonPanel1.Controls.Add(this.label17);
            this.kryptonPanel1.Controls.Add(this.label20);
            this.kryptonPanel1.Controls.Add(this.label21);
            this.kryptonPanel1.Controls.Add(this.iconButton6);
            this.kryptonPanel1.Controls.Add(this.label24);
            this.kryptonPanel1.Controls.Add(this.label25);
            this.kryptonPanel1.Location = new System.Drawing.Point(1020, 464);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuOuter;
            this.kryptonPanel1.Size = new System.Drawing.Size(431, 261);
            this.kryptonPanel1.TabIndex = 23;
            // 
            // totAbonement
            // 
            this.totAbonement.BackColor = System.Drawing.Color.Transparent;
            this.totAbonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totAbonement.Location = new System.Drawing.Point(5, 97);
            this.totAbonement.Name = "totAbonement";
            this.totAbonement.Size = new System.Drawing.Size(211, 41);
            this.totAbonement.TabIndex = 19;
            this.totAbonement.Text = "0";
            this.totAbonement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pouAbonement
            // 
            this.pouAbonement.BackColor = System.Drawing.Color.Transparent;
            this.pouAbonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pouAbonement.Location = new System.Drawing.Point(221, 97);
            this.pouAbonement.Name = "pouAbonement";
            this.pouAbonement.Size = new System.Drawing.Size(211, 41);
            this.pouAbonement.TabIndex = 20;
            this.pouAbonement.Text = "0";
            this.pouAbonement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(40, 18);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(88, 63);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 41);
            this.label15.TabIndex = 21;
            this.label15.Text = "MAD";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(113, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "Abonement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(221, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 41);
            this.label14.TabIndex = 22;
            this.label14.Text = "%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelwsf
            // 
            this.panelwsf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelwsf.Controls.Add(this.label14);
            this.panelwsf.Controls.Add(this.label4);
            this.panelwsf.Controls.Add(this.label15);
            this.panelwsf.Controls.Add(this.iconButton2);
            this.panelwsf.Controls.Add(this.pouAbonement);
            this.panelwsf.Controls.Add(this.totAbonement);
            this.panelwsf.Location = new System.Drawing.Point(1020, 187);
            this.panelwsf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelwsf.Name = "panelwsf";
            this.panelwsf.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuOuter;
            this.panelwsf.Size = new System.Drawing.Size(431, 261);
            this.panelwsf.TabIndex = 9;
            // 
            // download
            // 
            this.download.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.download.BackColor = System.Drawing.Color.Transparent;
            this.download.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.download.IconColor = System.Drawing.Color.Black;
            this.download.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.download.Location = new System.Drawing.Point(699, 125);
            this.download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(49, 43);
            this.download.TabIndex = 25;
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1503, 736);
            this.ControlBox = false;
            this.Controls.Add(this.download);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loisirsPanel);
            this.Controls.Add(this.panelwsf);
            this.Controls.Add(this.expType);
            this.Controls.Add(this.expAdd);
            this.Controls.Add(this.expAmount);
            this.Controls.Add(this.expDes);
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.transportPanel);
            this.Controls.Add(this.nourrituresPanel);
            this.Controls.Add(this.logementPanel);
            this.Controls.Add(this.expName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logementPanel)).EndInit();
            this.logementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportPanel)).EndInit();
            this.transportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loisirsPanel)).EndInit();
            this.loisirsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nourrituresPanel)).EndInit();
            this.nourrituresPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelwsf)).EndInit();
            this.panelwsf.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox expName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker expDate;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox expDes;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox expAmount;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private Database1DataSet1TableAdapters.expenseTableAdapter expenseTableAdapter;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource expenseBindingSource1;
        private Database1DataSet2TableAdapters.expenseTableAdapter expenseTableAdapter1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton expAdd;
        private System.Windows.Forms.ComboBox expType;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel logementPanel;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label totLogement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label pouLogement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label totTransport;
        private System.Windows.Forms.Label pouTransport;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel transportPanel;
        private System.Windows.Forms.Label totLoisirs;
        private System.Windows.Forms.Label pouLoisirs;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel loisirsPanel;
        private System.Windows.Forms.Label totNourriture;
        private System.Windows.Forms.Label pouNourriture;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel nourrituresPanel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label bilLogement;
        private System.Windows.Forms.Label bilNourriture;
        private System.Windows.Forms.Label bilTransport;
        private System.Windows.Forms.Label bilAbonement;
        private System.Windows.Forms.Label bilLoisirs;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label totAbonement;
        private System.Windows.Forms.Label pouAbonement;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelwsf;
        private FontAwesome.Sharp.IconButton download;
    }
}