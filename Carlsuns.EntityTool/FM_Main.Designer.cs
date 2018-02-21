namespace Carlsuns.EntityTool
{
    partial class FM_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_ProductNameVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_createFile = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_dirPath = new System.Windows.Forms.Button();
            this.tb_dirPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nameSpace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dv_tableList = new System.Windows.Forms.DataGridView();
            this.cbo_dbList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_tableList)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_ProductNameVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_ProductNameVersion
            // 
            this.TSSL_ProductNameVersion.Name = "TSSL_ProductNameVersion";
            this.TSSL_ProductNameVersion.Size = new System.Drawing.Size(131, 17);
            this.TSSL_ProductNameVersion.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_server);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库信息";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(795, 17);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(600, 17);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(185, 21);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "Pass@word1";
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密  码：";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(352, 17);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(185, 21);
            this.tb_user.TabIndex = 3;
            this.tb_user.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名：";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(64, 17);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(220, 21);
            this.tb_server.TabIndex = 1;
            this.tb_server.Text = "(local)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_createFile);
            this.groupBox2.Controls.Add(this.btn_preview);
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btn_dirPath);
            this.groupBox2.Controls.Add(this.tb_dirPath);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_nameSpace);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dv_tableList);
            this.groupBox2.Controls.Add(this.cbo_dbList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 506);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成配置";
            // 
            // btn_createFile
            // 
            this.btn_createFile.Location = new System.Drawing.Point(714, 39);
            this.btn_createFile.Name = "btn_createFile";
            this.btn_createFile.Size = new System.Drawing.Size(75, 23);
            this.btn_createFile.TabIndex = 14;
            this.btn_createFile.Text = "生成文件";
            this.btn_createFile.UseVisualStyleBackColor = true;
            this.btn_createFile.Click += new System.EventHandler(this.btn_createFile_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(633, 39);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 13;
            this.btn_preview.Text = "预览";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(795, 39);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_dirPath
            // 
            this.btn_dirPath.Location = new System.Drawing.Point(795, 12);
            this.btn_dirPath.Name = "btn_dirPath";
            this.btn_dirPath.Size = new System.Drawing.Size(75, 23);
            this.btn_dirPath.TabIndex = 11;
            this.btn_dirPath.Text = "选择";
            this.btn_dirPath.UseVisualStyleBackColor = true;
            this.btn_dirPath.Click += new System.EventHandler(this.btn_dirPath_Click);
            // 
            // tb_dirPath
            // 
            this.tb_dirPath.Enabled = false;
            this.tb_dirPath.Location = new System.Drawing.Point(352, 14);
            this.tb_dirPath.Name = "tb_dirPath";
            this.tb_dirPath.Size = new System.Drawing.Size(443, 21);
            this.tb_dirPath.TabIndex = 7;
            this.tb_dirPath.Text = "E:\\Test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "生成目录：";
            // 
            // tb_nameSpace
            // 
            this.tb_nameSpace.Location = new System.Drawing.Point(64, 39);
            this.tb_nameSpace.Name = "tb_nameSpace";
            this.tb_nameSpace.Size = new System.Drawing.Size(220, 21);
            this.tb_nameSpace.TabIndex = 7;
            this.tb_nameSpace.Text = "EastFoundation.Dao.Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "命名空间：";
            // 
            // dv_tableList
            // 
            this.dv_tableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_tableList.Location = new System.Drawing.Point(6, 66);
            this.dv_tableList.Name = "dv_tableList";
            this.dv_tableList.RowTemplate.Height = 23;
            this.dv_tableList.Size = new System.Drawing.Size(872, 440);
            this.dv_tableList.TabIndex = 9;
            this.dv_tableList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_tableList_CellContentClick);
            // 
            // cbo_dbList
            // 
            this.cbo_dbList.FormattingEnabled = true;
            this.cbo_dbList.Location = new System.Drawing.Point(64, 14);
            this.cbo_dbList.Name = "cbo_dbList";
            this.cbo_dbList.Size = new System.Drawing.Size(220, 20);
            this.cbo_dbList.TabIndex = 8;
            this.cbo_dbList.SelectedIndexChanged += new System.EventHandler(this.cbo_dbList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库：";
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体生成工具";
            this.Load += new System.EventHandler(this.FM_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_tableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_ProductNameVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_dbList;
        private System.Windows.Forms.DataGridView dv_tableList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nameSpace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_dirPath;
        private System.Windows.Forms.Button btn_dirPath;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_createFile;
        private System.Windows.Forms.Button btn_preview;
    }
}

