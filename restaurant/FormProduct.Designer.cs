namespace restaurant
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.labelProductTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProductPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProductPriceSale = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxProductStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxProductCategoryID = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonProductCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonProduct = new MaterialSkin.Controls.MaterialButton();
            this.buttonProductDelete = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtProductQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.btnChooseImage = new MaterialSkin.Controls.MaterialButton();
            this.txtProductDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtProductColor = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtProductSize = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductTitle
            // 
            this.labelProductTitle.AutoSize = true;
            this.labelProductTitle.Depth = 0;
            this.labelProductTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelProductTitle.Location = new System.Drawing.Point(568, 49);
            this.labelProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductTitle.Name = "labelProductTitle";
            this.labelProductTitle.Size = new System.Drawing.Size(219, 29);
            this.labelProductTitle.TabIndex = 0;
            this.labelProductTitle.Text = "Thêm mới sản phẩm";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(41, 123);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(211, 262);
            this.materialCard1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(14, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(183, 234);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.AnimateReadOnly = false;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Depth = 0;
            this.txtProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductName.Hint = "Tên sản phẩm";
            this.txtProductName.LeadingIcon = null;
            this.txtProductName.Location = new System.Drawing.Point(307, 123);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductName.Multiline = false;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(844, 50);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.Text = "";
            this.txtProductName.TrailingIcon = null;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductName_Validating);
            this.txtProductName.Validated += new System.EventHandler(this.TxtProductName_Validated);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.AnimateReadOnly = false;
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductPrice.Depth = 0;
            this.txtProductPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductPrice.Hint = "Giá";
            this.txtProductPrice.LeadingIcon = null;
            this.txtProductPrice.Location = new System.Drawing.Point(307, 402);
            this.txtProductPrice.MaxLength = 50;
            this.txtProductPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductPrice.Multiline = false;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(226, 50);
            this.txtProductPrice.TabIndex = 5;
            this.txtProductPrice.Text = "";
            this.txtProductPrice.TrailingIcon = null;
            this.txtProductPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductPrice_Validating);
            this.txtProductPrice.Validated += new System.EventHandler(this.TxtProductPrice_Validated);
            // 
            // txtProductPriceSale
            // 
            this.txtProductPriceSale.AnimateReadOnly = false;
            this.txtProductPriceSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductPriceSale.Depth = 0;
            this.txtProductPriceSale.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductPriceSale.Hint = "Giá khuyến mãi";
            this.txtProductPriceSale.LeadingIcon = null;
            this.txtProductPriceSale.Location = new System.Drawing.Point(587, 402);
            this.txtProductPriceSale.MaxLength = 50;
            this.txtProductPriceSale.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductPriceSale.Multiline = false;
            this.txtProductPriceSale.Name = "txtProductPriceSale";
            this.txtProductPriceSale.Size = new System.Drawing.Size(249, 50);
            this.txtProductPriceSale.TabIndex = 6;
            this.txtProductPriceSale.Text = "";
            this.txtProductPriceSale.TrailingIcon = null;
            this.txtProductPriceSale.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductPriceSale_Validating);
            this.txtProductPriceSale.Validated += new System.EventHandler(this.TxtProductPriceSale_Validated);
            // 
            // comboBoxProductStatus
            // 
            this.comboBoxProductStatus.AutoResize = false;
            this.comboBoxProductStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxProductStatus.Depth = 0;
            this.comboBoxProductStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProductStatus.DropDownHeight = 174;
            this.comboBoxProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductStatus.DropDownWidth = 121;
            this.comboBoxProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxProductStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxProductStatus.FormattingEnabled = true;
            this.comboBoxProductStatus.Hint = "Trạng thái";
            this.comboBoxProductStatus.IntegralHeight = false;
            this.comboBoxProductStatus.ItemHeight = 43;
            this.comboBoxProductStatus.Items.AddRange(new object[] {
            "New",
            "Sale"});
            this.comboBoxProductStatus.Location = new System.Drawing.Point(307, 473);
            this.comboBoxProductStatus.MaxDropDownItems = 4;
            this.comboBoxProductStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxProductStatus.Name = "comboBoxProductStatus";
            this.comboBoxProductStatus.Size = new System.Drawing.Size(372, 49);
            this.comboBoxProductStatus.StartIndex = 0;
            this.comboBoxProductStatus.TabIndex = 7;
            this.comboBoxProductStatus.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxProductStatus_Validating);
            this.comboBoxProductStatus.Validated += new System.EventHandler(this.ComboBoxProductStatus_Validated);
            // 
            // comboBoxProductCategoryID
            // 
            this.comboBoxProductCategoryID.AutoResize = false;
            this.comboBoxProductCategoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxProductCategoryID.Depth = 0;
            this.comboBoxProductCategoryID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProductCategoryID.DropDownHeight = 174;
            this.comboBoxProductCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductCategoryID.DropDownWidth = 121;
            this.comboBoxProductCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxProductCategoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxProductCategoryID.FormattingEnabled = true;
            this.comboBoxProductCategoryID.Hint = "Danh mục";
            this.comboBoxProductCategoryID.IntegralHeight = false;
            this.comboBoxProductCategoryID.ItemHeight = 43;
            this.comboBoxProductCategoryID.Location = new System.Drawing.Point(708, 473);
            this.comboBoxProductCategoryID.MaxDropDownItems = 4;
            this.comboBoxProductCategoryID.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxProductCategoryID.Name = "comboBoxProductCategoryID";
            this.comboBoxProductCategoryID.Size = new System.Drawing.Size(443, 49);
            this.comboBoxProductCategoryID.StartIndex = 0;
            this.comboBoxProductCategoryID.TabIndex = 8;
            this.comboBoxProductCategoryID.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxProductCategoryID_Validating);
            this.comboBoxProductCategoryID.Validated += new System.EventHandler(this.ComboBoxProductCategoryID_Validated);
            // 
            // buttonProductCancel
            // 
            this.buttonProductCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProductCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProductCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonProductCancel.Depth = 0;
            this.buttonProductCancel.HighEmphasis = true;
            this.buttonProductCancel.Icon = null;
            this.buttonProductCancel.Location = new System.Drawing.Point(573, 673);
            this.buttonProductCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonProductCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProductCancel.Name = "buttonProductCancel";
            this.buttonProductCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonProductCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonProductCancel.TabIndex = 11;
            this.buttonProductCancel.Text = "Huỷ";
            this.buttonProductCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonProductCancel.UseAccentColor = false;
            this.buttonProductCancel.UseVisualStyleBackColor = true;
            this.buttonProductCancel.Click += new System.EventHandler(this.buttonProductCancel_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonProduct.Depth = 0;
            this.buttonProduct.HighEmphasis = true;
            this.buttonProduct.Icon = null;
            this.buttonProduct.Location = new System.Drawing.Point(941, 673);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonProduct.Size = new System.Drawing.Size(172, 36);
            this.buttonProduct.TabIndex = 12;
            this.buttonProduct.Text = "Thêm mới sản phẩm";
            this.buttonProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonProduct.UseAccentColor = false;
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProductDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonProductDelete.Depth = 0;
            this.buttonProductDelete.HighEmphasis = true;
            this.buttonProductDelete.Icon = null;
            this.buttonProductDelete.Location = new System.Drawing.Point(707, 673);
            this.buttonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonProductDelete.Size = new System.Drawing.Size(129, 36);
            this.buttonProductDelete.TabIndex = 13;
            this.buttonProductDelete.Text = "Xoá sản phẩm";
            this.buttonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonProductDelete.UseAccentColor = false;
            this.buttonProductDelete.UseVisualStyleBackColor = true;
            this.buttonProductDelete.Visible = false;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.AnimateReadOnly = false;
            this.txtProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductQuantity.Depth = 0;
            this.txtProductQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductQuantity.Hint = "Số lượng";
            this.txtProductQuantity.LeadingIcon = null;
            this.txtProductQuantity.Location = new System.Drawing.Point(918, 402);
            this.txtProductQuantity.MaxLength = 50;
            this.txtProductQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductQuantity.Multiline = false;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(233, 50);
            this.txtProductQuantity.TabIndex = 14;
            this.txtProductQuantity.Text = "";
            this.txtProductQuantity.TrailingIcon = null;
            this.txtProductQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductQuantity_Validating);
            this.txtProductQuantity.Validated += new System.EventHandler(this.TxtProductQuantity_Validated);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChooseImage.Depth = 0;
            this.btnChooseImage.HighEmphasis = true;
            this.btnChooseImage.Icon = null;
            this.btnChooseImage.Location = new System.Drawing.Point(90, 405);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChooseImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChooseImage.Size = new System.Drawing.Size(97, 36);
            this.btnChooseImage.TabIndex = 15;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChooseImage.UseAccentColor = false;
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.AnimateReadOnly = false;
            this.txtProductDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductDescription.Depth = 0;
            this.txtProductDescription.HideSelection = true;
            this.txtProductDescription.Hint = "Mô tả";
            this.txtProductDescription.Location = new System.Drawing.Point(307, 196);
            this.txtProductDescription.MaxLength = 3000;
            this.txtProductDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.PasswordChar = '\0';
            this.txtProductDescription.ReadOnly = false;
            this.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductDescription.SelectedText = "";
            this.txtProductDescription.SelectionLength = 0;
            this.txtProductDescription.SelectionStart = 0;
            this.txtProductDescription.ShortcutsEnabled = true;
            this.txtProductDescription.Size = new System.Drawing.Size(844, 175);
            this.txtProductDescription.TabIndex = 16;
            this.txtProductDescription.TabStop = false;
            this.txtProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductDescription.UseSystemPasswordChar = false;
            this.txtProductDescription.Validated += new System.EventHandler(this.TxtProductDescription_Validated);
            this.txtProductDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductDescription_Validating);
            // 
            // txtProductColor
            // 
            this.txtProductColor.AnimateReadOnly = false;
            this.txtProductColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductColor.Depth = 0;
            this.txtProductColor.HideSelection = true;
            this.txtProductColor.Hint = "Màu sắc";
            this.txtProductColor.Location = new System.Drawing.Point(307, 544);
            this.txtProductColor.MaxLength = 32767;
            this.txtProductColor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductColor.Name = "txtProductColor";
            this.txtProductColor.PasswordChar = '\0';
            this.txtProductColor.ReadOnly = false;
            this.txtProductColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductColor.SelectedText = "";
            this.txtProductColor.SelectionLength = 0;
            this.txtProductColor.SelectionStart = 0;
            this.txtProductColor.ShortcutsEnabled = true;
            this.txtProductColor.Size = new System.Drawing.Size(372, 108);
            this.txtProductColor.TabIndex = 17;
            this.txtProductColor.TabStop = false;
            this.txtProductColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductColor.UseSystemPasswordChar = false;
            this.txtProductColor.Validated += new System.EventHandler(this.TxtProductColor_Validated);
            this.txtProductColor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductColor_Validating);
            // 
            // txtProductSize
            // 
            this.txtProductSize.AnimateReadOnly = false;
            this.txtProductSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductSize.Depth = 0;
            this.txtProductSize.HideSelection = true;
            this.txtProductSize.Hint = "Kích thước";
            this.txtProductSize.Location = new System.Drawing.Point(708, 544);
            this.txtProductSize.MaxLength = 32767;
            this.txtProductSize.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.PasswordChar = '\0';
            this.txtProductSize.ReadOnly = false;
            this.txtProductSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductSize.SelectedText = "";
            this.txtProductSize.SelectionLength = 0;
            this.txtProductSize.SelectionStart = 0;
            this.txtProductSize.ShortcutsEnabled = true;
            this.txtProductSize.Size = new System.Drawing.Size(443, 108);
            this.txtProductSize.TabIndex = 18;
            this.txtProductSize.TabStop = false;
            this.txtProductSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductSize.UseSystemPasswordChar = false;
            this.txtProductSize.Validated += new System.EventHandler(this.TxtProductSize_Validated);
            this.txtProductSize.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductSize_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 729);
            this.Controls.Add(this.txtProductSize);
            this.Controls.Add(this.txtProductColor);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.buttonProductDelete);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonProductCancel);
            this.Controls.Add(this.comboBoxProductCategoryID);
            this.Controls.Add(this.comboBoxProductStatus);
            this.Controls.Add(this.txtProductPriceSale);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.labelProductTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduct";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelProductTitle;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialTextBox txtProductName;
        private MaterialSkin.Controls.MaterialTextBox txtProductPrice;
        private MaterialSkin.Controls.MaterialTextBox txtProductPriceSale;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProductStatus;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProductCategoryID;
        private MaterialSkin.Controls.MaterialButton buttonProductCancel;
        private MaterialSkin.Controls.MaterialButton buttonProduct;
        private MaterialSkin.Controls.MaterialButton buttonProductDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialTextBox txtProductQuantity;
        private MaterialSkin.Controls.MaterialButton btnChooseImage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtProductDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtProductColor;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtProductSize;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}