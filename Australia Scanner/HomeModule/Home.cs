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
using System.Threading;
using Newtonsoft.Json;
using Australia_Scanner.SaveOptionModule;
using System.IO;
using System.Diagnostics;

namespace Australia_Scanner.HomeModule
{
    public partial class Home : DevExpress.XtraEditors.XtraUserControl
    {
        public AustraliaScanner scanner = new AustraliaScanner();
        public bool onScan = true;
        public Home()
        {
            InitializeComponent();
            LoadDefaultInfo();
            scanner.LoadInfoToGrid += Scanner_LoadInfoToGrid;
            scanner.CaculateInfo += Scanner_CaculateInfo;
        }

        private void Scanner_CaculateInfo(object sender, Event.CaculatePercentEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                bcpProgress.Value = Convert.ToInt32(Math.Round(((double)e.NumverCurrentInfo / Convert.ToInt32(seNumber.Value)) * 100, 0));
                bcpProgress.Refresh();
            }));
        }

        private void Scanner_LoadInfoToGrid(object sender, Event.LoadInfoToGridEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                gridControl1.DataSource = e.Info;
                gridControl1.RefreshDataSource();
            }));
        }

        public void LoadDefaultInfo()
        {
            lblStatus.Text = "READY...";
            teElapsedTime.Text = "00:00:00";
            bcpProgress.Value = 0;
            blbPaused.Enabled = blbStop.Enabled = false;

            var stateSouce = HomeStatic.Instance.ListAuStates();
            leStates.Properties.DataSource = stateSouce;
            leStates.EditValue = stateSouce[0];

            leCountry.Properties.DataSource = HomeStatic.Instance.Country();
            leCountry.EditValue = HomeStatic.Instance.Country()[0];

            var proxy = SettingStatic.Instance.GetSshFiles();
            leSsh.Properties.DataSource = proxy;
            leSsh.EditValue = proxy[0];

            var listInfo = new List<PersonalDetails>();
            gridControl1.DataSource = listInfo; gridView1.Columns["Email"].Visible = false;
            gridView1.Columns["State"].Width = 35;
            gridView1.Columns["Zipcode"].Width = 55;
            gridView1.Columns["DOB"].Width = 55;
            gridView1.Columns["City"].Width = 55;
        }
        private void blbStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\st.js")) { XtraMessageBox.Show("File 'save results' not found !!\r\nConfigure 'Options' Tab first before start.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            var contentSettings = File.ReadAllText(Application.StartupPath + "\\st.js");
            if (string.IsNullOrEmpty(contentSettings))
            { XtraMessageBox.Show("File 'save results' not found !!\r\nConfigure 'Options' Tab first before start.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            OnDisableFuntions();
            lblStatus.Text = "RUNNING...";
            new Thread(() =>
            {
                scanner.ScanInfo(new StartInfo
                {
                    State = leStates.EditValue.ToString(),
                    NumberInfo = Convert.ToInt32(seNumber.Value),
                    ProxySelected = leSsh.EditValue.ToString(),
                    Name = teName.Text,
                });
                OnEnableFuntions();
                XtraMessageBox.Show("Complete !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            })
            { IsBackground = true }.Start();
        }

        private void OnDisableFuntions()
        {
            blbPaused.Enabled = blbStop.Enabled = true;
            tmrElapsedTime.Start();
            blbReset.Enabled = false;
            blbStart.Enabled = false;
            tmrExitTool.Start();
            (this.FindForm() as Form1).bnfHomeModule.Enabled = false;
            (this.FindForm() as Form1).bnfProxy.Enabled = false;
            (this.FindForm() as Form1).bnfOptions.Enabled = false;
            (this.FindForm() as Form1).bnfAbout.Enabled = false;
        }
        private void OnEnableFuntions()
        {
            blbPaused.Enabled = blbStop.Enabled = false;
            ElapsedTime = 0;
            tmrElapsedTime.Stop();
            blbReset.Enabled = true;
            blbStart.Enabled = true;
            (this.FindForm() as Form1).bnfHomeModule.Enabled = true;
            (this.FindForm() as Form1).bnfProxy.Enabled = true;
            (this.FindForm() as Form1).bnfOptions.Enabled = true;
            (this.FindForm() as Form1).bnfAbout.Enabled = true;
        }

        private void blbPaused_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lblStatus.Text = scanner.isPause == false ? "PAUSED" : "RUNNING...";
            scanner.isPause = !scanner.isPause;
        }

        private void blbStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scanner.isPause = false;
            lblStatus.Text = "STOPPED";
            scanner.isStop = true;
        }

        public int countDownToExit;
        private int ElapsedTime;
        private void tmrExitTool_Tick(object sender, EventArgs e)
        {
            countDownToExit++;
            var content = File.ReadAllText(Application.StartupPath + "\\st.js");
            var timeExit = JsonConvert.DeserializeObject<InfoSave>(content).AutoExit;
            if (timeExit * 60 == countDownToExit) Application.Exit();
        }

        private void tmrElapsedTime_Tick(object sender, EventArgs e)
        {
            ElapsedTime++;
            var timeToDisplay = TimeSpan.FromSeconds(ElapsedTime).ToString("hh\\:mm\\:ss");
            teElapsedTime.Text = timeToDisplay;
        }

        private void blbReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDefaultInfo();
        }

        private void sbExportText_Click(object sender, EventArgs e)
        {
            var rowSlected = GridviewExtension.GetSelectedRows<InfoDisplayOnGridView>(gridView1)?.ToList();
            if (rowSlected.Count.Equals(0)) return;
            var ofd = new OpenFileDialog();
            ofd.Filter = "File text|*.txt";
            ofd.Title = "File text";

            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            var builder = new StringBuilder();
            rowSlected.ForEach(item => builder.AppendLine($"{item.Name}|{item.Address}|{item.Zipcode}|{item.City}|{item.State}|{item.PhoneNumber}|{item.Email}|{item.DOB}"));
            File.WriteAllText(ofd.FileName, builder.ToString());
            var openConfirm = XtraMessageBox.Show($"Save Success! Open File {ofd.FileName} ?", "Messgae", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (openConfirm.Equals(DialogResult.Cancel)) return;
            Process.Start(ofd.FileName);
        }

        private void sbExportExcel_Click(object sender, EventArgs e)
        {
            var rowSlected = GridviewExtension.GetSelectedRows<InfoDisplayOnGridView>(gridView1)?.ToList();
            if (rowSlected.Count.Equals(0)) return;
            var ofd = new OpenFileDialog();
            ofd.Filter = "File text|*.csv;*.xlsx";
            ofd.Title = "File text";

            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            var builder = new StringBuilder();
            rowSlected.ForEach(item => builder.AppendLine($"{item.Name},{item.Address},{item.Zipcode},{item.City},{item.State},{item.PhoneNumber},{item.Email},{item.DOB}"));
            File.WriteAllText(ofd.FileName, builder.ToString());
            var openConfirm = XtraMessageBox.Show($"Save Success! Open File {ofd.FileName} ?", "Messgae", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (openConfirm.Equals(DialogResult.Cancel)) return;
            Process.Start(ofd.FileName);
        }
    }
}
