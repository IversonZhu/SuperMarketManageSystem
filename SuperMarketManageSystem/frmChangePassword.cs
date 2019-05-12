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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnChange_Click(object sender, EventArgs e)
        {
            //非空验证
        }

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtPassword.Text.Trim() == "" || txtNewPassword.Text.Trim() == "" || txtAgainNewPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名和密码");
                return false;
            }
            return true;
        } 
        #endregion
    }
}
