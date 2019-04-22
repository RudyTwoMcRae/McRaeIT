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
    public partial class frmTickets : Form
    {
        #region Global Variables
        public McraeitDataContext Context = new McraeitDataContext();
        public int ID = -1;
        #endregion

        public frmTickets(int iID)
        {
            InitializeComponent();

            ID = iID;
        }

        #region Functions
        private void LoadTicket()
        {
            var oTicket = from Ticket in Context.Tickets
                          where Ticket.ID == ID
                          select Ticket;

            lblID.Text = ID.ToString();

            //Set the databindings for every field
            txtProblem.DataBindings.Clear();
            txtProblem.DataBindings.Add("Text", oTicket.First(), "Problem");
            txtSolution.DataBindings.Clear();
            txtSolution.DataBindings.Add("Text", oTicket.First(), "Solution");
            txtNotes.DataBindings.Clear();
            txtNotes.DataBindings.Add("Text", oTicket.First(), "Notes");
            cboCompleted.DataBindings.Clear();
            cboCompleted.DataBindings.Add("Checked", oTicket.First(), "Completed");
            dtStartDate.DataBindings.Clear();
            dtStartDate.DataBindings.Add("Text", oTicket.First(), "StartDate");
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
        #endregion

        #region Events
        private void Tickets_Load(object sender, EventArgs e)
        {
            LoadTicket();
        }
        private void miSave_Click(object sender, EventArgs e)
        {
            EndEditOnAllBindingSources();
            Context.SubmitChanges();

            MessageBox.Show("Save Successfull");

            LoadTicket();
        }
        private void miQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
