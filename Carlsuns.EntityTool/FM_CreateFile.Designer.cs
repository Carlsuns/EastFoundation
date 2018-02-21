namespace Carlsuns.EntityTool
{
    partial class FM_CreateFile
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
            this.pb_createFile = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_createFile
            // 
            this.pb_createFile.Location = new System.Drawing.Point(4, 26);
            this.pb_createFile.Name = "pb_createFile";
            this.pb_createFile.Size = new System.Drawing.Size(403, 23);
            this.pb_createFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "生成文件进度：";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(86, 6);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(53, 12);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "正在生成";
            // 
            // FM_CreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 56);
            this.ControlBox = false;
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_createFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FM_CreateFile";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成文件";
            this.Shown += new System.EventHandler(this.FM_CreateFile_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pb_createFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_status;
    }
}