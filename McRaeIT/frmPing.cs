using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace McRaeIT
{
    public partial class frmPing : Form
    {
        public frmPing()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable("PingResults");
        private int progress = 0;

        private void configDataSet(bool getHostname)
        {
            //Set the Column Names and Descriptions
            dt = new DataTable("PingResults");
            DataColumn dc = new DataColumn("IP Address");
            dt.Columns.Add(dc);
            dc = new DataColumn("Time");
            dt.Columns.Add(dc);
            if (getHostname)
            {
                dc = new DataColumn("Host Name");
                dt.Columns.Add(dc);
            }

            dgView.DataSource = dt;
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
                Console.Error.WriteLine(ex.Message);
            }

            return machineName;
        }

        private void PingRange(bool getHostname)
        {
            //Variables used to create DataTable
            string sIPAddress = "";
            string sHostName = "";
            string sTime = "";
            //Variables used to ping local computers
            string sStart = txtStart.Text.Trim();
            string sStarter = sStart.Substring(0, sStart.LastIndexOf(".") + 1);
            string sEnd = txtEnd.Text.Trim();
            int iStart = int.Parse(sStart.Substring(sStart.LastIndexOf(".") + 1));
            int iEnd = int.Parse(sEnd.Substring(sEnd.LastIndexOf(".") + 1));
            Ping p = new Ping();
            PingReply reply;

            //Configure the Progress Bar
            pbPing.Visible = true;
            pbPing.Minimum = 0;
            pbPing.Maximum = iEnd - iStart;
            progress = 0;

            //Loop  through every ip in the range specified
            //NOTE: The start and end ip's must be the same up to the last .
            for (int i = iStart; i < iEnd; i++)
            {
                IPAddress curIP = IPAddress.Parse(sStarter + i.ToString());
                reply = p.Send(curIP, 100);

                //Update the progress bar
                progress++;
                pbPing.Value = progress;
                pbPing.Update();

                if (reply.Status == IPStatus.Success)
                {
                    List<string> PingInfo = new List<string>();
                    sIPAddress = curIP.ToString();
                    sTime = reply.RoundtripTime.ToString();
                    if (getHostname)
                        sHostName = HostNameFromIP(sIPAddress);
                    PingInfo.Add(sIPAddress);
                    PingInfo.Add(sTime);
                    if (getHostname)
                        PingInfo.Add(sHostName);
                    dt.Rows.Add(PingInfo.ToArray());

                    dgView.Update();
                }
            }
            pbPing.Visible = false;
        }
        private void PingSingle()
        {
            Ping p = new Ping();
            PingReply reply = p.Send(txtStart.Text.Trim(), 100);

            if (reply.Status == IPStatus.Success)
            {
                List<string> PingInfo = new List<string>();
                string sIPAddress = txtStart.Text.Trim();
                string sTime = reply.RoundtripTime.ToString();
                string sHostName = HostNameFromIP(sIPAddress);

                PingInfo.Add(sIPAddress);
                PingInfo.Add(sTime);
                PingInfo.Add(sHostName);
                dt.Rows.Add(PingInfo.ToArray());

                dgView.Update();
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            switch (cboType.Text)
            {
                case "Range":
                    configDataSet(false);
                    PingRange(false);
                    break;
                case "Range(With Hosts)":
                    configDataSet(true);
                    PingRange(true);
                    break;
                case "Single":
                    configDataSet(true);
                    PingSingle();
                    break;
                default:
                    configDataSet(false);
                    PingRange(false);
                    break;
            }
        }
    }
}
