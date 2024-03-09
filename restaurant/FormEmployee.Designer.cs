namespace restaurant
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelEmployeeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEmployeeChooseImage = new MaterialSkin.Controls.MaterialButton();
            this.buttonEmployee = new MaterialSkin.Controls.MaterialButton();
            this.buttonEmployeeDelete = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonEmployeeCancel = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtEmployeeFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmployeeUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmployeePhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmployeeAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxEmployeeAge = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxEmployeeGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxEmployeeRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(50, 179);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 259);
            this.materialCard1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(14, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 231);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelEmployeeTitle
            // 
            this.labelEmployeeTitle.AutoSize = true;
            this.labelEmployeeTitle.Depth = 0;
            this.labelEmployeeTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelEmployeeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelEmployeeTitle.Location = new System.Drawing.Point(515, 88);
            this.labelEmployeeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmployeeTitle.Name = "labelEmployeeTitle";
            this.labelEmployeeTitle.Size = new System.Drawing.Size(217, 29);
            this.labelEmployeeTitle.TabIndex = 1;
            this.labelEmployeeTitle.Text = "Thêm mới nhân viên";
            // 
            // buttonEmployeeChooseImage
            // 
            this.buttonEmployeeChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmployeeChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeeChooseImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEmployeeChooseImage.Depth = 0;
            this.buttonEmployeeChooseImage.HighEmphasis = true;
            this.buttonEmployeeChooseImage.Icon = null;
            this.buttonEmployeeChooseImage.Location = new System.Drawing.Point(88, 458);
            this.buttonEmployeeChooseImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEmployeeChooseImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEmployeeChooseImage.Name = "buttonEmployeeChooseImage";
            this.buttonEmployeeChooseImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEmployeeChooseImage.Size = new System.Drawing.Size(97, 36);
            this.buttonEmployeeChooseImage.TabIndex = 8;
            this.buttonEmployeeChooseImage.Text = "Chọn ảnh";
            this.buttonEmployeeChooseImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEmployeeChooseImage.UseAccentColor = false;
            this.buttonEmployeeChooseImage.UseVisualStyleBackColor = true;
            this.buttonEmployeeChooseImage.Click += new System.EventHandler(this.buttonEmployeeChooseImage_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEmployee.Depth = 0;
            this.buttonEmployee.HighEmphasis = true;
            this.buttonEmployee.Icon = null;
            this.buttonEmployee.Location = new System.Drawing.Point(1016, 501);
            this.buttonEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEmployee.Size = new System.Drawing.Size(93, 36);
            this.buttonEmployee.TabIndex = 9;
            this.buttonEmployee.Text = "Thêm mới";
            this.buttonEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEmployee.UseAccentColor = false;
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonEmployeeDelete
            // 
            this.buttonEmployeeDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmployeeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeeDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEmployeeDelete.Depth = 0;
            this.buttonEmployeeDelete.HighEmphasis = true;
            this.buttonEmployeeDelete.Icon = null;
            this.buttonEmployeeDelete.Location = new System.Drawing.Point(823, 501);
            this.buttonEmployeeDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEmployeeDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
            this.buttonEmployeeDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEmployeeDelete.Size = new System.Drawing.Size(132, 36);
            this.buttonEmployeeDelete.TabIndex = 10;
            this.buttonEmployeeDelete.Text = "Xoá nhân viên";
            this.buttonEmployeeDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonEmployeeDelete.UseAccentColor = false;
            this.buttonEmployeeDelete.UseVisualStyleBackColor = true;
            this.buttonEmployeeDelete.Click += new System.EventHandler(this.buttonEmployeeDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonEmployeeCancel
            // 
            this.buttonEmployeeCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmployeeCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEmployeeCancel.Depth = 0;
            this.buttonEmployeeCancel.HighEmphasis = true;
            this.buttonEmployeeCancel.Icon = null;
            this.buttonEmployeeCancel.Location = new System.Drawing.Point(335, 501);
            this.buttonEmployeeCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEmployeeCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEmployeeCancel.Name = "buttonEmployeeCancel";
            this.buttonEmployeeCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEmployeeCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonEmployeeCancel.TabIndex = 11;
            this.buttonEmployeeCancel.Text = "Huỷ";
            this.buttonEmployeeCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEmployeeCancel.UseAccentColor = false;
            this.buttonEmployeeCancel.UseVisualStyleBackColor = true;
            this.buttonEmployeeCancel.Click += new System.EventHandler(this.buttonEmployeeCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // txtEmployeeFullName
            // 
            this.txtEmployeeFullName.Animated = true;
            this.txtEmployeeFullName.BorderRadius = 4;
            this.txtEmployeeFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeFullName.DefaultText = "";
            this.txtEmployeeFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeFullName.Location = new System.Drawing.Point(335, 179);
            this.txtEmployeeFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeFullName.Name = "txtEmployeeFullName";
            this.txtEmployeeFullName.PasswordChar = '\0';
            this.txtEmployeeFullName.PlaceholderText = "Tên đầy đủ";
            this.txtEmployeeFullName.SelectedText = "";
            this.txtEmployeeFullName.Size = new System.Drawing.Size(370, 60);
            this.txtEmployeeFullName.TabIndex = 13;
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.Animated = true;
            this.txtEmployeeUsername.BorderRadius = 4;
            this.txtEmployeeUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeUsername.DefaultText = "";
            this.txtEmployeeUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeUsername.Location = new System.Drawing.Point(781, 179);
            this.txtEmployeeUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.PasswordChar = '\0';
            this.txtEmployeeUsername.PlaceholderText = "Tên đăng nhập";
            this.txtEmployeeUsername.SelectedText = "";
            this.txtEmployeeUsername.Size = new System.Drawing.Size(370, 60);
            this.txtEmployeeUsername.TabIndex = 14;
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.Animated = true;
            this.txtEmployeePhoneNumber.BorderRadius = 4;
            this.txtEmployeePhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeePhoneNumber.DefaultText = "";
            this.txtEmployeePhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeePhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeePhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeePhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeePhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeePhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeePhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(335, 334);
            this.txtEmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.PasswordChar = '\0';
            this.txtEmployeePhoneNumber.PlaceholderText = "Số điện thoại";
            this.txtEmployeePhoneNumber.SelectedText = "";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(816, 60);
            this.txtEmployeePhoneNumber.TabIndex = 15;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Animated = true;
            this.txtEmployeeAddress.BorderRadius = 4;
            this.txtEmployeeAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeAddress.DefaultText = "";
            this.txtEmployeeAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeAddress.Location = new System.Drawing.Point(335, 417);
            this.txtEmployeeAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.PasswordChar = '\0';
            this.txtEmployeeAddress.PlaceholderText = "Địa chỉ";
            this.txtEmployeeAddress.SelectedText = "";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(816, 60);
            this.txtEmployeeAddress.TabIndex = 16;
            // 
            // comboBoxEmployeeAge
            // 
            this.comboBoxEmployeeAge.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEmployeeAge.BorderRadius = 4;
            this.comboBoxEmployeeAge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEmployeeAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeAge.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEmployeeAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEmployeeAge.ItemHeight = 30;
            this.comboBoxEmployeeAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxEmployeeAge.Location = new System.Drawing.Point(335, 274);
            this.comboBoxEmployeeAge.Name = "comboBoxEmployeeAge";
            this.comboBoxEmployeeAge.Size = new System.Drawing.Size(230, 36);
            this.comboBoxEmployeeAge.TabIndex = 17;
            // 
            // comboBoxEmployeeGender
            // 
            this.comboBoxEmployeeGender.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEmployeeGender.BorderRadius = 4;
            this.comboBoxEmployeeGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEmployeeGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEmployeeGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEmployeeGender.ItemHeight = 30;
            this.comboBoxEmployeeGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Không xác định"});
            this.comboBoxEmployeeGender.Location = new System.Drawing.Point(628, 274);
            this.comboBoxEmployeeGender.Name = "comboBoxEmployeeGender";
            this.comboBoxEmployeeGender.Size = new System.Drawing.Size(230, 36);
            this.comboBoxEmployeeGender.TabIndex = 18;
            // 
            // comboBoxEmployeeRole
            // 
            this.comboBoxEmployeeRole.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEmployeeRole.BorderRadius = 4;
            this.comboBoxEmployeeRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEmployeeRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEmployeeRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEmployeeRole.ItemHeight = 30;
            this.comboBoxEmployeeRole.Location = new System.Drawing.Point(921, 274);
            this.comboBoxEmployeeRole.Name = "comboBoxEmployeeRole";
            this.comboBoxEmployeeRole.Size = new System.Drawing.Size(230, 36);
            this.comboBoxEmployeeRole.TabIndex = 19;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(335, 247);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 18);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Tuổi:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(628, 246);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(53, 18);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Giới tính:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(921, 250);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(53, 18);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Chức vụ:";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 780);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxEmployeeRole);
            this.Controls.Add(this.comboBoxEmployeeGender);
            this.Controls.Add(this.comboBoxEmployeeAge);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.txtEmployeePhoneNumber);
            this.Controls.Add(this.txtEmployeeUsername);
            this.Controls.Add(this.txtEmployeeFullName);
            this.Controls.Add(this.buttonEmployeeCancel);
            this.Controls.Add(this.buttonEmployeeDelete);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonEmployeeChooseImage);
            this.Controls.Add(this.labelEmployeeTitle);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployee";
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialLabel labelEmployeeTitle;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeChooseImage;
        private MaterialSkin.Controls.MaterialButton buttonEmployee;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeePhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeFullName;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEmployeeRole;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEmployeeGender;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEmployeeAge;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}