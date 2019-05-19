using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManageSystem
{
    public partial class frmChangePassword : Form
    {

        public User user;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        #region 操作
        //返回
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnChange_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckInput())
            {
                string sql_str = string.Format("@update [User] set PassWord='{0}' where UserID='{1}'",txtPassword.Text.Trim(),user.UserID);
            }
        }

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtPassword.Text.Trim() == "" )
            {
                MessageBox.Show("请输入原密码！");
                return false;
            }
            if (txtPassword.Text.Trim() != user.Password) {
                MessageBox.Show("原密码输入错误！");
                return false;
            }
            if (txtNewPassword.Text.Trim() == "") {
                MessageBox.Show("请输入新密码！");
                return false;
            }
            if (txtNewPassword.Text.Trim() != txtAgainNewPassword.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return false;
            }
            return true;
        } 
        #endregion
    }
}
