namespace restaurant
{
    partial class FormUpdateTableStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateTableStatus));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonUpdateTableStatus = new MaterialSkin.Controls.MaterialButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtTableId = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxTableStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(185, 60);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(210, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cập nhật trạng thái bàn";
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCancel.Depth = 0;
            this.buttonCancel.HighEmphasis = true;
            this.buttonCancel.Icon = null;
            this.buttonCancel.Location = new System.Drawing.Point(343, 338);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonCancel.UseAccentColor = false;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdateTableStatus
            // 
            this.buttonUpdateTableStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdateTableStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateTableStatus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonUpdateTableStatus.Depth = 0;
            this.buttonUpdateTableStatus.HighEmphasis = true;
            this.buttonUpdateTableStatus.Icon = null;
            this.buttonUpdateTableStatus.Location = new System.Drawing.Point(438, 338);
            this.buttonUpdateTableStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUpdateTableStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdateTableStatus.Name = "buttonUpdateTableStatus";
            this.buttonUpdateTableStatus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonUpdateTableStatus.Size = new System.Drawing.Size(93, 36);
            this.buttonUpdateTableStatus.TabIndex = 4;
            this.buttonUpdateTableStatus.Text = "Cập nhật";
            this.buttonUpdateTableStatus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonUpdateTableStatus.UseAccentColor = false;
            this.buttonUpdateTableStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateTableStatus.Click += new System.EventHandler(this.buttonUpdateTableStatus_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // txtTableId
            // 
            this.txtTableId.Animated = true;
            this.txtTableId.BorderRadius = 4;
            this.txtTableId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableId.DefaultText = "";
            this.txtTableId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableId.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTableId.IconLeft")));
            this.txtTableId.Location = new System.Drawing.Point(45, 121);
            this.txtTableId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.PasswordChar = '\0';
            this.txtTableId.PlaceholderText = "ID";
            this.txtTableId.SelectedText = "";
            this.txtTableId.Size = new System.Drawing.Size(505, 60);
            this.txtTableId.TabIndex = 5;
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
            this.comboBoxTableStatus.Location = new System.Drawing.Point(45, 235);
            this.comboBoxTableStatus.Name = "comboBoxTableStatus";
            this.comboBoxTableStatus.Size = new System.Drawing.Size(505, 36);
            this.comboBoxTableStatus.TabIndex = 6;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(45, 201);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 18);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Trạng thái:";
            // 
            // FormUpdateTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxTableStatus);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.buttonUpdateTableStatus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateTableStatus";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateTableStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonUpdateTableStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtTableId;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTableStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}