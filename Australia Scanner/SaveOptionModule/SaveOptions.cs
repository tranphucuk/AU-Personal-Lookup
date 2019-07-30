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
using Newtonsoft.Json;
using Australia_Scanner.SaveOptionModule;
using System.IO;

namespace Australia_Scanner.AboutModule
{
    public partial class About : DevExpress.XtraEditors.XtraUserControl
    {
        public readonly string saveFilePath = Application.StartupPath + "\\st.js";
        public About()
        {
            InitializeComponent();
            LoadDefaultInfo();
        }

        private void LoadDefaultInfo()
        {
            leSaveOptions.Properties.DataSource = HomeStatic.Instance.SaveOptions();
            leSaveOptions.EditValue = HomeStatic.Instance.SaveOptions()[0];
            while (!File.Exists(saveFilePath)) { File.Create(saveFilePath).Close(); }

            var info = File.ReadAllText(saveFilePath);
            if (!info.Equals(string.Empty))
            {
                var jsonInfo = JsonConvert.DeserializeObject<InfoSave>(info);
                leSaveOptions.EditValue = jsonInfo.OptionSave;
                teLocation.Text = jsonInfo.Location;
                sePort.Value = jsonInfo.ProxyPort;
                seTimeOut.Value = jsonInfo.TimeOutProxy;
                seAutoExitTool.Value = jsonInfo.AutoExit;
            }
        }

        private void teSelecteLocation_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = $"File {leSaveOptions.EditValue.ToString()}";
            ofd.Filter = leSaveOptions.EditValue.ToString() == "Text" ? $"File {leSaveOptions.EditValue.ToString()}|*.txt" : $"File {leSaveOptions.EditValue.ToString()}|*.csv;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            teLocation.Text = ofd.FileName;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (teLocation.Text.Equals(string.Empty)) { XtraMessageBox.Show("Set 'Location' to save result first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var saveInfo = new InfoSave()
            {
                OptionSave = leSaveOptions.EditValue.ToString(),
                Location = teLocation.Text,
                ProxyPort = Convert.ToInt32(sePort.Value),
                TimeOutProxy = Convert.ToInt32(seTimeOut.Value),
                AutoExit = Convert.ToInt32(seAutoExitTool.Value),
            };
            var json = JsonConvert.SerializeObject(saveInfo);
            File.WriteAllText(saveFilePath, json);
            XtraMessageBox.Show("Saved !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            var info = File.ReadAllText(saveFilePath);
            var jsonInfo = JsonConvert.DeserializeObject<InfoSave>(info);
            leSaveOptions.EditValue = jsonInfo.OptionSave;
            teLocation.Text = jsonInfo.Location;
            sePort.Value = jsonInfo.ProxyPort;
            seTimeOut.Value = jsonInfo.TimeOutProxy;
            seAutoExitTool.Value = jsonInfo.AutoExit;
        }

        private void teSelecteLocation_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
