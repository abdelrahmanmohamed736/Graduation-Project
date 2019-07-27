namespace Healthy_Life_app
{
    partial class FormConsulting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulting));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.buttonHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPersonal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonParts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonHealth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(834, 37);
            this.Header.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "منصة استشاراتي الصحية";
            // 
            // labelMini
            // 
            this.labelMini.AutoSize = true;
            this.labelMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMini.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMini.Location = new System.Drawing.Point(773, 2);
            this.labelMini.Name = "labelMini";
            this.labelMini.Size = new System.Drawing.Size(26, 29);
            this.labelMini.TabIndex = 13;
            this.labelMini.Text = "_";
            this.labelMini.Click += new System.EventHandler(this.labelMini_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClose.Location = new System.Drawing.Point(802, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 29);
            this.lblClose.TabIndex = 13;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Menu.Controls.Add(this.buttonHelp);
            this.Menu.Controls.Add(this.buttonPersonal);
            this.Menu.Controls.Add(this.buttonParts);
            this.Menu.Controls.Add(this.buttonHealth);
            this.Menu.Controls.Add(this.lbluser);
            this.Menu.Controls.Add(this.btnMenu);
            this.Menu.Controls.Add(this.UserPic);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.Location = new System.Drawing.Point(568, 37);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(266, 518);
            this.Menu.TabIndex = 4;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Active = false;
            this.buttonHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.buttonHelp.Location = new System.Drawing.Point(0, 413);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHelp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonHelp.selected = false;
            this.buttonHelp.Size = new System.Drawing.Size(262, 48);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = " المساعدة";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelp.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Active = true;
            this.buttonPersonal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.buttonPersonal.Location = new System.Drawing.Point(1, 200);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPersonal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPersonal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPersonal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonPersonal.selected = true;
            this.buttonPersonal.Size = new System.Drawing.Size(262, 48);
            this.buttonPersonal.TabIndex = 4;
            this.buttonPersonal.Text = "  حسابي        ";
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
            this.buttonParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.buttonParts.Location = new System.Drawing.Point(0, 271);
            this.buttonParts.Name = "buttonParts";
            this.buttonParts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonParts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonParts.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonParts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonParts.selected = false;
            this.buttonParts.Size = new System.Drawing.Size(262, 48);
            this.buttonParts.TabIndex = 4;
            this.buttonParts.Text = "  الأقسام";
            this.buttonParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParts.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonParts.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParts.Click += new System.EventHandler(this.buttonParts_Click);
            // 
            // buttonHealth
            // 
            this.buttonHealth.Active = false;
            this.buttonHealth.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHealth.BorderRadius = 0;
            this.buttonHealth.ButtonText = "  استشاراتي الصحية ";
            this.buttonHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHealth.DisabledColor = System.Drawing.Color.Gray;
            this.buttonHealth.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonHealth.Iconimage = null;
            this.buttonHealth.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("buttonHealth.Iconimage_right")));
            this.buttonHealth.Iconimage_right_Selected = null;
            this.buttonHealth.Iconimage_Selected = null;
            this.buttonHealth.IconMarginLeft = 0;
            this.buttonHealth.IconMarginRight = 0;
            this.buttonHealth.IconRightVisible = true;
            this.buttonHealth.IconRightZoom = 0D;
            this.buttonHealth.IconVisible = true;
            this.buttonHealth.IconZoom = 65D;
            this.buttonHealth.IsTab = true;
            this.buttonHealth.Location = new System.Drawing.Point(0, 342);
            this.buttonHealth.Name = "buttonHealth";
            this.buttonHealth.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHealth.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonHealth.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonHealth.selected = false;
            this.buttonHealth.Size = new System.Drawing.Size(262, 48);
            this.buttonHealth.TabIndex = 4;
            this.buttonHealth.Text = "  استشاراتي الصحية ";
            this.buttonHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHealth.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.buttonHealth.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHealth.Click += new System.EventHandler(this.buttonHealth_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Silver;
            this.lbluser.Location = new System.Drawing.Point(94, 131);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(87, 24);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "اسم المستخدم";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(17, 55);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            // 
            // UserPic
            // 
            this.UserPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserPic.BackgroundImage")));
            this.UserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPic.Location = new System.Drawing.Point(67, 21);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(133, 100);
            this.UserPic.TabIndex = 0;
            this.UserPic.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(145, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "لا توجد اي استشارات صحية لديك حتي الآن";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(397, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormConsulting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(834, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsulting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsulting";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Menu;
        private Bunifu.Framework.UI.BunifuFlatButton buttonHelp;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPersonal;
        private Bunifu.Framework.UI.BunifuFlatButton buttonParts;
        private Bunifu.Framework.UI.BunifuFlatButton buttonHealth;
        internal System.Windows.Forms.Label lbluser;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox UserPic;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMini;
        private System.Windows.Forms.Label lblClose;
    }
}