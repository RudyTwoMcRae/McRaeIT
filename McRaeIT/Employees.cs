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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        #region Global Variables
        public McraeitDataContext Context = new McraeitDataContext();
        public string ItTable = "Employees";
        #endregion

        #region Private Functions
        private void LoadEmployees()
        {
            switch (ItTable)
            {
                case "Employees":
                    var oEmployees = from Employee in Context.Employees
                                     select Employee;
                    dgvEmployees.DataSource = oEmployees;
                    break;
                case "Tickets":
                    var oTickets = from IPAddress in Context.Tickets
                                       select IPAddress;
                    dgvEmployees.DataSource = oTickets;
                    break;
                case "IPAddresses":
                    var oIPAddresses = from IPAddress in Context.IPAddresses
                                 select IPAddress;
                    dgvEmployees.DataSource = oIPAddresses;
                    break;
                case "Accounts":
                    var oAccounts = from IPAddress in Context.CompanyAccounts
                                       select IPAddress;
                    dgvEmployees.DataSource = oAccounts;
                    break;
                case "Configuration":
                    var oConfig = from Config in Context.Configurations
                                    select Config;
                    dgvEmployees.DataSource = oConfig;
                    break;
            }
            
            FormatView();
        }
        private void FormatView()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | 
                System.Reflection.BindingFlags.SetProperty, null, dgvEmployees, new object[] { true });

            dgvEmployees.Columns[0].ReadOnly = true;
            dgvEmployees.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;

            if (dgvEmployees.Columns.Contains("Employee"))
                dgvEmployees.Columns["Employee"].Visible = false;

            //Set the background color to WhiteSmoke for even rows
            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            //Move the Notes Column to the end
            if (dgvEmployees.Columns.Contains("Notes"))
            {
                dgvEmployees.Columns["Notes"].DisplayIndex = dgvEmployees.Columns.Count - 1;
            }
        }
        private void Search()
        {
            string sTerm = txtSearch.Text.Trim();

            switch (ItTable)
            {
                case "Employees":
                    var oEmployees = from Employee in Context.Employees
                                     where Employee.Name.Contains(sTerm)
                                     select Employee;
                    dgvEmployees.DataSource = oEmployees;
                    break;
                case "IPAddresses":
                    var oIPAddresses = from IPAddress in Context.IPAddresses
                                     where IPAddress.Address.Contains(sTerm) || IPAddress.Device.Contains(sTerm)
                                     select IPAddress;
                    dgvEmployees.DataSource = oIPAddresses;
                    break;
                case "Accounts":
                    var oAccounts = from CompanyAccount in Context.CompanyAccounts
                                     where CompanyAccount.Name.Contains(sTerm)
                                     select CompanyAccount;
                    dgvEmployees.DataSource = oAccounts;
                    break;
                case "Tickets":
                    var oTickets = from Ticket in Context.Tickets
                                       where Ticket.Problem.Contains(sTerm) || Ticket.Solution.Contains(sTerm) || Ticket.Notes.Contains(sTerm)
                                       select Ticket;
                    dgvEmployees.DataSource = oTickets;
                    break;
                default:
                    var oDefault = from Employee in Context.Employees
                                     where Employee.Name.Contains(sTerm)
                                     select Employee;
                    dgvEmployees.DataSource = oDefault;
                    break;
            }

            FormatView();
        }
        #endregion

        #region General Event Handlers
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ItTable == "Tickets" && e.ColumnIndex == 0)
            {
                frmTickets Tickets = new frmTickets((int)dgvEmployees.Rows[e.RowIndex].Cells["ID"].Value);
                Tickets.ShowDialog();
            }
            if (ItTable == "Configurations" && e.ColumnIndex == 0)
            {
                frmConfigurations Configs = new frmConfigurations((int)dgvEmployees.Rows[e.RowIndex].Cells["ID"].Value);
                Configs.ShowDialog();
            }
            if (ItTable == "Employees" && e.ColumnIndex == 0)
            {
                frmEmployee EmployeeForm = new frmEmployee((int)dgvEmployees.Rows[e.RowIndex].Cells["ID"].Value);
                EmployeeForm.ShowDialog();
            }
        }
        private void frmEmployees_Activated(object sender, EventArgs e)
        {
            Context.Refresh(Devart.Data.Linq.RefreshMode.KeepChanges, Context.Tickets);
        }
        private void frmEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Menu Event Handlers
        private void miQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void miSave_Click(object sender, EventArgs e)
        {
            cmdSave_Click(sender, e);
        }
        private void miSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void miIPAddresses_Click(object sender, EventArgs e)
        {
            ItTable = "IPAddresses";

            LoadEmployees();
        }
        private void miEmployees_Click(object sender, EventArgs e)
        {
            ItTable = "Employees";

            LoadEmployees();

        }
        private void miTickets_Click(object sender, EventArgs e)
        {
            ItTable = "Tickets";
            LoadEmployees();
        }
        private void miAccounts_Click(object sender, EventArgs e)
        {
            ItTable = "Accounts";
            LoadEmployees();
        }
        private void miEditEmployees_Click(object sender, EventArgs e)
        {
            frmEmployee EmployeeForm = new frmEmployee();
            EmployeeForm.ShowDialog();
        }
        private void miHostToIP_Click(object sender, EventArgs e)
        {
            frmHostNameIP HostToIPForm = new frmHostNameIP();
            HostToIPForm.ShowDialog();
        }
        private void miMACIP_Click(object sender, EventArgs e)
        {
            frmHostInfo HostInfoForm = new frmHostInfo();
            HostInfoForm.ShowDialog();
        }
        private void miPing_Click(object sender, EventArgs e)
        {
            frmPing PingForm = new frmPing();
            PingForm.ShowDialog();
        }
        private void MiConfigs_Click(object sender, EventArgs e)
        {
            ItTable = "Configuration";

            LoadEmployees();
        }
        #endregion

        #region ToolStrip Event Handlers
        private void cmdListAll_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            txtSearch.Text = "Name";
            txtSearch.ForeColor = Color.LightGray;
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Focus();
                Context.SubmitChanges();
                MessageBox.Show("Save Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadEmployees();
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Name";
                txtSearch.ForeColor = Color.LightGray;
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Search();
            }
        }
        #endregion

    }
}
