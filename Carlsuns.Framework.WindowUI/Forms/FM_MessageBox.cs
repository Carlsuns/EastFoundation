using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Carlsuns.Framework.WindowUI.Forms
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2017/4/12 14:36:07 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    internal partial class FM_MessageBox : Carlsuns.Framework.WindowUI.FM_Base
    {
        #region fileds
        private string _Caption;
        private string _Message;
        private EnumMessageBox _MessageMode;
        private readonly int _MaxWidth = 600;
        private readonly int _MaxHeight = 400;
        #endregion


        public FM_MessageBox()
        {
            InitializeComponent();
            //this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.TopMost = true;
            this._Caption = "";
            this._Message = "";
            this._MessageMode = EnumMessageBox.Info;
            this.MaximumSize = new Size(this._MaxWidth, this._MaxHeight);
            //ControlHelper.BindMouseMoveEvent(this.labMessage);
            //ControlHelper.BindMouseMoveEvent(this.panel1);
            //this.StartPosition = FormStartPosition.CenterParent;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
        }


        public FM_MessageBox(string captionText, string message, EnumMessageBox messageBoxMode)
            : this()
        {
            this._Caption = captionText;
            this._MessageMode = messageBoxMode;

            this._Message = message;
            this.ResetSize();
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FM_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(575, 193);
            this.Name = "FM_MessageBox";
            this.ResumeLayout(false);


            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Button();
            this.btnOK = new Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labMessage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 118);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labMessage
            // 
            this.labMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMessage.Location = new System.Drawing.Point(96, 8);
            this.labMessage.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.labMessage.Name = "labMessage";
            this.tableLayoutPanel2.SetRowSpan(this.labMessage, 3);
            this.labMessage.Size = new System.Drawing.Size(265, 102);
            this.labMessage.TabIndex = 0;
            this.labMessage.Text = "天下酒店网，一个神奇的网站！";
            this.labMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 19);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(80, 80);
            this.panel2.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(5, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Padding = new System.Windows.Forms.Padding(12);
            this.pbImage.Size = new System.Drawing.Size(70, 70);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //this.tableLayoutPanel1.Controls.Add(this.txPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 154);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = null;
            this.btnCancel.Location = new System.Drawing.Point(203, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = null;
            this.btnOK.Location = new System.Drawing.Point(106, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // TXMessageBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            //this.BorderWidth = 1;
            this.CancelButton = this.btnCancel;
            //this.CaptionFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(383, 188);
            //this.ControlBoxSize = new System.Drawing.Size(35, 16);
            this.Controls.Add(this.tableLayoutPanel1);
            //this.CornerRadius = 2;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FM_MessageBox";
            this.Padding = new System.Windows.Forms.Padding(3);
            //this.txPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private void ResetSize()
        {
            Size labSize = labMessage.Size;
            Size minSize = TextRenderer.MeasureText("鄺", this.Font);
            int maxLineCount = labSize.Height / minSize.Height;
            int maxWordCount = (labSize.Width * labSize.Height) / (minSize.Width * minSize.Width);
            using (Graphics g = labMessage.CreateGraphics())
            {
                int wordCount, lineCount;
                g.MeasureString(this._Message, this.Font,
                    new SizeF(labSize.Width, this._MaxHeight),
                    StringFormat.GenericDefault, out wordCount, out lineCount);

                if (lineCount > maxLineCount)
                {
                    this.Size = new SizeF(this.Size.Width, this.Size.Height + minSize.Height * (lineCount - maxLineCount)).ToSize();
                }

                if (wordCount > maxWordCount)
                {
                    float rate = this._Message.Length / maxWordCount;
                    rate = 1 + (rate - 1) / 8;
                    this.Size = new SizeF(this.Size.Width * rate, this.Size.Height * rate).ToSize();
                }
            }
        }


        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labMessage;
        private Button btnCancel;
        private Button btnOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
