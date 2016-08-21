using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoVIP
{
    public partial class FM_ad : Form
    {
        public FM_ad()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://o7x4zxzvg.bkt.clouddn.com/hosts.txt");
        }

        private void btn_ad_Click(object sender, EventArgs e)
        {
            string url = "http://o7x4zxzvg.bkt.clouddn.com/hosts.txt?v=" + text_url;
            webBrowser1.Navigate(url);
        }
    }
}
