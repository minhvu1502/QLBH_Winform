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
            if (checkRemember.Checked)
            {
                Properties.Settings.Default.username = txt_user.Text;
                Properties.Settings.Default.password = txt_pass.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
            }
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
                string sql = "select name from Account where username ='" + username + "' and password ='" + Hash(password) +"'" ;
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                txt_user.Text = Properties.Settings.Default.username;
                txt_pass.Text = Properties.Settings.Default.password;
                checkRemember.Checked = true;
            }
        }
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }
        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}