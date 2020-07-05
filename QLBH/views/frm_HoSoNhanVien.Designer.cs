namespace QLBH
{
    partial class frm_HoSoNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoSoNhanVien));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tkma = new DevExpress.XtraEditors.TextEdit();
            this.txt_tkten = new DevExpress.XtraEditors.TextEdit();
            this.cb_maque = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.button_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.button_themmoi = new DevExpress.XtraEditors.SimpleButton();
            this.button_capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.button_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.button_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_dienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_manv = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_tennv = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.qLNhaHangDataSet = new QLBH.QLNhaHangDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLBH.QLNhaHangDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLBH.QLNhaHangDataSetTableAdapters.TableAdapterManager();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tkma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tkten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(728, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã Nhân Viên:";
            // 
            // txt_tkma
            // 
            this.txt_tkma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tkma.Location = new System.Drawing.Point(805, 18);
            this.txt_tkma.Name = "txt_tkma";
            this.txt_tkma.Size = new System.Drawing.Size(100, 20);
            this.txt_tkma.TabIndex = 1;
            // 
            // txt_tkten
            // 
            this.txt_tkten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tkten.Location = new System.Drawing.Point(557, 18);
            this.txt_tkten.Name = "txt_tkten";
            this.txt_tkten.Size = new System.Drawing.Size(156, 20);
            this.txt_tkten.TabIndex = 0;
            // 
            // cb_maque
            // 
            this.cb_maque.FormattingEnabled = true;
            this.cb_maque.Location = new System.Drawing.Point(390, 218);
            this.cb_maque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_maque.Name = "cb_maque";
            this.cb_maque.Size = new System.Drawing.Size(137, 21);
            this.cb_maque.TabIndex = 53;
            this.cb_maque.Click += new System.EventHandler(this.Cb_maque_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 151);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 21);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Location = new System.Drawing.Point(362, 280);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 51;
            this.labelControl7.Text = "Mã Quê";
            // 
            // labelControl19
            // 
            this.labelControl19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl19.Location = new System.Drawing.Point(105, 280);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(51, 13);
            this.labelControl19.TabIndex = 43;
            this.labelControl19.Text = "Điện Thoại";
            // 
            // panelControl2
            // 
            this.tablePanel1.SetColumn(this.panelControl2, 0);
            this.tablePanel1.SetColumnSpan(this.panelControl2, 2);
            this.panelControl2.Controls.Add(this.btn_refresh);
            this.panelControl2.Controls.Add(this.button_timkiem);
            this.panelControl2.Controls.Add(this.button_themmoi);
            this.panelControl2.Controls.Add(this.button_capnhat);
            this.panelControl2.Controls.Add(this.button_xoa);
            this.panelControl2.Controls.Add(this.button_thoat);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.Name = "panelControl2";
            this.tablePanel1.SetRow(this.panelControl2, 0);
            this.panelControl2.Size = new System.Drawing.Size(1392, 47);
            this.panelControl2.TabIndex = 12;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(616, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 34);
            this.btn_refresh.TabIndex = 36;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_timkiem.ImageOptions.Image")));
            this.button_timkiem.Location = new System.Drawing.Point(298, 7);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(100, 33);
            this.button_timkiem.TabIndex = 0;
            this.button_timkiem.Text = "Tìm Kiếm";
            this.button_timkiem.Click += new System.EventHandler(this.Button_timkiem_Click);
            // 
            // button_themmoi
            // 
            this.button_themmoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_themmoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_themmoi.ImageOptions.Image")));
            this.button_themmoi.Location = new System.Drawing.Point(403, 7);
            this.button_themmoi.Name = "button_themmoi";
            this.button_themmoi.Size = new System.Drawing.Size(100, 33);
            this.button_themmoi.TabIndex = 1;
            this.button_themmoi.Text = "Thêm Mới";
            this.button_themmoi.Click += new System.EventHandler(this.Button_themmoi_Click);
            // 
            // button_capnhat
            // 
            this.button_capnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_capnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_capnhat.ImageOptions.Image")));
            this.button_capnhat.Location = new System.Drawing.Point(510, 7);
            this.button_capnhat.Name = "button_capnhat";
            this.button_capnhat.Size = new System.Drawing.Size(100, 33);
            this.button_capnhat.TabIndex = 2;
            this.button_capnhat.Text = "Cập Nhật";
            this.button_capnhat.Click += new System.EventHandler(this.Button_capnhat_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.ImageOptions.Image")));
            this.button_xoa.Location = new System.Drawing.Point(730, 7);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(100, 33);
            this.button_xoa.TabIndex = 3;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.Click += new System.EventHandler(this.Button_xoa_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_thoat.ImageOptions.Image")));
            this.button_thoat.Location = new System.Drawing.Point(835, 7);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(100, 33);
            this.button_thoat.TabIndex = 4;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.Click += new System.EventHandler(this.Button_thoat_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl11.Location = new System.Drawing.Point(121, 249);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(34, 13);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "Địa Chỉ";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Location = new System.Drawing.Point(360, 222);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 13);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Giới Tính";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Location = new System.Drawing.Point(330, 191);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "*Mã Nhân Viên";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Location = new System.Drawing.Point(81, 191);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "*Tên Nhân Viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(478, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên Nhân Viên:";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Location = new System.Drawing.Point(111, 219);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 33;
            this.labelControl9.Text = "Ngày Sinh";
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_gioitinh.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Location = new System.Drawing.Point(405, 216);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(136, 21);
            this.cbb_gioitinh.TabIndex = 26;
            this.cbb_gioitinh.UseWaitCursor = true;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dienthoai.Location = new System.Drawing.Point(164, 277);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(143, 20);
            this.txt_dienthoai.TabIndex = 16;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_diachi.Location = new System.Drawing.Point(164, 246);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(377, 20);
            this.txt_diachi.TabIndex = 4;
            // 
            // txt_manv
            // 
            this.txt_manv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_manv.Location = new System.Drawing.Point(405, 188);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(137, 20);
            this.txt_manv.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 1);
            this.groupControl1.Controls.Add(this.cb_maque);
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cbb_gioitinh);
            this.groupControl1.Controls.Add(this.txt_dienthoai);
            this.groupControl1.Controls.Add(this.txt_diachi);
            this.groupControl1.Controls.Add(this.txt_manv);
            this.groupControl1.Controls.Add(this.txt_tennv);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(760, 114);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(635, 523);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Chi Tiết Nhân Viên";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tennv.Location = new System.Drawing.Point(164, 188);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(143, 20);
            this.txt_tennv.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27.52F)});
            this.tablePanel1.Controls.Add(this.dataGridView1);
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Controls.Add(this.panelControl2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 53F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 58F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1398, 640);
            this.tablePanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePanel1.SetColumn(this.dataGridView1, 0);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.maQueDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tablePanel1.SetRow(this.dataGridView1, 2);
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 523);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.tablePanel1.SetColumnSpan(this.panelControl1, 2);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_tkma);
            this.panelControl1.Controls.Add(this.txt_tkten);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 56);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 1);
            this.panelControl1.Size = new System.Drawing.Size(1392, 52);
            this.panelControl1.TabIndex = 6;
            // 
            // qLNhaHangDataSet
            // 
            this.qLNhaHangDataSet.DataSetName = "QLNhaHangDataSet";
            this.qLNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNhaHangDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHoaDonNhapTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuDBTableAdapter = null;
            this.tableAdapterManager.CongDungTableAdapter = null;
            this.tableAdapterManager.HoaDonNhapTableAdapter = null;
            this.tableAdapterManager.KhachTableAdapter = null;
            this.tableAdapterManager.LoaiMonTableAdapter = null;
            this.tableAdapterManager.MonAnTableAdapter = null;
            this.tableAdapterManager.NguyenLieu_MonAnTableAdapter = null;
            this.tableAdapterManager.NguyenLieuTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuDatBanTableAdapter = null;
            this.tableAdapterManager.QueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.QLNhaHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maQueDataGridViewTextBoxColumn
            // 
            this.maQueDataGridViewTextBoxColumn.DataPropertyName = "MaQue";
            this.maQueDataGridViewTextBoxColumn.HeaderText = "Mã Quê";
            this.maQueDataGridViewTextBoxColumn.Name = "maQueDataGridViewTextBoxColumn";
            this.maQueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            this.dienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_HoSoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 640);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frm_HoSoNhanVien";
            this.Load += new System.EventHandler(this.Frm_HoSoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tkma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tkten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_dienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_tkma;
        private DevExpress.XtraEditors.TextEdit txt_tkten;
        private System.Windows.Forms.ComboBox cb_maque;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private DevExpress.XtraEditors.TextEdit txt_dienthoai;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_manv;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton button_timkiem;
        private DevExpress.XtraEditors.SimpleButton button_themmoi;
        private DevExpress.XtraEditors.SimpleButton button_capnhat;
        private DevExpress.XtraEditors.SimpleButton button_xoa;
        private DevExpress.XtraEditors.SimpleButton button_thoat;
        private DevExpress.XtraEditors.TextEdit txt_tennv;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private QLNhaHangDataSet qLNhaHangDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNhaHangDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLNhaHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
    }
}