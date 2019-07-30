namespace Australia_Scanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnfAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bnfOptions = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfProxy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfHomeModule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClose = new DevExpress.XtraEditors.LabelControl();
            this.lblMinimize = new DevExpress.XtraEditors.LabelControl();
            this.lblDisplayName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tmrExitTool = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.bnfAbout);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bnfOptions);
            this.panel1.Controls.Add(this.bnfProxy);
            this.panel1.Controls.Add(this.bnfHomeModule);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 589);
            this.panel1.TabIndex = 0;
            // 
            // bnfAbout
            // 
            this.bnfAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfAbout.BorderRadius = 0;
            this.bnfAbout.ButtonText = "                 About";
            this.bnfAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfAbout.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnfAbout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfAbout.Iconimage = null;
            this.bnfAbout.Iconimage_right = null;
            this.bnfAbout.Iconimage_right_Selected = null;
            this.bnfAbout.Iconimage_Selected = null;
            this.bnfAbout.IconMarginLeft = 0;
            this.bnfAbout.IconMarginRight = 0;
            this.bnfAbout.IconRightVisible = true;
            this.bnfAbout.IconRightZoom = 0D;
            this.bnfAbout.IconVisible = true;
            this.bnfAbout.IconZoom = 90D;
            this.bnfAbout.IsTab = false;
            this.bnfAbout.Location = new System.Drawing.Point(0, 268);
            this.bnfAbout.Margin = new System.Windows.Forms.Padding(4);
            this.bnfAbout.Name = "bnfAbout";
            this.bnfAbout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfAbout.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfAbout.selected = false;
            this.bnfAbout.Size = new System.Drawing.Size(247, 68);
            this.bnfAbout.TabIndex = 5;
            this.bnfAbout.Text = "                 About";
            this.bnfAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfAbout.Textcolor = System.Drawing.Color.White;
            this.bnfAbout.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfAbout.Click += new System.EventHandler(this.bnfAbout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 578);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 11);
            this.panel4.TabIndex = 4;
            // 
            // bnfOptions
            // 
            this.bnfOptions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfOptions.BorderRadius = 0;
            this.bnfOptions.ButtonText = "                 Options";
            this.bnfOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfOptions.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnfOptions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfOptions.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfOptions.Iconimage = null;
            this.bnfOptions.Iconimage_right = null;
            this.bnfOptions.Iconimage_right_Selected = null;
            this.bnfOptions.Iconimage_Selected = null;
            this.bnfOptions.IconMarginLeft = 0;
            this.bnfOptions.IconMarginRight = 0;
            this.bnfOptions.IconRightVisible = true;
            this.bnfOptions.IconRightZoom = 0D;
            this.bnfOptions.IconVisible = true;
            this.bnfOptions.IconZoom = 90D;
            this.bnfOptions.IsTab = false;
            this.bnfOptions.Location = new System.Drawing.Point(0, 200);
            this.bnfOptions.Margin = new System.Windows.Forms.Padding(4);
            this.bnfOptions.Name = "bnfOptions";
            this.bnfOptions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfOptions.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfOptions.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfOptions.selected = false;
            this.bnfOptions.Size = new System.Drawing.Size(247, 68);
            this.bnfOptions.TabIndex = 3;
            this.bnfOptions.Text = "                 Options";
            this.bnfOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfOptions.Textcolor = System.Drawing.Color.White;
            this.bnfOptions.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfOptions.Click += new System.EventHandler(this.bndAbout_Click);
            // 
            // bnfProxy
            // 
            this.bnfProxy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfProxy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfProxy.BorderRadius = 0;
            this.bnfProxy.ButtonText = "                  Proxy";
            this.bnfProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfProxy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfProxy.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnfProxy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfProxy.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfProxy.Iconimage = null;
            this.bnfProxy.Iconimage_right = null;
            this.bnfProxy.Iconimage_right_Selected = null;
            this.bnfProxy.Iconimage_Selected = null;
            this.bnfProxy.IconMarginLeft = 0;
            this.bnfProxy.IconMarginRight = 0;
            this.bnfProxy.IconRightVisible = true;
            this.bnfProxy.IconRightZoom = 0D;
            this.bnfProxy.IconVisible = true;
            this.bnfProxy.IconZoom = 90D;
            this.bnfProxy.IsTab = false;
            this.bnfProxy.Location = new System.Drawing.Point(0, 132);
            this.bnfProxy.Margin = new System.Windows.Forms.Padding(4);
            this.bnfProxy.Name = "bnfProxy";
            this.bnfProxy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfProxy.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfProxy.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfProxy.selected = false;
            this.bnfProxy.Size = new System.Drawing.Size(247, 68);
            this.bnfProxy.TabIndex = 3;
            this.bnfProxy.Text = "                  Proxy";
            this.bnfProxy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfProxy.Textcolor = System.Drawing.Color.White;
            this.bnfProxy.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfProxy.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // bnfHomeModule
            // 
            this.bnfHomeModule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfHomeModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfHomeModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfHomeModule.BorderRadius = 0;
            this.bnfHomeModule.ButtonText = "                  Home";
            this.bnfHomeModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfHomeModule.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfHomeModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnfHomeModule.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfHomeModule.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfHomeModule.Iconimage = null;
            this.bnfHomeModule.Iconimage_right = null;
            this.bnfHomeModule.Iconimage_right_Selected = null;
            this.bnfHomeModule.Iconimage_Selected = null;
            this.bnfHomeModule.IconMarginLeft = 0;
            this.bnfHomeModule.IconMarginRight = 0;
            this.bnfHomeModule.IconRightVisible = true;
            this.bnfHomeModule.IconRightZoom = 0D;
            this.bnfHomeModule.IconVisible = true;
            this.bnfHomeModule.IconZoom = 90D;
            this.bnfHomeModule.IsTab = false;
            this.bnfHomeModule.Location = new System.Drawing.Point(0, 64);
            this.bnfHomeModule.Margin = new System.Windows.Forms.Padding(4);
            this.bnfHomeModule.Name = "bnfHomeModule";
            this.bnfHomeModule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bnfHomeModule.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfHomeModule.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfHomeModule.selected = false;
            this.bnfHomeModule.Size = new System.Drawing.Size(247, 68);
            this.bnfHomeModule.TabIndex = 2;
            this.bnfHomeModule.Text = "                  Home";
            this.bnfHomeModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnfHomeModule.Textcolor = System.Drawing.Color.White;
            this.bnfHomeModule.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfHomeModule.Click += new System.EventHandler(this.bnfHomeModule_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(75)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 64);
            this.panel3.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(30, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(188, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Australia Scanner";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblClose);
            this.panel2.Controls.Add(this.lblMinimize);
            this.panel2.Controls.Add(this.lblDisplayName);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(247, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 64);
            this.panel2.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Appearance.Options.UseFont = true;
            this.lblClose.Appearance.Options.UseTextOptions = true;
            this.lblClose.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblClose.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblClose.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblClose.AppearanceHovered.Options.UseForeColor = true;
            this.lblClose.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClose.Location = new System.Drawing.Point(664, 18);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(34, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Appearance.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Appearance.Options.UseFont = true;
            this.lblMinimize.Appearance.Options.UseTextOptions = true;
            this.lblMinimize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMinimize.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMinimize.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblMinimize.AppearanceHovered.Options.UseForeColor = true;
            this.lblMinimize.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMinimize.Location = new System.Drawing.Point(639, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(26, 36);
            this.lblMinimize.TabIndex = 0;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Appearance.Options.UseFont = true;
            this.lblDisplayName.Appearance.Options.UseTextOptions = true;
            this.lblDisplayName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDisplayName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDisplayName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDisplayName.Location = new System.Drawing.Point(167, 17);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(408, 30);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Author : Tran Phuc";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Image = global::Australia_Scanner.Properties.Resources.youtube__3____Copy;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(59, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 25);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            this.labelControl3.MouseHover += new System.EventHandler(this.labelControl3_MouseHover);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Image = global::Australia_Scanner.Properties.Resources.home__2____Copy;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(17, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 30);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            this.labelControl2.MouseHover += new System.EventHandler(this.labelControl2_MouseHover);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(247, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(710, 525);
            this.panelControl1.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblDisplayName;
            this.bunifuDragControl2.Vertical = true;
            // 
            // tmrExitTool
            // 
            this.tmrExitTool.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 589);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblClose;
        private DevExpress.XtraEditors.LabelControl lblMinimize;
        private DevExpress.XtraEditors.LabelControl lblDisplayName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel4;
        public Bunifu.Framework.UI.BunifuFlatButton bnfHomeModule;
        public Bunifu.Framework.UI.BunifuFlatButton bnfOptions;
        public Bunifu.Framework.UI.BunifuFlatButton bnfProxy;
        public Bunifu.Framework.UI.BunifuFlatButton bnfAbout;
        private System.Windows.Forms.Timer tmrExitTool;
    }
}

