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
    public partial class frmSuperMarketMain : Form
    {

        #region 变量
        public User user; 
        #endregion
        #region 容器加载（构造函数）
        public frmSuperMarketMain()
        {
            InitializeComponent();
        } 
        #endregion

        #region 操作事件
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            
        }
        #endregion

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword fcp = new frmChangePassword();
            fcp.user = user;
            fcp.Show();
        }
    }
}
