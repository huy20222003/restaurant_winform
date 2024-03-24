using MaterialSkin.Controls;
using MaterialSkin;
using restaurant.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Main
    {
        private void showEmployeeItem()
        {
            ClearCardItem();
            DataTable employeeList = EmployeeDAO.Instance.GetListEmployee();
            // Lặp qua từng bản ghi trong DataTable
            foreach (DataRow row in employeeList.Rows)
            {
                // Tạo một MaterialCard mới cho mỗi sản phẩm
                MaterialCard cardEmployeeItem = new MaterialCard();
                cardEmployeeItem.Width = 600; // Đặt độ rộng của thẻ sản phẩm
                cardEmployeeItem.Height = 250;
                cardEmployeeItem.Padding = new Padding(10); // Đặt padding cho thẻ sản phẩm
                cardEmployeeItem.Margin = new Padding(20, 150, 10, 10);

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = cardEmployeeItem.Width / 3; // Chiếm 1/3 chiều rộng của cardEmployeeItem
                pictureBox.Height = cardEmployeeItem.Height; // Chiều cao bằng cardEmployeeItem
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = row["avatar"].ToString();


                // Thêm các thông tin sản phẩm vào TableLayoutPanel
                MaterialLabel labelFullName = new MaterialLabel() { Text = "Tên đầy đủ: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelFullName.Location = new System.Drawing.Point(220, 20);
                MaterialLabel labelFullNameValue = new MaterialLabel() { Text = row["FullName"].ToString(), AutoSize = true };
                labelFullNameValue.Location = new System.Drawing.Point(350, 20);

                MaterialLabel labelUsername = new MaterialLabel() { Text = "Tên đăng nhập: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelUsername.Location = new System.Drawing.Point(220, 50);
                MaterialLabel labelUsernameValue = new MaterialLabel() { Text = row["Username"].ToString(), AutoSize = true };
                labelUsernameValue.Location = new System.Drawing.Point(350, 50);

                MaterialLabel labelGender = new MaterialLabel() { Text = "Giới tính: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelGender.Location = new System.Drawing.Point(220, 80);
                MaterialLabel labelGenderValue = new MaterialLabel() { Text = row["Gender"].ToString(), AutoSize = true };
                labelGenderValue.Location = new System.Drawing.Point(350, 80);

                MaterialLabel labelAddress = new MaterialLabel() { Text = "Địa chỉ: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelAddress.Location = new System.Drawing.Point(220, 110);
                MaterialLabel labelAddressValue = new MaterialLabel() { Text = row["Address"].ToString(), AutoSize = true };
                labelAddressValue.Location = new System.Drawing.Point(350, 110);

                MaterialLabel labelAge = new MaterialLabel() { Text = "Tuổi: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelAge.Location = new System.Drawing.Point(220, 140);
                MaterialLabel labelAgeValue = new MaterialLabel() { Text = row["Age"].ToString(), AutoSize = true };
                labelAgeValue.Location = new System.Drawing.Point(350, 140);

                MaterialLabel labelPosition = new MaterialLabel() { Text = "Chức vụ: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelPosition.Location = new System.Drawing.Point(220, 170);
                int roleID = int.Parse(row["roleID"].ToString());
                DTO.Role role = RoleDAO.Instance.GetRoleById(roleID);
                MaterialLabel labelPositionValue = new MaterialLabel() { Text = role.Name, AutoSize = true };
                labelPositionValue.Location = new System.Drawing.Point(350, 170);

                MaterialButton buttonViewDetailEmployee = new MaterialButton() { Text = "Xem chi tiết", AutoSize = true, Cursor = Cursors.Hand };
                buttonViewDetailEmployee.Location = new System.Drawing.Point(400, 200);


                cardEmployeeItem.Controls.Add(pictureBox);
                cardEmployeeItem.Controls.Add(labelFullName);
                cardEmployeeItem.Controls.Add(labelFullNameValue);
                cardEmployeeItem.Controls.Add(labelUsername);
                cardEmployeeItem.Controls.Add(labelUsernameValue);
                cardEmployeeItem.Controls.Add(labelGender);
                cardEmployeeItem.Controls.Add(labelGenderValue);
                cardEmployeeItem.Controls.Add(labelAddress);
                cardEmployeeItem.Controls.Add(labelAddressValue);
                cardEmployeeItem.Controls.Add(labelAge);
                cardEmployeeItem.Controls.Add(labelAgeValue);
                cardEmployeeItem.Controls.Add(labelPosition);
                cardEmployeeItem.Controls.Add(labelPositionValue);
                cardEmployeeItem.Controls.Add(buttonViewDetailEmployee);

                buttonViewDetailEmployee.Click += buttonViewDetailEmployee_Click;
                buttonViewDetailEmployee.Tag = row;

                // Thêm thẻ sản phẩm vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(cardEmployeeItem);
            }
            employeeList?.Dispose();
            // Thêm FlowLayoutPanel vào TabPage hoặc Panel tương ứng
            tabEmployee.Controls.Add(flowLayoutPanel);
        }

        private void buttonViewDetailEmployee_Click(object sender, EventArgs e)
        {
            bool isEdit = true;
            DataRow employeeInfo = (sender as MaterialButton).Tag as DataRow;

            string id = employeeInfo["ID"].ToString();
            string fullName = employeeInfo["FullName"].ToString();
            string username = employeeInfo["Username"].ToString();
            string avatar = employeeInfo["Avatar"].ToString();
            string gender = employeeInfo["Gender"].ToString();
            string age = employeeInfo["Age"].ToString();
            string address = employeeInfo["Address"].ToString();
            string roleId = employeeInfo["RoleID"].ToString();
            string phoneNumber = employeeInfo["PhoneNumber"].ToString();

            FormEmployee formEmployee = new FormEmployee(id, fullName, username, avatar, age, address, gender, phoneNumber, roleId, isEdit);
            formEmployee.TopMost = true;
            formEmployee.getListEmployee = this.showEmployeeItem;
            formEmployee.Show();
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.TopMost = true;
            formEmployee.getListEmployee = this.showEmployeeItem;
            formEmployee.Show();
        }
    }
}
