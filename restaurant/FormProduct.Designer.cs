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
            this.buttonProductCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonProduct = new MaterialSkin.Controls.MaterialButton();
            this.buttonProductDelete = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductPriceSale = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxProductStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxProductCategoryID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnChooseImage = new MaterialSkin.Controls.MaterialButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            // txtProductName
            // 
            this.txtProductName.Animated = true;
            this.txtProductName.BorderRadius = 4;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(307, 114);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "Tên sản phẩm";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(844, 60);
            this.txtProductName.TabIndex = 19;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Animated = true;
            this.txtProductDescription.BorderRadius = 4;
            this.txtProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductDescription.DefaultText = "";
            this.txtProductDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductDescription.Location = new System.Drawing.Point(307, 188);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.PasswordChar = '\0';
            this.txtProductDescription.PlaceholderText = "Mô tả";
            this.txtProductDescription.SelectedText = "";
            this.txtProductDescription.Size = new System.Drawing.Size(844, 183);
            this.txtProductDescription.TabIndex = 20;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Animated = true;
            this.txtProductPrice.BorderRadius = 4;
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.DefaultText = "";
            this.txtProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductPrice.Location = new System.Drawing.Point(307, 392);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PlaceholderText = "Giá";
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.Size = new System.Drawing.Size(257, 60);
            this.txtProductPrice.TabIndex = 21;
            // 
            // txtProductPriceSale
            // 
            this.txtProductPriceSale.Animated = true;
            this.txtProductPriceSale.BorderRadius = 4;
            this.txtProductPriceSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPriceSale.DefaultText = "";
            this.txtProductPriceSale.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductPriceSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductPriceSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductPriceSale.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductPriceSale.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductPriceSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductPriceSale.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductPriceSale.Location = new System.Drawing.Point(602, 392);
            this.txtProductPriceSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductPriceSale.Name = "txtProductPriceSale";
            this.txtProductPriceSale.PasswordChar = '\0';
            this.txtProductPriceSale.PlaceholderText = "Giá khuyến mãi";
            this.txtProductPriceSale.SelectedText = "";
            this.txtProductPriceSale.Size = new System.Drawing.Size(257, 60);
            this.txtProductPriceSale.TabIndex = 22;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Animated = true;
            this.txtProductQuantity.BorderRadius = 4;
            this.txtProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQuantity.DefaultText = "";
            this.txtProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductQuantity.Location = new System.Drawing.Point(894, 392);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PlaceholderText = "Số lượng";
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.Size = new System.Drawing.Size(257, 60);
            this.txtProductQuantity.TabIndex = 23;
            // 
            // txtProductColor
            // 
            this.txtProductColor.Animated = true;
            this.txtProductColor.BorderRadius = 4;
            this.txtProductColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductColor.DefaultText = "";
            this.txtProductColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductColor.Location = new System.Drawing.Point(307, 544);
            this.txtProductColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductColor.Multiline = true;
            this.txtProductColor.Name = "txtProductColor";
            this.txtProductColor.PasswordChar = '\0';
            this.txtProductColor.PlaceholderText = "Màu sắc";
            this.txtProductColor.SelectedText = "";
            this.txtProductColor.Size = new System.Drawing.Size(372, 108);
            this.txtProductColor.TabIndex = 24;
            // 
            // txtProductSize
            // 
            this.txtProductSize.Animated = true;
            this.txtProductSize.BorderRadius = 4;
            this.txtProductSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductSize.DefaultText = "";
            this.txtProductSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSize.Location = new System.Drawing.Point(759, 544);
            this.txtProductSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductSize.Multiline = true;
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.PasswordChar = '\0';
            this.txtProductSize.PlaceholderText = "Kích thước";
            this.txtProductSize.SelectedText = "";
            this.txtProductSize.Size = new System.Drawing.Size(392, 108);
            this.txtProductSize.TabIndex = 25;
            // 
            // comboBoxProductStatus
            // 
            this.comboBoxProductStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxProductStatus.BorderRadius = 4;
            this.comboBoxProductStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxProductStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxProductStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxProductStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxProductStatus.ItemHeight = 30;
            this.comboBoxProductStatus.Items.AddRange(new object[] {
            "New",
            "Sale"});
            this.comboBoxProductStatus.Location = new System.Drawing.Point(307, 486);
            this.comboBoxProductStatus.Name = "comboBoxProductStatus";
            this.comboBoxProductStatus.Size = new System.Drawing.Size(372, 36);
            this.comboBoxProductStatus.TabIndex = 26;
            // 
            // comboBoxProductCategoryID
            // 
            this.comboBoxProductCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxProductCategoryID.BorderRadius = 4;
            this.comboBoxProductCategoryID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxProductCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductCategoryID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxProductCategoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxProductCategoryID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxProductCategoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxProductCategoryID.ItemHeight = 30;
            this.comboBoxProductCategoryID.Location = new System.Drawing.Point(759, 486);
            this.comboBoxProductCategoryID.Name = "comboBoxProductCategoryID";
            this.comboBoxProductCategoryID.Size = new System.Drawing.Size(392, 36);
            this.comboBoxProductCategoryID.TabIndex = 27;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(307, 460);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 18);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "Trạng thái:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(759, 460);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(63, 18);
            this.guna2HtmlLabel2.TabIndex = 29;
            this.guna2HtmlLabel2.Text = "Danh mục";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 729);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxProductCategoryID);
            this.Controls.Add(this.comboBoxProductStatus);
            this.Controls.Add(this.txtProductSize);
            this.Controls.Add(this.txtProductColor);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductPriceSale);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.buttonProductDelete);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonProductCancel);
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
        private MaterialSkin.Controls.MaterialButton buttonProductCancel;
        private MaterialSkin.Controls.MaterialButton buttonProduct;
        private MaterialSkin.Controls.MaterialButton buttonProductDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtProductSize;
        private Guna.UI2.WinForms.Guna2TextBox txtProductColor;
        private Guna.UI2.WinForms.Guna2TextBox txtProductQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtProductPriceSale;
        private Guna.UI2.WinForms.Guna2TextBox txtProductPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtProductDescription;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxProductCategoryID;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxProductStatus;
        private MaterialSkin.Controls.MaterialButton btnChooseImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}