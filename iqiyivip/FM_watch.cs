using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace iqiyivip
{
    public partial class FM_watch : Form
    {
        public FM_watch(string url)
        {
            try
            {
                InitializeComponent();
                webBrowser1.Navigate(url);
            }
            catch
            {
                throw;
            }
        }
    }
}
