using Australia_Scanner.AboutModule;
using Australia_Scanner.HomeModule;
using Australia_Scanner.LicenseModule;
using Australia_Scanner.SettingModule;
using Australia_Scanner.StaticClass;
using Bunifu.Framework.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Australia_Scanner
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            CheckLicense();
        }

        private void CheckLicense()
        {
            var license = LicenseInfoController.Instance.GetLicense();
            switch (license.Type)
            {
                case LicenseType.Invalid:
                    {
                        var frm = new FrmLicense() { Text = "Invalid Key" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                case LicenseType.Valid:
                    break;
                case LicenseType.Expired:
                    {
                        var frm = new FrmLicense() { Text = "Key has Expired" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }

        public void ChangeModuleTo<T>() where T : UserControl
        {
            SplashScreenManager.ShowForm(FindForm(), typeof(WaitForm1), true, true, false);
            panelControl1.Controls.Clear();
            var newModule = Activator.CreateInstance<T>();
            newModule.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(newModule);
            SplashScreenManager.CloseForm();
        }

        public void ChangeColor(BunifuFlatButton oldButton1, BunifuFlatButton oldButton2, BunifuFlatButton oldButton3, BunifuFlatButton newButton)
        {
            oldButton1.Textcolor = Color.White;
            oldButton2.Textcolor = Color.White;
            oldButton3.Textcolor = Color.White;
            newButton.Textcolor = Color.FromArgb(172, 75, 68);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            var closeConfirm = XtraMessageBox.Show("Close ???", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (closeConfirm == DialogResult.Cancel) return;
            else
            {
                HomeStatic.Instance.KillProcessByName("BvSsh");
                HomeStatic.Instance.KillProcessByName("autocontrol");
                Application.Exit();
            }
        }

        private void bnfHomeModule_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Home>();
            ChangeColor(bnfOptions, bnfProxy, bnfAbout, bnfHomeModule);
            lblDisplayName.Text = "HOME";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Settings>();
            bnfProxy.Textcolor = Color.FromArgb(172, 75, 68);
            ChangeColor(bnfOptions, bnfHomeModule, bnfAbout, bnfProxy);
            lblDisplayName.Text = "PROXY";
        }

        private void bndAbout_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<About>();
            bnfOptions.Textcolor = Color.FromArgb(172, 75, 68);
            ChangeColor(bnfHomeModule, bnfProxy, bnfAbout, bnfOptions);
            lblDisplayName.Text = "OPTIONS";
        }

        private void bnfAbout_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<AboutAuthor>();
            bnfAbout.Textcolor = Color.FromArgb(172, 75, 68);
            ChangeColor(bnfHomeModule, bnfProxy, bnfOptions, bnfAbout);
            lblDisplayName.Text = "ABOUT";
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            // Process.Start("http://www.blastsofts.com/tool-get-info-australia/");
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            //  Process.Start("https://www.youtube.com/watch?v=YR3ymSkw9MM");
        }

        private void labelControl2_MouseHover(object sender, EventArgs e)
        {
            labelControl2.Cursor = Cursors.Hand;
        }

        private void labelControl3_MouseHover(object sender, EventArgs e)
        {
            labelControl3.Cursor = Cursors.Hand;
        }
    }
}
