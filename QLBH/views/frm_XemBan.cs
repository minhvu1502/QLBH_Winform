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
using QLBH.Common;
using QLBH.Repository;

namespace QLBH.views
{
    public partial class frm_XemBan : DevExpress.XtraEditors.XtraForm
    {
        ConnectAndQuery db = new ConnectAndQuery();
        
        public frm_XemBan()
        {
            InitializeComponent();
            LoadData();
        }
        List<Button> list = new List<Button>();
        public void LoadData()
        {
            DataTable data, data1;
            string sql;
            sql = "  select * from PhieuDatBan where DATEDIFF(DAY, GETDATE(), NgayDung) >= 0";
            data = db.DocBang(sql);
            sql = "select * from Ban";
            data1 = db.DocBang(sql);
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
                list.Add(button);
                button.Click += new EventHandler(this.buttonClick);
            }
        }

        public void buttonClick(object sender, EventArgs e)
        {
            var x = (Button) sender;
            if (x.BackColor != Color.Red)
            {
                    if (x.BackColor == Color.DodgerBlue)
                    {
                        x.BackColor = Color.White;
                    }
                    else
                    {
                        x.BackColor = Color.DodgerBlue;
                    foreach (var t in list)
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
                    MessageBox.Show("Bàn Này Đã Được Đặt");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var count = 0;
            string result = null;
            foreach (var item in list)
            {
                if (item.BackColor == Color.DodgerBlue)
                {
                    count++;
                    result = item.Text;
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Bạn Hãy Chọn Một Bàn");
            }
            else
            {
                this.Hide();
                BanResult.MaBan = result;
                this.Close();
            }
        }
    }
}