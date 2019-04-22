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
    public partial class frmConfigurations : Form
    {
        public McraeitDataContext Context = new McraeitDataContext();
        public int ID = -1;

        public frmConfigurations()
        {
            InitializeComponent();
            LoadForm();
        }
        public frmConfigurations(int iID)
        {
            InitializeComponent();
            ID = iID;
            LoadForm(iID);
        }
        
        #region Functions
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
            configurationsBindingSource.DataSource = Context.Configurations;
        }
        private void LoadForm(int iID)
        {
            ID = iID;

            //Get the specific Config and bind all controls to only the 1 record
            var oConfig= from Config in Context.Configurations
                            where Config.ID == ID
                            select Config;

            configurationsBindingSource.DataSource = oConfig;
        }
        private void Search()
        {
            string sTerm = toolStripTextBoxSearch.Text.Trim();
            var oConfigs = from Configs in Context.Configurations
                             where Configs.Device.Contains(sTerm)
                             select Configs;

            configurationsBindingSource.DataSource = oConfigs;
        }
        #endregion

        #region Events
        private void ConfigurationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
        private void ToolStripButtonViewAll_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void ToolStripTextBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Text = "";
            toolStripTextBoxSearch.ForeColor = Color.Black;
        }
        private void ToolStripTextBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == "")
            {
                toolStripTextBoxSearch.Text = "Device";
                toolStripTextBoxSearch.ForeColor = Color.LightGray;
            }
        }
        private void ToolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Search();
            }
        }
        #endregion

    }
}
