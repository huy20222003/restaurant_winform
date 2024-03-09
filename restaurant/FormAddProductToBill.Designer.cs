namespace restaurant
{
    partial class FormAddProductToBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProductToBill));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductSearchValue = new MaterialSkin.Controls.MaterialTextBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.progressIndicatorProduct = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.cardFormAddProduct = new MaterialSkin.Controls.MaterialCard();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTipbuttonAddProductToBill = new Sunny.UI.UIToolTip(this.components);
            this.cardFormAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(733, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Thêm món ăn";
            // 
            // txtProductSearchValue
            // 
            this.txtProductSearchValue.AnimateReadOnly = false;
            this.txtProductSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductSearchValue.Depth = 0;
            this.txtProductSearchValue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductSearchValue.Hint = "Nhập tên sản phẩm";
            this.txtProductSearchValue.LeadingIcon = null;
            this.txtProductSearchValue.Location = new System.Drawing.Point(331, 105);
            this.txtProductSearchValue.MaxLength = 50;
            this.txtProductSearchValue.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductSearchValue.Multiline = false;
            this.txtProductSearchValue.Name = "txtProductSearchValue";
            this.txtProductSearchValue.Size = new System.Drawing.Size(861, 50);
            this.txtProductSearchValue.TabIndex = 1;
            this.txtProductSearchValue.Text = "";
            this.txtProductSearchValue.TrailingIcon = null;
            this.txtProductSearchValue.TextChanged += new System.EventHandler(this.txtProductSearchValue_TextChanged);
            // 
            // progressIndicatorProduct
            // 
            this.progressIndicatorProduct.Location = new System.Drawing.Point(665, 256);
            this.progressIndicatorProduct.Name = "progressIndicatorProduct";
            this.progressIndicatorProduct.Size = new System.Drawing.Size(90, 90);
            this.progressIndicatorProduct.TabIndex = 4;
            // 
            // cardFormAddProduct
            // 
            this.cardFormAddProduct.AutoScroll = true;
            this.cardFormAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFormAddProduct.Controls.Add(this.progressIndicatorProduct);
            this.cardFormAddProduct.Depth = 0;
            this.cardFormAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFormAddProduct.Location = new System.Drawing.Point(38, 182);
            this.cardFormAddProduct.Margin = new System.Windows.Forms.Padding(14);
            this.cardFormAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFormAddProduct.Name = "cardFormAddProduct";
            this.cardFormAddProduct.Padding = new System.Windows.Forms.Padding(14);
            this.cardFormAddProduct.Size = new System.Drawing.Size(1619, 573);
            this.cardFormAddProduct.TabIndex = 5;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // toolTipbuttonAddProductToBill
            // 
            this.toolTipbuttonAddProductToBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.toolTipbuttonAddProductToBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.toolTipbuttonAddProductToBill.OwnerDraw = true;
            // 
            // FormAddProductToBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.cardFormAddProduct);
            this.Controls.Add(this.txtProductSearchValue);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddProductToBill";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProductToBill";
            this.Load += new System.EventHandler(this.FormAddProductToBill_Load);
            this.cardFormAddProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtProductSearchValue;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progressIndicatorProduct;
        private MaterialSkin.Controls.MaterialCard cardFormAddProduct;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Sunny.UI.UIToolTip toolTipbuttonAddProductToBill;
    }
}