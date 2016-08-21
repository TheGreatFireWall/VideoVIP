using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iqiyivip
{
    public partial class FM_senior : Form
    {
        public FM_senior()
        {
            InitializeComponent();
        }

        private void btn_ad_Click(object sender, EventArgs e)
        {
            FM_ad son = new FM_ad();
            son.Owner = this;
            son.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.willv.cn");
        }

        private void btn_supply_Click(object sender, EventArgs e)
        {
            FM_supply son = new FM_supply();
            son.Owner = this;
            son.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheGreatFireWall/VideoVIP");
        }
    }
}
