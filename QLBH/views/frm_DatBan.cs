using System;
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
using System.Data.SqlClient;
using QLBH.Repository;
using System.Data.Common;
using QLBH.Common;
using QLBH.views;

namespace QLBH
{
    public partial class frm_DatBan : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _MaBan;
        List<Class_PhieuDatBan> Test;
        List<Class_Khach> Khach;
        List<Class_NhanVien> NV;
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_DatBan()
        {
            InitializeComponent();
            fill();
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        public frm_DatBan(string MaBan)
        {

            InitializeComponent();
            fill();
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void add()
        {
            Khach = new frm_KhachHang().Select();
            NV = new frm_HoSoNhanVien().Select();
            for (int i = 0; i < Khach.Count; i++)
            {
                comboBox1.Items.Add(Khach[i].MaKhach1);
            }
            for (int i = 0; i < NV.Count; i++)
            {
                comboBox2.Items.Add(NV[i].MaNhanVien1);
            }
        }

        public new List<Class_PhieuDatBan> Select()
        {
            string sql = "SELECT * FROM PhieuDatban";
            List<Class_PhieuDatBan> list = new List<Class_PhieuDatBan>();
            query.ketnoiSQL();
            using (DbDataReader reader = query.Reader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string MaPhieu = reader.GetString(0);
                        string MaNhanVien = reader.GetString(1);
                        string MaKhach = reader.GetString(2);
                        DateTime NgayDat = reader.GetDateTime(3);
                        DateTime NgayDung = reader.GetDateTime(4);
                        double TongTien;
                        var Tg = reader.GetValue(5);
                        if (Tg == DBNull.Value)
                        {
                            TongTien = 0;
                        }
                        else
                        {
                            TongTien = Convert.ToDouble(Tg);
                        }
                        Class_PhieuDatBan Test = new Class_PhieuDatBan(MaPhieu, MaKhach, MaNhanVien, NgayDat, NgayDung, TongTien);
                        list.Add(Test);
                    }
                }
            }
            query.DongketnoiSQL();
            return list;
        }
        private void fill()
        {
            DataTable data = query.DocBang("select * from PhieuDatBan");
            dataGridView1.DataSource = data;
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_LoaiBenh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //dateTimePicker1.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value);
            //dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textEdit4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_MaBan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_LoaiBenh.Enabled = false;
        }
        private void Frm_DatBan_Load(object sender, EventArgs e)
        {
            add();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Test = Select();
            bool check = false;

            bool k = false, nv = false;
            NV = new frm_HoSoNhanVien().Select();

            for (int i = 0; i < Khach.Count; i++)
            {
                if (Khach[i].MaKhach1.Equals(comboBox1.Text))
                {
                    k = true;
                    break;
                }
            }
            if (k == false)
            {
                MessageBox.Show("Chưa có mã Khách này!", "Thông báo");
            }
            else
            {
                for (int i = 0; i < NV.Count; i++)
                {
                    if (NV[i].MaNhanVien1.Equals(comboBox2.Text))
                    {
                        nv = true;
                        break;
                    }
                }
                if (nv == false)
                {
                    MessageBox.Show("Chưa có mã nhân viên này!", "Thông báo");
                }
            }




            for (int i = 0; i < Test.Count; i++)
            {
                if (Test[i].MaPhieu1.Equals(txt_LoaiBenh.Text))
                {
                    check = true;
                    MessageBox.Show("Đã có mã phiếu này, vui lòng nhập lại", "Thông báo");
                    break;
                }

            }
            if (check == false && k == true && nv == true)
            {
                if (DateTime.Compare(DateTime.Today, dateTimePicker2.Value) == 1)
                {
                    MessageBox.Show("ngày dùng phải lớn hơn hoặc bằng ngày hiện tại", "Thông báo");
                }
                else if (DateTime.Compare(DateTime.Now, dateTimePicker1.Value) == -1)
                {
                    MessageBox.Show("Ngày đặt phải nhỏ hơn hoặc bằng ngày hiện tại", "Thông báo");
                }
                else if (DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value) == 1)
                {
                    MessageBox.Show("Ngày đặt phải nhỏ hơn hoặc bằng ngày dùng", "Thông báo");
                }
                else if (comboBox2.Text.Trim() != "" && txt_LoaiBenh.Text.Trim() != "" && comboBox1.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "" && dateTimePicker2.Text.Trim() != "" && txt_MaBan.Text.Trim() !="")
                {
                    var ngaydat = Revese(dateTimePicker1.Text);
                    var ngaydi = Revese(dateTimePicker2.Text);

                    string sql = "insert into PhieuDatBan values(" + "N'" + txt_LoaiBenh.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.Text + "',CAST( N'" + ngaydat + "' as DateTime),CAST( N'" + ngaydi + "' as DateTime),'" + 0 + "', N'"+txt_MaBan.Text+"')";
                    query.CapNhatDuLieu(sql);
                    fill();
                    comboBox2.Text = "";
                    txt_LoaiBenh.Text = "";
                    comboBox1.Text = "";
                    textEdit4.Text = "";
                    comboBox2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                }
            }

        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Test = Select();
            bool check = false;
            for (int i = 0; i < Test.Count; i++)
            {
                if (txt_LoaiBenh.Text.Trim() == Test[i].MaPhieu1)
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
                    string sql = "delete from PhieuDatBan where MaPhieu=N'" + txt_LoaiBenh.Text + "'";
                    query.CapNhatDuLieu(sql);
                    fill();
                    comboBox2.Text = "";
                    txt_LoaiBenh.Text = "";
                    comboBox1.Text = "";
                    textEdit4.Text = "";
                    comboBox2.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "message");
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            Khach = new frm_KhachHang().Select();
            comboBox1.Items.Clear();
            for (int i = 0; i < Khach.Count; i++)
            {
                comboBox1.Items.Add(Khach[i].MaKhach1);
            }
        }

        private void ComboBox2_Click(object sender, EventArgs e)
        {
            NV = new frm_HoSoNhanVien().Select();
            comboBox2.Items.Clear();
            for (int i = 0; i < NV.Count; i++)
            {
                comboBox2.Items.Add(NV[i].MaNhanVien1);
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            txt_LoaiBenh.Text = "";
            comboBox1.Text = "";
            textEdit4.Text = "";
            txt_LoaiBenh.Enabled = true;
            fill();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Test = Select();
            if (comboBox2.Text.Trim() != "" && txt_LoaiBenh.Text.Trim() != "" && comboBox1.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "" && dateTimePicker2.Text.Trim() != "" && txt_MaBan.Text.Trim() != "")
            {
                var ngaydat = Revese(dateTimePicker1.Text);
                var ngaydi = Revese(dateTimePicker2.Text);
                string sql = "update PhieuDatBan set MaKhach=N'" + comboBox1.Text + "', MaNhanVien=N'" + comboBox2.Text + "', NgayDat=CAST( N'" + ngaydat + "' as DateTime), NgayDung=CAST( N'" + ngaydi + "' as DateTime), MaBan = N'" + txt_MaBan.Text + "' where MaPhieu = N'" + txt_LoaiBenh.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();

                //Select.Add(new Class_PhieuDatBan(txt_LoaiBenh.Text, comboBox1.Text, comboBox2.Text, Convert.ToDateTime(textEdit2.Text), Convert.ToDateTime(textEdit3.Text), Convert.Todouble(textEdit4.Text)));
                comboBox2.Text = "";
                txt_LoaiBenh.Text = "";
                comboBox1.Text = "";
                textEdit4.Text = "";
                comboBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        public string Revese(string x)
        {
            var p = x;
            var z = p.Split('/');
            Array.Reverse(z);
            var k = string.Join("", z);
            return k;
        }
        List<Button> list = new List<Button>();
        List<Button> list1 = new List<Button>();
        public void LoadData()
        {
            DataTable data, data1;
            string sql;
            sql = "  select * from PhieuDatBan where DATEDIFF(DAY, GETDATE(), NgayDung) >= 0";
            data = query.DocBang(sql);
            sql = "select * from Ban";
            data1 = query.DocBang(sql);
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                Button button = new Button();
                button.Text = data1.Rows[i]["TenBan"].ToString();
                button.Height = 35;
                button.Width = 100;
                button.Anchor = AnchorStyles.None;
                button.Image = Image.FromFile("F:\\CSharp-master\\CSharp-master\\BTLCSharp\\QLBH\\QLBH\\images\\Household-Table-icon.png");
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                for (int j = 0; j < data.Rows.Count; j++)
                {
                    if (data.Rows[j]["MaBan"].ToString() == data1.Rows[i]["MaBan"].ToString())
                    {
                        button.BackColor = Color.Red;
                    }
                }
                flowLayoutPanel1.Controls.Add(button);
                flowLayoutPanel1.AutoScroll = true;
                list.Add(button);
                button.Click += new EventHandler(this.buttonClick);
            }
        }


        public void buttonClick(object sender, EventArgs e)
        {
            var x = (Button)sender;
            if (x.BackColor != Color.Red)
            {
                if (x.BackColor == Color.DodgerBlue)
                {
                    x.BackColor = Color.White;
                    txt_MaBan.Text = "";
                }
                else
                {
                    x.BackColor = Color.DodgerBlue;
                    //var TenBan = x.Text;
                    //string sql = "select MaBan from Ban where TenBan = N'" + TenBan + "'";
                    //var tb = query.DocBang(sql);
                    //txt_MaBan.Text = tb.Rows[0]["MaBan"].ToString();
                    txt_MaBan.Text = x.Text;
                    foreach (var t in list1)
                    {
                        if (t.BackColor == Color.DodgerBlue && t.Text != x.Text)
                        {
                            t.BackColor = Color.White;
                        }

                    }
                }
            }
            else
            { 
                string sql = "select MaBan from Ban where MaBan = N'" + x.Text + "'"; 
                DataTable tb = query.DocBang(sql);
               BanResult.MaBan = tb.Rows[0]["MaBan"].ToString();
                DialogResult result = MessageBox.Show("Bàn Này Đã Được Đặt", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    frm_XemBan frm = new frm_XemBan();
                    frm.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            list1.Clear();
            string sql = "select * from Ban";
            DataTable data1 = query.DocBang(sql);
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                Button button = new Button();
                button.Text = data1.Rows[i]["MaBan"].ToString();
                button.Height = 35;
                button.Width = 100;
                button.Anchor = AnchorStyles.None;
                button.Image = Image.FromFile("F:\\CSharp-master\\CSharp-master\\BTLCSharp\\QLBH\\QLBH\\images\\Household-Table-icon.png");
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                list1.Add(button);
            }
            string date = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            sql = "select MaBan from PhieuDatBan where NgayDung = N'" + date + "' and DATEDIFF(DAY, GETDATE(), NgayDung) >= 0";
            DataTable db = query.DocBang(sql);
            for (int i = 0; i < db.Rows.Count; i++)
            {
                foreach (var item in list1)
                {
                    if (db.Rows[i]["MaBan"].ToString() == item.Text)
                    {
                        item.BackColor = Color.Red;
                    }
                }
            }
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in list1)
            {
                flowLayoutPanel1.Controls.Add(item);
                item.Click += new EventHandler(this.buttonClick);
            }
        }
    }
}
