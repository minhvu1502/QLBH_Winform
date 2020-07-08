﻿namespace QLBH.views
{
    partial class frm_Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ban));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cb_maloaiban = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refesrh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenBan = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaBan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cb_maloaiban);
            this.panelControl1.Controls.Add(this.btn_refresh);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_close);
            this.panelControl1.Controls.Add(this.btn_refesrh);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.txt_TenBan);
            this.panelControl1.Controls.Add(this.txt_MaBan);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 0);
            this.panelControl1.Size = new System.Drawing.Size(665, 153);
            this.panelControl1.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(366, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Mã Loại Bàn:";
            // 
            // cb_maloaiban
            // 
            this.cb_maloaiban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_maloaiban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maloaiban.FormattingEnabled = true;
            this.cb_maloaiban.Location = new System.Drawing.Point(433, 18);
            this.cb_maloaiban.Name = "cb_maloaiban";
            this.cb_maloaiban.Size = new System.Drawing.Size(121, 21);
            this.cb_maloaiban.TabIndex = 36;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(282, 93);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 34);
            this.btn_refresh.TabIndex = 35;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(396, 92);
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
            this.btn_close.Location = new System.Drawing.Point(510, 92);
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
            this.btn_refesrh.Location = new System.Drawing.Point(168, 92);
            this.btn_refesrh.Name = "btn_refesrh";
            this.btn_refesrh.Size = new System.Drawing.Size(108, 36);
            this.btn_refesrh.TabIndex = 13;
            this.btn_refesrh.Text = "Cập Nhật";
            this.btn_refesrh.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(56, 92);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 36);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm Mới";
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // txt_TenBan
            // 
            this.txt_TenBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenBan.Location = new System.Drawing.Point(241, 49);
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Size = new System.Drawing.Size(119, 20);
            this.txt_TenBan.TabIndex = 11;
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaBan.Location = new System.Drawing.Point(241, 19);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Size = new System.Drawing.Size(119, 20);
            this.txt_MaBan.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(192, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tên Bàn:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(196, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã Bàn:";
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
            this.tablePanel1.Size = new System.Drawing.Size(671, 593);
            this.tablePanel1.TabIndex = 22;
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 428);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // frm_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 593);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frm_Ban";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_refesrh;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.TextEdit txt_TenBan;
        private DevExpress.XtraEditors.TextEdit txt_MaBan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cb_maloaiban;
    }
}