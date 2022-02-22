using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.CusControls.TableLayoutPanelEx
{
    public class TableLayoutPanelEx : TableLayoutPanel
    {
        #region Ctor
        public TableLayoutPanelEx()
        {
            //填充
            this.Dock = DockStyle.Fill;
        }
        #endregion

        #region 私有属性
        private int _newRowCount;
        private int _newColumnCount;
        #endregion

        #region 公有属性
        public int NewRowCount
        {
            get { return this._newRowCount; }
            set
            {
                this._newRowCount = value;
                SetRowCount(value);
            }
        }

        public int NewColumnCount
        {
            get { return this._newColumnCount; }
            set
            {
                this._newColumnCount = value;
                SetColumnCount(value);
            }
        }
        #endregion

        private void SetRowCount(int value)
        {
            //清空原有行和格式
            this.RowCount = 0;
            this.RowStyles.Clear();
            //重新定义行和格式
            this.RowCount = value + 2;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            for (int i = 0; i < value; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            }
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            //设置界面大小
            SetParentSize();
        }

        private void SetColumnCount(int value)
        {
            //清空原有行和格式
            this.ColumnCount = 0;
            this.ColumnStyles.Clear();
            //重新定义行和格式
            this.ColumnCount = value * 2 + 2;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            for (int i = 0; i < value; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            }
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            //设置界面大小
            SetParentSize();
        }

        private void SetParentSize()
        {
            //设置界面大小
            if (this.Parent != null)
            {
                int sumHeight = 0;
                sumHeight += this._newRowCount * 35;
                sumHeight += 20;
                int sumWidth = 0;
                sumWidth += this._newColumnCount * 300;
                sumWidth += 20;
                this.Parent.MinimumSize = new System.Drawing.Size(sumWidth + 20, sumHeight + 45);
                this.MinimumSize = new System.Drawing.Size(sumWidth, sumHeight);
            }
        }
    }
}
