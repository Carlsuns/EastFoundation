using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carlsuns.EntityTool
{
    public partial class FM_Preview : Form
    {
        public FM_Preview(string strPreviewText)
        {
            InitializeComponent();
            this.rtb_entityClass.Text = strPreviewText;


            if (this.rtb_entityClass.Text != "")
            {
                this.rtb_entityClass.Font = new Font("新宋体", 13f);
                if (!this.rtb_entityClass.Focused)
                {
                    string[] keywords = new string[] {
                "public", "internal", "protected", "private", "void", "class", "get", "set", "value", "return", "this", "C#", "long", "bool", "double", "byte[]",
                "int", "decimal", "string", "float", "DateTime", "short", "byte", "Guid", "object", "未知类型","namespace","using"
             };
                    this.changeColor(keywords);
                    //string className = this.lbxTableName.SelectedItem.ToString().Trim();
                    //className = className.Substring(0, 1).ToUpper() + className.Substring(1);
                    //this.changeColor(className);
                }
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtb_entityClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeColor(string[] keywords)
        {
            int num = 0;
            for (int i = 0; i < this.rtb_entityClass.Text.Length; i++)
            {
                foreach (string str in keywords)
                {
                    num = this.rtb_entityClass.Find(str, i, str.Length + i, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
                    i = (num >= 0) ? (i + str.Length) : i;
                    if (num >= 0)
                    {
                        break;
                    }
                }
                this.rtb_entityClass.SelectionColor = Color.Blue;
            }
        }



    }
}
