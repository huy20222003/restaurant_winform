using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using restaurant.DAO;
using restaurant.Global;

namespace restaurant
{
    public partial class FormAvatar : MaterialForm
    {
        private int ID;
        private string ImagePath;
        public FormAvatar()
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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAvatar(int id, string imagePath)
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ID = id;
            this.ImagePath = 
            ImagePath = imagePath;
            pictureBoxAvatar.Image = Image.FromFile(imagePath);
        }

        private async void buttonChangeAvatar_Click(object sender, EventArgs e)
        {
            if (pictureBoxAvatar.Image != null)
            {
                string imageBase64 = Data.ConvertImageToBase64(pictureBoxAvatar.Image);
                ImageServices imageServices = new ImageServices();
                string imageUrl = await imageServices.UploadImageAsync(imageBase64);

                bool response = EmployeeDAO.Instance.UpdateEmployeeAvatar(this.ID, imageUrl);
                if (response)
                {
                    CustomMessageBox.Show("Cập nhật avatar thành công");
                    this.Close();
                }
                else
                {
                    CustomMessageBox.Show("Cập nhật avatar thất bại");
                    this.Close();
                }
            }
        }

        private void buttonAvatarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
