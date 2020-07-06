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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        ConnectAndQuery db = new ConnectAndQuery();
        public Login()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi frm = new DangKi();
            frm.ShowDialog();
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var username = txt_user.Text;
            var password = txt_pass.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("Hãy Nhập Tài Khoản", "Thông Báo");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Hãy Nhập Mật Khẩu", "Thông Báo");
            }
            else
            {
                string sql = "select name from Account where username ='" + username + "' and password ='" + password +"'" ;
                var result = db.DocBang(sql);
                if (result.Rows.Count > 0)
                {
                    this.Hide();
                    var user = (string)result.Rows[0]["name"];
                    frm_Main frm = new frm_Main(user);
                    frm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!", "Thông Báo");
                }
            }
        }
    }
}