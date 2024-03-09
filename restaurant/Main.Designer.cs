using System.Drawing;

namespace restaurant
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.materialCard13 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar = new System.Windows.Forms.PictureBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.labelDashboardCountProductSelled = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton4 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.labelDashboardRevenue = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.labelDashboardCountBill = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.labelDashboardCountEmployee = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.txtCategorySearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialCard22 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername1 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOpenFormAddCategory = new MaterialSkin.Controls.MaterialButton();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.categoryPagnation = new Sunny.UI.UIMiniPagination();
            this.categoryListView = new MaterialSkin.Controls.MaterialListView();
            this.categoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryUpdatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.txtProductSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialCard23 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername3 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar3 = new System.Windows.Forms.PictureBox();
            this.progressIndicatorProduct = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.buttonAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.txtTableSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialCard14 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername4 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar4 = new System.Windows.Forms.PictureBox();
            this.buttonOpenFormAddTable = new MaterialSkin.Controls.MaterialButton();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.tableListView = new MaterialSkin.Controls.MaterialListView();
            this.tableId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableUpdatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.materialCard15 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout5 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername5 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar5 = new System.Windows.Forms.PictureBox();
            this.buttonBillPrintBill = new MaterialSkin.Controls.MaterialButton();
            this.buttonBillPayment = new MaterialSkin.Controls.MaterialButton();
            this.cardBillTable = new MaterialSkin.Controls.MaterialCard();
            this.label20 = new System.Windows.Forms.Label();
            this.cardBillProducts = new MaterialSkin.Controls.MaterialCard();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.materialCard16 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout6 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername6 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar6 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.materialCard25 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout7 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername7 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar7 = new System.Windows.Forms.PictureBox();
            this.buttonEmployeeAdd = new MaterialSkin.Controls.MaterialButton();
            this.label19 = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.txtRoleSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialCard21 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout8 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername8 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar8 = new System.Windows.Forms.PictureBox();
            this.buttonOpenFormAddRole = new MaterialSkin.Controls.MaterialButton();
            this.label17 = new System.Windows.Forms.Label();
            this.materialCard19 = new MaterialSkin.Controls.MaterialCard();
            this.roleListView = new MaterialSkin.Controls.MaterialListView();
            this.roleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleUpdatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.materialCard20 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout9 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername9 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar9 = new System.Windows.Forms.PictureBox();
            this.materialCard17 = new MaterialSkin.Controls.MaterialCard();
            this.txtAccountPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxAccountAge = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxAccountGender = new MaterialSkin.Controls.MaterialComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonAccountChangeInfo = new MaterialSkin.Controls.MaterialButton();
            this.txtAccountAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAccountUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAccountFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.labelAccountFullName = new MaterialSkin.Controls.MaterialLabel();
            this.labelAccountUsername = new MaterialSkin.Controls.MaterialLabel();
            this.buttonAccountChooseImage = new MaterialSkin.Controls.MaterialButton();
            this.pictureBoxAccountAvatar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.materialCard12 = new MaterialSkin.Controls.MaterialCard();
            this.labelTimeNow9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonDashboardLogout10 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelDashboardEmployeeUsername10 = new System.Windows.Forms.Label();
            this.pictureBoxDashboardEmployeeAvatar10 = new System.Windows.Forms.PictureBox();
            this.materialCard18 = new MaterialSkin.Controls.MaterialCard();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonSettingChangePassword = new MaterialSkin.Controls.MaterialButton();
            this.txtSettingConfirmNewPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSettingNewPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSettingOldPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelProductCategory = new MaterialSkin.Controls.MaterialLabel();
            this.labelProductDescription = new MaterialSkin.Controls.MaterialLabel();
            this.labelProductName = new MaterialSkin.Controls.MaterialLabel();
            this.buttonProductDelete = new MaterialSkin.Controls.MaterialButton();
            this.buttonProductEdit = new MaterialSkin.Controls.MaterialButton();
            this.buttonProductViewDetail = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProductSize = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.imageListCategory = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.materialCard13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar)).BeginInit();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tabCategory.SuspendLayout();
            this.materialCard22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar1)).BeginInit();
            this.materialCard7.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.materialCard23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar3)).BeginInit();
            this.tabTable.SuspendLayout();
            this.materialCard14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar4)).BeginInit();
            this.materialCard8.SuspendLayout();
            this.tabBill.SuspendLayout();
            this.materialCard15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar5)).BeginInit();
            this.tabAnalytics.SuspendLayout();
            this.materialCard11.SuspendLayout();
            this.materialCard16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar6)).BeginInit();
            this.tabEmployee.SuspendLayout();
            this.materialCard25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar7)).BeginInit();
            this.tabRole.SuspendLayout();
            this.materialCard21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar8)).BeginInit();
            this.materialCard19.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.materialCard20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar9)).BeginInit();
            this.materialCard17.SuspendLayout();
            this.materialCard10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountAvatar)).BeginInit();
            this.tabSetting.SuspendLayout();
            this.materialCard12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar10)).BeginInit();
            this.materialCard18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabCategory);
            this.tabControl.Controls.Add(this.tabProduct);
            this.tabControl.Controls.Add(this.tabTable);
            this.tabControl.Controls.Add(this.tabBill);
            this.tabControl.Controls.Add(this.tabAnalytics);
            this.tabControl.Controls.Add(this.tabEmployee);
            this.tabControl.Controls.Add(this.tabRole);
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabSetting);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageListTab;
            this.tabControl.Location = new System.Drawing.Point(0, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1413, 833);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabDashboard
            // 
            this.tabDashboard.AutoScroll = true;
            this.tabDashboard.Controls.Add(this.materialCard13);
            this.tabDashboard.Controls.Add(this.materialCard4);
            this.tabDashboard.Controls.Add(this.materialCard3);
            this.tabDashboard.Controls.Add(this.materialCard2);
            this.tabDashboard.Controls.Add(this.materialCard1);
            this.tabDashboard.Controls.Add(this.materialCard6);
            this.tabDashboard.Controls.Add(this.materialCard5);
            this.tabDashboard.ImageKey = "icons8-home-50.png";
            this.tabDashboard.Location = new System.Drawing.Point(4, 32);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1405, 797);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Trang chủ";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // materialCard13
            // 
            this.materialCard13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard13.Controls.Add(this.labelTimeNow);
            this.materialCard13.Controls.Add(this.buttonDashboardLogout);
            this.materialCard13.Controls.Add(this.labelDashboardEmployeeUsername);
            this.materialCard13.Controls.Add(this.pictureBoxDashboardEmployeeAvatar);
            this.materialCard13.Depth = 0;
            this.materialCard13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard13.Location = new System.Drawing.Point(0, 0);
            this.materialCard13.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard13.Name = "materialCard13";
            this.materialCard13.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard13.Size = new System.Drawing.Size(1402, 69);
            this.materialCard13.TabIndex = 6;
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(3, 2);
            this.labelTimeNow.TabIndex = 7;
            this.labelTimeNow.Text = null;
            // 
            // buttonDashboardLogout
            // 
            this.buttonDashboardLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout.Image")));
            this.buttonDashboardLogout.ImageRotate = 0F;
            this.buttonDashboardLogout.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout.Name = "buttonDashboardLogout";
            this.buttonDashboardLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout.TabIndex = 8;
            this.buttonDashboardLogout.TabStop = false;
            this.buttonDashboardLogout.UseTransparentBackground = true;
            this.buttonDashboardLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelDashboardEmployeeUsername
            // 
            this.labelDashboardEmployeeUsername.AutoSize = true;
            this.labelDashboardEmployeeUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername.Name = "labelDashboardEmployeeUsername";
            this.labelDashboardEmployeeUsername.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername.TabIndex = 1;
            this.labelDashboardEmployeeUsername.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar
            // 
            this.pictureBoxDashboardEmployeeAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar.Image")));
            this.pictureBoxDashboardEmployeeAvatar.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar.Name = "pictureBoxDashboardEmployeeAvatar";
            this.pictureBoxDashboardEmployeeAvatar.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar.TabStop = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.labelDashboardCountProductSelled);
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Controls.Add(this.materialFloatingActionButton4);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(1004, 162);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(290, 129);
            this.materialCard4.TabIndex = 3;
            // 
            // labelDashboardCountProductSelled
            // 
            this.labelDashboardCountProductSelled.AutoSize = true;
            this.labelDashboardCountProductSelled.Depth = 0;
            this.labelDashboardCountProductSelled.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDashboardCountProductSelled.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelDashboardCountProductSelled.Location = new System.Drawing.Point(48, 54);
            this.labelDashboardCountProductSelled.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDashboardCountProductSelled.Name = "labelDashboardCountProductSelled";
            this.labelDashboardCountProductSelled.Size = new System.Drawing.Size(14, 29);
            this.labelDashboardCountProductSelled.TabIndex = 3;
            this.labelDashboardCountProductSelled.Text = "0";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(18, 18);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(188, 19);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "Tổng số sản phẩm đã bán";
            // 
            // materialFloatingActionButton4
            // 
            this.materialFloatingActionButton4.Depth = 0;
            this.materialFloatingActionButton4.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton4.Icon")));
            this.materialFloatingActionButton4.ImageKey = "icons8-kawaii-bread-50.png";
            this.materialFloatingActionButton4.ImageList = this.imageListTab;
            this.materialFloatingActionButton4.Location = new System.Drawing.Point(217, 17);
            this.materialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton4.Name = "materialFloatingActionButton4";
            this.materialFloatingActionButton4.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton4.TabIndex = 1;
            this.materialFloatingActionButton4.Text = "materialFloatingActionButton4";
            this.materialFloatingActionButton4.UseVisualStyleBackColor = false;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "icons8-analytics-50.png");
            this.imageListTab.Images.SetKeyName(1, "icons8-bill-50.png");
            this.imageListTab.Images.SetKeyName(2, "icons8-home-50.png");
            this.imageListTab.Images.SetKeyName(3, "icons8-kawaii-bread-50.png");
            this.imageListTab.Images.SetKeyName(4, "icons8-list-50.png");
            this.imageListTab.Images.SetKeyName(5, "icons8-table-50.png");
            this.imageListTab.Images.SetKeyName(6, "icons8-user-50.png");
            this.imageListTab.Images.SetKeyName(7, "icons8-money-50.png");
            this.imageListTab.Images.SetKeyName(8, "icons8-setting-50.png");
            this.imageListTab.Images.SetKeyName(9, "icons8-employee-50.png");
            this.imageListTab.Images.SetKeyName(10, "icons8-role-66.png");
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.labelDashboardRevenue);
            this.materialCard3.Controls.Add(this.materialLabel6);
            this.materialCard3.Controls.Add(this.materialFloatingActionButton3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(673, 162);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(290, 129);
            this.materialCard3.TabIndex = 2;
            // 
            // labelDashboardRevenue
            // 
            this.labelDashboardRevenue.AutoSize = true;
            this.labelDashboardRevenue.Depth = 0;
            this.labelDashboardRevenue.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDashboardRevenue.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelDashboardRevenue.Location = new System.Drawing.Point(55, 54);
            this.labelDashboardRevenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDashboardRevenue.Name = "labelDashboardRevenue";
            this.labelDashboardRevenue.Size = new System.Drawing.Size(14, 29);
            this.labelDashboardRevenue.TabIndex = 3;
            this.labelDashboardRevenue.Text = "0";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(18, 18);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Doanh thu";
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton3.Icon")));
            this.materialFloatingActionButton3.ImageKey = "icons8-money-50.png";
            this.materialFloatingActionButton3.ImageList = this.imageListTab;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(217, 17);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 1;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.labelDashboardCountBill);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialFloatingActionButton2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(346, 162);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(290, 129);
            this.materialCard2.TabIndex = 1;
            // 
            // labelDashboardCountBill
            // 
            this.labelDashboardCountBill.AutoSize = true;
            this.labelDashboardCountBill.Depth = 0;
            this.labelDashboardCountBill.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDashboardCountBill.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelDashboardCountBill.Location = new System.Drawing.Point(51, 54);
            this.labelDashboardCountBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDashboardCountBill.Name = "labelDashboardCountBill";
            this.labelDashboardCountBill.Size = new System.Drawing.Size(14, 29);
            this.labelDashboardCountBill.TabIndex = 3;
            this.labelDashboardCountBill.Text = "0";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 18);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Tổng số hoá đơn";
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.ImageKey = "icons8-bill-50.png";
            this.materialFloatingActionButton2.ImageList = this.imageListTab;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(217, 17);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 1;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.labelDashboardCountEmployee);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialFloatingActionButton1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 162);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(290, 129);
            this.materialCard1.TabIndex = 0;
            // 
            // labelDashboardCountEmployee
            // 
            this.labelDashboardCountEmployee.AutoSize = true;
            this.labelDashboardCountEmployee.Depth = 0;
            this.labelDashboardCountEmployee.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDashboardCountEmployee.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelDashboardCountEmployee.Location = new System.Drawing.Point(53, 54);
            this.labelDashboardCountEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDashboardCountEmployee.Name = "labelDashboardCountEmployee";
            this.labelDashboardCountEmployee.Size = new System.Drawing.Size(14, 29);
            this.labelDashboardCountEmployee.TabIndex = 3;
            this.labelDashboardCountEmployee.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Tổng số nhân viên";
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton1.Icon")));
            this.materialFloatingActionButton1.ImageKey = "icons8-user-50.png";
            this.materialFloatingActionButton1.ImageList = this.imageListTab;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(217, 17);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 1;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.pieChart1);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(1004, 390);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(290, 325);
            this.materialCard6.TabIndex = 5;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(14, 14);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(262, 297);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.cartesianChart1);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(20, 390);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(926, 325);
            this.materialCard5.TabIndex = 4;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(14, 14);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(898, 297);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.txtCategorySearch);
            this.tabCategory.Controls.Add(this.materialCard22);
            this.tabCategory.Controls.Add(this.label6);
            this.tabCategory.Controls.Add(this.buttonOpenFormAddCategory);
            this.tabCategory.Controls.Add(this.materialCard7);
            this.tabCategory.ImageKey = "icons8-list-50.png";
            this.tabCategory.Location = new System.Drawing.Point(4, 32);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(1405, 797);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Danh mục";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Animated = true;
            this.txtCategorySearch.BorderRadius = 4;
            this.txtCategorySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategorySearch.DefaultText = "";
            this.txtCategorySearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategorySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategorySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategorySearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategorySearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategorySearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategorySearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategorySearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtCategorySearch.IconLeft")));
            this.txtCategorySearch.Location = new System.Drawing.Point(14, 202);
            this.txtCategorySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.PasswordChar = '\0';
            this.txtCategorySearch.PlaceholderText = "Nhập ID hoặc tên danh mục";
            this.txtCategorySearch.SelectedText = "";
            this.txtCategorySearch.Size = new System.Drawing.Size(287, 50);
            this.txtCategorySearch.TabIndex = 9;
            this.txtCategorySearch.TextChanged += new System.EventHandler(this.txtCategorySearch_TextChanged);
            // 
            // materialCard22
            // 
            this.materialCard22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard22.Controls.Add(this.labelTimeNow1);
            this.materialCard22.Controls.Add(this.buttonDashboardLogout1);
            this.materialCard22.Controls.Add(this.labelDashboardEmployeeUsername1);
            this.materialCard22.Controls.Add(this.pictureBoxDashboardEmployeeAvatar1);
            this.materialCard22.Depth = 0;
            this.materialCard22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard22.Location = new System.Drawing.Point(0, 0);
            this.materialCard22.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard22.Name = "materialCard22";
            this.materialCard22.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard22.Size = new System.Drawing.Size(1402, 69);
            this.materialCard22.TabIndex = 8;
            // 
            // labelTimeNow1
            // 
            this.labelTimeNow1.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow1.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow1.Name = "labelTimeNow1";
            this.labelTimeNow1.Size = new System.Drawing.Size(3, 2);
            this.labelTimeNow1.TabIndex = 7;
            this.labelTimeNow1.Text = null;
            // 
            // buttonDashboardLogout1
            // 
            this.buttonDashboardLogout1.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout1.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout1.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout1.Image")));
            this.buttonDashboardLogout1.ImageRotate = 0F;
            this.buttonDashboardLogout1.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout1.Name = "buttonDashboardLogout1";
            this.buttonDashboardLogout1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout1.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout1.TabIndex = 8;
            this.buttonDashboardLogout1.TabStop = false;
            this.buttonDashboardLogout1.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername1
            // 
            this.labelDashboardEmployeeUsername1.AutoSize = true;
            this.labelDashboardEmployeeUsername1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername1.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername1.Name = "labelDashboardEmployeeUsername1";
            this.labelDashboardEmployeeUsername1.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername1.TabIndex = 1;
            this.labelDashboardEmployeeUsername1.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar1
            // 
            this.pictureBoxDashboardEmployeeAvatar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar1.Image")));
            this.pictureBoxDashboardEmployeeAvatar1.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar1.Name = "pictureBoxDashboardEmployeeAvatar1";
            this.pictureBoxDashboardEmployeeAvatar1.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar1.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh mục";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOpenFormAddCategory
            // 
            this.buttonOpenFormAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenFormAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFormAddCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonOpenFormAddCategory.Depth = 0;
            this.buttonOpenFormAddCategory.HighEmphasis = true;
            this.buttonOpenFormAddCategory.Icon = null;
            this.buttonOpenFormAddCategory.Location = new System.Drawing.Point(1188, 219);
            this.buttonOpenFormAddCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOpenFormAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonOpenFormAddCategory.Name = "buttonOpenFormAddCategory";
            this.buttonOpenFormAddCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonOpenFormAddCategory.Size = new System.Drawing.Size(142, 36);
            this.buttonOpenFormAddCategory.TabIndex = 1;
            this.buttonOpenFormAddCategory.Text = "Thêm danh mục";
            this.buttonOpenFormAddCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonOpenFormAddCategory.UseAccentColor = false;
            this.buttonOpenFormAddCategory.UseVisualStyleBackColor = true;
            this.buttonOpenFormAddCategory.Click += new System.EventHandler(this.buttonOpenFormAddCategory_Click);
            // 
            // materialCard7
            // 
            this.materialCard7.AutoScroll = true;
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.categoryPagnation);
            this.materialCard7.Controls.Add(this.categoryListView);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 270);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(1316, 513);
            this.materialCard7.TabIndex = 0;
            // 
            // categoryPagnation
            // 
            this.categoryPagnation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryPagnation.FillColorGradient = true;
            this.categoryPagnation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryPagnation.Location = new System.Drawing.Point(14, 459);
            this.categoryPagnation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryPagnation.MinimumSize = new System.Drawing.Size(1, 1);
            this.categoryPagnation.Name = "categoryPagnation";
            this.categoryPagnation.PagerCount = 5;
            this.categoryPagnation.PageSize = 1;
            this.categoryPagnation.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.categoryPagnation.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.categoryPagnation.ShowText = false;
            this.categoryPagnation.Size = new System.Drawing.Size(1288, 40);
            this.categoryPagnation.TabIndex = 2;
            this.categoryPagnation.Text = null;
            this.categoryPagnation.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryPagnation.TotalCount = 1000;
            this.categoryPagnation.PageChanged += new Sunny.UI.UIMiniPagination.OnPageChangeEventHandler(this.categoryPagnation_PageChanged);
            // 
            // categoryListView
            // 
            this.categoryListView.AutoSizeTable = false;
            this.categoryListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryId,
            this.categoryImage,
            this.categoryName,
            this.categoryDescription,
            this.categoryCreatedAt,
            this.categoryUpdatedAt,
            this.categoryAction});
            this.categoryListView.Depth = 0;
            this.categoryListView.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.HideSelection = false;
            this.categoryListView.HoverSelection = true;
            this.categoryListView.Location = new System.Drawing.Point(14, 14);
            this.categoryListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.categoryListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.categoryListView.MouseState = MaterialSkin.MouseState.OUT;
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.OwnerDraw = true;
            this.categoryListView.Size = new System.Drawing.Size(1288, 457);
            this.categoryListView.TabIndex = 1;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.SelectedIndexChanged += new System.EventHandler(this.categoryListView_SelectedIndexChanged);
            // 
            // categoryId
            // 
            this.categoryId.Text = "ID";
            this.categoryId.Width = 50;
            // 
            // categoryImage
            // 
            this.categoryImage.Text = "Hình ảnh";
            this.categoryImage.Width = 150;
            // 
            // categoryName
            // 
            this.categoryName.Text = "Mô tả";
            this.categoryName.Width = 250;
            // 
            // categoryDescription
            // 
            this.categoryDescription.Text = "Mô tả";
            this.categoryDescription.Width = 300;
            // 
            // categoryCreatedAt
            // 
            this.categoryCreatedAt.Text = "Ngày tạo";
            this.categoryCreatedAt.Width = 180;
            // 
            // categoryUpdatedAt
            // 
            this.categoryUpdatedAt.Text = "Ngày cập nhật";
            this.categoryUpdatedAt.Width = 180;
            // 
            // categoryAction
            // 
            this.categoryAction.Text = "Hành động";
            this.categoryAction.Width = 200;
            // 
            // tabProduct
            // 
            this.tabProduct.AutoScroll = true;
            this.tabProduct.Controls.Add(this.txtProductSearch);
            this.tabProduct.Controls.Add(this.materialCard23);
            this.tabProduct.Controls.Add(this.progressIndicatorProduct);
            this.tabProduct.Controls.Add(this.buttonAddProduct);
            this.tabProduct.Controls.Add(this.label5);
            this.tabProduct.ImageKey = "icons8-kawaii-bread-50.png";
            this.tabProduct.Location = new System.Drawing.Point(4, 32);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(1405, 797);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Sản phẩm";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Animated = true;
            this.txtProductSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductSearch.DefaultText = "";
            this.txtProductSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtProductSearch.IconLeft")));
            this.txtProductSearch.Location = new System.Drawing.Point(17, 129);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.PasswordChar = '\0';
            this.txtProductSearch.PlaceholderText = "Nhập ID hoặc tên sản phẩm\r\n";
            this.txtProductSearch.SelectedText = "";
            this.txtProductSearch.Size = new System.Drawing.Size(287, 50);
            this.txtProductSearch.TabIndex = 12;
            // 
            // materialCard23
            // 
            this.materialCard23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard23.Controls.Add(this.labelTimeNow2);
            this.materialCard23.Controls.Add(this.buttonDashboardLogout3);
            this.materialCard23.Controls.Add(this.labelDashboardEmployeeUsername3);
            this.materialCard23.Controls.Add(this.pictureBoxDashboardEmployeeAvatar3);
            this.materialCard23.Depth = 0;
            this.materialCard23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard23.Location = new System.Drawing.Point(0, 0);
            this.materialCard23.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard23.Name = "materialCard23";
            this.materialCard23.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard23.Size = new System.Drawing.Size(1402, 69);
            this.materialCard23.TabIndex = 11;
            // 
            // labelTimeNow2
            // 
            this.labelTimeNow2.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow2.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow2.Name = "labelTimeNow2";
            this.labelTimeNow2.Size = new System.Drawing.Size(3, 2);
            this.labelTimeNow2.TabIndex = 7;
            this.labelTimeNow2.Text = null;
            // 
            // buttonDashboardLogout3
            // 
            this.buttonDashboardLogout3.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout3.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout3.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout3.Image")));
            this.buttonDashboardLogout3.ImageRotate = 0F;
            this.buttonDashboardLogout3.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout3.Name = "buttonDashboardLogout3";
            this.buttonDashboardLogout3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout3.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout3.TabIndex = 8;
            this.buttonDashboardLogout3.TabStop = false;
            this.buttonDashboardLogout3.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername3
            // 
            this.labelDashboardEmployeeUsername3.AutoSize = true;
            this.labelDashboardEmployeeUsername3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername3.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername3.Name = "labelDashboardEmployeeUsername3";
            this.labelDashboardEmployeeUsername3.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername3.TabIndex = 1;
            this.labelDashboardEmployeeUsername3.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar3
            // 
            this.pictureBoxDashboardEmployeeAvatar3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar3.Image")));
            this.pictureBoxDashboardEmployeeAvatar3.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar3.Name = "pictureBoxDashboardEmployeeAvatar3";
            this.pictureBoxDashboardEmployeeAvatar3.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar3.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar3.TabStop = false;
            // 
            // progressIndicatorProduct
            // 
            this.progressIndicatorProduct.AutoStart = true;
            this.progressIndicatorProduct.Location = new System.Drawing.Point(578, 325);
            this.progressIndicatorProduct.Name = "progressIndicatorProduct";
            this.progressIndicatorProduct.Size = new System.Drawing.Size(90, 90);
            this.progressIndicatorProduct.TabIndex = 9;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddProduct.Depth = 0;
            this.buttonAddProduct.HighEmphasis = true;
            this.buttonAddProduct.Icon = null;
            this.buttonAddProduct.Location = new System.Drawing.Point(1126, 143);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddProduct.Size = new System.Drawing.Size(141, 36);
            this.buttonAddProduct.TabIndex = 8;
            this.buttonAddProduct.Text = "Thêm sản phẩm";
            this.buttonAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddProduct.UseAccentColor = false;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sản phẩm";
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.txtTableSearch);
            this.tabTable.Controls.Add(this.materialCard14);
            this.tabTable.Controls.Add(this.buttonOpenFormAddTable);
            this.tabTable.Controls.Add(this.materialCard8);
            this.tabTable.Controls.Add(this.label7);
            this.tabTable.ImageKey = "icons8-table-50.png";
            this.tabTable.Location = new System.Drawing.Point(4, 32);
            this.tabTable.Name = "tabTable";
            this.tabTable.Size = new System.Drawing.Size(1405, 797);
            this.tabTable.TabIndex = 3;
            this.tabTable.Text = "Danh sách bàn";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // txtTableSearch
            // 
            this.txtTableSearch.Animated = true;
            this.txtTableSearch.BorderRadius = 4;
            this.txtTableSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableSearch.DefaultText = "";
            this.txtTableSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTableSearch.IconLeft")));
            this.txtTableSearch.Location = new System.Drawing.Point(14, 189);
            this.txtTableSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTableSearch.Name = "txtTableSearch";
            this.txtTableSearch.PasswordChar = '\0';
            this.txtTableSearch.PlaceholderText = "Nhập ID hoặc tên bàn";
            this.txtTableSearch.SelectedText = "";
            this.txtTableSearch.Size = new System.Drawing.Size(287, 50);
            this.txtTableSearch.TabIndex = 11;
            this.txtTableSearch.TextChanged += new System.EventHandler(this.txtTableSearch_TextChanged);
            // 
            // materialCard14
            // 
            this.materialCard14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard14.Controls.Add(this.labelTimeNow3);
            this.materialCard14.Controls.Add(this.buttonDashboardLogout4);
            this.materialCard14.Controls.Add(this.labelDashboardEmployeeUsername4);
            this.materialCard14.Controls.Add(this.pictureBoxDashboardEmployeeAvatar4);
            this.materialCard14.Depth = 0;
            this.materialCard14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard14.Location = new System.Drawing.Point(0, 0);
            this.materialCard14.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard14.Name = "materialCard14";
            this.materialCard14.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard14.Size = new System.Drawing.Size(1402, 69);
            this.materialCard14.TabIndex = 10;
            // 
            // labelTimeNow3
            // 
            this.labelTimeNow3.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow3.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow3.Name = "labelTimeNow3";
            this.labelTimeNow3.Size = new System.Drawing.Size(3, 2);
            this.labelTimeNow3.TabIndex = 7;
            this.labelTimeNow3.Text = null;
            // 
            // buttonDashboardLogout4
            // 
            this.buttonDashboardLogout4.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout4.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout4.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout4.Image")));
            this.buttonDashboardLogout4.ImageRotate = 0F;
            this.buttonDashboardLogout4.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout4.Name = "buttonDashboardLogout4";
            this.buttonDashboardLogout4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout4.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout4.TabIndex = 8;
            this.buttonDashboardLogout4.TabStop = false;
            this.buttonDashboardLogout4.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername4
            // 
            this.labelDashboardEmployeeUsername4.AutoSize = true;
            this.labelDashboardEmployeeUsername4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername4.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername4.Name = "labelDashboardEmployeeUsername4";
            this.labelDashboardEmployeeUsername4.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername4.TabIndex = 1;
            this.labelDashboardEmployeeUsername4.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar4
            // 
            this.pictureBoxDashboardEmployeeAvatar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar4.Image")));
            this.pictureBoxDashboardEmployeeAvatar4.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar4.Name = "pictureBoxDashboardEmployeeAvatar4";
            this.pictureBoxDashboardEmployeeAvatar4.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar4.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar4.TabStop = false;
            // 
            // buttonOpenFormAddTable
            // 
            this.buttonOpenFormAddTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenFormAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFormAddTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonOpenFormAddTable.Depth = 0;
            this.buttonOpenFormAddTable.HighEmphasis = true;
            this.buttonOpenFormAddTable.Icon = null;
            this.buttonOpenFormAddTable.Location = new System.Drawing.Point(1235, 179);
            this.buttonOpenFormAddTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOpenFormAddTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonOpenFormAddTable.Name = "buttonOpenFormAddTable";
            this.buttonOpenFormAddTable.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonOpenFormAddTable.Size = new System.Drawing.Size(95, 36);
            this.buttonOpenFormAddTable.TabIndex = 2;
            this.buttonOpenFormAddTable.Text = "Thêm bàn";
            this.buttonOpenFormAddTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonOpenFormAddTable.UseAccentColor = false;
            this.buttonOpenFormAddTable.UseVisualStyleBackColor = true;
            this.buttonOpenFormAddTable.Click += new System.EventHandler(this.buttonOpenFormAddTable_Click);
            // 
            // materialCard8
            // 
            this.materialCard8.AutoScroll = true;
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.tableListView);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(14, 257);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(1316, 510);
            this.materialCard8.TabIndex = 1;
            // 
            // tableListView
            // 
            this.tableListView.AutoSizeTable = false;
            this.tableListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableId,
            this.tableName,
            this.tableDescription,
            this.tableStatus,
            this.tableCreatedAt,
            this.tableUpdatedAt,
            this.tableAction});
            this.tableListView.Depth = 0;
            this.tableListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableListView.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableListView.FullRowSelect = true;
            this.tableListView.HideSelection = false;
            this.tableListView.HoverSelection = true;
            this.tableListView.Location = new System.Drawing.Point(14, 14);
            this.tableListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.tableListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tableListView.MouseState = MaterialSkin.MouseState.OUT;
            this.tableListView.Name = "tableListView";
            this.tableListView.OwnerDraw = true;
            this.tableListView.Size = new System.Drawing.Size(1288, 482);
            this.tableListView.TabIndex = 2;
            this.tableListView.UseCompatibleStateImageBehavior = false;
            this.tableListView.View = System.Windows.Forms.View.Details;
            this.tableListView.SelectedIndexChanged += new System.EventHandler(this.tableListView_SelectedIndexChanged);
            // 
            // tableId
            // 
            this.tableId.Text = "ID";
            // 
            // tableName
            // 
            this.tableName.Text = "Tên bàn";
            this.tableName.Width = 200;
            // 
            // tableDescription
            // 
            this.tableDescription.Text = "Mô tả";
            this.tableDescription.Width = 300;
            // 
            // tableStatus
            // 
            this.tableStatus.Text = "Trạng thái";
            this.tableStatus.Width = 150;
            // 
            // tableCreatedAt
            // 
            this.tableCreatedAt.Text = "Ngày tạo";
            this.tableCreatedAt.Width = 180;
            // 
            // tableUpdatedAt
            // 
            this.tableUpdatedAt.Text = "Ngày cập nhật";
            this.tableUpdatedAt.Width = 180;
            // 
            // tableAction
            // 
            this.tableAction.Text = "Hành động";
            this.tableAction.Width = 180;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh sách bàn";
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.materialCard15);
            this.tabBill.Controls.Add(this.buttonBillPrintBill);
            this.tabBill.Controls.Add(this.buttonBillPayment);
            this.tabBill.Controls.Add(this.cardBillTable);
            this.tabBill.Controls.Add(this.label20);
            this.tabBill.Controls.Add(this.cardBillProducts);
            this.tabBill.ImageKey = "icons8-bill-50.png";
            this.tabBill.Location = new System.Drawing.Point(4, 32);
            this.tabBill.Name = "tabBill";
            this.tabBill.Size = new System.Drawing.Size(1405, 797);
            this.tabBill.TabIndex = 4;
            this.tabBill.Text = "Hoá đơn";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // materialCard15
            // 
            this.materialCard15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard15.Controls.Add(this.labelTimeNow4);
            this.materialCard15.Controls.Add(this.buttonDashboardLogout5);
            this.materialCard15.Controls.Add(this.labelDashboardEmployeeUsername5);
            this.materialCard15.Controls.Add(this.pictureBoxDashboardEmployeeAvatar5);
            this.materialCard15.Depth = 0;
            this.materialCard15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard15.Location = new System.Drawing.Point(0, 0);
            this.materialCard15.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard15.Name = "materialCard15";
            this.materialCard15.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard15.Size = new System.Drawing.Size(1402, 69);
            this.materialCard15.TabIndex = 14;
            // 
            // labelTimeNow4
            // 
            this.labelTimeNow4.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow4.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow4.Name = "labelTimeNow4";
            this.labelTimeNow4.Size = new System.Drawing.Size(3, 2);
            this.labelTimeNow4.TabIndex = 7;
            this.labelTimeNow4.Text = null;
            // 
            // buttonDashboardLogout5
            // 
            this.buttonDashboardLogout5.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout5.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout5.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout5.Image")));
            this.buttonDashboardLogout5.ImageRotate = 0F;
            this.buttonDashboardLogout5.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout5.Name = "buttonDashboardLogout5";
            this.buttonDashboardLogout5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout5.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout5.TabIndex = 8;
            this.buttonDashboardLogout5.TabStop = false;
            this.buttonDashboardLogout5.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername5
            // 
            this.labelDashboardEmployeeUsername5.AutoSize = true;
            this.labelDashboardEmployeeUsername5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername5.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername5.Name = "labelDashboardEmployeeUsername5";
            this.labelDashboardEmployeeUsername5.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername5.TabIndex = 1;
            this.labelDashboardEmployeeUsername5.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar5
            // 
            this.pictureBoxDashboardEmployeeAvatar5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar5.Image")));
            this.pictureBoxDashboardEmployeeAvatar5.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar5.Name = "pictureBoxDashboardEmployeeAvatar5";
            this.pictureBoxDashboardEmployeeAvatar5.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar5.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar5.TabStop = false;
            // 
            // buttonBillPrintBill
            // 
            this.buttonBillPrintBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBillPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBillPrintBill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonBillPrintBill.Depth = 0;
            this.buttonBillPrintBill.HighEmphasis = true;
            this.buttonBillPrintBill.Icon = null;
            this.buttonBillPrintBill.Location = new System.Drawing.Point(1059, 755);
            this.buttonBillPrintBill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBillPrintBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBillPrintBill.Name = "buttonBillPrintBill";
            this.buttonBillPrintBill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonBillPrintBill.Size = new System.Drawing.Size(127, 36);
            this.buttonBillPrintBill.TabIndex = 13;
            this.buttonBillPrintBill.Text = "Xuất hoá đơn";
            this.buttonBillPrintBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonBillPrintBill.UseAccentColor = false;
            this.buttonBillPrintBill.UseVisualStyleBackColor = true;
            // 
            // buttonBillPayment
            // 
            this.buttonBillPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBillPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBillPayment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonBillPayment.Depth = 0;
            this.buttonBillPayment.HighEmphasis = true;
            this.buttonBillPayment.Icon = null;
            this.buttonBillPayment.Location = new System.Drawing.Point(1225, 755);
            this.buttonBillPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBillPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBillPayment.Name = "buttonBillPayment";
            this.buttonBillPayment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonBillPayment.Size = new System.Drawing.Size(114, 36);
            this.buttonBillPayment.TabIndex = 12;
            this.buttonBillPayment.Text = "Thanh toán";
            this.buttonBillPayment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonBillPayment.UseAccentColor = false;
            this.buttonBillPayment.UseVisualStyleBackColor = true;
            this.buttonBillPayment.Click += new System.EventHandler(this.buttonBillPayment_Click);
            // 
            // cardBillTable
            // 
            this.cardBillTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardBillTable.Depth = 0;
            this.cardBillTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardBillTable.Location = new System.Drawing.Point(27, 149);
            this.cardBillTable.Margin = new System.Windows.Forms.Padding(14);
            this.cardBillTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardBillTable.Name = "cardBillTable";
            this.cardBillTable.Padding = new System.Windows.Forms.Padding(14);
            this.cardBillTable.Size = new System.Drawing.Size(835, 596);
            this.cardBillTable.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(20, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 38);
            this.label20.TabIndex = 8;
            this.label20.Text = "Hoá đơn";
            // 
            // cardBillProducts
            // 
            this.cardBillProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardBillProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardBillProducts.BackgroundImage")));
            this.cardBillProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardBillProducts.Depth = 0;
            this.cardBillProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardBillProducts.Location = new System.Drawing.Point(883, 149);
            this.cardBillProducts.Margin = new System.Windows.Forms.Padding(14);
            this.cardBillProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardBillProducts.Name = "cardBillProducts";
            this.cardBillProducts.Padding = new System.Windows.Forms.Padding(14);
            this.cardBillProducts.Size = new System.Drawing.Size(456, 596);
            this.cardBillProducts.TabIndex = 10;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Controls.Add(this.materialCard11);
            this.tabAnalytics.Controls.Add(this.materialCard16);
            this.tabAnalytics.Controls.Add(this.guna2HtmlLabel1);
            this.tabAnalytics.ImageKey = "icons8-analytics-50.png";
            this.tabAnalytics.Location = new System.Drawing.Point(4, 32);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Size = new System.Drawing.Size(1405, 797);
            this.tabAnalytics.TabIndex = 5;
            this.tabAnalytics.Text = "Thống kê";
            this.tabAnalytics.UseVisualStyleBackColor = true;
            // 
            // materialCard11
            // 
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.reportViewer1);
            this.materialCard11.Depth = 0;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(14, 213);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard11.Size = new System.Drawing.Size(1377, 570);
            this.materialCard11.TabIndex = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(14, 14);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1349, 542);
            this.reportViewer1.TabIndex = 0;
            // 
            // materialCard16
            // 
            this.materialCard16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard16.Controls.Add(this.labelTimeNow5);
            this.materialCard16.Controls.Add(this.buttonDashboardLogout6);
            this.materialCard16.Controls.Add(this.labelDashboardEmployeeUsername6);
            this.materialCard16.Controls.Add(this.pictureBoxDashboardEmployeeAvatar6);
            this.materialCard16.Depth = 0;
            this.materialCard16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard16.Location = new System.Drawing.Point(0, 0);
            this.materialCard16.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard16.Name = "materialCard16";
            this.materialCard16.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard16.Size = new System.Drawing.Size(1402, 69);
            this.materialCard16.TabIndex = 9;
            // 
            // labelTimeNow5
            // 
            this.labelTimeNow5.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow5.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow5.Name = "labelTimeNow5";
            this.labelTimeNow5.Size = new System.Drawing.Size(19, 30);
            this.labelTimeNow5.TabIndex = 7;
            this.labelTimeNow5.Text = "11";
            // 
            // buttonDashboardLogout6
            // 
            this.buttonDashboardLogout6.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout6.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout6.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout6.Image")));
            this.buttonDashboardLogout6.ImageRotate = 0F;
            this.buttonDashboardLogout6.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout6.Name = "buttonDashboardLogout6";
            this.buttonDashboardLogout6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout6.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout6.TabIndex = 8;
            this.buttonDashboardLogout6.TabStop = false;
            this.buttonDashboardLogout6.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername6
            // 
            this.labelDashboardEmployeeUsername6.AutoSize = true;
            this.labelDashboardEmployeeUsername6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername6.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername6.Name = "labelDashboardEmployeeUsername6";
            this.labelDashboardEmployeeUsername6.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername6.TabIndex = 1;
            this.labelDashboardEmployeeUsername6.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar6
            // 
            this.pictureBoxDashboardEmployeeAvatar6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar6.Image")));
            this.pictureBoxDashboardEmployeeAvatar6.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar6.Name = "pictureBoxDashboardEmployeeAvatar6";
            this.pictureBoxDashboardEmployeeAvatar6.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar6.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar6.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 75);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(117, 39);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Thống kê";
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.materialCard25);
            this.tabEmployee.Controls.Add(this.buttonEmployeeAdd);
            this.tabEmployee.Controls.Add(this.label19);
            this.tabEmployee.ImageKey = "icons8-employee-50.png";
            this.tabEmployee.Location = new System.Drawing.Point(4, 32);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(1405, 797);
            this.tabEmployee.TabIndex = 6;
            this.tabEmployee.Text = "Nhân viên";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // materialCard25
            // 
            this.materialCard25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard25.Controls.Add(this.labelTimeNow6);
            this.materialCard25.Controls.Add(this.buttonDashboardLogout7);
            this.materialCard25.Controls.Add(this.labelDashboardEmployeeUsername7);
            this.materialCard25.Controls.Add(this.pictureBoxDashboardEmployeeAvatar7);
            this.materialCard25.Depth = 0;
            this.materialCard25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard25.Location = new System.Drawing.Point(0, 0);
            this.materialCard25.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard25.Name = "materialCard25";
            this.materialCard25.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard25.Size = new System.Drawing.Size(1402, 69);
            this.materialCard25.TabIndex = 9;
            // 
            // labelTimeNow6
            // 
            this.labelTimeNow6.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow6.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow6.Name = "labelTimeNow6";
            this.labelTimeNow6.Size = new System.Drawing.Size(19, 30);
            this.labelTimeNow6.TabIndex = 7;
            this.labelTimeNow6.Text = "11";
            // 
            // buttonDashboardLogout7
            // 
            this.buttonDashboardLogout7.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout7.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout7.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout7.Image")));
            this.buttonDashboardLogout7.ImageRotate = 0F;
            this.buttonDashboardLogout7.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout7.Name = "buttonDashboardLogout7";
            this.buttonDashboardLogout7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout7.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout7.TabIndex = 8;
            this.buttonDashboardLogout7.TabStop = false;
            this.buttonDashboardLogout7.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername7
            // 
            this.labelDashboardEmployeeUsername7.AutoSize = true;
            this.labelDashboardEmployeeUsername7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername7.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername7.Name = "labelDashboardEmployeeUsername7";
            this.labelDashboardEmployeeUsername7.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername7.TabIndex = 1;
            this.labelDashboardEmployeeUsername7.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar7
            // 
            this.pictureBoxDashboardEmployeeAvatar7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar7.Image")));
            this.pictureBoxDashboardEmployeeAvatar7.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar7.Name = "pictureBoxDashboardEmployeeAvatar7";
            this.pictureBoxDashboardEmployeeAvatar7.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar7.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar7.TabStop = false;
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmployeeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeeAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEmployeeAdd.Depth = 0;
            this.buttonEmployeeAdd.HighEmphasis = true;
            this.buttonEmployeeAdd.Icon = null;
            this.buttonEmployeeAdd.Location = new System.Drawing.Point(1145, 98);
            this.buttonEmployeeAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEmployeeAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEmployeeAdd.Size = new System.Drawing.Size(143, 36);
            this.buttonEmployeeAdd.TabIndex = 10;
            this.buttonEmployeeAdd.Text = "Thêm nhân viên";
            this.buttonEmployeeAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEmployeeAdd.UseAccentColor = false;
            this.buttonEmployeeAdd.UseVisualStyleBackColor = true;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonEmployeeAdd_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(42, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 38);
            this.label19.TabIndex = 9;
            this.label19.Text = "Nhân viên";
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.txtRoleSearch);
            this.tabRole.Controls.Add(this.materialCard21);
            this.tabRole.Controls.Add(this.buttonOpenFormAddRole);
            this.tabRole.Controls.Add(this.label17);
            this.tabRole.Controls.Add(this.materialCard19);
            this.tabRole.ImageKey = "icons8-role-66.png";
            this.tabRole.Location = new System.Drawing.Point(4, 32);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(1405, 797);
            this.tabRole.TabIndex = 9;
            this.tabRole.Text = "Quyền";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // txtRoleSearch
            // 
            this.txtRoleSearch.Animated = true;
            this.txtRoleSearch.BorderRadius = 4;
            this.txtRoleSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoleSearch.DefaultText = "";
            this.txtRoleSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoleSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoleSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoleSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoleSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoleSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRoleSearch.IconLeft")));
            this.txtRoleSearch.Location = new System.Drawing.Point(23, 247);
            this.txtRoleSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleSearch.Name = "txtRoleSearch";
            this.txtRoleSearch.PasswordChar = '\0';
            this.txtRoleSearch.PlaceholderText = "Nhập ID hoặc tên quyền";
            this.txtRoleSearch.SelectedText = "";
            this.txtRoleSearch.Size = new System.Drawing.Size(287, 50);
            this.txtRoleSearch.TabIndex = 14;
            this.txtRoleSearch.TextChanged += new System.EventHandler(this.txtRoleSearch_TextChanged);
            // 
            // materialCard21
            // 
            this.materialCard21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard21.Controls.Add(this.labelTimeNow7);
            this.materialCard21.Controls.Add(this.buttonDashboardLogout8);
            this.materialCard21.Controls.Add(this.labelDashboardEmployeeUsername8);
            this.materialCard21.Controls.Add(this.pictureBoxDashboardEmployeeAvatar8);
            this.materialCard21.Depth = 0;
            this.materialCard21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard21.Location = new System.Drawing.Point(0, 0);
            this.materialCard21.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard21.Name = "materialCard21";
            this.materialCard21.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard21.Size = new System.Drawing.Size(1402, 69);
            this.materialCard21.TabIndex = 13;
            // 
            // labelTimeNow7
            // 
            this.labelTimeNow7.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow7.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow7.Name = "labelTimeNow7";
            this.labelTimeNow7.Size = new System.Drawing.Size(19, 30);
            this.labelTimeNow7.TabIndex = 7;
            this.labelTimeNow7.Text = "11";
            // 
            // buttonDashboardLogout8
            // 
            this.buttonDashboardLogout8.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout8.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout8.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout8.Image")));
            this.buttonDashboardLogout8.ImageRotate = 0F;
            this.buttonDashboardLogout8.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout8.Name = "buttonDashboardLogout8";
            this.buttonDashboardLogout8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout8.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout8.TabIndex = 8;
            this.buttonDashboardLogout8.TabStop = false;
            this.buttonDashboardLogout8.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername8
            // 
            this.labelDashboardEmployeeUsername8.AutoSize = true;
            this.labelDashboardEmployeeUsername8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername8.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername8.Name = "labelDashboardEmployeeUsername8";
            this.labelDashboardEmployeeUsername8.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername8.TabIndex = 1;
            this.labelDashboardEmployeeUsername8.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar8
            // 
            this.pictureBoxDashboardEmployeeAvatar8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar8.Image")));
            this.pictureBoxDashboardEmployeeAvatar8.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar8.Name = "pictureBoxDashboardEmployeeAvatar8";
            this.pictureBoxDashboardEmployeeAvatar8.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar8.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar8.TabStop = false;
            // 
            // buttonOpenFormAddRole
            // 
            this.buttonOpenFormAddRole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenFormAddRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFormAddRole.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonOpenFormAddRole.Depth = 0;
            this.buttonOpenFormAddRole.HighEmphasis = true;
            this.buttonOpenFormAddRole.Icon = null;
            this.buttonOpenFormAddRole.Location = new System.Drawing.Point(1226, 262);
            this.buttonOpenFormAddRole.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOpenFormAddRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonOpenFormAddRole.Name = "buttonOpenFormAddRole";
            this.buttonOpenFormAddRole.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonOpenFormAddRole.Size = new System.Drawing.Size(113, 36);
            this.buttonOpenFormAddRole.TabIndex = 12;
            this.buttonOpenFormAddRole.Text = "Thêm quyền";
            this.buttonOpenFormAddRole.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonOpenFormAddRole.UseAccentColor = false;
            this.buttonOpenFormAddRole.UseVisualStyleBackColor = true;
            this.buttonOpenFormAddRole.Click += new System.EventHandler(this.buttonOpenFormAddRole_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(564, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 41);
            this.label17.TabIndex = 9;
            this.label17.Text = "Quyền";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialCard19
            // 
            this.materialCard19.AutoScroll = true;
            this.materialCard19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard19.Controls.Add(this.roleListView);
            this.materialCard19.Depth = 0;
            this.materialCard19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard19.Location = new System.Drawing.Point(23, 313);
            this.materialCard19.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard19.Name = "materialCard19";
            this.materialCard19.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard19.Size = new System.Drawing.Size(1316, 484);
            this.materialCard19.TabIndex = 1;
            // 
            // roleListView
            // 
            this.roleListView.AutoSizeTable = false;
            this.roleListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roleListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roleID,
            this.roleName,
            this.roleDescription,
            this.roleCreatedAt,
            this.roleUpdatedAt,
            this.roleAction});
            this.roleListView.Depth = 0;
            this.roleListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleListView.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleListView.FullRowSelect = true;
            this.roleListView.HideSelection = false;
            this.roleListView.HoverSelection = true;
            this.roleListView.Location = new System.Drawing.Point(14, 14);
            this.roleListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.roleListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.roleListView.MouseState = MaterialSkin.MouseState.OUT;
            this.roleListView.Name = "roleListView";
            this.roleListView.OwnerDraw = true;
            this.roleListView.Size = new System.Drawing.Size(1288, 456);
            this.roleListView.TabIndex = 1;
            this.roleListView.UseCompatibleStateImageBehavior = false;
            this.roleListView.View = System.Windows.Forms.View.Details;
            this.roleListView.SelectedIndexChanged += new System.EventHandler(this.roleListView_SelectedIndexChanged);
            // 
            // roleID
            // 
            this.roleID.Text = "ID";
            // 
            // roleName
            // 
            this.roleName.Text = "Tên quyền";
            this.roleName.Width = 200;
            // 
            // roleDescription
            // 
            this.roleDescription.Text = "Mô tả";
            this.roleDescription.Width = 300;
            // 
            // roleCreatedAt
            // 
            this.roleCreatedAt.Text = "Ngày tạo";
            this.roleCreatedAt.Width = 150;
            // 
            // roleUpdatedAt
            // 
            this.roleUpdatedAt.Text = "Ngày cập nhật";
            this.roleUpdatedAt.Width = 180;
            // 
            // roleAction
            // 
            this.roleAction.Text = "Hành động";
            this.roleAction.Width = 180;
            // 
            // tabAccount
            // 
            this.tabAccount.AutoScroll = true;
            this.tabAccount.Controls.Add(this.materialCard20);
            this.tabAccount.Controls.Add(this.materialCard17);
            this.tabAccount.Controls.Add(this.materialCard10);
            this.tabAccount.Controls.Add(this.label8);
            this.tabAccount.ImageKey = "icons8-user-50.png";
            this.tabAccount.Location = new System.Drawing.Point(4, 32);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1405, 797);
            this.tabAccount.TabIndex = 7;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // materialCard20
            // 
            this.materialCard20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard20.Controls.Add(this.labelTimeNow8);
            this.materialCard20.Controls.Add(this.buttonDashboardLogout9);
            this.materialCard20.Controls.Add(this.labelDashboardEmployeeUsername9);
            this.materialCard20.Controls.Add(this.pictureBoxDashboardEmployeeAvatar9);
            this.materialCard20.Depth = 0;
            this.materialCard20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard20.Location = new System.Drawing.Point(0, 0);
            this.materialCard20.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard20.Name = "materialCard20";
            this.materialCard20.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard20.Size = new System.Drawing.Size(1402, 69);
            this.materialCard20.TabIndex = 9;
            // 
            // labelTimeNow8
            // 
            this.labelTimeNow8.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow8.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow8.Name = "labelTimeNow8";
            this.labelTimeNow8.Size = new System.Drawing.Size(19, 30);
            this.labelTimeNow8.TabIndex = 7;
            this.labelTimeNow8.Text = "11";
            // 
            // buttonDashboardLogout9
            // 
            this.buttonDashboardLogout9.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout9.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout9.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout9.Image")));
            this.buttonDashboardLogout9.ImageRotate = 0F;
            this.buttonDashboardLogout9.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout9.Name = "buttonDashboardLogout9";
            this.buttonDashboardLogout9.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout9.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout9.TabIndex = 8;
            this.buttonDashboardLogout9.TabStop = false;
            this.buttonDashboardLogout9.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername9
            // 
            this.labelDashboardEmployeeUsername9.AutoSize = true;
            this.labelDashboardEmployeeUsername9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername9.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername9.Name = "labelDashboardEmployeeUsername9";
            this.labelDashboardEmployeeUsername9.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername9.TabIndex = 1;
            this.labelDashboardEmployeeUsername9.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar9
            // 
            this.pictureBoxDashboardEmployeeAvatar9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar9.Image")));
            this.pictureBoxDashboardEmployeeAvatar9.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar9.Name = "pictureBoxDashboardEmployeeAvatar9";
            this.pictureBoxDashboardEmployeeAvatar9.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar9.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar9.TabStop = false;
            // 
            // materialCard17
            // 
            this.materialCard17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard17.Controls.Add(this.txtAccountPhoneNumber);
            this.materialCard17.Controls.Add(this.comboBoxAccountAge);
            this.materialCard17.Controls.Add(this.comboBoxAccountGender);
            this.materialCard17.Controls.Add(this.label14);
            this.materialCard17.Controls.Add(this.buttonAccountChangeInfo);
            this.materialCard17.Controls.Add(this.txtAccountAddress);
            this.materialCard17.Controls.Add(this.txtAccountUsername);
            this.materialCard17.Controls.Add(this.txtAccountFullName);
            this.materialCard17.Depth = 0;
            this.materialCard17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard17.Location = new System.Drawing.Point(600, 149);
            this.materialCard17.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard17.Name = "materialCard17";
            this.materialCard17.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard17.Size = new System.Drawing.Size(687, 598);
            this.materialCard17.TabIndex = 4;
            // 
            // txtAccountPhoneNumber
            // 
            this.txtAccountPhoneNumber.AnimateReadOnly = false;
            this.txtAccountPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountPhoneNumber.Depth = 0;
            this.txtAccountPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountPhoneNumber.Hint = "Số điện thoại";
            this.txtAccountPhoneNumber.LeadingIcon = null;
            this.txtAccountPhoneNumber.Location = new System.Drawing.Point(39, 468);
            this.txtAccountPhoneNumber.MaxLength = 50;
            this.txtAccountPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAccountPhoneNumber.Multiline = false;
            this.txtAccountPhoneNumber.Name = "txtAccountPhoneNumber";
            this.txtAccountPhoneNumber.Size = new System.Drawing.Size(614, 50);
            this.txtAccountPhoneNumber.TabIndex = 7;
            this.txtAccountPhoneNumber.Text = "";
            this.txtAccountPhoneNumber.TrailingIcon = null;
            // 
            // comboBoxAccountAge
            // 
            this.comboBoxAccountAge.AutoResize = false;
            this.comboBoxAccountAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAccountAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAccountAge.Depth = 0;
            this.comboBoxAccountAge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxAccountAge.DropDownHeight = 174;
            this.comboBoxAccountAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountAge.DropDownWidth = 121;
            this.comboBoxAccountAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxAccountAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxAccountAge.FormattingEnabled = true;
            this.comboBoxAccountAge.Hint = "Chọn tuổi";
            this.comboBoxAccountAge.IntegralHeight = false;
            this.comboBoxAccountAge.ItemHeight = 43;
            this.comboBoxAccountAge.Location = new System.Drawing.Point(39, 402);
            this.comboBoxAccountAge.MaxDropDownItems = 4;
            this.comboBoxAccountAge.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxAccountAge.Name = "comboBoxAccountAge";
            this.comboBoxAccountAge.Size = new System.Drawing.Size(614, 49);
            this.comboBoxAccountAge.StartIndex = 0;
            this.comboBoxAccountAge.TabIndex = 6;
            // 
            // comboBoxAccountGender
            // 
            this.comboBoxAccountGender.AutoResize = false;
            this.comboBoxAccountGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAccountGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAccountGender.Depth = 0;
            this.comboBoxAccountGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxAccountGender.DropDownHeight = 174;
            this.comboBoxAccountGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountGender.DropDownWidth = 121;
            this.comboBoxAccountGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxAccountGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxAccountGender.FormattingEnabled = true;
            this.comboBoxAccountGender.Hint = "Chọn giới tính";
            this.comboBoxAccountGender.IntegralHeight = false;
            this.comboBoxAccountGender.ItemHeight = 43;
            this.comboBoxAccountGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxAccountGender.Location = new System.Drawing.Point(39, 328);
            this.comboBoxAccountGender.MaxDropDownItems = 4;
            this.comboBoxAccountGender.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxAccountGender.Name = "comboBoxAccountGender";
            this.comboBoxAccountGender.Size = new System.Drawing.Size(614, 49);
            this.comboBoxAccountGender.StartIndex = 0;
            this.comboBoxAccountGender.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 31);
            this.label14.TabIndex = 4;
            this.label14.Text = "Thông tin cá nhân";
            // 
            // buttonAccountChangeInfo
            // 
            this.buttonAccountChangeInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAccountChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccountChangeInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAccountChangeInfo.Depth = 0;
            this.buttonAccountChangeInfo.HighEmphasis = true;
            this.buttonAccountChangeInfo.Icon = null;
            this.buttonAccountChangeInfo.Location = new System.Drawing.Point(560, 542);
            this.buttonAccountChangeInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccountChangeInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccountChangeInfo.Name = "buttonAccountChangeInfo";
            this.buttonAccountChangeInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccountChangeInfo.Size = new System.Drawing.Size(93, 36);
            this.buttonAccountChangeInfo.TabIndex = 3;
            this.buttonAccountChangeInfo.Text = "Cập nhật";
            this.buttonAccountChangeInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccountChangeInfo.UseAccentColor = false;
            this.buttonAccountChangeInfo.UseVisualStyleBackColor = true;
            this.buttonAccountChangeInfo.Click += new System.EventHandler(this.buttonAccountChangeInfo_Click);
            // 
            // txtAccountAddress
            // 
            this.txtAccountAddress.AnimateReadOnly = false;
            this.txtAccountAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountAddress.Depth = 0;
            this.txtAccountAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountAddress.Hint = "Nhập địa chỉ";
            this.txtAccountAddress.LeadingIcon = null;
            this.txtAccountAddress.Location = new System.Drawing.Point(33, 248);
            this.txtAccountAddress.MaxLength = 50;
            this.txtAccountAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAccountAddress.Multiline = false;
            this.txtAccountAddress.Name = "txtAccountAddress";
            this.txtAccountAddress.Size = new System.Drawing.Size(620, 50);
            this.txtAccountAddress.TabIndex = 2;
            this.txtAccountAddress.Text = "";
            this.txtAccountAddress.TrailingIcon = null;
            // 
            // txtAccountUsername
            // 
            this.txtAccountUsername.AnimateReadOnly = false;
            this.txtAccountUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountUsername.Depth = 0;
            this.txtAccountUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountUsername.Hint = "Nhập tên đăng nhập";
            this.txtAccountUsername.LeadingIcon = null;
            this.txtAccountUsername.Location = new System.Drawing.Point(33, 174);
            this.txtAccountUsername.MaxLength = 50;
            this.txtAccountUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAccountUsername.Multiline = false;
            this.txtAccountUsername.Name = "txtAccountUsername";
            this.txtAccountUsername.Size = new System.Drawing.Size(620, 50);
            this.txtAccountUsername.TabIndex = 1;
            this.txtAccountUsername.Text = "";
            this.txtAccountUsername.TrailingIcon = null;
            // 
            // txtAccountFullName
            // 
            this.txtAccountFullName.AnimateReadOnly = false;
            this.txtAccountFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountFullName.Depth = 0;
            this.txtAccountFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountFullName.Hint = "Nhập tên đầy đủ";
            this.txtAccountFullName.LeadingIcon = null;
            this.txtAccountFullName.Location = new System.Drawing.Point(33, 93);
            this.txtAccountFullName.MaxLength = 50;
            this.txtAccountFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAccountFullName.Multiline = false;
            this.txtAccountFullName.Name = "txtAccountFullName";
            this.txtAccountFullName.Size = new System.Drawing.Size(620, 50);
            this.txtAccountFullName.TabIndex = 0;
            this.txtAccountFullName.Text = "";
            this.txtAccountFullName.TrailingIcon = null;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.labelAccountFullName);
            this.materialCard10.Controls.Add(this.labelAccountUsername);
            this.materialCard10.Controls.Add(this.buttonAccountChooseImage);
            this.materialCard10.Controls.Add(this.pictureBoxAccountAvatar);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(38, 149);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(451, 598);
            this.materialCard10.TabIndex = 1;
            // 
            // labelAccountFullName
            // 
            this.labelAccountFullName.AutoSize = true;
            this.labelAccountFullName.Depth = 0;
            this.labelAccountFullName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountFullName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelAccountFullName.Location = new System.Drawing.Point(161, 373);
            this.labelAccountFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountFullName.Name = "labelAccountFullName";
            this.labelAccountFullName.Size = new System.Drawing.Size(128, 29);
            this.labelAccountFullName.TabIndex = 7;
            this.labelAccountFullName.Text = "Nguyễn Huy";
            // 
            // labelAccountUsername
            // 
            this.labelAccountUsername.AutoSize = true;
            this.labelAccountUsername.Depth = 0;
            this.labelAccountUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccountUsername.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labelAccountUsername.Location = new System.Drawing.Point(196, 404);
            this.labelAccountUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccountUsername.Name = "labelAccountUsername";
            this.labelAccountUsername.Size = new System.Drawing.Size(46, 19);
            this.labelAccountUsername.TabIndex = 6;
            this.labelAccountUsername.Text = "admin";
            // 
            // buttonAccountChooseImage
            // 
            this.buttonAccountChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAccountChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccountChooseImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAccountChooseImage.Depth = 0;
            this.buttonAccountChooseImage.HighEmphasis = true;
            this.buttonAccountChooseImage.Icon = null;
            this.buttonAccountChooseImage.Location = new System.Drawing.Point(166, 468);
            this.buttonAccountChooseImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccountChooseImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccountChooseImage.Name = "buttonAccountChooseImage";
            this.buttonAccountChooseImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccountChooseImage.Size = new System.Drawing.Size(97, 36);
            this.buttonAccountChooseImage.TabIndex = 4;
            this.buttonAccountChooseImage.Text = "Chọn ảnh";
            this.buttonAccountChooseImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccountChooseImage.UseAccentColor = false;
            this.buttonAccountChooseImage.UseVisualStyleBackColor = true;
            this.buttonAccountChooseImage.Click += new System.EventHandler(this.buttonAccountChooseImage_Click);
            // 
            // pictureBoxAccountAvatar
            // 
            this.pictureBoxAccountAvatar.Location = new System.Drawing.Point(114, 57);
            this.pictureBoxAccountAvatar.Name = "pictureBoxAccountAvatar";
            this.pictureBoxAccountAvatar.Size = new System.Drawing.Size(225, 294);
            this.pictureBoxAccountAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAccountAvatar.TabIndex = 0;
            this.pictureBoxAccountAvatar.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tài khoản";
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.materialCard12);
            this.tabSetting.Controls.Add(this.materialCard18);
            this.tabSetting.Controls.Add(this.label15);
            this.tabSetting.ImageKey = "icons8-setting-50.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 32);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(1405, 797);
            this.tabSetting.TabIndex = 8;
            this.tabSetting.Text = "Cài đặt";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // materialCard12
            // 
            this.materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard12.Controls.Add(this.labelTimeNow9);
            this.materialCard12.Controls.Add(this.buttonDashboardLogout10);
            this.materialCard12.Controls.Add(this.labelDashboardEmployeeUsername10);
            this.materialCard12.Controls.Add(this.pictureBoxDashboardEmployeeAvatar10);
            this.materialCard12.Depth = 0;
            this.materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard12.Location = new System.Drawing.Point(0, 0);
            this.materialCard12.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard12.Name = "materialCard12";
            this.materialCard12.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard12.Size = new System.Drawing.Size(1402, 69);
            this.materialCard12.TabIndex = 9;
            // 
            // labelTimeNow9
            // 
            this.labelTimeNow9.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNow9.Location = new System.Drawing.Point(92, 22);
            this.labelTimeNow9.Name = "labelTimeNow9";
            this.labelTimeNow9.Size = new System.Drawing.Size(19, 30);
            this.labelTimeNow9.TabIndex = 7;
            this.labelTimeNow9.Text = "11";
            // 
            // buttonDashboardLogout10
            // 
            this.buttonDashboardLogout10.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboardLogout10.FillColor = System.Drawing.Color.Transparent;
            this.buttonDashboardLogout10.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboardLogout10.Image")));
            this.buttonDashboardLogout10.ImageRotate = 0F;
            this.buttonDashboardLogout10.Location = new System.Drawing.Point(1277, 0);
            this.buttonDashboardLogout10.Name = "buttonDashboardLogout10";
            this.buttonDashboardLogout10.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonDashboardLogout10.Size = new System.Drawing.Size(64, 69);
            this.buttonDashboardLogout10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDashboardLogout10.TabIndex = 8;
            this.buttonDashboardLogout10.TabStop = false;
            this.buttonDashboardLogout10.UseTransparentBackground = true;
            // 
            // labelDashboardEmployeeUsername10
            // 
            this.labelDashboardEmployeeUsername10.AutoSize = true;
            this.labelDashboardEmployeeUsername10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardEmployeeUsername10.Location = new System.Drawing.Point(1187, 24);
            this.labelDashboardEmployeeUsername10.Name = "labelDashboardEmployeeUsername10";
            this.labelDashboardEmployeeUsername10.Size = new System.Drawing.Size(67, 28);
            this.labelDashboardEmployeeUsername10.TabIndex = 1;
            this.labelDashboardEmployeeUsername10.Text = "admin";
            // 
            // pictureBoxDashboardEmployeeAvatar10
            // 
            this.pictureBoxDashboardEmployeeAvatar10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDashboardEmployeeAvatar10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboardEmployeeAvatar10.Image")));
            this.pictureBoxDashboardEmployeeAvatar10.Location = new System.Drawing.Point(1126, 14);
            this.pictureBoxDashboardEmployeeAvatar10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDashboardEmployeeAvatar10.Name = "pictureBoxDashboardEmployeeAvatar10";
            this.pictureBoxDashboardEmployeeAvatar10.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxDashboardEmployeeAvatar10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboardEmployeeAvatar10.TabIndex = 0;
            this.pictureBoxDashboardEmployeeAvatar10.TabStop = false;
            // 
            // materialCard18
            // 
            this.materialCard18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard18.Controls.Add(this.label16);
            this.materialCard18.Controls.Add(this.buttonSettingChangePassword);
            this.materialCard18.Controls.Add(this.txtSettingConfirmNewPassword);
            this.materialCard18.Controls.Add(this.txtSettingNewPassword);
            this.materialCard18.Controls.Add(this.txtSettingOldPassword);
            this.materialCard18.Depth = 0;
            this.materialCard18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard18.Location = new System.Drawing.Point(39, 188);
            this.materialCard18.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard18.Name = "materialCard18";
            this.materialCard18.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard18.Size = new System.Drawing.Size(1262, 373);
            this.materialCard18.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 31);
            this.label16.TabIndex = 4;
            this.label16.Text = "Đổi mật khẩu";
            // 
            // buttonSettingChangePassword
            // 
            this.buttonSettingChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSettingChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettingChangePassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSettingChangePassword.Depth = 0;
            this.buttonSettingChangePassword.HighEmphasis = true;
            this.buttonSettingChangePassword.Icon = null;
            this.buttonSettingChangePassword.Location = new System.Drawing.Point(1105, 317);
            this.buttonSettingChangePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSettingChangePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSettingChangePassword.Name = "buttonSettingChangePassword";
            this.buttonSettingChangePassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSettingChangePassword.Size = new System.Drawing.Size(123, 36);
            this.buttonSettingChangePassword.TabIndex = 3;
            this.buttonSettingChangePassword.Text = "Đổi mật khẩu";
            this.buttonSettingChangePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSettingChangePassword.UseAccentColor = false;
            this.buttonSettingChangePassword.UseVisualStyleBackColor = true;
            this.buttonSettingChangePassword.Click += new System.EventHandler(this.buttonSettingChangePassword_Click);
            // 
            // txtSettingConfirmNewPassword
            // 
            this.txtSettingConfirmNewPassword.AnimateReadOnly = false;
            this.txtSettingConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSettingConfirmNewPassword.Depth = 0;
            this.txtSettingConfirmNewPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSettingConfirmNewPassword.Hint = "Nhập lại mật khẩu mới";
            this.txtSettingConfirmNewPassword.LeadingIcon = null;
            this.txtSettingConfirmNewPassword.Location = new System.Drawing.Point(33, 248);
            this.txtSettingConfirmNewPassword.MaxLength = 50;
            this.txtSettingConfirmNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSettingConfirmNewPassword.Multiline = false;
            this.txtSettingConfirmNewPassword.Name = "txtSettingConfirmNewPassword";
            this.txtSettingConfirmNewPassword.Password = true;
            this.txtSettingConfirmNewPassword.Size = new System.Drawing.Size(1195, 50);
            this.txtSettingConfirmNewPassword.TabIndex = 2;
            this.txtSettingConfirmNewPassword.Text = "";
            this.txtSettingConfirmNewPassword.TrailingIcon = null;
            // 
            // txtSettingNewPassword
            // 
            this.txtSettingNewPassword.AnimateReadOnly = false;
            this.txtSettingNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSettingNewPassword.Depth = 0;
            this.txtSettingNewPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSettingNewPassword.Hint = "Nhập mật khẩu mới";
            this.txtSettingNewPassword.LeadingIcon = null;
            this.txtSettingNewPassword.Location = new System.Drawing.Point(33, 174);
            this.txtSettingNewPassword.MaxLength = 50;
            this.txtSettingNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSettingNewPassword.Multiline = false;
            this.txtSettingNewPassword.Name = "txtSettingNewPassword";
            this.txtSettingNewPassword.Password = true;
            this.txtSettingNewPassword.Size = new System.Drawing.Size(1195, 50);
            this.txtSettingNewPassword.TabIndex = 1;
            this.txtSettingNewPassword.Text = "";
            this.txtSettingNewPassword.TrailingIcon = null;
            // 
            // txtSettingOldPassword
            // 
            this.txtSettingOldPassword.AnimateReadOnly = false;
            this.txtSettingOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSettingOldPassword.Depth = 0;
            this.txtSettingOldPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSettingOldPassword.Hint = "Nhập mật khẩu cũ";
            this.txtSettingOldPassword.LeadingIcon = null;
            this.txtSettingOldPassword.Location = new System.Drawing.Point(33, 93);
            this.txtSettingOldPassword.MaxLength = 50;
            this.txtSettingOldPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSettingOldPassword.Multiline = false;
            this.txtSettingOldPassword.Name = "txtSettingOldPassword";
            this.txtSettingOldPassword.Password = true;
            this.txtSettingOldPassword.Size = new System.Drawing.Size(1195, 50);
            this.txtSettingOldPassword.TabIndex = 0;
            this.txtSettingOldPassword.Text = "";
            this.txtSettingOldPassword.TrailingIcon = null;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 38);
            this.label15.TabIndex = 1;
            this.label15.Text = "Cài đặt";
            // 
            // labelProductCategory
            // 
            this.labelProductCategory.Depth = 0;
            this.labelProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductCategory.Location = new System.Drawing.Point(0, 0);
            this.labelProductCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductCategory.Name = "labelProductCategory";
            this.labelProductCategory.Size = new System.Drawing.Size(100, 23);
            this.labelProductCategory.TabIndex = 0;
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.Depth = 0;
            this.labelProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductDescription.Location = new System.Drawing.Point(0, 0);
            this.labelProductDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(100, 23);
            this.labelProductDescription.TabIndex = 0;
            // 
            // labelProductName
            // 
            this.labelProductName.Depth = 0;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductName.Location = new System.Drawing.Point(0, 0);
            this.labelProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(100, 23);
            this.labelProductName.TabIndex = 0;
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonProductDelete.Depth = 0;
            this.buttonProductDelete.HighEmphasis = true;
            this.buttonProductDelete.Icon = null;
            this.buttonProductDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonProductDelete.Size = new System.Drawing.Size(75, 36);
            this.buttonProductDelete.TabIndex = 0;
            this.buttonProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonProductDelete.UseAccentColor = false;
            // 
            // buttonProductEdit
            // 
            this.buttonProductEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProductEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonProductEdit.Depth = 0;
            this.buttonProductEdit.HighEmphasis = true;
            this.buttonProductEdit.Icon = null;
            this.buttonProductEdit.Location = new System.Drawing.Point(0, 0);
            this.buttonProductEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonProductEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProductEdit.Name = "buttonProductEdit";
            this.buttonProductEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonProductEdit.Size = new System.Drawing.Size(75, 36);
            this.buttonProductEdit.TabIndex = 0;
            this.buttonProductEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonProductEdit.UseAccentColor = false;
            // 
            // buttonProductViewDetail
            // 
            this.buttonProductViewDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProductViewDetail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonProductViewDetail.Depth = 0;
            this.buttonProductViewDetail.HighEmphasis = true;
            this.buttonProductViewDetail.Icon = null;
            this.buttonProductViewDetail.Location = new System.Drawing.Point(0, 0);
            this.buttonProductViewDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonProductViewDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonProductViewDetail.Name = "buttonProductViewDetail";
            this.buttonProductViewDetail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonProductViewDetail.Size = new System.Drawing.Size(75, 36);
            this.buttonProductViewDetail.TabIndex = 0;
            this.buttonProductViewDetail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonProductViewDetail.UseAccentColor = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // comboBoxProductSize
            // 
            this.comboBoxProductSize.AutoResize = false;
            this.comboBoxProductSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxProductSize.Depth = 0;
            this.comboBoxProductSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProductSize.DropDownHeight = 174;
            this.comboBoxProductSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductSize.DropDownWidth = 121;
            this.comboBoxProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxProductSize.IntegralHeight = false;
            this.comboBoxProductSize.ItemHeight = 43;
            this.comboBoxProductSize.Location = new System.Drawing.Point(0, 0);
            this.comboBoxProductSize.MaxDropDownItems = 4;
            this.comboBoxProductSize.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxProductSize.Name = "comboBoxProductSize";
            this.comboBoxProductSize.Size = new System.Drawing.Size(121, 26);
            this.comboBoxProductSize.StartIndex = 0;
            this.comboBoxProductSize.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(0, 0);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(200, 100);
            this.materialCard9.TabIndex = 0;
            // 
            // imageListCategory
            // 
            this.imageListCategory.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListCategory.ImageSize = new System.Drawing.Size(25, 25);
            this.imageListCategory.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.IsBalloon = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.UseGdiPlusTextRendering = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1416, 900);
            this.Controls.Add(this.tabControl);
            this.DrawerIndicatorWidth = 2;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.DrawerWidth = 300;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.materialCard13.ResumeLayout(false);
            this.materialCard13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.tabCategory.ResumeLayout(false);
            this.tabCategory.PerformLayout();
            this.materialCard22.ResumeLayout(false);
            this.materialCard22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar1)).EndInit();
            this.materialCard7.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.materialCard23.ResumeLayout(false);
            this.materialCard23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar3)).EndInit();
            this.tabTable.ResumeLayout(false);
            this.tabTable.PerformLayout();
            this.materialCard14.ResumeLayout(false);
            this.materialCard14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar4)).EndInit();
            this.materialCard8.ResumeLayout(false);
            this.tabBill.ResumeLayout(false);
            this.tabBill.PerformLayout();
            this.materialCard15.ResumeLayout(false);
            this.materialCard15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar5)).EndInit();
            this.tabAnalytics.ResumeLayout(false);
            this.tabAnalytics.PerformLayout();
            this.materialCard11.ResumeLayout(false);
            this.materialCard16.ResumeLayout(false);
            this.materialCard16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar6)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.materialCard25.ResumeLayout(false);
            this.materialCard25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar7)).EndInit();
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            this.materialCard21.ResumeLayout(false);
            this.materialCard21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar8)).EndInit();
            this.materialCard19.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.materialCard20.ResumeLayout(false);
            this.materialCard20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar9)).EndInit();
            this.materialCard17.ResumeLayout(false);
            this.materialCard17.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountAvatar)).EndInit();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.materialCard12.ResumeLayout(false);
            this.materialCard12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashboardLogout10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboardEmployeeAvatar10)).EndInit();
            this.materialCard18.ResumeLayout(false);
            this.materialCard18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.ImageList imageListTab;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabAnalytics;
        private System.Windows.Forms.TabPage tabEmployee;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel labelDashboardCountProductSelled;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel labelDashboardRevenue;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel labelDashboardCountBill;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialLabel labelDashboardCountEmployee;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.ImageList imageListCategory;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProductSize;
        private MaterialSkin.Controls.MaterialButton buttonProductDelete;
        private MaterialSkin.Controls.MaterialButton buttonProductEdit;
        private MaterialSkin.Controls.MaterialButton buttonProductViewDetail;
        private MaterialSkin.Controls.MaterialLabel labelProductName;
        private MaterialSkin.Controls.MaterialLabel labelProductCategory;
        private MaterialSkin.Controls.MaterialLabel labelProductDescription;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialButton buttonOpenFormAddTable;
        private System.Windows.Forms.TabPage tabCategory;
        private MaterialSkin.Controls.MaterialButton buttonOpenFormAddCategory;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername;
        private System.Windows.Forms.PictureBox pictureBoxAccountAvatar;
        private MaterialSkin.Controls.MaterialButton buttonAccountChooseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialLabel labelAccountFullName;
        private MaterialSkin.Controls.MaterialLabel labelAccountUsername;
        private MaterialSkin.Controls.MaterialCard materialCard17;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialButton buttonAccountChangeInfo;
        private MaterialSkin.Controls.MaterialTextBox txtAccountAddress;
        private MaterialSkin.Controls.MaterialTextBox txtAccountUsername;
        private MaterialSkin.Controls.MaterialTextBox txtAccountFullName;
        private MaterialSkin.Controls.MaterialComboBox comboBoxAccountGender;
        private MaterialSkin.Controls.MaterialComboBox comboBoxAccountAge;
        private System.Windows.Forms.TabPage tabSetting;
        private MaterialSkin.Controls.MaterialCard materialCard18;
        private System.Windows.Forms.Label label16;
        private MaterialSkin.Controls.MaterialButton buttonSettingChangePassword;
        private MaterialSkin.Controls.MaterialTextBox txtSettingConfirmNewPassword;
        private MaterialSkin.Controls.MaterialTextBox txtSettingNewPassword;
        private MaterialSkin.Controls.MaterialTextBox txtSettingOldPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabRole;
        private MaterialSkin.Controls.MaterialButton buttonOpenFormAddRole;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private MaterialSkin.Controls.MaterialButton buttonAddProduct;
        private MaterialSkin.Controls.MaterialButton buttonEmployeeAdd;
        private MaterialSkin.Controls.MaterialCard cardBillProducts;
        private MaterialSkin.Controls.MaterialCard cardBillTable;
        private MaterialSkin.Controls.MaterialTextBox txtAccountPhoneNumber;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progressIndicatorProduct;
        private MaterialSkin.Controls.MaterialButton buttonBillPrintBill;
        private MaterialSkin.Controls.MaterialButton buttonBillPayment;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialCard materialCard22;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout1;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername1;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar1;
        private MaterialSkin.Controls.MaterialCard materialCard23;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout3;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername3;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar3;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout4;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername4;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar4;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout5;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername5;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar5;
        private MaterialSkin.Controls.MaterialCard materialCard16;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout6;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername6;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar6;
        private MaterialSkin.Controls.MaterialCard materialCard25;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout7;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername7;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar7;
        private MaterialSkin.Controls.MaterialCard materialCard21;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout8;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername8;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar8;
        private MaterialSkin.Controls.MaterialCard materialCard20;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow8;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout9;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername9;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar9;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTimeNow9;
        private Guna.UI2.WinForms.Guna2CirclePictureBox buttonDashboardLogout10;
        private System.Windows.Forms.Label labelDashboardEmployeeUsername10;
        private System.Windows.Forms.PictureBox pictureBoxDashboardEmployeeAvatar10;
        private Guna.UI2.WinForms.Guna2TextBox txtCategorySearch;
        private Guna.UI2.WinForms.Guna2TextBox txtProductSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtTableSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtRoleSearch;
        private MaterialSkin.Controls.MaterialListView categoryListView;
        private System.Windows.Forms.ColumnHeader categoryId;
        private System.Windows.Forms.ColumnHeader categoryImage;
        private System.Windows.Forms.ColumnHeader categoryName;
        private System.Windows.Forms.ColumnHeader categoryDescription;
        private System.Windows.Forms.ColumnHeader categoryCreatedAt;
        private System.Windows.Forms.ColumnHeader categoryUpdatedAt;
        private System.Windows.Forms.ColumnHeader categoryAction;
        private Sunny.UI.UIMiniPagination categoryPagnation;
        private MaterialSkin.Controls.MaterialCard materialCard19;
        private MaterialSkin.Controls.MaterialListView roleListView;
        private System.Windows.Forms.ColumnHeader roleID;
        private System.Windows.Forms.ColumnHeader roleName;
        private System.Windows.Forms.ColumnHeader roleDescription;
        private System.Windows.Forms.ColumnHeader roleCreatedAt;
        private System.Windows.Forms.ColumnHeader roleUpdatedAt;
        private System.Windows.Forms.ColumnHeader roleAction;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private MaterialSkin.Controls.MaterialListView tableListView;
        private System.Windows.Forms.ColumnHeader tableId;
        private System.Windows.Forms.ColumnHeader tableName;
        private System.Windows.Forms.ColumnHeader tableDescription;
        private System.Windows.Forms.ColumnHeader tableCreatedAt;
        private System.Windows.Forms.ColumnHeader tableUpdatedAt;
        private System.Windows.Forms.ColumnHeader tableAction;
        private System.Windows.Forms.ColumnHeader tableStatus;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}