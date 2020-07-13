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
using QLBH.Repository;

namespace QLBH.views
{
    public partial class DangKi : DevExpress.XtraEditors.XtraForm
    {
        public DangKi()
        {
            InitializeComponent();
        }
        ConnectAndQuery db = new ConnectAndQuery();
        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy bỏ", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login frm = new Login();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void txt_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            var username = txt_username.Text;
            var password = txt_password.Text;
            var confirm = txt_confirm.Text;
            var name = txt_name.Text;
            var phone = txt_phone.Text;
            var email = txt_email.Text;
            if (username.Equals("") || password.Equals("") || confirm.Equals("") || name.Equals("") ||
                phone.Equals("") || email.Equals(""))
            {
                MessageBox.Show("Hãy Nhập Đủ Thông Tin", "Thông Báo");
            } else if (password != confirm)
            {
                MessageBox.Show("Confirm Password does not match", "Thông Báo");
            }
            else
            {
                string sql = "select * from Account where username ='" + username +"'";
                var result = db.DocBang(sql);
                if (result.Rows.Count > 0)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại", "Thông Báo");
                }
                else
                {
                    sql = "INSERT account ([username], [password], [name], [phone], [email]) VALUES (N'" + username + "', N'" + Hash(password) + "', N'" + name + "', N'" + phone + "', '" + email + "')";
                    db.CapNhatDuLieu(sql);
                    MessageBox.Show("Đăng kí thành công", "Thông Báo");
                    this.Hide();
                    Login frm = new Login();
                    frm.ShowDialog();
                    this.Close();
                }
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
    }
}