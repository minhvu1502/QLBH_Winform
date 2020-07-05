﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Model_Class;
using QLBH.Repository;
using System.Data.SqlClient;
using System.Data.Common;

namespace QLBH
{
    public partial class frm_NguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        List<Class_NguyenLieu> nguyen_lieu;
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_NguyenLieu()
        {
            InitializeComponent();
        }

        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("select * from NguyenLieu");
        }

        public new List<Class_NguyenLieu> Select()
        {
            string sql = "SELECT * FROM NguyenLieu";
            List<Class_NguyenLieu> list = new List<Class_NguyenLieu>();
           query.ketnoiSQL();
            using (DbDataReader reader = query.Reader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string MaNguyenLieu = reader.GetString(0);
                        string TenNguyenLieu = reader.GetString(1);
                        string DonViTinh = reader.GetString(2);
                        double SoLuong = (double)reader.GetValue(3);
                        double DonGiaNhap = reader.GetDouble(4);
                        double DonGiaBan = reader.GetDouble(5);
                        string CongDung = reader.GetString(6);
                        string YeuCau = reader.GetString(7);
                        string ChongChiDinh = reader.GetString(8);
                        Class_NguyenLieu nl = new Class_NguyenLieu(MaNguyenLieu, TenNguyenLieu, DonViTinh, SoLuong, DonGiaNhap, DonGiaBan, CongDung, YeuCau, ChongChiDinh);
                        list.Add(nl);
                    }
                }
            }
            query.DongketnoiSQL();
            return list;
        }
        private void Button_themmoi_Click(object sender, EventArgs e)
        {
            nguyen_lieu = Select();
            bool check = false;
            for (int i = 0; i < nguyen_lieu.Count; i++)
            {
                if (nguyen_lieu[i].MaNguyenLieu1.Equals(txt_manl.Text) || nguyen_lieu[i].TenNguyenLieu1.Equals(txt_tennl.Text))
                {
                    check = true;
                    MessageBox.Show("Đã có mã nguyên liệu hoặc tên nguyên liệu này", "Thông báo");
                    break;
                }
            }

            if (check == false)
            {

                if (txt_manl.Text.Trim() != "" || txt_tennl.Text.Trim() != "" || txt_donvitinh.Text.Trim() != "" || txt_congdung.Text.Trim() != "" || txt_yeucau.Text.Trim() != "" || txt_chongchidinh.Text.Trim() != "")
                {

                    string sql = "insert into NguyenLieu values(N'" + txt_manl.Text + "',N'" + txt_tennl.Text + "',N'" + txt_donvitinh.Text + "','" + 0 + "','" + 0 + "','" + 0 + "',N'" + txt_congdung.Text + "',N'" + txt_yeucau.Text + "',N'" + txt_chongchidinh.Text + "')";
                    query.CapNhatDuLieu(sql);
                    fill();
                    //nguyen_lieu.Add(new Class_NguyenLieu(txt_manl.Text, txt_tennl.Text, txt_donvitinh.Text, 0,0,0, txt_congdung.Text, txt_yeucau.Text, txt_chongchidinh.Text));
                    txt_manl.Text = "";
                    txt_tennl.Text = "";
                    txt_donvitinh.Text = "";
                    txt_soluong.Text = "";
                    txt_dongianhap.Text = "";
                    txt_dongiaban.Text = "";
                    txt_congdung.Text = "";
                    txt_yeucau.Text = "";
                    txt_chongchidinh.Text = "";
                    //txt_manl.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                }
            }
        }

        private void Frm_NguyenLieu_Load(object sender, EventArgs e)
        {
            fill();
        }
        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_manl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tennl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_donvitinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_dongianhap.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_dongiaban.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_congdung.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_yeucau.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_chongchidinh.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_manl.Enabled = false;
        }

        private void Button_capnhat_Click(object sender, EventArgs e)
        {
            nguyen_lieu = Select();
            if (txt_manl.Text.Trim() != "" || txt_tennl.Text.Trim() != "" || txt_donvitinh.Text.Trim() != "" || txt_soluong.Text.Trim() != "" || txt_dongianhap.Text.Trim() != "" || txt_dongiaban.Text.Trim() != "" || txt_congdung.Text.Trim() != "" || txt_yeucau.Text.Trim() != "" || txt_chongchidinh.Text.Trim() != "")
            {

                string sql = "update NguyenLieu set TenNguyenLieu=N'" + txt_tennl.Text + "',DonViTinh=N'" + txt_donvitinh.Text + "',SoLuong='" + txt_soluong.Text + "',DonGiaNhap='" + txt_dongianhap.Text + "',DonGiaBan='" + txt_dongiaban.Text + "',CongDung=N'" + txt_congdung.Text + "',YeuCau=N'" + txt_yeucau.Text + "',ChongChiDinh=N'" + txt_chongchidinh.Text + "' where MaNguyenLieu = N'" + txt_manl.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                txt_manl.Text = "";
                txt_tennl.Text = "";
                txt_donvitinh.Text = "";
                txt_soluong.Text = "";
                txt_dongianhap.Text = "";
                txt_dongiaban.Text = "";
                txt_congdung.Text = "";
                txt_yeucau.Text = "";
                txt_chongchidinh.Text = "";
                txt_manl.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void SimpleButton4_Click(object sender, EventArgs e)
        {
            nguyen_lieu = Select();
            bool check = false;
            for (int i = 0; i < nguyen_lieu.Count; i++)
            {
                if (txt_manl.Text.Trim() == nguyen_lieu[i].MaNguyenLieu1)
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from NguyenLieu where MaNguyenLieu = N'" + txt_manl.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();
                    txt_manl.Text = "";
                    txt_tennl.Text = "";
                    txt_donvitinh.Text = "";
                    txt_soluong.Text = "";
                    txt_dongianhap.Text = "";
                    txt_dongiaban.Text = "";
                    txt_congdung.Text = "";
                    txt_yeucau.Text = "";
                    txt_chongchidinh.Text = "";
                    txt_manl.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo");
            }
        }

        private void Txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void Txt_dongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void Txt_dongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SimpleButton5_Click(object sender, EventArgs e)
        {
            if (txt_ccdtk.Text.Trim() != "" || txt_congdungtk.Text.Trim() != "" || txt_tentk.Text.Trim() != "")
            {
                string sql = "select  * from NguyenLieu where MaNguyenLieu is not null";
                if (txt_tentk.Text != "")
                {
                    sql += " and TenNguyenLieu like N'" + txt_tentk.Text.Trim() + "%'";
                }
                if (txt_congdungtk.Text != "")
                {
                    sql += " and CongDung like N'" + txt_congdungtk.Text.Trim() + "%'";
                }
                if (txt_tentk.Text != "")
                {
                    sql += " and ChongChiDinh like N'" + txt_ccdtk.Text.Trim() + "%'";
                }
                DataTable a = query.DocBang(sql);
                dataGridView1.DataSource = a;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu tìm kiếm!", "Thông báo");
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            txt_ccdtk.Text = "";
            txt_chongchidinh.Text = "";
            txt_congdung.Text = "";
            txt_dongiaban.Text = "";
            txt_dongianhap.Text = "";
            txt_donvitinh.Text = "";
            txt_manl.Text = "";
            txt_soluong.Text = "";
            txt_tennl.Text = "";
            txt_manl.Enabled = true;
            fill();
        }
    }
}