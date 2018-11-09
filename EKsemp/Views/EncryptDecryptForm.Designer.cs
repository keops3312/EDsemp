namespace EKsemp.Views
{
    partial class EncryptDecryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptDecryptForm));
            this.cmbSelect = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblcombo = new DevComponents.DotNetBar.LabelX();
            this.swtSelect = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lblselect = new DevComponents.DotNetBar.LabelX();
            this.lblencrypt = new DevComponents.DotNetBar.LabelX();
            this.lbldecrypt = new DevComponents.DotNetBar.LabelX();
            this.txtEncrypt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDecrypt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtResponse = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnlanguaje = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnDo = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelect
            // 
            this.cmbSelect.DisplayMember = "Text";
            this.cmbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.ItemHeight = 15;
            this.cmbSelect.Location = new System.Drawing.Point(42, 130);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(151, 21);
            this.cmbSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cmbSelect.TabIndex = 1;
            // 
            // lblcombo
            // 
            // 
            // 
            // 
            this.lblcombo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblcombo.Location = new System.Drawing.Point(42, 101);
            this.lblcombo.Name = "lblcombo";
            this.lblcombo.Size = new System.Drawing.Size(371, 23);
            this.lblcombo.TabIndex = 2;
            this.lblcombo.Text = "-";
            // 
            // swtSelect
            // 
            // 
            // 
            // 
            this.swtSelect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.swtSelect.Location = new System.Drawing.Point(265, 171);
            this.swtSelect.Name = "swtSelect";
            this.swtSelect.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.swtSelect.OffText = "Desencryptar";
            this.swtSelect.OffTextColor = System.Drawing.Color.White;
            this.swtSelect.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.swtSelect.OnText = "Encryptar";
            this.swtSelect.OnTextColor = System.Drawing.Color.White;
            this.swtSelect.Size = new System.Drawing.Size(148, 38);
            this.swtSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtSelect.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.swtSelect.SwitchBorderColor = System.Drawing.Color.Teal;
            this.swtSelect.TabIndex = 2;
            this.swtSelect.ValueChanged += new System.EventHandler(this.swtSelect_ValueChanged);
            // 
            // lblselect
            // 
            // 
            // 
            // 
            this.lblselect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblselect.Location = new System.Drawing.Point(42, 168);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(217, 54);
            this.lblselect.TabIndex = 5;
            this.lblselect.Text = "-";
            // 
            // lblencrypt
            // 
            // 
            // 
            // 
            this.lblencrypt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblencrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblencrypt.Location = new System.Drawing.Point(42, 228);
            this.lblencrypt.Name = "lblencrypt";
            this.lblencrypt.Size = new System.Drawing.Size(371, 23);
            this.lblencrypt.TabIndex = 6;
            this.lblencrypt.Text = "-";
            // 
            // lbldecrypt
            // 
            // 
            // 
            // 
            this.lbldecrypt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbldecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbldecrypt.Location = new System.Drawing.Point(42, 318);
            this.lbldecrypt.Name = "lbldecrypt";
            this.lbldecrypt.Size = new System.Drawing.Size(371, 23);
            this.lbldecrypt.TabIndex = 7;
            this.lbldecrypt.Text = "-";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.txtEncrypt.Border.Class = "TextBoxBorder";
            this.txtEncrypt.Border.CornerDiameter = 30;
            this.txtEncrypt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtEncrypt.ForeColor = System.Drawing.Color.White;
            this.txtEncrypt.Location = new System.Drawing.Point(42, 257);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.PreventEnterBeep = true;
            this.txtEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEncrypt.Size = new System.Drawing.Size(371, 55);
            this.txtEncrypt.TabIndex = 3;
            this.txtEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.txtDecrypt.Border.Class = "TextBoxBorder";
            this.txtDecrypt.Border.CornerDiameter = 30;
            this.txtDecrypt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtDecrypt.ForeColor = System.Drawing.Color.White;
            this.txtDecrypt.Location = new System.Drawing.Point(42, 347);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.PreventEnterBeep = true;
            this.txtDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDecrypt.Size = new System.Drawing.Size(371, 58);
            this.txtDecrypt.TabIndex = 4;
            this.txtDecrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.txtResponse.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtResponse.Border.BorderColor = System.Drawing.Color.Aquamarine;
            this.txtResponse.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtResponse.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtResponse.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtResponse.Border.Class = "TextBoxBorder";
            this.txtResponse.Border.CornerDiameter = 30;
            this.txtResponse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtResponse.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResponse.ForeColor = System.Drawing.Color.White;
            this.txtResponse.Location = new System.Drawing.Point(42, 488);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.PreventEnterBeep = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResponse.Size = new System.Drawing.Size(371, 63);
            this.txtResponse.TabIndex = 6;
            this.txtResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResponse.WatermarkColor = System.Drawing.SystemColors.Control;
            // 
            // btnlanguaje
            // 
            this.btnlanguaje.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlanguaje.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlanguaje.Location = new System.Drawing.Point(183, 72);
            this.btnlanguaje.Name = "btnlanguaje";
            this.btnlanguaje.Size = new System.Drawing.Size(157, 23);
            this.btnlanguaje.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlanguaje.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.btnlanguaje.TabIndex = 0;
            this.btnlanguaje.Text = "-";
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Image = global::EKsemp.Properties.Resources.usa_circle_flat;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "US";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.GlobalItem = false;
            this.buttonItem2.Image = global::EKsemp.Properties.Resources.mexico_circle_flat;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "MEX";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::EKsemp.Properties.Resources.encryption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnClose.Image = global::EKsemp.Properties.Resources.close;
            this.BtnClose.ImageFixedSize = new System.Drawing.Size(48, 48);
            this.BtnClose.Location = new System.Drawing.Point(398, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnClose.Size = new System.Drawing.Size(48, 45);
            this.BtnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDo
            // 
            this.btnDo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDo.BackColor = System.Drawing.Color.Transparent;
            this.btnDo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDo.Image = global::EKsemp.Properties.Resources.resolv;
            this.btnDo.ImageFixedSize = new System.Drawing.Size(48, 48);
            this.btnDo.Location = new System.Drawing.Point(183, 411);
            this.btnDo.Name = "btnDo";
            this.btnDo.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnDo.Size = new System.Drawing.Size(76, 71);
            this.btnDo.SplitButton = true;
            this.btnDo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDo.TabIndex = 5;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(108, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(249, 45);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "EncryptDecrypt SEMP";
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.MintCream;
            this.line1.Location = new System.Drawing.Point(106, 52);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(234, 23);
            this.line1.TabIndex = 19;
            this.line1.Text = "line1";
            // 
            // EncryptDecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(458, 577);
            this.ControlBox = false;
            this.Controls.Add(this.line1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnlanguaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lbldecrypt);
            this.Controls.Add(this.lblencrypt);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.swtSelect);
            this.Controls.Add(this.lblcombo);
            this.Controls.Add(this.cmbSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptDecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptDecryptForm";
            this.Load += new System.EventHandler(this.EncryptDecryptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSelect;
        private DevComponents.DotNetBar.LabelX lblcombo;
        private DevComponents.DotNetBar.Controls.SwitchButton swtSelect;
        private DevComponents.DotNetBar.LabelX lblselect;
        private DevComponents.DotNetBar.LabelX lblencrypt;
        private DevComponents.DotNetBar.LabelX lbldecrypt;
        private DevComponents.DotNetBar.ButtonX btnDo;
        private DevComponents.DotNetBar.ButtonX BtnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEncrypt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDecrypt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResponse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnlanguaje;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line1;
    }
}