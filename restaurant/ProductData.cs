using restaurant.DAO;
using restaurant.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sunny.UI;

namespace restaurant
{
    public partial class Main
    {
        private FlowLayoutPanel flowLayoutPanelProduct;
        private void ShowProductItems(DataTable productList)
        {
            // Hiển thị hiệu ứng loader
            progressIndicatorProduct.Visible = true;

            // Tạo mới FlowLayoutPanel
            flowLayoutPanelProduct = new FlowLayoutPanel();
            flowLayoutPanelProduct.Controls.Clear();
            flowLayoutPanelProduct.FlowDirection = (System.Windows.Forms.FlowDirection)System.Windows.FlowDirection.LeftToRight;
            flowLayoutPanelProduct.WrapContents = true;
            flowLayoutPanelProduct.AutoScroll = true;
            flowLayoutPanelProduct.Location = new System.Drawing.Point(10, 200);
            flowLayoutPanelProduct.Width = tabProduct.Width;
            flowLayoutPanelProduct.Height = tabProduct.Height;

            flowLayoutPanelProduct.Controls.Clear();
            // Lặp qua từng bản ghi trong DataTable
            foreach (DataRow row in productList.Rows)
            {
                // Tạo một MaterialCard mới cho mỗi sản phẩm
                MaterialCard cardProductItem = new MaterialCard();
                cardProductItem.Width = 340;
                cardProductItem.Height = 180;
                cardProductItem.Padding = new Padding(5);
                cardProductItem.Margin = new Padding(10);

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = row["ImageUrl"].ToString();
                pictureBox.Location = new System.Drawing.Point(170, 0);
                pictureBox.Width = cardProductItem.Width / 2;
                pictureBox.Height = cardProductItem.Height;
                pictureBox.InitialImage = Properties.Resources.logo_ver_2;

                // Tạo các phần tử thông tin sản phẩm và đặt vị trí cho chúng
                UILabel labelNameValue = new UILabel() { Text = row["Name"].ToString(), AutoSize = true, Font = new Font("Segoe UI", 10, System.Drawing.FontStyle.Regular) };
                labelNameValue.Location = new System.Drawing.Point(10, 20);

                var font = new Font("Segoe UI", 12);
                UILabel labelPriceValue = new UILabel() { Text = row["Price"].ToString() + "VND", AutoSize = true, Font = font, ForeColor = Color.FromArgb(80, 160, 255) };
                labelPriceValue.ForeColor = System.Drawing.Color.Blue;
                labelPriceValue.Location = new System.Drawing.Point(10, 140);

                cardProductItem.Cursor = Cursors.Hand;
                cardProductItem.DoubleClick += cardProductItem_DoubleClick;
                cardProductItem.Tag = row;

                cardProductItem.Controls.Add(pictureBox);
                cardProductItem.Controls.Add(labelNameValue);
                cardProductItem.Controls.Add(labelPriceValue);

                // Thêm thẻ sản phẩm vào FlowLayoutPanel
                flowLayoutPanelProduct.Controls.Add(cardProductItem);
            }
            tabProduct.Controls.Add(flowLayoutPanelProduct);

            // Ẩn hiệu ứng loader khi đã thêm xong các card sản phẩm
            progressIndicatorProduct.Visible = false;
        }


        private void ShowAllProducts()
        {
            DataTable productList = ProductDAO.Instance.GetListProduct();
            // Xóa tất cả các card sản phẩm trong flowLayoutPanelProduct
            this.ShowProductItems(productList);
            productList?.Dispose();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductSearch.Text))
            {
                this.ShowAllProducts();
            }
            else
            {
                DataTable productList = ProductDAO.Instance.GetProductByName(txtProductSearch.Text);
                this.ShowProductItems(productList);
                productList?.Dispose();
            }
        }


        private void cardProductItem_DoubleClick(object sender, EventArgs e)
        {
            bool isEdit = true;
            DataRow productInfo = (sender as MaterialCard).Tag as DataRow;

            string id = productInfo["ID"].ToString();
            string name = productInfo["Name"].ToString();
            string description = productInfo["Description"].ToString();
            string imageUrl = productInfo["imageUrl"].ToString();
            string price = productInfo["Price"].ToString();
            string priceSale = productInfo["PriceSale"].ToString();
            string status = productInfo["Status"].ToString();
            string color = productInfo["Color"].ToString();
            string size = productInfo["Size"].ToString();
            string quantity = productInfo["Quantity"].ToString();
            string categoryId = productInfo["CategoryId"].ToString();

            FormProduct formProduct = new FormProduct(id, name, description, imageUrl, price, priceSale, categoryId, status, color, size, quantity, isEdit);
            formProduct.TopMost = true;
            formProduct.GetListProduct = this.ShowAllProducts;
            formProduct.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.TopMost = true;
            formProduct.GetListProduct = this.ShowAllProducts;
            formProduct.ShowDialog();
        }
    }
}
