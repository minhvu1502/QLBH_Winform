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
    public partial class frm_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        List<Class_HoaDonNhap> hoaDonNhap;
        List<Class_NhanVien> nhanVien;
        List<Class_NhaCungCap> nhaCungCap;
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_HoaDon()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        public new List<Class_HoaDonNhap> Select()
        {
            string sql = "Select * from HoaDonNhap";
            List<Class_HoaDonNhap> list = new List<Class_HoaDonNhap>();
          query.ketnoiSQL();
            using (DbDataReader reader = query.Reader(sql))
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        String MaHoaDonNhap = reader.GetString(0);
                        DateTime NgayNhap = reader.GetDateTime(1);
                        String MaNhanVien = reader.GetString(2);
                        String MaNhaCungCap = reader.GetString(3);
                        double TongTien =(double) reader.GetValue(4);
                        Class_HoaDonNhap hoaDonNhap1 = new Class_HoaDonNhap(MaHoaDonNhap, NgayNhap, MaHoaDonNhap, MaNhaCungCap, TongTien);
                        list.Add(hoaDonNhap1);
                    }
            }
            query.DongketnoiSQL();
            return list;
        }
        private void add()
        {
            nhanVien = new frm_HoSoNhanVien().Select();
            nhaCungCap = new frm_NCC().Select();
            for (int i = 0; i < nhanVien.Count; i++)
            {
                comboBox1.Items.Add(nhanVien[i].MaNhanVien1);
            }
            for (int i = 0; i < nhaCungCap.Count; i++)
            {
                comboBox2.Items.Add(nhaCungCap[i].MaNhaCungCap1);
            }
        }
        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("select * from HoaDonNhap");
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            nhaCungCap = new frm_NCC().Select();
            nhanVien = new frm_HoSoNhanVien().Select();
            hoaDonNhap = Select();
            bool ncc = false, nv = false;
            bool check = false;
            for (int i = 0; i < hoaDonNhap.Count; i++)
            {
                if (hoaDonNhap[i].MaHoaDonNhap1.Equals(txt_MaHoaDon.Text))
                {
                    check = true;
                    MessageBox.Show("Đã có dữ liệu", "Thông báo");
                    break;
                }
            }

            for (int i = 0; i < nhaCungCap.Count; i++)
            {
                if (nhaCungCap[i].MaNhaCungCap1.Equals(comboBox2.Text))
                {
                    ncc = true;
                    break;
                }
            }
            if (ncc == false)
            {
                MessageBox.Show("Bạn chưa có mã nhà cung cấp này", "Thông báo");
            }
            else
            {
                for (int i = 0; i < nhanVien.Count; i++)
                {
                    if (nhanVien[i].MaNhanVien1.Equals(comboBox1.Text))
                    {
                        nv = true;
                        break;
                    }
                }
                if (nv == false)
                {
                    MessageBox.Show("Bạn chưa có mã nhân viên này", "Thông báo");
                }
            }
            double x;
            //bool number = false;
            //if (!double.TryParse(txt_TongTien.Text, out x))
            //{
            //    number = true;
            //    MessageBox.Show("Bạn cần nhập số");

            //}



            if (check == false && nv == true && ncc == true)
            {
                if (txt_MaHoaDon.Text.Trim() != "" && comboBox2.Text.Trim() != "" && comboBox1.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "")
                {
                    var p = dateTimePicker1.Text;
                    var z = p.Split('/');
                    Array.Reverse(z);
                    var k = string.Join("", z);
                    string sql = "insert into HoaDonNhap values(N'" + txt_MaHoaDon.Text + "',CAST( N'" + k + "' as DateTime),N'" + comboBox1.Text + "',N'" + comboBox2.Text + "','" + 0 + "')";
                    query.CapNhatDuLieu(sql);
                    fill();
                    hoaDonNhap.Add(new Class_HoaDonNhap(txt_MaHoaDon.Text, Convert.ToDateTime(dateTimePicker1.Text),  comboBox1.Text, comboBox2.Text, 0));
                    txt_MaHoaDon.Text = "";
                    comboBox2.Text = "";
                    comboBox1.Text = "";
                    //dateTimePicker1.Text = "";
                    txt_TongTien.Text = "";
                    txt_MaHoaDon.Focus();

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                }
            }
            txt_MaHoaDon.Text = "";
            txt_TongTien.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
           
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            hoaDonNhap = Select();
            bool check = false;
            for (int i = 0; i < hoaDonNhap.Count; i++)
            {
                if (txt_MaHoaDon.Text.Trim() == hoaDonNhap[i].MaHoaDonNhap1)
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from HoaDonNhap where MaHoaDonNhap=N'" + txt_MaHoaDon.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();
                    txt_MaHoaDon.Enabled = true;
                    comboBox2.Text = "";
                    comboBox1.Text = "";
                    //dateTimePicker1.Text = " ";
                    txt_TongTien.Text = "";
                    txt_MaHoaDon.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo");
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_MaHoaDon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_TongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_MaHoaDon.Enabled = false;
        }

        private void Btn_refesrh_Click(object sender, EventArgs e)
        {
            nhaCungCap = new frm_NCC().Select();
            nhanVien = new frm_HoSoNhanVien().Select();
            hoaDonNhap = Select();
            bool ncc = false, nv = false;


            for (int i = 0; i < nhaCungCap.Count; i++)
            {
                if (nhaCungCap[i].MaNhaCungCap1.Equals(comboBox2.Text))
                {
                    ncc = true;
                    break;
                }
            }
            if (ncc == false)
            {
                MessageBox.Show("Bạn chưa có mã nhà cung cấp này", "Thông báo");
            }
            else
            {
                for (int i = 0; i < nhanVien.Count; i++)
                {
                    if (nhanVien[i].MaNhanVien1.Equals(comboBox1.Text))
                    {
                        nv = true;
                        break;
                    }
                }
                if (nv == false)
                {
                    MessageBox.Show("Bạn chưa có mã nhân viên này", "Thông báo");
                }
            }
            double x;
            bool number = false;
            if (!double.TryParse(txt_TongTien.Text, out x))
            {
                number = true;
                MessageBox.Show("Bạn cần nhập số", "Thông báo");

            }

            if (number == false && ncc == true && nv == true && txt_MaHoaDon.Text.Trim() != "" && comboBox2.Text.Trim() != "" && comboBox1.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "" && txt_TongTien.Text.Trim() != "")
            {
                String sql = "update HoaDonNhap set NgayNhap=N'" + dateTimePicker1.Text + "', MaNhanVien=N'" + comboBox1.Text + "', MaNhaCungCap=N'" + comboBox2.Text + "', TongTien=N'" +txt_TongTien.Text + "' where MaHoaDonNhap = N'" + txt_MaHoaDon.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                hoaDonNhap.Add(new Class_HoaDonNhap(txt_MaHoaDon.Text, Convert.ToDateTime(dateTimePicker1.Text), comboBox1.Text, comboBox2.Text, Convert.ToDouble(txt_TongTien.Text)));
                txt_MaHoaDon.Text = "";
                //dateTimePicker1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                txt_TongTien.Text = "";
                txt_MaHoaDon.Enabled = true;
                txt_MaHoaDon.Focus();
            }
            else
            {
                MessageBox.Show("Bạn hãy nhập đủ thông tin khách hàng", "Thông báo");
            }
        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            add();
            fill();
            txt_MaHoaDon.Focus();
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            nhanVien = new frm_HoSoNhanVien().Select();
            comboBox1.Items.Clear();
            for (int i = 0; i < nhanVien.Count; i++)
            {
                comboBox1.Items.Add(nhanVien[i].MaNhanVien1);
            }
        }

        private void ComboBox2_Click(object sender, EventArgs e)
        {
            nhaCungCap = new frm_NCC().Select();
            comboBox2.Items.Clear();
            for (int i = 0; i < nhaCungCap.Count; i++)
            {
                comboBox2.Items.Add(nhaCungCap[i].MaNhaCungCap1);
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            txt_MaHoaDon.Text = "";
            txt_TongTien.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            fill();
        }
    }
}