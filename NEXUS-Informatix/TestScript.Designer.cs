namespace NEXUS_Informatix
{
    partial class frmTestScript
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddAction = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.cmdAddStep = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.cmdListScripts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Script Manager";
            // 
            // cmdAddAction
            // 
            this.cmdAddAction.BackColor = System.Drawing.Color.Orange;
            this.cmdAddAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddAction.Location = new System.Drawing.Point(756, 71);
            this.cmdAddAction.Name = "cmdAddAction";
            this.cmdAddAction.Size = new System.Drawing.Size(75, 23);
            this.cmdAddAction.TabIndex = 4;
            this.cmdAddAction.Text = "Add Action";
            this.cmdAddAction.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 71);
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Size = new System.Drawing.Size(1106, 569);
            this.dataGrid.TabIndex = 5;
            // 
            // cmdQuit
            // 
            this.cmdQuit.BackColor = System.Drawing.Color.Orange;
            this.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuit.Location = new System.Drawing.Point(1043, 41);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(75, 23);
            this.cmdQuit.TabIndex = 6;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = false;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // txtScriptName
            // 
            this.txtScriptName.Location = new System.Drawing.Point(18, 44);
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(220, 20);
            this.txtScriptName.TabIndex = 8;
            this.txtScriptName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdAddStep
            // 
            this.cmdAddStep.BackColor = System.Drawing.Color.Orange;
            this.cmdAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddStep.Location = new System.Drawing.Point(959, 41);
            this.cmdAddStep.Name = "cmdAddStep";
            this.cmdAddStep.Size = new System.Drawing.Size(75, 23);
            this.cmdAddStep.TabIndex = 9;
            this.cmdAddStep.Text = "Add Step";
            this.cmdAddStep.UseVisualStyleBackColor = false;
            this.cmdAddStep.Click += new System.EventHandler(this.cmdAddStep_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblServerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.Location = new System.Drawing.Point(956, 9);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(121, 18);
            this.lblServerStatus.TabIndex = 10;
            this.lblServerStatus.Text = "Not Connected";
            // 
            // cmdListScripts
            // 
            this.cmdListScripts.BackColor = System.Drawing.Color.Orange;
            this.cmdListScripts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListScripts.Location = new System.Drawing.Point(244, 41);
            this.cmdListScripts.Name = "cmdListScripts";
            this.cmdListScripts.Size = new System.Drawing.Size(75, 23);
            this.cmdListScripts.TabIndex = 11;
            this.cmdListScripts.Text = "Load";
            this.cmdListScripts.UseVisualStyleBackColor = false;
            this.cmdListScripts.Click += new System.EventHandler(this.cmdListScripts_Click);
            // 
            // frmTestScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1130, 652);
            this.Controls.Add(this.cmdListScripts);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.cmdAddStep);
            this.Controls.Add(this.txtScriptName);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.cmdAddAction);
            this.Controls.Add(this.label1);
            this.Name = "frmTestScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Scripting";
            this.Load += new System.EventHandler(this.frmTestScript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddAction;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.Button cmdAddStep;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Button cmdListScripts;
    }
}