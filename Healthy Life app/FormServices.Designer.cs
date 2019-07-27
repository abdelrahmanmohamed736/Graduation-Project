namespace Healthy_Life_app
{
    partial class FormServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.buttonHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPersonal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonParts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox2 = new Bunifu.Framework.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox3 = new Bunifu.Framework.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.RoyalBlue;
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.labelMini);
            this.Header.Controls.Add(this.lblClose);
            resources.ApplyResources(this.Header, "Header");
            this.Header.Name = "Header";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // labelMini
            // 
            resources.ApplyResources(this.labelMini, "labelMini");
            this.labelMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMini.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMini.Name = "labelMini";
            this.labelMini.Click += new System.EventHandler(this.labelMini_Click);
            // 
            // lblClose
            // 
            resources.ApplyResources(this.lblClose, "lblClose");
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClose.Name = "lblClose";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Menu.Controls.Add(this.lbluser);
            this.Menu.Controls.Add(this.buttonHelp);
            this.Menu.Controls.Add(this.buttonPersonal);
            this.Menu.Controls.Add(this.buttonParts);
            this.Menu.Controls.Add(this.btnMenu);
            this.Menu.Controls.Add(this.UserPic);
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Name = "Menu";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Active = false;
            this.buttonHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.BorderRadius = 0;
            this.buttonHelp.ButtonText = " المساعدة";
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.DisabledColor = System.Drawing.Color.Gray;
            this.buttonHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonHelp.Iconimage = null;
            this.buttonHelp.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Iconimage_right")));
            this.buttonHelp.Iconimage_right_Selected = null;
            this.buttonHelp.Iconimage_Selected = null;
            this.buttonHelp.IconMarginLeft = 0;
            this.buttonHelp.IconMarginRight = 0;
            this.buttonHelp.IconRightVisible = true;
            this.buttonHelp.IconRightZoom = 0D;
            this.buttonHelp.IconVisible = true;
            this.buttonHelp.IconZoom = 90D;
            this.buttonHelp.IsTab = true;
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHelp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonHelp.selected = false;
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelp.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Active = true;
            this.buttonPersonal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.buttonPersonal, "buttonPersonal");
            this.buttonPersonal.BorderRadius = 0;
            this.buttonPersonal.ButtonText = "  حسابي        ";
            this.buttonPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPersonal.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPersonal.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPersonal.Iconimage = null;
            this.buttonPersonal.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("buttonPersonal.Iconimage_right")));
            this.buttonPersonal.Iconimage_right_Selected = null;
            this.buttonPersonal.Iconimage_Selected = null;
            this.buttonPersonal.IconMarginLeft = 0;
            this.buttonPersonal.IconMarginRight = 0;
            this.buttonPersonal.IconRightVisible = true;
            this.buttonPersonal.IconRightZoom = 0D;
            this.buttonPersonal.IconVisible = true;
            this.buttonPersonal.IconZoom = 65D;
            this.buttonPersonal.IsTab = true;
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPersonal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPersonal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPersonal.selected = true;
            this.buttonPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonal.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonPersonal.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonParts
            // 
            this.buttonParts.Active = false;
            this.buttonParts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.buttonParts, "buttonParts");
            this.buttonParts.BorderRadius = 0;
            this.buttonParts.ButtonText = "  الأقسام";
            this.buttonParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonParts.DisabledColor = System.Drawing.Color.Gray;
            this.buttonParts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonParts.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonParts.Iconimage = null;
            this.buttonParts.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("buttonParts.Iconimage_right")));
            this.buttonParts.Iconimage_right_Selected = null;
            this.buttonParts.Iconimage_Selected = null;
            this.buttonParts.IconMarginLeft = 0;
            this.buttonParts.IconMarginRight = 0;
            this.buttonParts.IconRightVisible = true;
            this.buttonParts.IconRightZoom = 0D;
            this.buttonParts.IconVisible = true;
            this.buttonParts.IconZoom = 65D;
            this.buttonParts.IsTab = true;
            this.buttonParts.Name = "buttonParts";
            this.buttonParts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonParts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonParts.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonParts.selected = false;
            this.buttonParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParts.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonParts.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParts.Click += new System.EventHandler(this.buttonParts_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.ImageActive = null;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            // 
            // UserPic
            // 
            resources.ApplyResources(this.UserPic, "UserPic");
            this.UserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPic.Name = "UserPic";
            this.UserPic.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.bunifuCustomTextbox2, "bunifuCustomTextbox2");
            this.bunifuCustomTextbox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.bunifuCustomTextbox2.HideSelection = false;
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.ReadOnly = true;
            this.bunifuCustomTextbox2.HideSelectionChanged += new System.EventHandler(this.bunifuCustomTextbox1_HideSelectionChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.bunifuCustomTextbox3, "bunifuCustomTextbox3");
            this.bunifuCustomTextbox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.bunifuCustomTextbox3.HideSelection = false;
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.ReadOnly = true;
            this.bunifuCustomTextbox3.HideSelectionChanged += new System.EventHandler(this.bunifuCustomTextbox1_HideSelectionChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // lbluser
            // 
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbluser, "lbluser");
            this.lbluser.ForeColor = System.Drawing.Color.Silver;
            this.lbluser.Name = "lbluser";
            // 
            // FormServices
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.bunifuCustomTextbox3);
            this.Controls.Add(this.bunifuCustomTextbox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServices";
            this.Load += new System.EventHandler(this.FormServices_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel Menu;
        private Bunifu.Framework.UI.BunifuFlatButton buttonHelp;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPersonal;
        private Bunifu.Framework.UI.BunifuFlatButton buttonParts;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox UserPic;
        internal System.Windows.Forms.Label label1;
        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox2;
        internal System.Windows.Forms.Label label4;
        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lbluser;
    }
}