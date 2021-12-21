namespace Tool.CusControls.DataGridViewEx
{
    public class DataGridViewComboBoxColumnEx : DataGridViewComboBoxColumn
    {
        /// <summary>
        /// 重绘的时候行对象未加载，都为-1，判断序号奇偶的时候不准确
        /// 以此重新记录
        /// </summary>
        public int RowCountCurrent = -1;

        /// <summary>
        /// 构造函数，包括：表头单元格、行单元格
        /// </summary>
        /// <param name="isChangeHeader">是否修改标题为CheckBox</param>
        public DataGridViewComboBoxColumnEx()
            : base()
        {
            //建立表头单元格
            this.HeaderCell = new DataGridViewComboBoxColumnHeaderCellEx();

            //建立行单元格模板
            this.CellTemplate = new DataGridViewComboBoxCellEx();

            //设置下拉控件以平面展示
            this.FlatStyle = FlatStyle.Popup;
        }
    }

    /// <summary>
    /// 扩展表头单元格
    /// </summary>
    public class DataGridViewComboBoxColumnHeaderCellEx : DataGridViewColumnHeaderCell
    {

    }

    /// <summary>
    /// 扩展行单元格
    /// </summary>
    public class DataGridViewComboBoxCellEx : DataGridViewComboBoxCell
    {
        #region "type:paint"

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            //获取父级列
            DataGridViewComboBoxColumnEx parentColumn = this.OwningColumn as DataGridViewComboBoxColumnEx;

            //根据当前参数更新父级
            /**
             * 新增行：第一行绘制的时候不会丢失为0，第二行开始绘制才会丢失为-1
             * 界面调整后重绘：正常
             **/
            if (this.RowIndex == 0)
            {
                parentColumn.RowCountCurrent = 0;
            }
            else if (this.RowIndex == -1)
            {
                parentColumn.RowCountCurrent++;
            }
            else
            {
                parentColumn.RowCountCurrent = this.RowIndex;
            }

            //设置下拉控件选中色
            if (parentColumn.RowCountCurrent % 2 == 0)
            {
                cellStyle.BackColor = this.DataGridView.DefaultCellStyle.BackColor;
                cellStyle.SelectionBackColor = this.DataGridView.DefaultCellStyle.SelectionBackColor;
            }
            else
            {
                cellStyle.BackColor = this.DataGridView.AlternatingRowsDefaultCellStyle.BackColor;
                cellStyle.SelectionBackColor = this.DataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor;
            }
            //重绘ComboBox前景色
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        #endregion
    }
}
