using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;

namespace Australia_Scanner.LicenseModule
{
    public partial class FrmLicense : DevExpress.XtraEditors.XtraForm
    {
        public FrmLicense()
        {
            InitializeComponent();
            teProductID.Text = Program.ComputerId;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbActive_Click(object sender, EventArgs e)
        {
            if (teKey.Text == string.Empty)
            {
                XtraMessageBox.Show("Invalid Key", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var encryptedKey = teKey.Text;
                var decryptedKey = StringCipher.Decrypt(encryptedKey, Program.passwordToEncryptKey);

                //compuerID | usingdays
                var sp = decryptedKey.Split('|');
                var computerIdToActive = sp[0];
                var usingDay = int.Parse(sp[1]);
                if (computerIdToActive != Program.ComputerId)
                {
                    XtraMessageBox.Show("Invalid Key", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //computerId | usingdays | ActiveDays
                encryptedKey = StringCipher.Encrypt($"{computerIdToActive}|{sp[1]}|{DateTime.Now.ToFileTimeUtc()}", Program.passwordToEncryptKey);
                File.WriteAllText(Program.licensePath, encryptedKey);
                XtraMessageBox.Show("Activated !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Invalid Key", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lblHomPage_Click(object sender, EventArgs e)
        {
            //Process.Start("http://www.blastsofts.com/tool-get-info-australia/");
        }

        private void lblYoutube_Click(object sender, EventArgs e)
        {
           // Process.Start("https://goo.gl/uxhkZ7");
        }

        private void lblHomPage_MouseHover(object sender, EventArgs e)
        {
            lblHomPage.Cursor = Cursors.Hand;
        }

        private void lblYoutube_MouseHover(object sender, EventArgs e)
        {
            lblYoutube.Cursor = Cursors.Hand;
        }
    }
}