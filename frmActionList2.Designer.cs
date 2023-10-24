namespace Second_Electricity_POC
{
    partial class frmActionList2
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.emnployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveDemoDataSet = new Second_Electricity_POC.LeaveDemoDataSet();
            this.emnployeeTableAdapter = new Second_Electricity_POC.LeaveDemoDataSetTableAdapters.EmnployeeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineManagerRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emnployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDemoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.requestIdDataGridViewTextBoxColumn,
            this.leaveTypeIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.leaveBalanceDataGridViewTextBoxColumn,
            this.lineManagerRemarkDataGridViewTextBoxColumn,
            this.hRRemarkDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.emnployeeBindingSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(5, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1209, 376);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // emnployeeBindingSource
            // 
            this.emnployeeBindingSource.DataMember = "Emnployee";
            this.emnployeeBindingSource.DataSource = this.leaveDemoDataSet;
            // 
            // leaveDemoDataSet
            // 
            this.leaveDemoDataSet.DataSetName = "LeaveDemoDataSet";
            this.leaveDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emnployeeTableAdapter
            // 
            this.emnployeeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestIdDataGridViewTextBoxColumn
            // 
            this.requestIdDataGridViewTextBoxColumn.DataPropertyName = "RequestId";
            this.requestIdDataGridViewTextBoxColumn.HeaderText = "رقم الطلب";
            this.requestIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIdDataGridViewTextBoxColumn.Name = "requestIdDataGridViewTextBoxColumn";
            this.requestIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveTypeIDDataGridViewTextBoxColumn
            // 
            this.leaveTypeIDDataGridViewTextBoxColumn.DataPropertyName = "LeaveTypeID";
            this.leaveTypeIDDataGridViewTextBoxColumn.HeaderText = "نوع الإجازة";
            this.leaveTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveTypeIDDataGridViewTextBoxColumn.Name = "leaveTypeIDDataGridViewTextBoxColumn";
            this.leaveTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "من تاريخ";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "الى تاريخ";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveBalanceDataGridViewTextBoxColumn
            // 
            this.leaveBalanceDataGridViewTextBoxColumn.DataPropertyName = "LeaveBalance";
            this.leaveBalanceDataGridViewTextBoxColumn.HeaderText = "رصيد الاجازات";
            this.leaveBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveBalanceDataGridViewTextBoxColumn.Name = "leaveBalanceDataGridViewTextBoxColumn";
            this.leaveBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineManagerRemarkDataGridViewTextBoxColumn
            // 
            this.lineManagerRemarkDataGridViewTextBoxColumn.DataPropertyName = "LineManagerRemark";
            this.lineManagerRemarkDataGridViewTextBoxColumn.HeaderText = "ملاحظة قسم الادارة";
            this.lineManagerRemarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineManagerRemarkDataGridViewTextBoxColumn.Name = "lineManagerRemarkDataGridViewTextBoxColumn";
            this.lineManagerRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRRemarkDataGridViewTextBoxColumn
            // 
            this.hRRemarkDataGridViewTextBoxColumn.DataPropertyName = "HRRemark";
            this.hRRemarkDataGridViewTextBoxColumn.HeaderText = "ملاحظة قسم الموارد البشرية";
            this.hRRemarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hRRemarkDataGridViewTextBoxColumn.Name = "hRRemarkDataGridViewTextBoxColumn";
            this.hRRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 381);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1209, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.Location = new System.Drawing.Point(1059, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 39);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmActionList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 431);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Name = "frmActionList2";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة الاجراءات";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emnployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDemoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private LeaveDemoDataSet leaveDemoDataSet;
        private System.Windows.Forms.BindingSource emnployeeBindingSource;
        private LeaveDemoDataSetTableAdapters.EmnployeeTableAdapter emnployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineManagerRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
    }
}