namespace Healthy_Life_app
{
    partial class FormForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPass));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConfig = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.Header.Controls.Add(this.label2);
            this.Header.Controls.Add(this.label5);
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.labelMini);
            this.Header.Controls.Add(this.lblClose);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(604, 37);
            this.Header.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(542, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(571, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "منصة تعديل كلمة المرور";
            // 
            // labelMini
            // 
            this.labelMini.AutoSize = true;
            this.labelMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMini.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMini.Location = new System.Drawing.Point(789, 2);
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
            this.lblClose.Location = new System.Drawing.Point(819, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 29);
            this.lblClose.TabIndex = 13;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonConfig);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 413);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(80, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "تأكد من كتابة الإيميل بشكل صحيح والا لن تتمكن من تعديل كلمة المرور";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(465, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConfig
            // 
            this.buttonConfig.ActiveBorderThickness = 1;
            this.buttonConfig.ActiveCornerRadius = 20;
            this.buttonConfig.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.buttonConfig.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfig.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.buttonConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfig.BackgroundImage")));
            this.buttonConfig.ButtonText = "تأكيد";
            this.buttonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.ForeColor = System.Drawing.Color.White;
            this.buttonConfig.IdleBorderThickness = 1;
            this.buttonConfig.IdleCornerRadius = 20;
            this.buttonConfig.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConfig.IdleForecolor = System.Drawing.Color.Blue;
            this.buttonConfig.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonConfig.Location = new System.Drawing.Point(85, 321);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(413, 49);
            this.buttonConfig.TabIndex = 26;
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(358, 160);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(146, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "ارفق البريد الإلكتروني :-";
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtemail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.LavenderBlush;
            this.txtemail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtemail.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtemail.LineThickness = 2;
            this.txtemail.Location = new System.Drawing.Point(94, 160);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtemail.Size = new System.Drawing.Size(223, 34);
            this.txtemail.TabIndex = 20;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass
            // 
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.LavenderBlush;
            this.txtPass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPass.HintText = "";
            this.txtPass.isPassword = true;
            this.txtPass.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtPass.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtPass.LineThickness = 2;
            this.txtPass.Location = new System.Drawing.Point(94, 232);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPass.Size = new System.Drawing.Size(223, 34);
            this.txtPass.TabIndex = 20;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(331, 232);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(173, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "ادخل كلمة المرور الجديدة :- ";
            // 
            // FormForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(604, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgetPass";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonConfig;
        internal System.Windows.Forms.Label label7;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtemail;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}