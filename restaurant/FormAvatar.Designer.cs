namespace restaurant
{
    partial class FormAvatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvatar));
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.buttonChangeAvatar = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonAvatarCancel = new MaterialSkin.Controls.MaterialButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(90, 116);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(194, 190);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // buttonChangeAvatar
            // 
            this.buttonChangeAvatar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChangeAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeAvatar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonChangeAvatar.Depth = 0;
            this.buttonChangeAvatar.HighEmphasis = true;
            this.buttonChangeAvatar.Icon = null;
            this.buttonChangeAvatar.Location = new System.Drawing.Point(92, 344);
            this.buttonChangeAvatar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonChangeAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonChangeAvatar.Name = "buttonChangeAvatar";
            this.buttonChangeAvatar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonChangeAvatar.Size = new System.Drawing.Size(192, 36);
            this.buttonChangeAvatar.TabIndex = 1;
            this.buttonChangeAvatar.Text = "Cập nhật ảnh đại diện";
            this.buttonChangeAvatar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonChangeAvatar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonChangeAvatar.UseAccentColor = false;
            this.buttonChangeAvatar.UseVisualStyleBackColor = true;
            this.buttonChangeAvatar.Click += new System.EventHandler(this.buttonChangeAvatar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(128, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 29);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Ảnh đại diện";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAvatarCancel
            // 
            this.buttonAvatarCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAvatarCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAvatarCancel.Depth = 0;
            this.buttonAvatarCancel.HighEmphasis = true;
            this.buttonAvatarCancel.Icon = null;
            this.buttonAvatarCancel.Location = new System.Drawing.Point(150, 392);
            this.buttonAvatarCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAvatarCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAvatarCancel.Name = "buttonAvatarCancel";
            this.buttonAvatarCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAvatarCancel.Size = new System.Drawing.Size(64, 36);
            this.buttonAvatarCancel.TabIndex = 3;
            this.buttonAvatarCancel.Text = "Huỷ";
            this.buttonAvatarCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonAvatarCancel.UseAccentColor = false;
            this.buttonAvatarCancel.UseVisualStyleBackColor = true;
            this.buttonAvatarCancel.Click += new System.EventHandler(this.buttonAvatarCancel_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // FormAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.buttonAvatarCancel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonChangeAvatar);
            this.Controls.Add(this.pictureBoxAvatar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAvatar";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "FormAvatar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private MaterialSkin.Controls.MaterialButton buttonChangeAvatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton buttonAvatarCancel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}