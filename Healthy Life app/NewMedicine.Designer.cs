namespace Healthy_Life_app
{
    partial class NewMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMedicine));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfig = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MedMethod = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MedUse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.MedSide = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.MedDef = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.Medname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.Header.Controls.Add(this.label11);
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.labelMini);
            this.Header.Controls.Add(this.lblClose);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(568, 43);
            this.Header.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(12, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(522, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 43);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 39;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "منصة اضافة دواء جديد";
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.MedMethod);
            this.panel1.Controls.Add(this.MedUse);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MedSide);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MedDef);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Medname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 1088);
            this.panel1.TabIndex = 6;
            // 
            // btnConfig
            // 
            this.btnConfig.ActiveBorderThickness = 1;
            this.btnConfig.ActiveCornerRadius = 20;
            this.btnConfig.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfig.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConfig.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.ButtonText = "ارسل";
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.IdleBorderThickness = 1;
            this.btnConfig.IdleCornerRadius = 20;
            this.btnConfig.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.IdleForecolor = System.Drawing.Color.Blue;
            this.btnConfig.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfig.Location = new System.Drawing.Point(121, 996);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(301, 49);
            this.btnConfig.TabIndex = 39;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // MedMethod
            // 
            this.MedMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MedMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MedMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MedMethod.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MedMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedMethod.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.MedMethod.HintText = "اشرح بإختصار طريقة استخدام الدواء والجرعات ...";
            this.MedMethod.isPassword = false;
            this.MedMethod.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.MedMethod.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.MedMethod.LineMouseHoverColor = System.Drawing.SystemColors.WindowFrame;
            this.MedMethod.LineThickness = 3;
            this.MedMethod.Location = new System.Drawing.Point(17, 764);
            this.MedMethod.Margin = new System.Windows.Forms.Padding(4);
            this.MedMethod.MaxLength = 32767;
            this.MedMethod.Name = "MedMethod";
            this.MedMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedMethod.Size = new System.Drawing.Size(504, 215);
            this.MedMethod.TabIndex = 35;
            this.MedMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MedUse
            // 
            this.MedUse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MedUse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MedUse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MedUse.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MedUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedUse.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.MedUse.HintText = "اشرح بإختصار استخدامات الدواء ..";
            this.MedUse.isPassword = false;
            this.MedUse.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.MedUse.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.MedUse.LineMouseHoverColor = System.Drawing.SystemColors.WindowFrame;
            this.MedUse.LineThickness = 3;
            this.MedUse.Location = new System.Drawing.Point(17, 530);
            this.MedUse.Margin = new System.Windows.Forms.Padding(4);
            this.MedUse.MaxLength = 32767;
            this.MedUse.Name = "MedUse";
            this.MedUse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedUse.Size = new System.Drawing.Size(504, 178);
            this.MedUse.TabIndex = 36;
            this.MedUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(373, 725);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(154, 34);
            this.label6.TabIndex = 29;
            this.label6.Text = "كيف استخدم الدواء";
            // 
            // MedSide
            // 
            this.MedSide.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MedSide.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MedSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MedSide.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MedSide.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedSide.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.MedSide.HintText = "اشرح بإختصار الاعراض الجانبية للدواء ..";
            this.MedSide.isPassword = false;
            this.MedSide.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.MedSide.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.MedSide.LineMouseHoverColor = System.Drawing.SystemColors.WindowFrame;
            this.MedSide.LineThickness = 3;
            this.MedSide.Location = new System.Drawing.Point(17, 287);
            this.MedSide.Margin = new System.Windows.Forms.Padding(4);
            this.MedSide.MaxLength = 32767;
            this.MedSide.Name = "MedSide";
            this.MedSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedSide.Size = new System.Drawing.Size(504, 192);
            this.MedSide.TabIndex = 37;
            this.MedSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(342, 492);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(185, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "ماهي استخدامات الدواء";
            // 
            // MedDef
            // 
            this.MedDef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MedDef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MedDef.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MedDef.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MedDef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedDef.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.MedDef.HintText = "اشرح بإختصار التعريف بالدواء ...";
            this.MedDef.isPassword = false;
            this.MedDef.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.MedDef.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.MedDef.LineMouseHoverColor = System.Drawing.SystemColors.WindowFrame;
            this.MedDef.LineThickness = 3;
            this.MedDef.Location = new System.Drawing.Point(17, 112);
            this.MedDef.Margin = new System.Windows.Forms.Padding(4);
            this.MedDef.MaxLength = 32767;
            this.MedDef.Name = "MedDef";
            this.MedDef.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MedDef.Size = new System.Drawing.Size(504, 128);
            this.MedDef.TabIndex = 38;
            this.MedDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(352, 249);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(175, 34);
            this.label4.TabIndex = 31;
            this.label4.Text = "الأعراض الجانبية للدواء";
            // 
            // Medname
            // 
            this.Medname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Medname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Medname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Medname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Medname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Medname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medname.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Medname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Medname.HintText = "";
            this.Medname.isPassword = false;
            this.Medname.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.Medname.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.Medname.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.Medname.LineThickness = 2;
            this.Medname.Location = new System.Drawing.Point(172, 11);
            this.Medname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Medname.MaxLength = 32767;
            this.Medname.Name = "Medname";
            this.Medname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Medname.Size = new System.Drawing.Size(223, 34);
            this.Medname.TabIndex = 34;
            this.Medname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(408, 74);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(119, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "التعريف بالدواء";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(442, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "اسم الدواء";
            // 
            // NewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(585, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMedicine";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMini;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox MedMethod;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox MedUse;
        internal System.Windows.Forms.Label label6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox MedSide;
        internal System.Windows.Forms.Label label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox MedDef;
        internal System.Windows.Forms.Label label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox Medname;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfig;
        private System.Windows.Forms.Label label11;
    }
}