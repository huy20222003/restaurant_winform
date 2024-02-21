using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using restaurant.DAO;
using restaurant.Global;

namespace restaurant
{
    public partial class FormTable : MaterialForm
    {
        private int ID;
        private bool isEdit = false;
        public Action getListTable;
        public FormTable()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormTable(string id, string name, string description, string status, bool isEdit)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            this.ID = int.Parse(id);
            this.isEdit = isEdit;
            if (isEdit)
            {
                labelTableTitle.Text = "Chỉnh sửa bàn";
                buttonAddTable.Text = "Sửa bàn";
                txtTableName.Text = name;
                txtTableDescription.Text = description;
                comboBoxTableStatus.Text = status;
            }
        }

        private void buttonTableCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            string description = txtTableDescription.Text;
            string status = comboBoxTableStatus.SelectedItem.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                CustomMessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            { 
                if (isEdit)
                {
                    buttonDeleteTable.Visible = true;
                    DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                    string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    bool response = TablesDAO.Instance.UpdateTable(this.ID, name, description, status, formattedDate);

                    if (response)
                    {
                        this.getListTable();
                        CustomMessageBox.Show("Sửa bàn thành công");
                        this.Close();
                    }
                    else
                    {
                        this.getListTable();
                        CustomMessageBox.Show("Sửa bàn thất bại");
                        this.Close();
                    }
                }
                else
                {
                    bool response = TablesDAO.Instance.InsertTable(name, description, status);

                    if (response)
                    {
                        this.getListTable();
                        CustomMessageBox.Show("Thêm bàn thành công");
                        this.Close();
                    }
                    else
                    {
                        this.getListTable();
                        CustomMessageBox.Show("Thêm bàn thất bại");
                        this.Close();
                    }
                }
            }
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            bool response = TablesDAO.Instance.DeleteTable(this.ID);
            if (response)
            {
                this.getListTable();
                CustomMessageBox.Show("Xoá bàn thành công");
                this.Close();
            }
            else
            {
                this.getListTable();
                CustomMessageBox.Show("Xoá bàn thất bại");
                this.Close();
            }
        }

        private void TxtTableName_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập tên bàn!");
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void TxtTableDescription_Validating(object sender, CancelEventArgs e)
        {
            MaterialMultiLineTextBox textBox = sender as MaterialMultiLineTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập mô tả bàn!");
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void ComboBoxTableStatus_Validating(object sender, CancelEventArgs e)
        {
            MaterialComboBox comboBox = sender as MaterialComboBox;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Vui lòng chọn trạng thái bàn!");
            }
            else
            {
                errorProvider.SetError(comboBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void TxtTableName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void TxtTableDescription_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void ComboBoxTableStatus_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }
    }
}
