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
            this.RowCount = 0;
            this.RowStyles.Clear();

            this.RowCount = value + 2;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            for (int i = 0; i < value; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            }
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
        }

        private void SetColumnCount(int value)
        {
            this.ColumnCount = 0;
            this.ColumnStyles.Clear();

            this.ColumnCount = value * 2 + 2;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            for (int i = 0; i < value; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            }
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
        }
    }
}
