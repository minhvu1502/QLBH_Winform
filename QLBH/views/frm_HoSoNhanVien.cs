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
    public partial class frm_HoSoNhanVien : DevExpress.XtraEditors.XtraForm
    {
        List<Class_Que> list_que= new List<Class_Que>();
        List<Class_NhanVien> nv;
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_HoSoNhanVien()
        {
            InitializeComponent();
            //list_que = new Frm_QueQuan().Select();
            this.cbb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void add()
        {
            cbb_gioitinh.Items.Add("Nam");
            cbb_gioitinh.Items.Add("Nữ");
            list_que = new Frm_QueQuan().Select();
            for (int i = 0; i < list_que.Count; i++)
            {
                cb_maque.Items.Add(list_que[i].MaQue1);
            }
        }
        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("select * from NhanVien");
        }
        public new List<Class_NhanVien> Select()
        {
            string sql = "SELECT * FROM NhanVien";
            List<Class_NhanVien> list = new List<Class_NhanVien>();
            using (DbDataReader reader = query.Reader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string MaNhanVien = reader.GetString(0);
                        string TenNhanVien = reader.GetString(1);
                        string GioiTinh = reader.GetString(2);
                        DateTime NgaySinh = reader.GetDateTime(3);
                        string DiaChi = reader.GetString(4);
                        string MaQue = reader.GetString(5);
                        string DienThoai = reader.GetString(6);
                        Class_NhanVien nv = new Class_NhanVien(MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, MaQue, DienThoai);
                        list.Add(nv);
                    }
                }
            }
            query.DongketnoiSQL();
            return list;
        }

        private void Button_themmoi_Click(object sender, EventArgs e)
        {
            nv = Select();
            list_que = new Frm_QueQuan().Select();
            bool check = false;
            bool kiemtra = false;

            for(int i=0;i<list_que.Count;i++)
            {
                if (list_que[i].MaQue1.Equals(cb_maque.Text))
                {
                    kiemtra = true;
                    check = false;       
                }
            }

            if (kiemtra == false)
            {
                MessageBox.Show("Mã quê không hợp lệ","Thông báo");
            }
            //for(int i=0;i<que)
            for (int i = 0; i < nv.Count; i++)
            {
                if (nv[i].MaNhanVien1.Equals(txt_manv.Text))
                {
                    check = true;
                    MessageBox.Show("Đã có mã nhân viên này, vui lòng nhập lại","Thông báo");
                    break;
                }
            }

            if (check == false && kiemtra==true)
            {
                if (txt_manv.Text.Trim() != "" && txt_tennv.Text.Trim() != "" && cbb_gioitinh.Text.Trim() != "" && txt_diachi.Text.Trim() != "" && txt_dienthoai.Text.Trim() != "" && cb_maque.Text.Trim() != "")
                {
                    var p = dateTimePicker1.Text;
                    var z = p.Split('/');
                    Array.Reverse(z);
                    var k = string.Join("", z);
                    string sql = "insert into NhanVien values('" + txt_manv.Text + "',N'" + txt_tennv.Text + "',N'"+cbb_gioitinh.Text+ "',CAST( N'" + k + "' as DateTime),N'" + txt_diachi.Text + "','" + cb_maque.Text + "','" + txt_dienthoai.Text + "')";                    
                    query.CapNhatDuLieu(sql);
                    fill();

                    nv.Add(new Class_NhanVien(txt_manv.Text, txt_tennv.Text, cbb_gioitinh.Text, Convert.ToDateTime(dateTimePicker1.Text), txt_diachi.Text, cb_maque.Text, txt_dienthoai.Text));
                    txt_manv.Text = "";
                    txt_tennv.Text = "";
                    cbb_gioitinh.Text = "";
                    txt_diachi.Text = "";
                    cb_maque.Text = "";
                    txt_dienthoai.Text = "";
                    txt_manv.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo");
                }
            }
        }

        private void Frm_HoSoNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNhaHangDataSet.NhanVien);
            fill();
            add();
        }

        private void Button_capnhat_Click(object sender, EventArgs e)
        {
            //if (txt_manv.Text.Trim() != "" || txt_tennv.Text != "" || cbb_gioitinh.Text.Trim() != "" || txt_diachi.Text.Trim() != "" || txt_dienthoai.Text.Trim() != "" || cb_maque.Text.Trim() != "")
            //{
            //    string sql = "update NhanVien set TenNhanVien=N'" + txt_tennv.Text + "',GioiTinh=N'"+cbb_gioitinh.Text+"',NgaySinh=N'" + dateTimePicker1.Text + "',DiaChi=N'" + txt_diachi.Text + "',MaQue=N'" + cb_maque.Text + "',DienThoai=N'" + txt_dienthoai.Text + "' where MaNhanVien =N'" + txt_manv.Text + "'";
            //    query.CapNhatDuLieu(sql);
            //    fill();
            //    txt_manv.Text = "";
            //    txt_tennv.Text = "";
            //    cbb_gioitinh.Text = "";
            //    dateTimePicker1.Text = "";
            //    txt_diachi.Text = "";
            //    cb_maque.Text = "";
            //    txt_dienthoai.Text = "";
            //    txt_manv.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo");
            //}
            if (txt_tennv.Text == "" || txt_manv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo");
            }
            else
            {
                string sql = "update NhanVien set TenNhanVien=N'" + txt_tennv.Text + "',GioiTinh=N'" + cbb_gioitinh.Text + "',NgaySinh=N'" + dateTimePicker1.Text + "',DiaChi=N'" + txt_diachi.Text + "',MaQue=N'" + cb_maque.Text + "',DienThoai=N'" + txt_dienthoai.Text + "' where MaNhanVien =N'" + txt_manv.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                txt_manv.Text = "";
                txt_tennv.Text = "";
                cbb_gioitinh.Text = "";
                dateTimePicker1.Text = "";
                txt_diachi.Text = "";
                cb_maque.Text = "";
                txt_dienthoai.Text = "";
                txt_manv.Enabled = true;
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_manv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //cbb_gioitinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                cbb_gioitinh.Text = "Nam";
            }
            else
            {
                cbb_gioitinh.Text = "Nữ";
            }
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cb_maque.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_dienthoai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_manv.Enabled = false;
        }

        private void Button_xoa_Click(object sender, EventArgs e)
        {
            nv = Select();
            bool check = false;
            for (int i = 0; i < nv.Count; i++)
            {
                if (txt_manv.Text == nv[i].MaNhanVien1)
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
                    string sql = "delete from NhanVien where MaNhanVien = N'" + txt_manv.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();
                    txt_manv.Enabled = true;
                    txt_manv.Text = "";
                    txt_tennv.Text = "";
                    cbb_gioitinh.Text = "";
                    dateTimePicker1.Text = "";
                    txt_diachi.Text = "";
                    cb_maque.Text = "";
                    txt_dienthoai.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu", "Thông báo");
            }
        }

        private void Button_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_timkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhanVien where MaNhanVien is not null";
            if(txt_tkma.Text == "" && txt_tkten.Text == "")
            {
                MessageBox.Show("Bạn cần nhập dữ liệu để tìm kiếm", "Thông báo");
            }
            else if (txt_tkma.Text != "")
            {
                sql += " and MaNhanVien Like N'%" + txt_tkma.Text.Trim() + "%'";
            }
            if (txt_tkten.Text != "")
            {
                sql += " and TenNhanVien like N'%" + txt_tkten.Text.Trim() + "%'";
            }
            DataTable a = query.DocBang(sql);
            dataGridView1.DataSource = a;
        }

        private void Cb_maque_Click(object sender, EventArgs e)
        {
            cb_maque.Items.Clear();
            list_que = new Frm_QueQuan().Select();
            for (int i = 0; i < list_que.Count; i++)
            {
                cb_maque.Items.Add(list_que[i].MaQue1);
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            txt_diachi.Text = "";
            txt_dienthoai.Text = "";
            txt_manv.Text = "";
            txt_tennv.Text = "";
            cbb_gioitinh.Text = "";
            cb_maque.Text = "";
            txt_manv.Enabled = true;
            fill();
        }
    }
}