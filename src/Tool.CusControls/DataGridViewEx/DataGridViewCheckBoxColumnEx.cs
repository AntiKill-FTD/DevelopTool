﻿using System.Windows.Forms.VisualStyles;
using Tool.CusControls.CommonEx;

/*
 * @Content:
 *      此类主要是在DataGridView的checkbox列中扩展出一个更便于控制的CheckBox列
 *      1> 主要可以再表头添加全选的checkbox
 *      2> 全选可以和下面的行进行联动
 *      3> 控制此列单元格中只有点击到checkbox时才起作用，不会点击单元格就起效果。
 *      4> 封装了checkbox列的一些操作，不必是DataGridView中需要自定义操作。
 */
namespace Tool.CusControls.DataGridViewEx
{
    /// <summary>
    /// 扩展列
    /// </summary>
    public class DataGridViewCheckBoxColumnEx : DataGridViewCheckBoxColumn
    {
        /// <summary>
        /// 扩展表头属性
        /// </summary>
        public DataGridViewCheckBoxColumnHeaderCellEx HeaderCellEx
        {
            get { return this.HeaderCell as DataGridViewCheckBoxColumnHeaderCellEx; }
        }

        /// <summary>
        /// 本列是否全选，方便在Cell中获取
        /// </summary>
        public Boolean IsCheckedAll
        {
            get { return HeaderCellEx.CheckedAllState == CheckState.Checked; }
        }

        /// <summary>
        /// 构造函数，包括：表头单元格、行单元格
        /// </summary>
        /// <param name="isChangeHeader">是否修改标题为CheckBox</param>
        public DataGridViewCheckBoxColumnEx(bool isChangeHeader = false)
            : base()
        {
            //建立表头单元格
            this.HeaderCell = new DataGridViewCheckBoxColumnHeaderCellEx(isChangeHeader);

            //建立行单元格模板
            this.CellTemplate = new DataGridViewCheckBoxCellEx();
        }
    }

    /// <summary>
    /// 扩展表头单元格
    /// </summary>
    public class DataGridViewCheckBoxColumnHeaderCellEx : DataGridViewColumnHeaderCell
    {
        #region "type:properties"

        private bool m_isChangeHeader = false;
        /// <summary>
        /// 是否修改标题为CheckBox
        /// </summary>
        public bool IsChangeHeader
        {
            get { return m_isChangeHeader; }
            set { m_isChangeHeader = value; }
        }

        private CheckState m_checkedAllState = CheckState.Unchecked;
        /// <summary>
        /// 全选按钮状态
        /// </summary>
        public CheckState CheckedAllState
        {
            get { return m_checkedAllState; }
            set { m_checkedAllState = value; }
        }

        /// <summary>
        /// 用于标识当前的checkbox状态
        /// </summary>
        protected CheckBoxState m_checkboxState = CheckBoxState.UncheckedNormal;

        /// <summary>
        /// 是否是鼠标经过的这种hot状态，不是即为normal
        /// </summary>
        protected Boolean m_isHot = false;

        /// <summary>
        /// checkbox按钮区域
        /// </summary>
        protected Rectangle m_chkboxRegion;

        /// <summary>
        /// 相对于本cell的位置
        /// </summary>
        protected Rectangle m_absChkboxRegion;

        #endregion

        #region "type:initial"

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="isChangeHeader"></param>
        public DataGridViewCheckBoxColumnHeaderCellEx(bool isChangeHeader)
        {
            this.IsChangeHeader = isChangeHeader;
        }

        #endregion

        #region "type:paint"

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            //绘制checkbox还是绘制文字
            if (!this.IsChangeHeader)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, @"", @"", errorText, cellStyle, advancedBorderStyle, paintParts);
                this.m_chkboxRegion = RectangleCommon.GetSmallRectOfRectangle(cellBounds, CheckBoxRenderer.GetGlyphSize(graphics, CheckBoxState.UncheckedNormal), out m_absChkboxRegion);
                this.RenderCheckBox(graphics);
            }
            else
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
        }

        protected void RenderCheckBox(Graphics graphics)
        {
            if (m_isHot)
                RenderCheckBoxHover();
            else
                RenderCheckBoxNormal();

            CheckBoxRenderer.DrawCheckBox(graphics, m_chkboxRegion.Location, m_checkboxState);
        }

        protected void RenderCheckBoxNormal()
        {
            switch (m_checkedAllState)
            {
                case CheckState.Unchecked:
                    this.m_checkboxState = CheckBoxState.UncheckedNormal;
                    break;
                case CheckState.Indeterminate:
                    this.m_checkboxState = CheckBoxState.MixedNormal;
                    break;
                case CheckState.Checked:
                    this.m_checkboxState = CheckBoxState.CheckedNormal;
                    break;
            }
        }

        protected void RenderCheckBoxHover()
        {
            switch (m_checkedAllState)
            {
                case CheckState.Unchecked:
                    this.m_checkboxState = CheckBoxState.UncheckedHot;
                    break;
                case CheckState.Indeterminate:
                    this.m_checkboxState = CheckBoxState.MixedHot;
                    break;
                case CheckState.Checked:
                    this.m_checkboxState = CheckBoxState.CheckedHot;
                    break;
            }
        }

        #endregion

        #region "type:events"

        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (IsInCheckRegion(e.Location))
                m_isHot = true;
            this.DataGridView.InvalidateCell(this);
        }

        protected override void OnMouseLeave(int rowIndex)
        {
            base.OnMouseLeave(rowIndex);
            m_isHot = false;
            this.DataGridView.InvalidateCell(this);
        }

        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseDown(e);
            m_isHot = IsInCheckRegion(e.Location);
            this.DataGridView.InvalidateCell(this);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            Boolean value = false;
            if (IsInCheckRegion(e.Location))
            {
                switch (m_checkedAllState)
                {
                    case CheckState.Unchecked:
                        m_checkedAllState = CheckState.Checked;
                        value = true;
                        break;
                    case CheckState.Indeterminate:
                        m_checkedAllState = CheckState.Checked;
                        value = true;
                        break;
                    case CheckState.Checked:
                        m_checkedAllState = CheckState.Unchecked;
                        value = false;
                        break;
                }
                this.Value = value;
                //执行默认事件
                ((DataGridViewCommonEx)this.DataGridView).OnCheckAllCheckedChange(e.ColumnIndex, value);
                //执行用户绑定事件
                try
                {
                    string chkName = this.DataGridView.Columns[e.ColumnIndex].Name;
                    if (Enum.IsDefined(typeof(CheckBoxName), chkName))
                    {
                        CheckBoxName eC = (CheckBoxName)Enum.Parse(typeof(CheckBoxName), chkName, true);
                        ((DataGridViewCommonEx)this.DataGridView).GetCheckBoxDelegate(eC, CheckBoxEventType.All)?.Invoke(e);
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            base.OnMouseClick(e);
        }

        /// <summary>
        /// 是否在checkbox按钮区域
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        protected bool IsInCheckRegion(Point p)
        {
            return this.m_absChkboxRegion.Contains(p);
        }

        #endregion
    }

    /// <summary>
    /// 扩展行单元格
    /// </summary>
    public class DataGridViewCheckBoxCellEx : DataGridViewCheckBoxCell
    {
        /// <summary>
        /// 本单元格是否被选中
        /// </summary>
        public Boolean Checked
        {
            get
            {
                return Convert.ToBoolean(this.Value);
            }
            set
            {
                this.Value = value;
            }
        }

        /// <summary>
        /// 宿主列扩展
        /// </summary>
        internal DataGridViewCheckBoxColumnEx OwningColumnEx
        {
            get { return this.OwningColumn as DataGridViewCheckBoxColumnEx; }
        }

        /// <summary>
        /// 处理选中与取消选中
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Checked = !this.Checked;
            //对象
            DataGridViewCheckBoxColumnEx col = this.DataGridView.Columns[e.ColumnIndex] as DataGridViewCheckBoxColumnEx;
            DataGridViewCheckBoxColumnHeaderCellEx cell = col.HeaderCell as DataGridViewCheckBoxColumnHeaderCellEx;
            //执行默认事件
            if (!cell.IsChangeHeader)
            {
                ((DataGridViewCommonEx)this.DataGridView).OnCheckBoxCellCheckedChange(e.ColumnIndex, e.RowIndex, this.Checked);
            }
            //执行用户绑定事件
            try
            {
                string chkName = col.Name;
                if (Enum.IsDefined(typeof(CheckBoxName), chkName))
                {
                    CheckBoxName eC = (CheckBoxName)Enum.Parse(typeof(CheckBoxName), chkName, true);
                    ((DataGridViewCommonEx)this.DataGridView).GetCheckBoxDelegate(eC, CheckBoxEventType.Cell)?.Invoke(e);
                }
            }
            catch (Exception ex)
            {
                return;
            }
            base.OnMouseClick(e);
        }
    }
}
