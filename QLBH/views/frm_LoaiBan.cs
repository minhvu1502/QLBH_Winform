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
    public partial class frm_LoaiBan : DevExpress.XtraEditors.XtraForm
    {
        public frm_LoaiBan()
        {
            InitializeComponent();
            fill();
        }
        ConnectAndQuery query = new ConnectAndQuery();
        private List<Class_LoaiBan> Test;
        public new List<Class_LoaiBan> test1()
        {
            query.ketnoiSQL();
            string sql = "SELECT * FROM LoaiBan";
            List<Class_LoaiBan> list = new List<Class_LoaiBan>();
            using (DbDataReader reader = query.Reader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string MaLoaiBan = reader.GetString(0);
                        string TenLoaiBan = reader.GetString(1);
                        Class_LoaiBan Test = new Class_LoaiBan()
                        {
                            MaLoaiBan = MaLoaiBan,
                            TenLoaiBan = TenLoaiBan
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
            DataTable data = query.DocBang("select * from LoaiBan");
            dataGridView1.DataSource = data;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Test = test1();
            bool check = false;
            for (int i = 0; i < Test.Count; i++)
            {
                if (txt_MaLoaiBan.Text.Trim() == Test[i].MaLoaiBan)
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
                    string sql = "delete from LoaiBan where MaLoaiBan = N'" + txt_MaLoaiBan.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();

                    txt_MaLoaiBan.Text = "";
                    txt_TenLoaiBan.Text = "";
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "message");
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (txt_MaLoaiBan.Text.Trim() != "" && txt_TenLoaiBan.Text.Trim() != "")
            {
                string sql = "UPDATE LoaiBan set TenLoaiBan=N'" + txt_TenLoaiBan.Text + "' where MaLoaiBan=N'" + txt_MaLoaiBan.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();


                txt_MaLoaiBan.Text = "";
                txt_TenLoaiBan.Text = "";
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
                if (Test[i].MaLoaiBan.Equals(txt_MaLoaiBan.Text))
                {
                    check = true;
                    MessageBox.Show("Đã có mã phiếu này, vui lòng nhập lại", "Thông báo");
                    break;
                }

            }
            if (check == false )
            {
                if (txt_MaLoaiBan.Text.Trim() != "" && txt_TenLoaiBan.Text.Trim() != "")
                {
                    string sql = "insert into LoaiBan values(N'" + txt_MaLoaiBan.Text + "',N'" + txt_TenLoaiBan.Text + "')";
                    query.CapNhatDuLieu(sql);
                    fill();
                    txt_MaLoaiBan.Text = "";
                    txt_TenLoaiBan.Text = "";
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
            txt_MaLoaiBan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenLoaiBan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_MaLoaiBan.Enabled = false;
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            txt_MaLoaiBan.Text = "";
            txt_MaLoaiBan.Enabled = true;
            txt_TenLoaiBan.Text = "";
            fill();
        }
    }
}