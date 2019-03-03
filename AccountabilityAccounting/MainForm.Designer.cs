namespace AccountabilityAccounting
{
    partial class MainForm
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
            this.tabPageAccountables = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewAccountables = new System.Windows.Forms.DataGridView();
            this.btnAccountablesRefresh = new System.Windows.Forms.Button();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMainTab = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccountables = new System.Windows.Forms.ComboBox();
            this.btnAcceptFilters = new System.Windows.Forms.Button();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSendToDB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteString = new System.Windows.Forms.Button();
            this.btnNewString = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMainTabGetData = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProjectsRefresh = new System.Windows.Forms.Button();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnItemsRefresh = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.tabPageAccountables.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountables)).BeginInit();
            this.tabPageMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTab)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageProjects.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.tabPageItems.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageAccountables
            // 
            this.tabPageAccountables.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAccountables.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccountables.Name = "tabPageAccountables";
            this.tabPageAccountables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccountables.Size = new System.Drawing.Size(1276, 701);
            this.tabPageAccountables.TabIndex = 1;
            this.tabPageAccountables.Text = "Подотчетники";
            this.tabPageAccountables.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewAccountables, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAccountablesRefresh, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1270, 695);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewAccountables
            // 
            this.dataGridViewAccountables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccountables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccountables.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewAccountables.Name = "dataGridViewAccountables";
            this.dataGridViewAccountables.Size = new System.Drawing.Size(1264, 655);
            this.dataGridViewAccountables.TabIndex = 0;
            // 
            // btnAccountablesRefresh
            // 
            this.btnAccountablesRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnAccountablesRefresh.Name = "btnAccountablesRefresh";
            this.btnAccountablesRefresh.Size = new System.Drawing.Size(131, 23);
            this.btnAccountablesRefresh.TabIndex = 1;
            this.btnAccountablesRefresh.Text = "Обновить";
            this.btnAccountablesRefresh.UseVisualStyleBackColor = true;
            this.btnAccountablesRefresh.Click += new System.EventHandler(this.btnAccountablesRefresh_Click);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.tableLayoutPanel1);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1276, 701);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главная";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMainTab, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewMainTab
            // 
            this.dataGridViewMainTab.AllowUserToAddRows = false;
            this.dataGridViewMainTab.AllowUserToDeleteRows = false;
            this.dataGridViewMainTab.AllowUserToOrderColumns = true;
            this.dataGridViewMainTab.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewMainTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMainTab.Location = new System.Drawing.Point(6, 75);
            this.dataGridViewMainTab.Name = "dataGridViewMainTab";
            this.dataGridViewMainTab.ReadOnly = true;
            this.dataGridViewMainTab.Size = new System.Drawing.Size(1258, 590);
            this.dataGridViewMainTab.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSum);
            this.panel1.Controls.Add(this.lbCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 674);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 15);
            this.panel1.TabIndex = 2;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(98, 2);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(0, 13);
            this.lbSum.TabIndex = 1;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(0, 2);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 13);
            this.lbCount.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 60);
            this.panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbAccountables);
            this.groupBox4.Controls.Add(this.btnAcceptFilters);
            this.groupBox4.Controls.Add(this.cmbItems);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbProjects);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(521, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 59);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(221, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Подотчетники";
            // 
            // cmbAccountables
            // 
            this.cmbAccountables.FormattingEnabled = true;
            this.cmbAccountables.Location = new System.Drawing.Point(318, 10);
            this.cmbAccountables.Name = "cmbAccountables";
            this.cmbAccountables.Size = new System.Drawing.Size(159, 23);
            this.cmbAccountables.TabIndex = 5;
            // 
            // btnAcceptFilters
            // 
            this.btnAcceptFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAcceptFilters.Location = new System.Drawing.Point(483, 11);
            this.btnAcceptFilters.Name = "btnAcceptFilters";
            this.btnAcceptFilters.Size = new System.Drawing.Size(73, 42);
            this.btnAcceptFilters.TabIndex = 4;
            this.btnAcceptFilters.Text = "Применить фильтры";
            this.btnAcceptFilters.UseVisualStyleBackColor = true;
            this.btnAcceptFilters.Click += new System.EventHandler(this.btnAcceptFilters_Click);
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(72, 34);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(130, 23);
            this.cmbItems.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Статья";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Проекты";
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(72, 11);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(130, 23);
            this.cmbProjects.TabIndex = 0;
            this.cmbProjects.Click += new System.EventHandler(this.filters_click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbSendToDB);
            this.groupBox3.Location = new System.Drawing.Point(1089, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tbSendToDB
            // 
            this.tbSendToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSendToDB.Location = new System.Drawing.Point(6, 11);
            this.tbSendToDB.Name = "tbSendToDB";
            this.tbSendToDB.Size = new System.Drawing.Size(145, 39);
            this.tbSendToDB.TabIndex = 0;
            this.tbSendToDB.Text = "Отправить изменения на сервер";
            this.tbSendToDB.UseVisualStyleBackColor = true;
            this.tbSendToDB.Click += new System.EventHandler(this.tbSendToDB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteString);
            this.groupBox2.Controls.Add(this.btnNewString);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(325, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Строки";
            // 
            // btnDeleteString
            // 
            this.btnDeleteString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteString.Location = new System.Drawing.Point(98, 14);
            this.btnDeleteString.Name = "btnDeleteString";
            this.btnDeleteString.Size = new System.Drawing.Size(84, 40);
            this.btnDeleteString.TabIndex = 1;
            this.btnDeleteString.Text = "Удалить строку";
            this.btnDeleteString.UseVisualStyleBackColor = true;
            // 
            // btnNewString
            // 
            this.btnNewString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewString.Location = new System.Drawing.Point(7, 13);
            this.btnNewString.Name = "btnNewString";
            this.btnNewString.Size = new System.Drawing.Size(84, 40);
            this.btnNewString.TabIndex = 0;
            this.btnNewString.Text = "Новая строка";
            this.btnNewString.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMainTabGetData);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период";
            // 
            // btnMainTabGetData
            // 
            this.btnMainTabGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainTabGetData.Location = new System.Drawing.Point(206, 13);
            this.btnMainTabGetData.Name = "btnMainTabGetData";
            this.btnMainTabGetData.Size = new System.Drawing.Size(93, 40);
            this.btnMainTabGetData.TabIndex = 4;
            this.btnMainTabGetData.Text = "Получить данные";
            this.btnMainTabGetData.UseVisualStyleBackColor = true;
            this.btnMainTabGetData.Click += new System.EventHandler(this.btnMainTabGetData_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.Location = new System.Drawing.Point(32, 34);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(168, 20);
            this.dtEnd.TabIndex = 3;
            // 
            // dtBegin
            // 
            this.dtBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBegin.Location = new System.Drawing.Point(32, 13);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(168, 20);
            this.dtBegin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "По";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "С";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageAccountables);
            this.tabControl1.Controls.Add(this.tabPageProjects);
            this.tabControl1.Controls.Add(this.tabPageItems);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Controls.Add(this.tableLayoutPanel3);
            this.tabPageProjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageProjects.Name = "tabPageProjects";
            this.tabPageProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProjects.Size = new System.Drawing.Size(1276, 701);
            this.tabPageProjects.TabIndex = 2;
            this.tabPageProjects.Text = "Проекты";
            this.tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnProjectsRefresh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewProjects, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1270, 695);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnProjectsRefresh
            // 
            this.btnProjectsRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnProjectsRefresh.Name = "btnProjectsRefresh";
            this.btnProjectsRefresh.Size = new System.Drawing.Size(147, 26);
            this.btnProjectsRefresh.TabIndex = 0;
            this.btnProjectsRefresh.Text = "Обновить";
            this.btnProjectsRefresh.UseVisualStyleBackColor = true;
            this.btnProjectsRefresh.Click += new System.EventHandler(this.btnProjectsRefresh_Click);
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjects.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(1264, 655);
            this.dataGridViewProjects.TabIndex = 1;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.tableLayoutPanel4);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(1276, 701);
            this.tabPageItems.TabIndex = 3;
            this.tabPageItems.Text = "Статьи";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnItemsRefresh, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewItems, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1270, 695);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnItemsRefresh
            // 
            this.btnItemsRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnItemsRefresh.Name = "btnItemsRefresh";
            this.btnItemsRefresh.Size = new System.Drawing.Size(147, 26);
            this.btnItemsRefresh.TabIndex = 1;
            this.btnItemsRefresh.Text = "Обновить";
            this.btnItemsRefresh.UseVisualStyleBackColor = true;
            this.btnItemsRefresh.Click += new System.EventHandler(this.btnItemsRefresh_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(1264, 655);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountabilityAccounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPageAccountables.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountables)).EndInit();
            this.tabPageMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTab)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProjects.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.tabPageItems.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAccountables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewAccountables;
        private System.Windows.Forms.Button btnAccountablesRefresh;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.DataGridView dataGridViewMainTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbAccountables;
        private System.Windows.Forms.Button btnAcceptFilters;
        internal System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tbSendToDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteString;
        private System.Windows.Forms.Button btnNewString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMainTabGetData;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnProjectsRefresh;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnItemsRefresh;
        private System.Windows.Forms.DataGridView dataGridViewItems;
    }
}