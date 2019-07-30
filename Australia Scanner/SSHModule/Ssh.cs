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
using Australia_Scanner.StaticClass;
using System.IO;
using System.Diagnostics;

namespace Australia_Scanner.SettingModule
{
    public partial class Settings : DevExpress.XtraEditors.XtraUserControl
    {
        public Settings()
        {
            InitializeComponent();
            var listSsh = new List<SshDetails>();
            gridControl1.DataSource = listSsh;
            LoadDefaultInfo();
        }

        private void LoadDefaultInfo()
        {
            var source = SettingStatic.Instance.GetSshFiles();
            leSshFiles.Properties.DataSource = source;
            leSshFiles.EditValue = source[0];
        }

        private void leSshFiles_EditValueChanged(object sender, EventArgs e)
        {
            SettingStatic.Instance.LoadSshDefault(leSshFiles.EditValue.ToString(), gridControl1, lblSshCount);
        }

        private void sbSAve_Click(object sender, EventArgs e)
        {
            if (teNewFileName.Text.Equals(string.Empty)) { XtraMessageBox.Show("Name must have value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            SettingStatic.Instance.CreatFolderIfNotExist();
            File.Create(SettingStatic.sshFolder + $"{teNewFileName.Text}.txt").Close();
            XtraMessageBox.Show("Created Success !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            leSshFiles.Properties.DataSource = SettingStatic.Instance.GetSshFiles();
            leSshFiles.EditValue = SettingStatic.Instance.GetSshFiles()[0];
        }

        private void sbRemove_Click(object sender, EventArgs e)
        {
            var removeConfirm = XtraMessageBox.Show($"Delete file '{leSshFiles.EditValue.ToString()} ??'", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (removeConfirm.Equals(DialogResult.OK)) { File.Delete(SettingStatic.sshFolder + leSshFiles.EditValue.ToString()); }
            XtraMessageBox.Show("Deleted Success !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            leSshFiles.Properties.DataSource = SettingStatic.Instance.GetSshFiles();
            leSshFiles.EditValue = SettingStatic.Instance.GetSshFiles()[0];
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "check":
                    Process.Start(SettingStatic.sshFolder + leSshFiles.EditValue.ToString());
                    break;
                case "load":
                    var ofd = new OpenFileDialog();
                    ofd.Title = "SSH FILE";
                    ofd.Multiselect = false;
                    ofd.Filter = "SSH FILE |*.txt";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        var lines = File.ReadAllLines(ofd.FileName);
                        var builder = new StringBuilder();
                        foreach (var item in lines)
                        {
                            var split = item.Split('|');
                            builder.AppendLine($"{split[0]}|{split[1]}|{split[2]}");
                        }
                        File.WriteAllText(SettingStatic.sshFolder + leSshFiles.EditValue.ToString(), builder.ToString());
                        SettingStatic.Instance.LoadSshDefault(leSshFiles.EditValue.ToString(), gridControl1, lblSshCount);
                    }
                    break;
                case "remove":
                    var removeConfirm = XtraMessageBox.Show($"Delete {gridView1.GetSelectedRows().Count()} SSH ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (removeConfirm == DialogResult.Cancel) return;
                    XtraMessageBox.Show("Deleted Success !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView1.DeleteSelectedRows();
                    var listSsh = gridControl1.DataSource as List<SshDetails>;
                    SettingStatic.Instance.WriteSshToFile(listSsh, leSshFiles.EditValue.ToString());
                    SettingStatic.Instance.LoadSshDefault(leSshFiles.EditValue.ToString(), gridControl1, lblSshCount);
                    break;
                default:
                    break;
            }
        }
    }
}
