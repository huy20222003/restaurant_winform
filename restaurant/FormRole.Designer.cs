namespace restaurant
{
    partial class FormRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRole));
            this.buttonRoleCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonRoleDelete = new MaterialSkin.Controls.MaterialButton();
            this.buttonRoleAdd = new MaterialSkin.Controls.MaterialButton();
            this.labelRoleTitle = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtRoleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoleDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoleCancel
            // 
            this.buttonRoleCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRoleCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoleCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRoleCancel.Depth = 0;
            this.buttonRoleCancel.HighEmphasis = true;
            this.buttonRoleCancel.Icon = null;
            this.buttonRoleCancel.Location = new System.Drawing.Point(34, 328);
            this.buttonRoleCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRoleCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRoleCancel.Name = "buttonRoleCancel";
            this.buttonRoleCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRoleCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonRoleCancel.TabIndex = 2;
            this.buttonRoleCancel.Text = "Huỷ";
            this.buttonRoleCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonRoleCancel.UseAccentColor = false;
            this.buttonRoleCancel.UseVisualStyleBackColor = true;
            this.buttonRoleCancel.Click += new System.EventHandler(this.buttonRoleCancel_Click);
            // 
            // buttonRoleDelete
            // 
            this.buttonRoleDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRoleDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoleDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRoleDelete.Depth = 0;
            this.buttonRoleDelete.HighEmphasis = true;
            this.buttonRoleDelete.Icon = null;
            this.buttonRoleDelete.Location = new System.Drawing.Point(257, 328);
            this.buttonRoleDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRoleDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRoleDelete.Name = "buttonRoleDelete";
            this.buttonRoleDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRoleDelete.Size = new System.Drawing.Size(64, 36);
            this.buttonRoleDelete.TabIndex = 3;
            this.buttonRoleDelete.Text = "Xoá ";
            this.buttonRoleDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonRoleDelete.UseAccentColor = false;
            this.buttonRoleDelete.UseVisualStyleBackColor = true;
            this.buttonRoleDelete.Visible = false;
            this.buttonRoleDelete.Click += new System.EventHandler(this.buttonRoleDelete_Click);
            // 
            // buttonRoleAdd
            // 
            this.buttonRoleAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRoleAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoleAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRoleAdd.Depth = 0;
            this.buttonRoleAdd.HighEmphasis = true;
            this.buttonRoleAdd.Icon = null;
            this.buttonRoleAdd.Location = new System.Drawing.Point(361, 328);
            this.buttonRoleAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRoleAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRoleAdd.Name = "buttonRoleAdd";
            this.buttonRoleAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRoleAdd.Size = new System.Drawing.Size(93, 36);
            this.buttonRoleAdd.TabIndex = 4;
            this.buttonRoleAdd.Text = "Thêm mới";
            this.buttonRoleAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonRoleAdd.UseAccentColor = false;
            this.buttonRoleAdd.UseVisualStyleBackColor = true;
            this.buttonRoleAdd.Click += new System.EventHandler(this.buttonRoleAdd_Click);
            // 
            // labelRoleTitle
            // 
            this.labelRoleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoleTitle.AutoSize = true;
            this.labelRoleTitle.Depth = 0;
            this.labelRoleTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoleTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelRoleTitle.Location = new System.Drawing.Point(159, 59);
            this.labelRoleTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoleTitle.Name = "labelRoleTitle";
            this.labelRoleTitle.Size = new System.Drawing.Size(179, 29);
            this.labelRoleTitle.TabIndex = 5;
            this.labelRoleTitle.Text = "Thêm mới quyền";
            this.labelRoleTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // txtRoleName
            // 
            this.txtRoleName.Animated = true;
            this.txtRoleName.BorderRadius = 4;
            this.txtRoleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoleName.DefaultText = "";
            this.txtRoleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRoleName.IconLeft")));
            this.txtRoleName.Location = new System.Drawing.Point(34, 121);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.PasswordChar = '\0';
            this.txtRoleName.PlaceholderText = "Tên quyền";
            this.txtRoleName.SelectedText = "";
            this.txtRoleName.Size = new System.Drawing.Size(420, 60);
            this.txtRoleName.TabIndex = 6;
            // 
            // txtRoleDescription
            // 
            this.txtRoleDescription.Animated = true;
            this.txtRoleDescription.BorderRadius = 4;
            this.txtRoleDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoleDescription.DefaultText = "";
            this.txtRoleDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoleDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoleDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoleDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleDescription.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRoleDescription.IconLeft")));
            this.txtRoleDescription.Location = new System.Drawing.Point(34, 209);
            this.txtRoleDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleDescription.Multiline = true;
            this.txtRoleDescription.Name = "txtRoleDescription";
            this.txtRoleDescription.PasswordChar = '\0';
            this.txtRoleDescription.PlaceholderText = "Mô tả";
            this.txtRoleDescription.SelectedText = "";
            this.txtRoleDescription.Size = new System.Drawing.Size(420, 96);
            this.txtRoleDescription.TabIndex = 7;
            // 
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.txtRoleDescription);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.labelRoleTitle);
            this.Controls.Add(this.buttonRoleAdd);
            this.Controls.Add(this.buttonRoleDelete);
            this.Controls.Add(this.buttonRoleCancel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRole";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRole";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton buttonRoleCancel;
        private MaterialSkin.Controls.MaterialButton buttonRoleDelete;
        private MaterialSkin.Controls.MaterialButton buttonRoleAdd;
        private MaterialSkin.Controls.MaterialLabel labelRoleTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtRoleDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtRoleName;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}