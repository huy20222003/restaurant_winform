namespace restaurant
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.button_login = new MaterialSkin.Controls.MaterialButton();
            this.checkbox_showpassword = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.button_login);
            this.panel2.Controls.Add(this.checkbox_showpassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(561, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 498);
            this.panel2.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.materialLabel1.Location = new System.Drawing.Point(167, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(281, 32);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "ĐĂNG NHẬP";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_login
            // 
            this.button_login.AutoSize = false;
            this.button_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_login.Depth = 0;
            this.button_login.HighEmphasis = true;
            this.button_login.Icon = null;
            this.button_login.Location = new System.Drawing.Point(82, 355);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_login.Name = "button_login";
            this.button_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_login.Size = new System.Drawing.Size(410, 47);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "ĐĂNG NHẬP";
            this.button_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_login.UseAccentColor = false;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // checkbox_showpassword
            // 
            this.checkbox_showpassword.AutoSize = true;
            this.checkbox_showpassword.Depth = 0;
            this.checkbox_showpassword.Location = new System.Drawing.Point(82, 303);
            this.checkbox_showpassword.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_showpassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkbox_showpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkbox_showpassword.Name = "checkbox_showpassword";
            this.checkbox_showpassword.ReadOnly = false;
            this.checkbox_showpassword.Ripple = true;
            this.checkbox_showpassword.Size = new System.Drawing.Size(160, 37);
            this.checkbox_showpassword.TabIndex = 4;
            this.checkbox_showpassword.Text = "Hiển thị mật khẩu";
            this.checkbox_showpassword.UseVisualStyleBackColor = true;
            this.checkbox_showpassword.CheckedChanged += new System.EventHandler(this.checkbox_showpassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AllowPromptAsInput = true;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AsciiOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BeepOnError = true;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.Depth = 0;
            this.txtPassword.ErrorMessage = "Vui lòng nhập mật khẩu";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HelperText = "Nhập mật khẩu";
            this.txtPassword.HidePromptOnLeave = false;
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Mật khẩu";
            this.txtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(82, 231);
            this.txtPassword.Mask = "";
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.PromptChar = '_';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RejectInputOnFirstFailure = false;
            this.txtPassword.ResetOnPrompt = true;
            this.txtPassword.ResetOnSpace = true;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(410, 48);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "123";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.ValidatingType = null;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.AllowPromptAsInput = true;
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.AsciiOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.BeepOnError = true;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername.Depth = 0;
            this.txtUsername.ErrorMessage = "Nhập vào tên đăng nhập";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HelperText = "Nhập vào tên đăng nhập";
            this.txtUsername.HidePromptOnLeave = false;
            this.txtUsername.HideSelection = true;
            this.txtUsername.Hint = "Tên đăng nhập";
            this.txtUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(82, 137);
            this.txtUsername.Mask = "";
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PrefixSuffixText = null;
            this.txtUsername.PromptChar = '_';
            this.txtUsername.ReadOnly = false;
            this.txtUsername.RejectInputOnFirstFailure = false;
            this.txtUsername.ResetOnPrompt = true;
            this.txtUsername.ResetOnSpace = true;
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(410, 48);
            this.txtUsername.SkipLiterals = true;
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "admin";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.ValidatingType = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton button_login;
        private MaterialSkin.Controls.MaterialCheckbox checkbox_showpassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

