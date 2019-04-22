using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace McRaeIT
{
    public partial class frmHostNameIP : Form
    {
        public frmHostNameIP()
        {
            InitializeComponent();
        }

        public string HostNameFromIP(string IPAdress)
        {
            string machineName = string.Empty;

            try
            {
                System.Net.IPHostEntry hostEntry = System.Net.Dns.GetHostEntry(IPAdress);
                machineName = hostEntry.HostName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in " + ex.Source, MessageBoxButtons.OK);
            }

            return machineName;
        }
        public string IPFromHostName(string HostName)
        {
            string ipAddress = string.Empty;
            try
            {
                System.Net.IPAddress ip = System.Net.Dns.GetHostEntry(HostName).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
                ipAddress = ip.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in " + ex.Source, MessageBoxButtons.OK);
            }
            return ipAddress;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtHostName.Text = "";
            txtIP.Text = "";
        }
        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (txtHostName.Text != "" || txtIP.Text != "")
            {
                if (txtHostName.Text == "")
                    txtHostName.Text = HostNameFromIP(txtIP.Text.Trim());
                else
                    txtIP.Text = IPFromHostName(txtHostName.Text.Trim());
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                cmdFind_Click(sender, new EventArgs());
        }
        private void txtHostName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                cmdFind_Click(sender, new EventArgs());
        }
    }
}
