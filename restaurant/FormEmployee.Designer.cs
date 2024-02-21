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
            this.txtEmployeeFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmployeeUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxEmployeeAge = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxEmployeeGender = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxEmployeeRole = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmployeeAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonEmployeeChooseImage = new MaterialSkin.Controls.MaterialButton();
            this.buttonEmployee = new MaterialSkin.Controls.MaterialButton();
            this.buttonEmployeeDelete = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonEmployeeCancel = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEmployeePhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
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
            // txtEmployeeFullName
            // 
            this.txtEmployeeFullName.AnimateReadOnly = false;
            this.txtEmployeeFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeFullName.Depth = 0;
            this.txtEmployeeFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeFullName.Hint = "Tên đầy đủ";
            this.txtEmployeeFullName.LeadingIcon = null;
            this.txtEmployeeFullName.Location = new System.Drawing.Point(335, 179);
            this.txtEmployeeFullName.MaxLength = 100;
            this.txtEmployeeFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeFullName.Multiline = false;
            this.txtEmployeeFullName.Name = "txtEmployeeFullName";
            this.txtEmployeeFullName.Size = new System.Drawing.Size(371, 50);
            this.txtEmployeeFullName.TabIndex = 2;
            this.txtEmployeeFullName.Text = "";
            this.txtEmployeeFullName.TrailingIcon = null;
            this.txtEmployeeFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeFullName_Validating);
            this.txtEmployeeFullName.Validated += new System.EventHandler(this.txtEmployeeFullName_Validated);
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.AnimateReadOnly = false;
            this.txtEmployeeUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeUsername.Depth = 0;
            this.txtEmployeeUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeUsername.Hint = "Tên đăng nhập";
            this.txtEmployeeUsername.LeadingIcon = null;
            this.txtEmployeeUsername.Location = new System.Drawing.Point(742, 179);
            this.txtEmployeeUsername.MaxLength = 100;
            this.txtEmployeeUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeUsername.Multiline = false;
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.Size = new System.Drawing.Size(409, 50);
            this.txtEmployeeUsername.TabIndex = 3;
            this.txtEmployeeUsername.Text = "";
            this.txtEmployeeUsername.TrailingIcon = null;
            this.txtEmployeeUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeUsername_Validating);
            this.txtEmployeeUsername.Validated += new System.EventHandler(this.txtEmployeeUsername_Validated);
            // 
            // comboBoxEmployeeAge
            // 
            this.comboBoxEmployeeAge.AutoResize = false;
            this.comboBoxEmployeeAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeAge.Depth = 0;
            this.comboBoxEmployeeAge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEmployeeAge.DropDownHeight = 174;
            this.comboBoxEmployeeAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeAge.DropDownWidth = 121;
            this.comboBoxEmployeeAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxEmployeeAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxEmployeeAge.FormattingEnabled = true;
            this.comboBoxEmployeeAge.Hint = "Tuổi";
            this.comboBoxEmployeeAge.IntegralHeight = false;
            this.comboBoxEmployeeAge.ItemHeight = 43;
            this.comboBoxEmployeeAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBoxEmployeeAge.Location = new System.Drawing.Point(335, 261);
            this.comboBoxEmployeeAge.MaxDropDownItems = 4;
            this.comboBoxEmployeeAge.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxEmployeeAge.Name = "comboBoxEmployeeAge";
            this.comboBoxEmployeeAge.Size = new System.Drawing.Size(229, 49);
            this.comboBoxEmployeeAge.StartIndex = 0;
            this.comboBoxEmployeeAge.TabIndex = 4;
            this.comboBoxEmployeeAge.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmployeeAge_Validating);
            this.comboBoxEmployeeAge.Validated += new System.EventHandler(this.ComboBoxEmployeeAge_Validated);
            // 
            // comboBoxEmployeeGender
            // 
            this.comboBoxEmployeeGender.AutoResize = false;
            this.comboBoxEmployeeGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeGender.Depth = 0;
            this.comboBoxEmployeeGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEmployeeGender.DropDownHeight = 174;
            this.comboBoxEmployeeGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeGender.DropDownWidth = 121;
            this.comboBoxEmployeeGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxEmployeeGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxEmployeeGender.FormattingEnabled = true;
            this.comboBoxEmployeeGender.Hint = "Giới tính";
            this.comboBoxEmployeeGender.IntegralHeight = false;
            this.comboBoxEmployeeGender.ItemHeight = 43;
            this.comboBoxEmployeeGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không xác định"});
            this.comboBoxEmployeeGender.Location = new System.Drawing.Point(607, 261);
            this.comboBoxEmployeeGender.MaxDropDownItems = 4;
            this.comboBoxEmployeeGender.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxEmployeeGender.Name = "comboBoxEmployeeGender";
            this.comboBoxEmployeeGender.Size = new System.Drawing.Size(224, 49);
            this.comboBoxEmployeeGender.StartIndex = 0;
            this.comboBoxEmployeeGender.TabIndex = 5;
            this.comboBoxEmployeeGender.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxEmployeeGender_Validating);
            this.comboBoxEmployeeGender.Validated += new System.EventHandler(this.ComboBoxEmployeeGender_Validated);
            // 
            // comboBoxEmployeeRole
            // 
            this.comboBoxEmployeeRole.AutoResize = false;
            this.comboBoxEmployeeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxEmployeeRole.Depth = 0;
            this.comboBoxEmployeeRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEmployeeRole.DropDownHeight = 174;
            this.comboBoxEmployeeRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeRole.DropDownWidth = 121;
            this.comboBoxEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxEmployeeRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxEmployeeRole.FormattingEnabled = true;
            this.comboBoxEmployeeRole.Hint = "Chức vụ";
            this.comboBoxEmployeeRole.IntegralHeight = false;
            this.comboBoxEmployeeRole.ItemHeight = 43;
            this.comboBoxEmployeeRole.Location = new System.Drawing.Point(878, 261);
            this.comboBoxEmployeeRole.MaxDropDownItems = 4;
            this.comboBoxEmployeeRole.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxEmployeeRole.Name = "comboBoxEmployeeRole";
            this.comboBoxEmployeeRole.Size = new System.Drawing.Size(273, 49);
            this.comboBoxEmployeeRole.StartIndex = 0;
            this.comboBoxEmployeeRole.TabIndex = 6;
            this.comboBoxEmployeeRole.TextUpdate += new System.EventHandler(this.ComboBoxEmployeeRole_Validated);
            this.comboBoxEmployeeRole.Validated += new System.EventHandler(this.ComboBoxEmployeeRole_Validated);
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.AnimateReadOnly = false;
            this.txtEmployeeAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeAddress.Depth = 0;
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeAddress.Hint = "Địa chỉ";
            this.txtEmployeeAddress.LeadingIcon = null;
            this.txtEmployeeAddress.Location = new System.Drawing.Point(335, 418);
            this.txtEmployeeAddress.MaxLength = 200;
            this.txtEmployeeAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeAddress.Multiline = false;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(816, 50);
            this.txtEmployeeAddress.TabIndex = 7;
            this.txtEmployeeAddress.Text = "";
            this.txtEmployeeAddress.TrailingIcon = null;
            this.txtEmployeeAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeAddress_Validating);
            this.txtEmployeeAddress.Validated += new System.EventHandler(this.txtEmployeeAddress_Validated);
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
            this.buttonEmployee.Location = new System.Drawing.Point(1058, 501);
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
            this.buttonEmployeeDelete.Location = new System.Drawing.Point(840, 501);
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
            this.buttonEmployeeCancel.Location = new System.Drawing.Point(335, 487);
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
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.AnimateReadOnly = false;
            this.txtEmployeePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePhoneNumber.Depth = 0;
            this.txtEmployeePhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeePhoneNumber.Hint = "Số điện thoại";
            this.txtEmployeePhoneNumber.LeadingIcon = null;
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(336, 343);
            this.txtEmployeePhoneNumber.MaxLength = 50;
            this.txtEmployeePhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeePhoneNumber.Multiline = false;
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(816, 50);
            this.txtEmployeePhoneNumber.TabIndex = 12;
            this.txtEmployeePhoneNumber.Text = "";
            this.txtEmployeePhoneNumber.TrailingIcon = null;
            this.txtEmployeePhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeePhoneNumber_Validating);
            this.txtEmployeePhoneNumber.Validated += new System.EventHandler(this.txtEmployeePhoneNumber_Validated);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 780);
            this.Controls.Add(this.txtEmployeePhoneNumber);
            this.Controls.Add(this.buttonEmployeeCancel);
            this.Controls.Add(this.buttonEmployeeDelete);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonEmployeeChooseImage);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.comboBoxEmployeeRole);
            this.Controls.Add(this.comboBoxEmployeeGender);
            this.Controls.Add(this.comboBoxEmployeeAge);
            this.Controls.Add(this.txtEmployeeUsername);
            this.Controls.Add(this.txtEmployeeFullName);
            this.Controls.Add(this.labelEmployeeTitle);
            this.Controls.Add(this.materialCard1);
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
        private MaterialSkin.Controls.MaterialTextBox txtEmployeeFullName;
        private MaterialSkin.Controls.MaterialTextBox txtEmployeeUsername;
        private MaterialSkin.Controls.MaterialComboBox comboBoxEmployeeAge;
        private MaterialSkin.Controls.MaterialComboBox comboBoxEmployeeGender;
        private MaterialSkin.Controls.MaterialComboBox comboBoxEmployeeRole;
        private MaterialSkin.Controls.MaterialTextBox txtEmployeeAddress;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeChooseImage;
        private MaterialSkin.Controls.MaterialButton buttonEmployee;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialTextBox txtEmployeePhoneNumber;
    }
}