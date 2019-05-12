using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManageSystem
{
    public partial class frmLogin : Form
    {
        #region 构造函数
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region 组件添加
        private void InitializeComponent()
        {
            this.sysName = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sysName
            // 
            this.sysName.AutoSize = true;
            this.sysName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sysName.Location = new System.Drawing.Point(43, 41);
            this.sysName.Name = "sysName";
            this.sysName.Size = new System.Drawing.Size(200, 16);
            this.sysName.TabIndex = 0;
            this.sysName.Text = "欢迎使用超市商品管理系统";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(33, 112);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(41, 12);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "用户名";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(33, 169);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(29, 12);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "密码";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(46, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 21);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(286, 301);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.sysName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        #endregion

        #region 事件
        //点击登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (Login())
                {
                    User user = new User();
                    user.Username = txtName.Text.Trim();
                    user.Password = txtPassword.Text.Trim();
                    frmSuperMarketMain fsmm = new frmSuperMarketMain();
                    fsmm.user = user;
                    fsmm.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("登录失败");
                }
            }
        }

        //点击取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名和密码");
                return false;
            }
            return true;
        }
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns>true :登录成功, false :登录失败</returns>
        public bool Login()
        {
            bool flag = false;
            string username = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            DBHelper dbHelper = new DBHelper();
            try
            {
                //1.创建sql语句
                string sql = string.Format("select * from [User] where UserName='{0}' and PassWord='{1}'", username, password);
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Conn);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if (reader.Read())
                {
                    flag = true;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("发生异常: " + e.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return flag;
        }
        #endregion

        
    }
}
