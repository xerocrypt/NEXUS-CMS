namespace NEXUS_Informatix
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.cmdAddBug = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdInventory = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdTestScripts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdStoredAccounts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBugReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdTasks = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdLoadAll = new System.Windows.Forms.Button();
            this.cmdConnection = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipAbout = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipNewRecord = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipConnection = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipTaskQueue = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipTestAccounts = new System.Windows.Forms.ToolTip(this.components);
            this.MebuStrrip = new System.Windows.Forms.MenuStrip();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdAddSystem = new System.Windows.Forms.Button();
            this.grpActions.SuspendLayout();
            this.MebuStrrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grpActions
            // 
            this.grpActions.AutoSize = true;
            this.grpActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpActions.Controls.Add(this.cmdAddSystem);
            this.grpActions.Controls.Add(this.button1);
            this.grpActions.Controls.Add(this.cmdAddBug);
            this.grpActions.Controls.Add(this.cmdLoad);
            this.grpActions.Controls.Add(this.label10);
            this.grpActions.Controls.Add(this.cmdInventory);
            this.grpActions.Controls.Add(this.label9);
            this.grpActions.Controls.Add(this.cmdTestScripts);
            this.grpActions.Controls.Add(this.label3);
            this.grpActions.Controls.Add(this.cmdStoredAccounts);
            this.grpActions.Controls.Add(this.label2);
            this.grpActions.Controls.Add(this.cmdBugReport);
            this.grpActions.Controls.Add(this.label1);
            this.grpActions.Controls.Add(this.cmdTasks);
            this.grpActions.Controls.Add(this.label8);
            this.grpActions.Controls.Add(this.label7);
            this.grpActions.Controls.Add(this.label6);
            this.grpActions.Controls.Add(this.cmdLoadAll);
            this.grpActions.Controls.Add(this.cmdConnection);
            this.grpActions.Controls.Add(this.cmdAbout);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(0, 24);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(916, 124);
            this.grpActions.TabIndex = 8;
            this.grpActions.TabStop = false;
            this.grpActions.Enter += new System.EventHandler(this.grpActions_Enter);
            // 
            // cmdAddBug
            // 
            this.cmdAddBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddBug.Location = new System.Drawing.Point(657, 79);
            this.cmdAddBug.Name = "cmdAddBug";
            this.cmdAddBug.Size = new System.Drawing.Size(108, 25);
            this.cmdAddBug.TabIndex = 19;
            this.cmdAddBug.Text = "Report Bug";
            this.cmdAddBug.UseVisualStyleBackColor = true;
            this.cmdAddBug.Click += new System.EventHandler(this.cmdAddBug_Click);
            // 
            // cmdLoad
            // 
            this.cmdLoad.BackColor = System.Drawing.Color.Orange;
            this.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.Location = new System.Drawing.Point(553, 20);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(87, 49);
            this.cmdLoad.TabIndex = 18;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = false;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Systems\r\nInventory";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdInventory
            // 
            this.cmdInventory.BackColor = System.Drawing.Color.Transparent;
            this.cmdInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdInventory.BackgroundImage")));
            this.cmdInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInventory.Location = new System.Drawing.Point(417, 19);
            this.cmdInventory.Name = "cmdInventory";
            this.cmdInventory.Size = new System.Drawing.Size(47, 49);
            this.cmdInventory.TabIndex = 16;
            this.cmdInventory.UseVisualStyleBackColor = false;
            this.cmdInventory.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Test\r\nScripts";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdTestScripts
            // 
            this.cmdTestScripts.BackColor = System.Drawing.Color.Transparent;
            this.cmdTestScripts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdTestScripts.BackgroundImage")));
            this.cmdTestScripts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdTestScripts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTestScripts.Location = new System.Drawing.Point(281, 20);
            this.cmdTestScripts.Name = "cmdTestScripts";
            this.cmdTestScripts.Size = new System.Drawing.Size(47, 49);
            this.cmdTestScripts.TabIndex = 14;
            this.tooltipTestAccounts.SetToolTip(this.cmdTestScripts, "Access stored account\r\nlogin details");
            this.cmdTestScripts.UseVisualStyleBackColor = false;
            this.cmdTestScripts.Click += new System.EventHandler(this.cmdTestScripts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Test\r\nAccounts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdStoredAccounts
            // 
            this.cmdStoredAccounts.BackColor = System.Drawing.Color.Transparent;
            this.cmdStoredAccounts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdStoredAccounts.BackgroundImage")));
            this.cmdStoredAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdStoredAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStoredAccounts.Location = new System.Drawing.Point(215, 20);
            this.cmdStoredAccounts.Name = "cmdStoredAccounts";
            this.cmdStoredAccounts.Size = new System.Drawing.Size(47, 49);
            this.cmdStoredAccounts.TabIndex = 12;
            this.tooltipTestAccounts.SetToolTip(this.cmdStoredAccounts, "Access stored account\r\nlogin details");
            this.cmdStoredAccounts.UseVisualStyleBackColor = false;
            this.cmdStoredAccounts.Click += new System.EventHandler(this.cmdStoredAccounts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bug\r\nReporting";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdBugReport
            // 
            this.cmdBugReport.BackColor = System.Drawing.Color.Transparent;
            this.cmdBugReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBugReport.BackgroundImage")));
            this.cmdBugReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBugReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBugReport.Location = new System.Drawing.Point(348, 20);
            this.cmdBugReport.Name = "cmdBugReport";
            this.cmdBugReport.Size = new System.Drawing.Size(47, 49);
            this.cmdBugReport.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmdBugReport, "View and file bug reports");
            this.cmdBugReport.UseVisualStyleBackColor = false;
            this.cmdBugReport.Click += new System.EventHandler(this.cmdBugReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Task\r\nQueue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdTasks
            // 
            this.cmdTasks.BackColor = System.Drawing.Color.Transparent;
            this.cmdTasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdTasks.BackgroundImage")));
            this.cmdTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTasks.Location = new System.Drawing.Point(148, 20);
            this.cmdTasks.Name = "cmdTasks";
            this.cmdTasks.Size = new System.Drawing.Size(47, 49);
            this.cmdTasks.TabIndex = 9;
            this.tooltipTaskQueue.SetToolTip(this.cmdTasks, "View and add tasks");
            this.cmdTasks.UseVisualStyleBackColor = false;
            this.cmdTasks.Click += new System.EventHandler(this.cmdTasks_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(488, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "About";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tests";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Connection";
            // 
            // cmdLoadAll
            // 
            this.cmdLoadAll.BackColor = System.Drawing.Color.Transparent;
            this.cmdLoadAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdLoadAll.BackgroundImage")));
            this.cmdLoadAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoadAll.Location = new System.Drawing.Point(85, 20);
            this.cmdLoadAll.Name = "cmdLoadAll";
            this.cmdLoadAll.Size = new System.Drawing.Size(47, 49);
            this.cmdLoadAll.TabIndex = 3;
            this.toolTip2.SetToolTip(this.cmdLoadAll, "View records");
            this.cmdLoadAll.UseVisualStyleBackColor = false;
            this.cmdLoadAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdConnection
            // 
            this.cmdConnection.BackColor = System.Drawing.Color.Transparent;
            this.cmdConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdConnection.BackgroundImage")));
            this.cmdConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnection.Location = new System.Drawing.Point(18, 20);
            this.cmdConnection.Name = "cmdConnection";
            this.cmdConnection.Size = new System.Drawing.Size(47, 49);
            this.cmdConnection.TabIndex = 2;
            this.tooltipConnection.SetToolTip(this.cmdConnection, "Configure connection and \r\nauthentication settings");
            this.cmdConnection.UseVisualStyleBackColor = false;
            this.cmdConnection.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.BackColor = System.Drawing.Color.Transparent;
            this.cmdAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAbout.BackgroundImage")));
            this.cmdAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbout.Location = new System.Drawing.Point(482, 20);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(47, 49);
            this.cmdAbout.TabIndex = 1;
            this.cmdAbout.UseVisualStyleBackColor = false;
            this.cmdAbout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tooltipAbout
            // 
            this.tooltipAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // tooltipNewRecord
            // 
            this.tooltipNewRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // tooltipConnection
            // 
            this.tooltipConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // tooltipTestAccounts
            // 
            this.tooltipTestAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // MebuStrrip
            // 
            this.MebuStrrip.BackColor = System.Drawing.Color.Orange;
            this.MebuStrrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSettingsToolStripMenuItem});
            this.MebuStrrip.Location = new System.Drawing.Point(0, 0);
            this.MebuStrrip.Name = "MebuStrrip";
            this.MebuStrrip.Size = new System.Drawing.Size(916, 24);
            this.MebuStrrip.TabIndex = 9;
            this.MebuStrrip.Text = "menuStrip2";
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSettingsToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.connectionSettingsToolStripMenuItem.Text = "Application";
            this.connectionSettingsToolStripMenuItem.Click += new System.EventHandler(this.connectionSettingsToolStripMenuItem_Click);
            // 
            // connectionSettingsToolStripMenuItem1
            // 
            this.connectionSettingsToolStripMenuItem1.BackColor = System.Drawing.Color.Orange;
            this.connectionSettingsToolStripMenuItem1.Name = "connectionSettingsToolStripMenuItem1";
            this.connectionSettingsToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.connectionSettingsToolStripMenuItem1.Text = "Connection Settings";
            this.connectionSettingsToolStripMenuItem1.Click += new System.EventHandler(this.connectionSettingsToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 148);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Size = new System.Drawing.Size(916, 383);
            this.dataGrid.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStatus.Location = new System.Drawing.Point(0, 146);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(657, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Report Bug";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdAddSystem
            // 
            this.cmdAddSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddSystem.Location = new System.Drawing.Point(657, 49);
            this.cmdAddSystem.Name = "cmdAddSystem";
            this.cmdAddSystem.Size = new System.Drawing.Size(108, 24);
            this.cmdAddSystem.TabIndex = 21;
            this.cmdAddSystem.Text = "Add System";
            this.cmdAddSystem.UseVisualStyleBackColor = true;
            this.cmdAddSystem.Click += new System.EventHandler(this.cmdAddSystem_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(916, 531);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.MebuStrrip);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEXUS Informatix 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.MebuStrrip.ResumeLayout(false);
            this.MebuStrrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdLoadAll;
        private System.Windows.Forms.Button cmdConnection;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBugReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdStoredAccounts;
        private System.Windows.Forms.ToolTip tooltipTestAccounts;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip tooltipTaskQueue;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip tooltipConnection;
        private System.Windows.Forms.ToolTip tooltipNewRecord;
        private System.Windows.Forms.ToolTip tooltipAbout;
        private System.Windows.Forms.MenuStrip MebuStrrip;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdTestScripts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdInventory;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdAddBug;
        private System.Windows.Forms.Button cmdAddSystem;
        private System.Windows.Forms.Button button1;
    }
}

