using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using NativeWifi;

namespace MyagkovAS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListNet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)

            { Wlan.WlanAvailableNetwork[] wlanBssEntries = wlanIface.GetAvailableNetworkList(0);

                ListNet.Items.Clear();
                foreach (Wlan.WlanAvailableNetwork network in wlanBssEntries)
                { ListViewItem listItemWiFi = new ListViewItem();
                    listItemWiFi.Text = System.Text.ASCIIEncoding.ASCII.GetString(network.dot11Ssid.SSID).Trim((char)0);
                    listItemWiFi.SubItems.Add(network.wlanSignalQuality.ToString() + "%");
                    listItemWiFi.SubItems.Add(network.dot11DefaultAuthAlgorithm.ToString().Trim((char)0));
                    listItemWiFi.SubItems.Add(network.dot11DefaultCipherAlgorithm.ToString().Trim((char)0));
                    listItemWiFi.ImageIndex = 0;
                    ListNet.Items.Add(listItemWiFi);
                }



            }
        }
    } 
}
