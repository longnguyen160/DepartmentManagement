using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentManagement
{
    public partial class Form1 : Form
    {
        private DataTable table;
        String type = "";

        public Form1()
        {
            InitializeComponent();
//            string cnStr = ConfigurationManager.ConnectionStrings["DepartmentManagement"].ConnectionString;
//            dAdapt = new SqlDataAdapter("Select * From tblDepartMent", cnStr);
//            SqlCommandBuilder builder = new SqlCommandBuilder(dAdapt);
//            data = new DataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tblDepartmentTableAdapter1.Fill(this.departmentManagementDataSet1.tblDepartment);
            cbID.ValueMember = "id";
            initData();
        }

        private void initData()
        {
            this.txtID.Text = cbID.SelectedValue.ToString();
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtTotal.ReadOnly = true;
            table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("name");
            DataRow row = table.NewRow();
            row["id"] = cbID.SelectedValue.ToString();
            cbID.ValueMember = "name";
            row["name"] = cbID.SelectedValue.ToString();
            table.Rows.Add(row);
            this.txtName.Text = cbID.SelectedValue.ToString();
            cbID.ValueMember = "id";
            gvDepartment.DataSource = table;
            this.txtTotal.Text = cbID.Items.Count.ToString();
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbID.SelectedItem != null && table != null)
            {
                selectedIndex();
            }
        }

        private void selectedIndex()
        {
            table.Rows.Clear();
            DataRow row = table.NewRow();
            row["id"] = cbID.SelectedValue.ToString();
            this.txtID.Text = cbID.SelectedValue.ToString();
            cbID.ValueMember = "name";
            this.txtName.Text = cbID.SelectedValue.ToString();
            row["name"] = cbID.SelectedValue.ToString();
            table.Rows.Add(row);
            cbID.ValueMember = "id";
            gvDepartment.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";            
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            type = "add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type.Equals("add"))
                add();
            else if (type.Equals("edit"))
                edit();
            type = "";
        }

        private void edit()
        {
            DataRow[] row = this.departmentManagementDataSet1.tblDepartment.Select(string.Format("id = '{0}'", txtID.Text));            
            row[0]["name"] = txtName.Text;
            this.tblDepartmentTableAdapter1.Update(this.departmentManagementDataSet1.tblDepartment);
            txtName.ReadOnly = true;
        }

        private void add()
        {
            DataRow row = this.departmentManagementDataSet1.tblDepartment.NewRow();
            row["id"] = txtID.Text;
            row["name"] = txtName.Text;
            try
            {
                this.departmentManagementDataSet1.tblDepartment.Rows.Add(row);
                this.tblDepartmentTableAdapter1.Update(this.departmentManagementDataSet1.tblDepartment);
                cbID.Update();
                txtID.ReadOnly = true;
                txtName.ReadOnly = true;
                this.txtTotal.Text = cbID.Items.Count.ToString();
                cbID.SelectedIndex = cbID.Items.Count - 1;
                selectedIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This id is existed! " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = cbID.SelectedIndex;
            try
            {
                this.departmentManagementDataSet1.tblDepartment.Rows[index].Delete();
                this.tblDepartmentTableAdapter1.Update(this.departmentManagementDataSet1.tblDepartment);
                cbID.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error! " + ex.Message);
            }
            selectedIndex();
            this.txtTotal.Text = cbID.Items.Count.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            initData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (type.Equals(""))
            {
                txtName.ReadOnly = false;
                type = "edit";
            }
        }
    }
}
