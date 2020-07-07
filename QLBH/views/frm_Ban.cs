using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Model_Class;
using QLBH.Repository;

namespace QLBH.views
{
    public partial class frm_Ban : DevExpress.XtraEditors.XtraForm
    {
        public frm_Ban()
        {
            InitializeComponent();
            fill();
        }
        ConnectAndQuery query = new ConnectAndQuery();
        private List<Class_Ban> Test;
        public new List<Class_Ban> test1()
        {
            query.ketnoiSQL();
            string sql = "SELECT * FROM Ban";
            List<Class_Ban> list = new List<Class_Ban>();
            using (DbDataReader reader = query.Reader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string MaBan = reader.GetString(0);
                        string MaLoaiBan = reader.GetString(1);
                        string TenBan = reader.GetString(2);
                        Class_Ban Test = new Class_Ban()
                        {
                            MaBan = MaBan,
                            MaLoaiBan = MaLoaiBan,
                            TenBan = TenBan
                        };
                        list.Add(Test);
                    }
                }
            }
            query.DongketnoiSQL();
            return list;
        }
        private void fill()
        {
            DataTable data = query.DocBang("select * from Ban");
            dataGridView1.DataSource = data;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Test = test1();
            bool check = false;
            for (int i = 0; i < Test.Count; i++)
            {
                if (txt_MaBan.Text.Trim() == Test[i].MaLoaiBan)
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
                    string sql = "delete from Ban where MaBan = N'" + txt_MaBan.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();

                    txt_MaBan.Text = "";
                    txt_TenBan.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "message");
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (txt_MaBan.Text.Trim() != "" && txt_TenBan.Text.Trim() != "")
            {
                string sql = "UPDATE Ban set TenBan=N'" + txt_TenBan.Text + "', MaLoaiBan=N'"+cb_maloaiban.Text+"' where MaBan=N'" + txt_MaBan.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();


                txt_MaBan.Text = "";
                txt_TenBan.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Test = test1();
            bool check = false;

            for (int i = 0; i < Test.Count; i++)
            {
                if (Test[i].MaLoaiBan.Equals(txt_MaBan.Text))
                {
                    check = true;
                    MessageBox.Show("Đã có mã phiếu này, vui lòng nhập lại", "Thông báo");
                    break;
                }

            }
            if (check == false)
            {
                if (txt_MaBan.Text.Trim() != "" && txt_TenBan.Text.Trim() != "" && cb_maloaiban.Text.Trim() != "")
                {
                    string sql = "insert into Ban values(N'" + txt_MaBan.Text + "',N'" + cb_maloaiban.Text + "', N'"+txt_TenBan.Text+"')";
                    query.CapNhatDuLieu(sql);
                    fill();
                    txt_MaBan.Text = "";
                    txt_TenBan.Text = "";
                    cb_maloaiban.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_MaBan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenBan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_MaBan.Enabled = false;
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            txt_MaBan.Text = "";
            txt_MaBan.Enabled = true;
            txt_TenBan.Text = "";
            fill();
        }
    }
}