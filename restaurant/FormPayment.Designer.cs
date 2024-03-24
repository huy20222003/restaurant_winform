namespace restaurant
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabCash = new System.Windows.Forms.TabPage();
            this.tabVNPay = new System.Windows.Forms.TabPage();
            this.uiTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabCash);
            this.uiTabControl1.Controls.Add(this.tabVNPay);
            this.uiTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 24);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.White;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTabControl1.RightToLeftLayout = true;
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.ShowToolTips = true;
            this.uiTabControl1.Size = new System.Drawing.Size(894, 573);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiTabControl1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tabCash
            // 
            this.tabCash.Location = new System.Drawing.Point(0, 40);
            this.tabCash.Name = "tabCash";
            this.tabCash.Size = new System.Drawing.Size(894, 533);
            this.tabCash.TabIndex = 0;
            this.tabCash.Text = "Tiền mặt";
            this.tabCash.UseVisualStyleBackColor = true;
            // 
            // tabVNPay
            // 
            this.tabVNPay.Location = new System.Drawing.Point(0, 40);
            this.tabVNPay.Name = "tabVNPay";
            this.tabVNPay.Size = new System.Drawing.Size(894, 533);
            this.tabVNPay.TabIndex = 1;
            this.tabVNPay.Text = "VNPay";
            this.tabVNPay.UseVisualStyleBackColor = true;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.uiTabControl1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPayment";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayment";
            this.uiTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabCash;
        private System.Windows.Forms.TabPage tabVNPay;
    }
}