namespace Second_Electricity_POC
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leaveDemoDataSet = new Second_Electricity_POC.LeaveDemoDataSet();
            this.emnployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emnployeeTableAdapter = new Second_Electricity_POC.LeaveDemoDataSetTableAdapters.EmnployeeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineManagerRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emnployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.leaveTypeIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.leaveBalanceDataGridViewTextBoxColumn,
            this.lineManagerRemarkDataGridViewTextBoxColumn,
            this.hRRemarkDataGridViewTextBoxColumn,
            this.requestIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emnployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // leaveDemoDataSet
            // 
            this.leaveDemoDataSet.DataSetName = "LeaveDemoDataSet";
            this.leaveDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emnployeeBindingSource
            // 
            this.emnployeeBindingSource.DataMember = "Emnployee";
            this.emnployeeBindingSource.DataSource = this.leaveDemoDataSet;
            // 
            // emnployeeTableAdapter
            // 
            this.emnployeeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveTypeIDDataGridViewTextBoxColumn
            // 
            this.leaveTypeIDDataGridViewTextBoxColumn.DataPropertyName = "LeaveTypeID";
            this.leaveTypeIDDataGridViewTextBoxColumn.HeaderText = "LeaveTypeID";
            this.leaveTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveTypeIDDataGridViewTextBoxColumn.Name = "leaveTypeIDDataGridViewTextBoxColumn";
            this.leaveTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveBalanceDataGridViewTextBoxColumn
            // 
            this.leaveBalanceDataGridViewTextBoxColumn.DataPropertyName = "LeaveBalance";
            this.leaveBalanceDataGridViewTextBoxColumn.HeaderText = "LeaveBalance";
            this.leaveBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveBalanceDataGridViewTextBoxColumn.Name = "leaveBalanceDataGridViewTextBoxColumn";
            this.leaveBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineManagerRemarkDataGridViewTextBoxColumn
            // 
            this.lineManagerRemarkDataGridViewTextBoxColumn.DataPropertyName = "LineManagerRemark";
            this.lineManagerRemarkDataGridViewTextBoxColumn.HeaderText = "LineManagerRemark";
            this.lineManagerRemarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineManagerRemarkDataGridViewTextBoxColumn.Name = "lineManagerRemarkDataGridViewTextBoxColumn";
            this.lineManagerRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRRemarkDataGridViewTextBoxColumn
            // 
            this.hRRemarkDataGridViewTextBoxColumn.DataPropertyName = "HRRemark";
            this.hRRemarkDataGridViewTextBoxColumn.HeaderText = "HRRemark";
            this.hRRemarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hRRemarkDataGridViewTextBoxColumn.Name = "hRRemarkDataGridViewTextBoxColumn";
            this.hRRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestIdDataGridViewTextBoxColumn
            // 
            this.requestIdDataGridViewTextBoxColumn.DataPropertyName = "RequestId";
            this.requestIdDataGridViewTextBoxColumn.HeaderText = "RequestId";
            this.requestIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIdDataGridViewTextBoxColumn.Name = "requestIdDataGridViewTextBoxColumn";
            this.requestIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emnployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LeaveDemoDataSet leaveDemoDataSet;
        private System.Windows.Forms.BindingSource emnployeeBindingSource;
        private LeaveDemoDataSetTableAdapters.EmnployeeTableAdapter emnployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineManagerRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIdDataGridViewTextBoxColumn;
    }
}