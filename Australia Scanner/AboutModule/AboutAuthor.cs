using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Australia_Scanner.AboutModule
{
    public partial class AboutAuthor : DevExpress.XtraEditors.XtraUserControl
    {
        public AboutAuthor()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/w9XpN9");
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.blastsofts.com/tool-get-info-australia/");
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/uxhkZ7");
        }
    }
}
