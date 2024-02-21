namespace restaurant
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new MaterialSkin.Controls.MaterialButton();
            this.txtCategoryName = new MaterialSkin.Controls.MaterialTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddCategory = new MaterialSkin.Controls.MaterialButton();
            this.txtCategoryDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.buttonCategoryDelete = new MaterialSkin.Controls.MaterialButton();
            this.labelCategoryTitle = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.materialCard1.Location = new System.Drawing.Point(49, 121);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 260);
            this.materialCard1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(14, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 232);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChooseImage.Depth = 0;
            this.btnChooseImage.HighEmphasis = true;
            this.btnChooseImage.Icon = null;
            this.btnChooseImage.Location = new System.Drawing.Point(82, 401);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChooseImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChooseImage.Size = new System.Drawing.Size(97, 36);
            this.btnChooseImage.TabIndex = 5;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChooseImage.UseAccentColor = false;
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.AnimateReadOnly = false;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryName.Depth = 0;
            this.txtCategoryName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategoryName.Hint = "Nhập tên danh mục";
            this.txtCategoryName.LeadingIcon = null;
            this.txtCategoryName.Location = new System.Drawing.Point(287, 121);
            this.txtCategoryName.MaxLength = 10;
            this.txtCategoryName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategoryName.Multiline = false;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(472, 50);
            this.txtCategoryName.TabIndex = 6;
            this.txtCategoryName.Text = "";
            this.txtCategoryName.TrailingIcon = null;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCancel.Depth = 0;
            this.buttonCancel.HighEmphasis = true;
            this.buttonCancel.Icon = null;
            this.buttonCancel.Location = new System.Drawing.Point(501, 401);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonCancel.UseAccentColor = false;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddCategory.Depth = 0;
            this.buttonAddCategory.HighEmphasis = true;
            this.buttonAddCategory.Icon = null;
            this.buttonAddCategory.Location = new System.Drawing.Point(599, 401);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddCategory.Size = new System.Drawing.Size(142, 36);
            this.buttonAddCategory.TabIndex = 9;
            this.buttonAddCategory.Text = "Thêm danh mục";
            this.buttonAddCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddCategory.UseAccentColor = false;
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.AnimateReadOnly = false;
            this.txtCategoryDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCategoryDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCategoryDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDescription.Depth = 0;
            this.txtCategoryDescription.HideSelection = true;
            this.txtCategoryDescription.Hint = "Nhập vào mô tả của danh mục";
            this.txtCategoryDescription.Location = new System.Drawing.Point(287, 194);
            this.txtCategoryDescription.MaxLength = 2000;
            this.txtCategoryDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.PasswordChar = '\0';
            this.txtCategoryDescription.ReadOnly = false;
            this.txtCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryDescription.SelectedText = "";
            this.txtCategoryDescription.SelectionLength = 0;
            this.txtCategoryDescription.SelectionStart = 0;
            this.txtCategoryDescription.ShortcutsEnabled = true;
            this.txtCategoryDescription.Size = new System.Drawing.Size(472, 187);
            this.txtCategoryDescription.TabIndex = 10;
            this.txtCategoryDescription.TabStop = false;
            this.txtCategoryDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoryDescription.UseSystemPasswordChar = false;
            // 
            // buttonCategoryDelete
            // 
            this.buttonCategoryDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCategoryDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCategoryDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCategoryDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCategoryDelete.Depth = 0;
            this.buttonCategoryDelete.HighEmphasis = true;
            this.buttonCategoryDelete.Icon = null;
            this.buttonCategoryDelete.Location = new System.Drawing.Point(287, 401);
            this.buttonCategoryDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCategoryDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCategoryDelete.Name = "buttonCategoryDelete";
            this.buttonCategoryDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCategoryDelete.Size = new System.Drawing.Size(64, 36);
            this.buttonCategoryDelete.TabIndex = 11;
            this.buttonCategoryDelete.Text = "Xoá";
            this.buttonCategoryDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonCategoryDelete.UseAccentColor = false;
            this.buttonCategoryDelete.UseVisualStyleBackColor = false;
            this.buttonCategoryDelete.Click += new System.EventHandler(this.buttonCategoryDelete_Click);
            // 
            // labelCategoryTitle
            // 
            this.labelCategoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoryTitle.AutoSize = true;
            this.labelCategoryTitle.Depth = 0;
            this.labelCategoryTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCategoryTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelCategoryTitle.Location = new System.Drawing.Point(398, 49);
            this.labelCategoryTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCategoryTitle.Name = "labelCategoryTitle";
            this.labelCategoryTitle.Size = new System.Drawing.Size(221, 29);
            this.labelCategoryTitle.TabIndex = 12;
            this.labelCategoryTitle.Text = "Thêm mới danh mục";
            this.labelCategoryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.labelCategoryTitle);
            this.Controls.Add(this.buttonCategoryDelete);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCategory";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategory";
            this.TopMost = true;
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialButton btnChooseImage;
        private MaterialSkin.Controls.MaterialTextBox txtCategoryName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAddCategory;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCategoryDescription;
        private MaterialSkin.Controls.MaterialButton buttonCategoryDelete;
        private MaterialSkin.Controls.MaterialLabel labelCategoryTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}