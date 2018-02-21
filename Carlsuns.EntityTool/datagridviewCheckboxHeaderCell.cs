using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Carlsuns.EntityTool
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2018/1/25 15:12:43 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    /*****************************以下是自定义在datagridview列头绘制复选框*********************************************/
    //定义继承于DataGridViewColumnHeaderCell的类，用于绘制checkbox，定义checkbox鼠标单击事件
    public class datagridviewCheckboxHeaderCell : DataGridViewColumnHeaderCell
    {
        public delegate void HeaderEventHander(object sender, datagridviewCheckboxHeaderEventArgs e);
        public event HeaderEventHander OnCheckBoxClicked;
        public bool Checked
        {
            get { return _checked; }
        }
        Point checkBoxLocation;
        Size checkBoxSize;
        bool _checked = false;
        Point _cellLocation = new Point();
        System.Windows.Forms.VisualStyles.CheckBoxState _cbState =
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;

        //绘制列头checkbox
        protected override void Paint(System.Drawing.Graphics graphics,
           System.Drawing.Rectangle clipBounds,
           System.Drawing.Rectangle cellBounds,
           int rowIndex,
           DataGridViewElementStates dataGridViewElementState,
           object value,
           object formattedValue,
           string errorText,
           DataGridViewCellStyle cellStyle,
           DataGridViewAdvancedBorderStyle advancedBorderStyle,
           DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                dataGridViewElementState, value,
                formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);
            Point p = new Point();
            Size s = CheckBoxRenderer.GetGlyphSize(graphics,
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            p.X = cellBounds.Location.X +
                (cellBounds.Width / 2) - (s.Width / 2) - 1;//列头checkbox的X坐标
            p.Y = cellBounds.Location.Y +
                (cellBounds.Height / 2) - (s.Height / 2);//列头checkbox的Y坐标
            _cellLocation = cellBounds.Location;
            checkBoxLocation = p;
            checkBoxSize = s;
            if (_checked)
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.CheckedNormal;
            else
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.UncheckedNormal;
            CheckBoxRenderer.DrawCheckBox
            (graphics, checkBoxLocation, _cbState);
        }

        // /// <summary>
        ///// 点击列头checkbox单击事件
        ///// </summary>
        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            Point p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
            if (p.X >= checkBoxLocation.X && p.X <=
                checkBoxLocation.X + checkBoxSize.Width
            && p.Y >= checkBoxLocation.Y && p.Y <=
                checkBoxLocation.Y + checkBoxSize.Height)
            {
                _checked = !_checked;
                //获取列头checkbox的选择状态
                datagridviewCheckboxHeaderEventArgs ex = new datagridviewCheckboxHeaderEventArgs();
                ex.CheckedState = _checked;

                object sender = new object();//此处不代表选择的列头checkbox，只是作为参数传递。应该列头checkbox是绘制出来的，无法获得它的实例

                if (OnCheckBoxClicked != null)
                {
                    OnCheckBoxClicked(sender, ex);//触发单击事件
                    this.DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }
    }

    public class datagridviewCheckboxHeaderEventArgs : EventArgs
    {
        private bool checkedState = false;
        public bool CheckedState
        {
            get { return checkedState; }
            set { checkedState = value; }
        }
    }
}
