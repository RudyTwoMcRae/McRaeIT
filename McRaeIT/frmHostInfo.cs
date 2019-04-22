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
using System.Net.NetworkInformation;

namespace McRaeIT
{
    public partial class frmHostInfo : Form
    {
        public frmHostInfo()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable("HostInfoTable");

        private void configDataSet()
        {
            //Set the Column Names and Descriptions
            DataColumn dc = new DataColumn("NICName");
            dc.Caption = "NIC Name";
            dt.Columns.Add(dc);
            dc = new DataColumn("NICDescription");
            dc.Caption = "NIC Description";
            dt.Columns.Add(dc);
            dc = new DataColumn("Speed");
            dc.Caption = "NIC Max Speed";
            dt.Columns.Add(dc);
            dc = new DataColumn("MacAddress");
            dc.Caption = "MAC Address";
            dt.Columns.Add(dc);
            dc = new DataColumn("IPAddress");
            dc.Caption = "IP Address";
            dt.Columns.Add(dc);
            dc = new DataColumn("SubnetMask");
            dc.Caption = "Subnet Mask";
            dt.Columns.Add(dc);
            dc = new DataColumn("Gateway");
            dc.Caption = "Gateway";
            dt.Columns.Add(dc);
            dc = new DataColumn("DHCPServer");
            dc.Caption = "DHCP Server";
            dt.Columns.Add(dc);
            dc = new DataColumn("DNSServer");
            dc.Caption = "DNS Server";
            dt.Columns.Add(dc);
        }
        private List<string> GetHostInfo(NetworkInterface nic)
        {
            List<string> HostInfo = new List<string>();
            string macAddresses = "";
            string IPAddress = "";
            string NicName = "";
            string NicDescription = "";
            string NicSpeed = "";
            string Gateway = "";
            string SubnetMask = "";
            string DHCPServer = "";
            string DNSServers = "";


            macAddresses = nic.GetPhysicalAddress().ToString();
            Gateway = nic.GetIPProperties().GatewayAddresses.Count > 0 ? nic.GetIPProperties().GatewayAddresses[0].Address.ToString() : "";
            DHCPServer = nic.GetIPProperties().DhcpServerAddresses.Count > 0 ? nic.GetIPProperties().DhcpServerAddresses[0].ToString() : "";
            NicName = nic.Name;
            NicDescription = nic.Description;
            NicSpeed = (nic.Speed / 100000000).ToString() + "\\Gbps";

            //Get the IP Address
            foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = ip.Address.ToString();
                    SubnetMask = ip.IPv4Mask.ToString();
                }
            }

            //Get the DNS Servers
            foreach (IPAddress dnsip in nic.GetIPProperties().DnsAddresses)
            {
                DNSServers += dnsip + " | ";
            }

            DNSServers = DNSServers.Length > 5 ? DNSServers.Substring(0, DNSServers.Length - 3) : "";

            HostInfo.Add(NicName);
            HostInfo.Add(NicDescription);
            HostInfo.Add(NicSpeed);
            HostInfo.Add(macAddresses);
            HostInfo.Add(IPAddress);
            HostInfo.Add(SubnetMask);
            HostInfo.Add(Gateway);
            HostInfo.Add(DHCPServer);
            HostInfo.Add(DNSServers);

            return HostInfo;
        }

        private void HostInfo_Load(object sender, EventArgs e)
        {
            configDataSet();

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces, thereby ignoring any
                // loopback devices etc.
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet || nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        dt.Rows.Add(GetHostInfo(nic).ToArray());
                    }
                }
            }

            dgView.DataSource = dt;
            dgView.AutoResizeColumns();
            dgView.AutoResizeRows();
        }
    }
}
