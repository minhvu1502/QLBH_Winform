﻿namespace QLBH
{
    partial class frm_ChiTietHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChiTietHD));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_manl = new System.Windows.Forms.ComboBox();
            this.cb_mahd = new System.Windows.Forms.ComboBox();
            this.txt_KhuyenMai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txt_ThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refesrh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KhuyenMai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePanel1.SetColumn(this.dataGridView1, 0);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tablePanel1.SetRow(this.dataGridView1, 1);
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 458);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // cb_manl
            // 
            this.cb_manl.FormattingEnabled = true;
            this.cb_manl.Location = new System.Drawing.Point(475, 56);
            this.cb_manl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_manl.Name = "cb_manl";
            this.cb_manl.Size = new System.Drawing.Size(154, 21);
            this.cb_manl.TabIndex = 28;
            this.cb_manl.Click += new System.EventHandler(this.Cb_manl_Click);
            // 
            // cb_mahd
            // 
            this.cb_mahd.FormattingEnabled = true;
            this.cb_mahd.Location = new System.Drawing.Point(475, 26);
            this.cb_mahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_mahd.Name = "cb_mahd";
            this.cb_mahd.Size = new System.Drawing.Size(154, 21);
            this.cb_mahd.TabIndex = 27;
            this.cb_mahd.Click += new System.EventHandler(this.Cb_mahd_Click);
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KhuyenMai.Location = new System.Drawing.Point(458, 86);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.Size = new System.Drawing.Size(171, 20);
            this.txt_KhuyenMai.TabIndex = 26;
            this.txt_KhuyenMai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KhuyenMai_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Location = new System.Drawing.Point(393, 89);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Khuyến Mãi:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuong.Location = new System.Drawing.Point(458, 26);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(171, 20);
            this.txt_SoLuong.TabIndex = 24;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(167, 86);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(154, 20);
            this.txt_ThanhTien.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Location = new System.Drawing.Point(104, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Thành Tiền:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.Location = new System.Drawing.Point(458, 56);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(171, 20);
            this.txt_DonGia.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(410, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Đơn Giá:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(403, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Số Lượng:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(426, 113);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.Location = new System.Drawing.Point(540, 113);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 36);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Thoát";
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_refesrh
            // 
            this.btn_refesrh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refesrh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refesrh.ImageOptions.Image")));
            this.btn_refesrh.Location = new System.Drawing.Point(197, 113);
            this.btn_refesrh.Name = "btn_refesrh";
            this.btn_refesrh.Size = new System.Drawing.Size(108, 36);
            this.btn_refesrh.TabIndex = 13;
            this.btn_refesrh.Text = "Cập Nhật";
            this.btn_refesrh.Click += new System.EventHandler(this.Btn_refesrh_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(85, 113);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 36);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm Mới";
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(81, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mã Nguyên Liệu:";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.dataGridView1);
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 159F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(739, 623);
            this.tablePanel1.TabIndex = 27;
            // 
            // panelControl1
            // 
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.panelControl1.Controls.Add(this.btn_refresh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cb_manl);
            this.panelControl1.Controls.Add(this.cb_mahd);
            this.panelControl1.Controls.Add(this.txt_KhuyenMai);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_SoLuong);
            this.panelControl1.Controls.Add(this.txt_ThanhTien);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_DonGia);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_close);
            this.panelControl1.Controls.Add(this.btn_refesrh);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 0);
            this.panelControl1.Size = new System.Drawing.Size(733, 153);
            this.panelControl1.TabIndex = 17;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(311, 114);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 34);
            this.btn_refresh.TabIndex = 35;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "%";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(98, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã Hóa Đơn:";
            // 
            // frm_ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 623);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frm_ChiTietHD";
            this.Load += new System.EventHandler(this.Frm_ChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KhuyenMai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cb_manl;
        private System.Windows.Forms.ComboBox cb_mahd;
        private DevExpress.XtraEditors.TextEdit txt_KhuyenMai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_SoLuong;
        private DevExpress.XtraEditors.TextEdit txt_ThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_DonGia;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_refesrh;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
    }
}