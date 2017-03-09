namespace DepartmentManagement
{
    partial class Form1
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
            this.cbID = new System.Windows.Forms.ComboBox();
            this.tblDepartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentManagementDataSet1 = new DepartmentManagement.DepartmentManagementDataSet1();
            this.tblDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentManagementDataSet = new DepartmentManagement.DepartmentManagementDataSet();
            this.tblDepartmentTableAdapter = new DepartmentManagement.DepartmentManagementDataSetTableAdapters.tblDepartmentTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.departmentManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmentTableAdapter1 = new DepartmentManagement.DepartmentManagementDataSet1TableAdapters.tblDepartmentTableAdapter();
            this.gvDepartment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // cbID
            // 
            this.cbID.DataSource = this.tblDepartmentBindingSource1;
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(71, 12);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 21);
            this.cbID.TabIndex = 0;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // tblDepartmentBindingSource1
            // 
            this.tblDepartmentBindingSource1.DataMember = "tblDepartment";
            this.tblDepartmentBindingSource1.DataSource = this.departmentManagementDataSet1;
            // 
            // departmentManagementDataSet1
            // 
            this.departmentManagementDataSet1.DataSetName = "DepartmentManagementDataSet1";
            this.departmentManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmentBindingSource
            // 
            this.tblDepartmentBindingSource.DataMember = "tblDepartment";
            this.tblDepartmentBindingSource.DataSource = this.departmentManagementDataSet;
            // 
            // departmentManagementDataSet
            // 
            this.departmentManagementDataSet.DataSetName = "DepartmentManagementDataSet";
            this.departmentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmentTableAdapter
            // 
            this.tblDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(372, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(372, 155);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(372, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(170, 20);
            this.txtID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(372, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(467, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(467, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // departmentManagementDataSetBindingSource
            // 
            this.departmentManagementDataSetBindingSource.DataSource = this.departmentManagementDataSet;
            this.departmentManagementDataSetBindingSource.Position = 0;
            // 
            // tblDepartmentTableAdapter1
            // 
            this.tblDepartmentTableAdapter1.ClearBeforeFill = true;
            // 
            // gvDepartment
            // 
            this.gvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartment.Location = new System.Drawing.Point(12, 58);
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.Size = new System.Drawing.Size(245, 226);
            this.gvDepartment.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gvDepartment);
            this.Controls.Add(this.cbID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbID;
        private DepartmentManagementDataSet departmentManagementDataSet;
        private System.Windows.Forms.BindingSource tblDepartmentBindingSource;
        private DepartmentManagementDataSetTableAdapters.tblDepartmentTableAdapter tblDepartmentTableAdapter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource departmentManagementDataSetBindingSource;
        private DepartmentManagementDataSet1 departmentManagementDataSet1;
        private System.Windows.Forms.BindingSource tblDepartmentBindingSource1;
        private DepartmentManagementDataSet1TableAdapters.tblDepartmentTableAdapter tblDepartmentTableAdapter1;
        private System.Windows.Forms.DataGridView gvDepartment;
    }
}

