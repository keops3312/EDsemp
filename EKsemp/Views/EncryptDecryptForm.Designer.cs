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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.swtSelect = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lblselect = new DevComponents.DotNetBar.LabelX();
            this.lblencrypt = new DevComponents.DotNetBar.LabelX();
            this.lbldecrypt = new DevComponents.DotNetBar.LabelX();
            this.btnDo = new DevComponents.DotNetBar.ButtonX();
            this.BtnClose = new DevComponents.DotNetBar.ButtonX();
            this.actIndicator = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.txtEncrypt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDecrypt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtResponse = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelect
            // 
            this.cmbSelect.DisplayMember = "Text";
            this.cmbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.ItemHeight = 14;
            this.cmbSelect.Location = new System.Drawing.Point(42, 130);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(371, 20);
            this.cmbSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSelect.TabIndex = 1;
            // 
            // lblcombo
            // 
            // 
            // 
            // 
            this.lblcombo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblcombo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcombo.Location = new System.Drawing.Point(42, 101);
            this.lblcombo.Name = "lblcombo";
            this.lblcombo.Size = new System.Drawing.Size(371, 23);
            this.lblcombo.TabIndex = 2;
            this.lblcombo.Text = "labelX1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EKsemp.Properties.Resources.Header_Encryption;
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // swtSelect
            // 
            // 
            // 
            // 
            this.swtSelect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swtSelect.Location = new System.Drawing.Point(265, 187);
            this.swtSelect.Name = "swtSelect";
            this.swtSelect.OffText = "Desencryptar";
            this.swtSelect.OnText = "Encryptar";
            this.swtSelect.Size = new System.Drawing.Size(148, 22);
            this.swtSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtSelect.TabIndex = 4;
            // 
            // lblselect
            // 
            // 
            // 
            // 
            this.lblselect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblselect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblselect.Location = new System.Drawing.Point(42, 156);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(217, 54);
            this.lblselect.TabIndex = 5;
            this.lblselect.Text = "labelX1";
            // 
            // lblencrypt
            // 
            // 
            // 
            // 
            this.lblencrypt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblencrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblencrypt.Location = new System.Drawing.Point(42, 248);
            this.lblencrypt.Name = "lblencrypt";
            this.lblencrypt.Size = new System.Drawing.Size(371, 23);
            this.lblencrypt.TabIndex = 6;
            this.lblencrypt.Text = "labelX2";
            // 
            // lbldecrypt
            // 
            // 
            // 
            // 
            this.lbldecrypt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbldecrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldecrypt.Location = new System.Drawing.Point(42, 318);
            this.lbldecrypt.Name = "lbldecrypt";
            this.lbldecrypt.Size = new System.Drawing.Size(371, 23);
            this.lbldecrypt.TabIndex = 7;
            this.lbldecrypt.Text = "labelX3";
            // 
            // btnDo
            // 
            this.btnDo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDo.Location = new System.Drawing.Point(303, 391);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(110, 33);
            this.btnDo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDo.TabIndex = 8;
            this.btnDo.Text = "buttonX1";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnClose.Location = new System.Drawing.Point(390, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(47, 31);
            this.BtnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "buttonX2";
            this.BtnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // actIndicator
            // 
            // 
            // 
            // 
            this.actIndicator.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.actIndicator.Location = new System.Drawing.Point(191, 228);
            this.actIndicator.Name = "actIndicator";
            this.actIndicator.Size = new System.Drawing.Size(75, 23);
            this.actIndicator.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.actIndicator.TabIndex = 10;
            // 
            // txtEncrypt
            // 
            // 
            // 
            // 
            this.txtEncrypt.Border.Class = "TextBoxBorder";
            this.txtEncrypt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEncrypt.Location = new System.Drawing.Point(42, 277);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.PreventEnterBeep = true;
            this.txtEncrypt.Size = new System.Drawing.Size(371, 20);
            this.txtEncrypt.TabIndex = 11;
            // 
            // txtDecrypt
            // 
            // 
            // 
            // 
            this.txtDecrypt.Border.Class = "TextBoxBorder";
            this.txtDecrypt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDecrypt.Location = new System.Drawing.Point(42, 347);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.PreventEnterBeep = true;
            this.txtDecrypt.Size = new System.Drawing.Size(371, 20);
            this.txtDecrypt.TabIndex = 12;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(168, 23);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(74, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 13;
            // 
            // txtResponse
            // 
            // 
            // 
            // 
            this.txtResponse.Border.Class = "TextBoxBorder";
            this.txtResponse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtResponse.Location = new System.Drawing.Point(42, 404);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.PreventEnterBeep = true;
            this.txtResponse.Size = new System.Drawing.Size(240, 20);
            this.txtResponse.TabIndex = 14;
            // 
            // EncryptDecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.actIndicator);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lbldecrypt);
            this.Controls.Add(this.lblencrypt);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.swtSelect);
            this.Controls.Add(this.lblcombo);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.pictureBox1);
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

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSelect;
        private DevComponents.DotNetBar.LabelX lblcombo;
        private DevComponents.DotNetBar.Controls.SwitchButton swtSelect;
        private DevComponents.DotNetBar.LabelX lblselect;
        private DevComponents.DotNetBar.LabelX lblencrypt;
        private DevComponents.DotNetBar.LabelX lbldecrypt;
        private DevComponents.DotNetBar.ButtonX btnDo;
        private DevComponents.DotNetBar.ButtonX BtnClose;
        private DevComponents.DotNetBar.Controls.CircularProgress actIndicator;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEncrypt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDecrypt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResponse;
    }
}