using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using thanhps42.Common;
using FoxLearn.License;

namespace Australia_Scanner
{
    static class Program
    {
        public static string licensePath => Application.StartupPath + "\\license.eth";
        public static string passwordToEncryptKey = "vdrE:Y445&t2g23>@$L##''gr<%^?<:P)%Kh6L886>JH$%J<H$K%H;;cDtiAPLhS%";
        private static string _computerId;
        public static string ComputerId
        {
            get
            {
                return _computerId;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _computerId = ComputerInfo.GetComputerId();
            unclocker.Join();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new Form1());
        }
    }
}
