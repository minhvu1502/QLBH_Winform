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
        public void LoadData()
        {
            var MaBan = BanResult.MaBan;
            string sql = "select * from PhieuDatBan where DATEDIFF(DAY, GETDATE(), NgayDung) > 0 and MaBan = N'"+MaBan+"'";
            DataTable dataTable = db.DocBang(sql);
            dataGridView1.DataSource = dataTable;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        //private void btn_ok_Click(object sender, EventArgs e)
        //{
        //    var count = 0;
        //    string result = null;
        //    foreach (var item in list)
        //    {
        //        if (item.BackColor == Color.DodgerBlue)
        //        {
        //            count++;
        //            result = item.Text;
        //        }
        //    }

        //    if (count == 0)
        //    {
        //        MessageBox.Show("Bạn Hãy Chọn Một Bàn");
        //    }
        //    else
        //    {
        //        this.Hide();
        //        this.Close();
        //    }
        //}
    }
}