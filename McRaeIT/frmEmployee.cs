using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McraeitContext;

namespace McRaeIT
{
    public partial class frmEmployee : Form
    {
        public McraeitDataContext Context = new McraeitDataContext();
        public int ID = -1;
        private int rowIndex = -1;
        
        public frmEmployee()
        {
            InitializeComponent();
            LoadForm();
        }
        public frmEmployee(int iID)
        {
            InitializeComponent();
            LoadForm(iID);
        }

        #region Functions
        private void FormatView()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty, null, employeeLoginDataGridView, new object[] { true });

            employeeLoginDataGridView.Columns[0].ReadOnly = true;
            employeeLoginDataGridView.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;

            //Set the background color to WhiteSmoke for even rows
            foreach (DataGridViewRow row in employeeLoginDataGridView.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }
        private void EndEditOnAllBindingSources()
        {
            var BindingSourcesQuery =
                from Component bindingSources in this.components.Components
                where bindingSources is BindingSource
                select bindingSources;

            foreach (BindingSource bindingSource in BindingSourcesQuery)
            {
                bindingSource.EndEdit();
            }
        }
        private void LoadForm()
        {
            employeeBindingSource.DataSource = Context.Employees;
            departmentBindingSource.DataSource = Context.Departments;

            var Groups = from ServerGroup in Context.ServerGroups
                         select ServerGroup.GroupName;
            lstServerGroups.DataSource = Groups;

            FormatView();
        }
        private void LoadForm(int iID)
        {
            ID = iID;

            //Get the specific Employee and bind all controls to only the 1 record
            var oEmployee = from Employee in Context.Employees
                            where Employee.ID == ID
                            select Employee;

            employeeBindingSource.DataSource = oEmployee;
            departmentBindingSource.DataSource = Context.Departments;

            //Get the ServerGroups and populate the Server Groups List control with the values from the database
            var Groups = from ServerGroup in Context.ServerGroups
                         select ServerGroup.GroupName;
            lstServerGroups.DataSource = Groups;

            FormatView();
        }
        private void Search()
        {
            string sTerm = toolStripTextBoxSearch.Text.Trim();
            var oEmployees = from Employee in Context.Employees
                             where Employee.Name.Contains(sTerm)
                             select Employee;

            employeeBindingSource.DataSource = oEmployees;
        }
        #endregion

        #region Events
        private void lblAddGroup_Click(object sender, EventArgs e)
        {
            txtServerGroups.Text += Environment.NewLine + lstServerGroups.SelectedItem.ToString();
        }
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                EndEditOnAllBindingSources();
                Context.SubmitChanges();
                MessageBox.Show("Save Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void toolStripTextBoxSearch_Enter(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Text = "";
            toolStripTextBoxSearch.ForeColor = Color.Black;
        }
        private void toolStripTextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == "")
            {
                toolStripTextBoxSearch.Text = "Name";
                toolStripTextBoxSearch.ForeColor = Color.LightGray;
            }
        }
        private void toolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Search();
            }
        }
        private void employeeLoginDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            rowIndex = (int)e.Row.Cells[0].Value;
            var oEmployeeLogin = from el in Context.EmployeeLogins
                                 where el.ID == rowIndex
                                 select el;
            EmployeeLogin eLogin = (EmployeeLogin)oEmployeeLogin.First();

            Context.EmployeeLogins.DeleteOnSubmit(eLogin);
        }
        #endregion

    }
}
