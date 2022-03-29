using System.ComponentModel;
using static Tool.CusControls.DataGridViewEx.DataGridViewCommonEx;

namespace Tool.CusControls.DataGridViewEx
{
    public class DataGridViewComboBoxColumnEx : DataGridViewComboBoxColumn
    {
        /// <summary>
        /// 重绘的时候行对象未加载，都为-1，判断序号奇偶的时候不准确
        /// 以此重新记录
        /// </summary>
        public int RowCountCurrent = -1;
        public bool IsEdit = false;
        public bool IsValidate = false;

        /// <summary>
        /// 构造函数，包括：表头单元格、行单元格
        /// </summary>
        /// <param name="isChangeHeader">是否修改标题为CheckBox</param>
        public DataGridViewComboBoxColumnEx(bool isEdit = false, bool isValidate = false)
            : base()
        {
            this.IsEdit = isEdit;
            this.IsValidate = isValidate;

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
        #region "InitializeEditingControl"

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue,
           DataGridViewCellStyle dataGridViewCellStyle)
        {
            //执行父级初始化操作
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            //获取下拉框对象
            ComboBox comboBox = (ComboBox)base.DataGridView.EditingControl;
            //当下拉框可编辑的时候，设置样式以及自动保存输入值
            if (((DataGridViewComboBoxColumnEx)base.OwningColumn).IsEdit)
            {
                if (comboBox != null)
                {
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    if (((DataGridViewComboBoxColumnEx)base.OwningColumn).IsValidate)
                    {
                        comboBox.Validating += new CancelEventHandler(comboBox_Validating);
                    }
                }
            }

            //添加事件
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            DataGridViewComboBoxEditingControl cbo = (DataGridViewComboBoxEditingControl)sender;
            if (cbo.Text.Trim() == string.Empty)
                return;

            DataGridView grid = cbo.EditingControlDataGridView;
            object value = cbo.Text;

            if (cbo.Items.IndexOf(value) == -1)
            {
                DataGridViewComboBoxColumn cboCol = (DataGridViewComboBoxColumn)grid.Columns[grid.CurrentCell.ColumnIndex];
                // 添加到当前下拉框中以及模版中，避免出现重复项
                cbo.Items.Add(value);
                cboCol.Items.Add(value);
                grid.CurrentCell.Value = value;
            }
        }

        #endregion

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

        #region "type:events"

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //对象
            DataGridViewComboBoxEditingControl cbo = (DataGridViewComboBoxEditingControl)sender;
            DataGridView grid = cbo.EditingControlDataGridView;
            DataGridViewComboBoxColumn cboCol = (DataGridViewComboBoxColumn)grid.Columns[grid.CurrentCell.ColumnIndex];
            string colName = cboCol.Name;

            //执行默认事件---None

            //执行用户绑定事件 
            try
            {
                ComboBoxEventDelegate delegateInfo = ((DataGridViewCommonEx)this.DataGridView).GetComboBoxDelegate(colName);
                if (delegateInfo != null)
                {
                    delegateInfo.Invoke(sender, e);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        #endregion
    }
}
