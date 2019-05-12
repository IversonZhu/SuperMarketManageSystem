namespace SuperMarketManageSystem
{
    partial class frmSuperMarketMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCommodityManage = new System.Windows.Forms.Label();
            this.lbCategoryManage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePassword,
            this.tsmiExit});
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.商品管理ToolStripMenuItem.Text = "商品管理(&U)";
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(152, 22);
            this.tsmiChangePassword.Text = "修改密码";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // lbCommodityManage
            // 
            this.lbCommodityManage.AutoSize = true;
            this.lbCommodityManage.Location = new System.Drawing.Point(275, 176);
            this.lbCommodityManage.Name = "lbCommodityManage";
            this.lbCommodityManage.Size = new System.Drawing.Size(53, 12);
            this.lbCommodityManage.TabIndex = 1;
            this.lbCommodityManage.Text = "商品管理";
            // 
            // lbCategoryManage
            // 
            this.lbCategoryManage.AutoSize = true;
            this.lbCategoryManage.Location = new System.Drawing.Point(588, 176);
            this.lbCategoryManage.Name = "lbCategoryManage";
            this.lbCategoryManage.Size = new System.Drawing.Size(77, 12);
            this.lbCategoryManage.TabIndex = 2;
            this.lbCategoryManage.Text = "商品类别管理";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperMarketManageSystem.Properties.Resources.manage;
            this.pictureBox1.Location = new System.Drawing.Point(230, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SuperMarketManageSystem.Properties.Resources.category;
            this.pictureBox2.Location = new System.Drawing.Point(559, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmSuperMarketMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 646);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCategoryManage);
            this.Controls.Add(this.lbCommodityManage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuperMarketMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市商品管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label lbCommodityManage;
        private System.Windows.Forms.Label lbCategoryManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}