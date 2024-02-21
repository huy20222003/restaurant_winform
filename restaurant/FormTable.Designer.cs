namespace restaurant
{
    partial class FormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.txtTableName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTableDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.comboBoxTableStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonTableCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddTable = new MaterialSkin.Controls.MaterialButton();
            this.buttonDeleteTable = new MaterialSkin.Controls.MaterialButton();
            this.labelTableTitle = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTableName
            // 
            this.txtTableName.AnimateReadOnly = false;
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Depth = 0;
            this.txtTableName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTableName.Hint = "Nhập vào tên bàn";
            this.txtTableName.LeadingIcon = null;
            this.txtTableName.Location = new System.Drawing.Point(33, 115);
            this.txtTableName.MaxLength = 100;
            this.txtTableName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTableName.Multiline = false;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(434, 50);
            this.txtTableName.TabIndex = 0;
            this.txtTableName.Text = "";
            this.txtTableName.TrailingIcon = null;
            this.txtTableName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTableName_Validating);
            this.txtTableName.Validated += new System.EventHandler(this.TxtTableName_Validated);
            // 
            // txtTableDescription
            // 
            this.txtTableDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTableDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableDescription.Depth = 0;
            this.txtTableDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTableDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTableDescription.Hint = "Nhập vào mô tả của bàn";
            this.txtTableDescription.Location = new System.Drawing.Point(33, 202);
            this.txtTableDescription.MaxLength = 300;
            this.txtTableDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTableDescription.Name = "txtTableDescription";
            this.txtTableDescription.Size = new System.Drawing.Size(434, 206);
            this.txtTableDescription.TabIndex = 1;
            this.txtTableDescription.Text = "";
            this.txtTableDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTableDescription_Validating);
            this.txtTableDescription.Validated += new System.EventHandler(this.TxtTableDescription_Validated);
            // 
            // comboBoxTableStatus
            // 
            this.comboBoxTableStatus.AutoResize = false;
            this.comboBoxTableStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTableStatus.Depth = 0;
            this.comboBoxTableStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTableStatus.DropDownHeight = 174;
            this.comboBoxTableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableStatus.DropDownWidth = 121;
            this.comboBoxTableStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTableStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTableStatus.FormattingEnabled = true;
            this.comboBoxTableStatus.Hint = "Trạng thái";
            this.comboBoxTableStatus.IntegralHeight = false;
            this.comboBoxTableStatus.ItemHeight = 43;
            this.comboBoxTableStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxTableStatus.Location = new System.Drawing.Point(33, 447);
            this.comboBoxTableStatus.MaxDropDownItems = 4;
            this.comboBoxTableStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTableStatus.Name = "comboBoxTableStatus";
            this.comboBoxTableStatus.Size = new System.Drawing.Size(434, 49);
            this.comboBoxTableStatus.StartIndex = 0;
            this.comboBoxTableStatus.TabIndex = 2;
            this.comboBoxTableStatus.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxTableStatus_Validating);
            this.comboBoxTableStatus.Validated += new System.EventHandler(this.ComboBoxTableStatus_Validated);
            // 
            // buttonTableCancel
            // 
            this.buttonTableCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTableCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTableCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonTableCancel.Depth = 0;
            this.buttonTableCancel.HighEmphasis = true;
            this.buttonTableCancel.Icon = null;
            this.buttonTableCancel.Location = new System.Drawing.Point(33, 515);
            this.buttonTableCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonTableCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonTableCancel.Name = "buttonTableCancel";
            this.buttonTableCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonTableCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonTableCancel.TabIndex = 3;
            this.buttonTableCancel.Text = "Huỷ";
            this.buttonTableCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonTableCancel.UseAccentColor = false;
            this.buttonTableCancel.UseVisualStyleBackColor = true;
            this.buttonTableCancel.Click += new System.EventHandler(this.buttonTableCancel_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddTable.Depth = 0;
            this.buttonAddTable.HighEmphasis = true;
            this.buttonAddTable.Icon = null;
            this.buttonAddTable.Location = new System.Drawing.Point(372, 515);
            this.buttonAddTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddTable.Size = new System.Drawing.Size(95, 36);
            this.buttonAddTable.TabIndex = 4;
            this.buttonAddTable.Text = "Thêm bàn";
            this.buttonAddTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddTable.UseAccentColor = false;
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDeleteTable.Depth = 0;
            this.buttonDeleteTable.HighEmphasis = true;
            this.buttonDeleteTable.Icon = null;
            this.buttonDeleteTable.Location = new System.Drawing.Point(232, 515);
            this.buttonDeleteTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDeleteTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDeleteTable.Size = new System.Drawing.Size(83, 36);
            this.buttonDeleteTable.TabIndex = 5;
            this.buttonDeleteTable.Text = "Xoá bàn";
            this.buttonDeleteTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonDeleteTable.UseAccentColor = false;
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // labelTableTitle
            // 
            this.labelTableTitle.AutoSize = true;
            this.labelTableTitle.Depth = 0;
            this.labelTableTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTableTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelTableTitle.Location = new System.Drawing.Point(161, 53);
            this.labelTableTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTableTitle.Name = "labelTableTitle";
            this.labelTableTitle.Size = new System.Drawing.Size(154, 29);
            this.labelTableTitle.TabIndex = 6;
            this.labelTableTitle.Text = "Thêm mới bàn";
            this.labelTableTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            this.errorProvider.RightToLeft = true;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.labelTableTitle);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonTableCancel);
            this.Controls.Add(this.comboBoxTableStatus);
            this.Controls.Add(this.txtTableDescription);
            this.Controls.Add(this.txtTableName);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTable";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtTableName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtTableDescription;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTableStatus;
        private MaterialSkin.Controls.MaterialButton buttonTableCancel;
        private MaterialSkin.Controls.MaterialButton buttonAddTable;
        private MaterialSkin.Controls.MaterialButton buttonDeleteTable;
        private MaterialSkin.Controls.MaterialLabel labelTableTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}