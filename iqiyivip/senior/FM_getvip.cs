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
    public partial class FM_getvip : Form
    {
        public FM_getvip()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://ftp593852.host551.zhujiwu.me/");
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            btn_get.Visible = false;
            label1.Visible = false;
            this.Size = new Size(570, 380);
            string ip = randomip();
            string time = standardtime();
            webBrowser1.Document.Cookie = "zhujiwusysdomain=ftp593852.host551.zhujiwu.me; CookieZJWFANGDAOLIAN=" + ip + "#" + time + "#ftp593852.host551.zhujiwu.me; IP=" + ip;
            webBrowser1.Refresh();
        }
        private string randomip()
        {
            Random ra = new Random();
            return Convert.ToString(ra.Next(1, 255)) + "." + Convert.ToString(ra.Next(1, 255)) + "."
                + Convert.ToString(ra.Next(1, 255)) + "." + Convert.ToString(ra.Next(1, 255));
        }
        private string standardtime()
        {
            string time = DateTime.Now.ToShortDateString() + "/" + DateTime.Now.ToShortTimeString();
            time = time.Remove(time.IndexOf(":"));
            time = time.Replace("/", "-");
            time = time.Replace(" ", "-");
            return time;
        }
    }
}
