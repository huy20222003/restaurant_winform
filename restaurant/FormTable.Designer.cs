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
            this.buttonTableCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddTable = new MaterialSkin.Controls.MaterialButton();
            this.buttonDeleteTable = new MaterialSkin.Controls.MaterialButton();
            this.labelTableTitle = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTableDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxTableStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTableCancel
            // 
            this.buttonTableCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTableCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTableCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonTableCancel.Depth = 0;
            this.buttonTableCancel.HighEmphasis = true;
            this.buttonTableCancel.Icon = null;
            this.buttonTableCancel.Location = new System.Drawing.Point(33, 535);
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
            this.buttonAddTable.Location = new System.Drawing.Point(372, 535);
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
            this.buttonDeleteTable.Location = new System.Drawing.Point(232, 535);
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
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // txtTableName
            // 
            this.txtTableName.Animated = true;
            this.txtTableName.BorderRadius = 4;
            this.txtTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableName.DefaultText = "";
            this.txtTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Location = new System.Drawing.Point(33, 111);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PlaceholderText = "Tên bàn";
            this.txtTableName.SelectedText = "";
            this.txtTableName.Size = new System.Drawing.Size(434, 60);
            this.txtTableName.TabIndex = 7;
            // 
            // txtTableDescription
            // 
            this.txtTableDescription.Animated = true;
            this.txtTableDescription.BorderRadius = 4;
            this.txtTableDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableDescription.DefaultText = "";
            this.txtTableDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableDescription.Location = new System.Drawing.Point(33, 203);
            this.txtTableDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTableDescription.Multiline = true;
            this.txtTableDescription.Name = "txtTableDescription";
            this.txtTableDescription.PasswordChar = '\0';
            this.txtTableDescription.PlaceholderText = "Mô tả";
            this.txtTableDescription.SelectedText = "";
            this.txtTableDescription.Size = new System.Drawing.Size(434, 215);
            this.txtTableDescription.TabIndex = 8;
            // 
            // comboBoxTableStatus
            // 
            this.comboBoxTableStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTableStatus.BorderRadius = 4;
            this.comboBoxTableStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTableStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTableStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTableStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxTableStatus.ItemHeight = 30;
            this.comboBoxTableStatus.Items.AddRange(new object[] {
            "active",
            "inactive",
            "used"});
            this.comboBoxTableStatus.Location = new System.Drawing.Point(33, 466);
            this.comboBoxTableStatus.Name = "comboBoxTableStatus";
            this.comboBoxTableStatus.Size = new System.Drawing.Size(434, 36);
            this.comboBoxTableStatus.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(33, 432);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 18);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Trạng thái:";
            // 
            // slideTimer
            // 
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxTableStatus);
            this.Controls.Add(this.txtTableDescription);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.labelTableTitle);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonTableCancel);
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
        private MaterialSkin.Controls.MaterialButton buttonTableCancel;
        private MaterialSkin.Controls.MaterialButton buttonAddTable;
        private MaterialSkin.Controls.MaterialButton buttonDeleteTable;
        private MaterialSkin.Controls.MaterialLabel labelTableTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTableStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtTableDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtTableName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Timer slideTimer;
    }
}