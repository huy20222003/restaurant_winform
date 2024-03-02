namespace restaurant
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.label_message = new MaterialSkin.Controls.MaterialLabel();
            this.button_confirm = new MaterialSkin.Controls.MaterialButton();
            this.button_cancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Depth = 0;
            this.label_message.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_message.Location = new System.Drawing.Point(6, 51);
            this.label_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(1, 0);
            this.label_message.TabIndex = 0;
            // 
            // button_confirm
            // 
            this.button_confirm.AutoSize = false;
            this.button_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_confirm.Depth = 0;
            this.button_confirm.HighEmphasis = true;
            this.button_confirm.Icon = null;
            this.button_confirm.Location = new System.Drawing.Point(425, 161);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_confirm.Size = new System.Drawing.Size(85, 36);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "Đồng ý";
            this.button_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_confirm.UseAccentColor = false;
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.AutoSize = false;
            this.button_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_cancel.BackColor = System.Drawing.Color.Red;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_cancel.Depth = 0;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.HighEmphasis = true;
            this.button_cancel.Icon = null;
            this.button_cancel.Location = new System.Drawing.Point(332, 161);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_cancel.Size = new System.Drawing.Size(85, 36);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Huỷ";
            this.button_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_cancel.UseAccentColor = false;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(517, 215);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_message);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Message Box";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_message;
        private MaterialSkin.Controls.MaterialButton button_confirm;
        private MaterialSkin.Controls.MaterialButton button_cancel;
    }
}