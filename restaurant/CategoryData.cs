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

namespace restaurant
{
    public partial class Main
    {
        private DataTable categoryData;
        private int itemsPerPage = 1; // Số lượng mục trên mỗi trang
        private int currentPage = 1; // Trang hiện tại
        private void getListCategoryToListView(int page)
        {
            // Tính chỉ số bắt đầu và kết thúc của dữ liệu trên trang hiện tại
            int startIndex = (page - 1) * itemsPerPage >= 0 ? (page - 1) * itemsPerPage : 0;
            int endIndex = startIndex + itemsPerPage - 1;
            CustomMessageBox.Show(startIndex.ToString() + endIndex.ToString());

            // Lấy danh sách các danh mục từ cơ sở dữ liệu
            DataTable dataTable = CategoryDAO.Instance.GetListCategory();

            // Xóa danh sách hiện tại trước khi thêm mới
            categoryListView.Items.Clear();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                int totalRows = dataTable.Rows.Count;

                // Duyệt qua mỗi dòng dữ liệu trong DataTable
                for (int i = 0; i < 1 && i < totalRows; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    // Tạo một ListViewItem mới và thêm các dữ liệu vào
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["image"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["createdAt"].ToString());
                    item.SubItems.Add(row["updatedAt"].ToString());
                    item.SubItems.Add("Sửa | Xoá");

                    // Thêm ListViewItem vào ListView
                    categoryListView.Items.Add(item);
                }
            }

            // Dispose of the DataTable if it's disposable
            dataTable?.Dispose();
        }

        // Xử lý sự kiện PageChanged của UIMiniPagination
        private void UpdateCategoryListView()
        {
            this.getListCategoryToListView(currentPage);
            // Cập nhật lại trạng thái của UIMiniPagination
            int totalItems = CategoryDAO.Instance.GetTotalCategories(); // Lấy tổng số danh mục từ cơ sở dữ liệu
            int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);
            categoryPagnation.TotalCount = totalPages;
            // Không có phương thức trực tiếp để cập nhật trang hiện tại, nên chúng ta cần cập nhật biến currentPage
        }

        // Xử lý sự kiện PageChanged của UIMiniPagination
        private void categoryPagnation_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            currentPage = pageIndex + 1; // pageIndex bắt đầu từ 0, nên cần cộng thêm 1
            this.UpdateCategoryListView();
        }

        //hàm gọi form thêm danh mục
        private void buttonOpenFormAddCategory_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.TopMost = true;
            formCategory.getListCategory = UpdateCategoryListView;
            formCategory.Show();
        }

        private void categoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEdit = true;
            // Kiểm tra xem có phần tử nào được chọn không
            if (categoryListView.SelectedItems.Count > 0)
            {
                // Lấy phần tử đầu tiên được chọn
                ListViewItem selectedItem = categoryListView.SelectedItems[0];

                // Lấy thông tin từ các cột của phần tử được chọn
                string id = selectedItem.SubItems[0].Text;
                string name = selectedItem.SubItems[2].Text;
                string description = selectedItem.SubItems[3].Text;
                string imageUrl = selectedItem.SubItems[1].Text;
                FormCategory formCategory = new FormCategory(id, name, description, imageUrl, isEdit);
                formCategory.getListCategory = UpdateCategoryListView;
                formCategory.Show();
            }
        }

        private void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtCategorySearch.Text;

            if (searchValue == "")
            {
                this.UpdateCategoryListView();
            }
            else
            {
                // Lấy danh sách các danh mục từ cơ sở dữ liệu
                DataTable dataTable = CategoryDAO.Instance.SearchCategoryByNameOrId(searchValue);

                categoryListView.Items.Clear();

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    // Duyệt qua mỗi dòng dữ liệu trong DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Tạo một ListViewItem mới và thêm các dữ liệu vào
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["image"].ToString());
                        item.SubItems.Add(row["name"].ToString());
                        item.SubItems.Add(row["description"].ToString());
                        item.SubItems.Add(row["createdAt"].ToString());
                        item.SubItems.Add(row["updatedAt"].ToString());
                        item.SubItems.Add("Sửa | Xoá");

                        // Thêm ListViewItem vào ListView
                        categoryListView.Items.Add(item);
                    }
                }
                dataTable?.Dispose();
            }
        }

    }
}
