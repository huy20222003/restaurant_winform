using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using restaurant.DAO;

namespace restaurant
{
    public partial class FormUpdateTableStatus : MaterialForm
    {
        public Action showTableInBill;
        private int ID;
        public FormUpdateTableStatus()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        public FormUpdateTableStatus(string id, string status)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            txtTableId.Text = id;
            txtTableId.ReadOnly = true;
            this.ID = int.Parse(id);
            comboBoxTableStatus.Text = status;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdateTableStatus_Click(object sender, EventArgs e)
        {
            string status = comboBoxTableStatus.SelectedItem.ToString();
            DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
            string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
            bool response = TablesDAO.Instance.UpdateTableStatus(this.ID, status, formattedDate);
            if(response)
            {
                this.showTableInBill();
                this.Close();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật trạng thái bàn thành công", ToolTipIcon.Info);
            } else
            {
                this.showTableInBill();
                this.Close();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật trạng thái bàn thất bại", ToolTipIcon.Error);
            }
        }
    }
}
