﻿namespace Tool.CusControls.DataGridViewEx
{
    public class DataGridViewCommonEx : DataGridView
    {
        /// <summary>
        /// CheckBox事件委托
        /// </summary>
        /// <param name="e"></param>
        public delegate void CheckBoxEventDelegate(DataGridViewCellMouseEventArgs e);

        /// <summary>
        /// 用户自定义事件集合-CheckBox委托
        /// </summary>
        private Dictionary<CheckBoxName, Dictionary<CheckBoxEventType, CheckBoxEventDelegate>> _handlerList = new Dictionary<CheckBoxName, Dictionary<CheckBoxEventType, CheckBoxEventDelegate>>();

        /// <summary>
        /// Ctor
        /// </summary>
        public DataGridViewCommonEx()
            : base()
        {

        }

        /// <summary>
        /// 设置用户自定义事件
        /// </summary>
        /// <param name="handlerList"></param>
        public void SetDelegate(CheckBoxName chkName, Dictionary<CheckBoxEventType, CheckBoxEventDelegate> dic)
        {
            if (_handlerList.Keys.Contains(chkName))
            {
                Dictionary<CheckBoxEventType, CheckBoxEventDelegate> oldDic = _handlerList[chkName];
                foreach (CheckBoxEventType ct in dic.Keys)
                {
                    if (oldDic.Keys.Contains(ct))
                    {
                        oldDic[ct] = dic[ct];
                    }
                    else
                    {
                        oldDic.Add(ct, dic[ct]);
                    }
                }
                _handlerList[chkName] = oldDic;
            }
            else
            {
                _handlerList.Add(chkName, dic);
            }
        }

        /// <summary>
        /// 获取用户自定义事件
        /// </summary>
        /// <param name="handlerList"></param>
        public Dictionary<CheckBoxEventType, CheckBoxEventDelegate> GetDelegate(CheckBoxName chkName)
        {
            if (_handlerList.Keys.Contains(chkName))
            {
                return _handlerList[chkName];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取用户自定义事件
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public CheckBoxEventDelegate GetDelegate(CheckBoxName chkName, CheckBoxEventType eventType)
        {
            if (_handlerList.Keys.Contains(chkName))
            {
                Dictionary<CheckBoxEventType, CheckBoxEventDelegate> dic = _handlerList[chkName];
                if (dic != null)
                {
                    if (dic.Keys.Contains(eventType))
                    {
                        return dic[eventType];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 全选中/取消全选中
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <param name="isCheckedAll"></param>
        internal void OnCheckAllCheckedChange(int columnIndex, bool isCheckedAll)
        {
            DataGridViewCheckBoxCellEx cellEx;
            foreach (DataGridViewRow row in this.Rows)
            {
                cellEx = row.Cells[columnIndex] as DataGridViewCheckBoxCellEx;
                if (cellEx == null) continue;
                cellEx.Checked = isCheckedAll;
            }
        }

        /// <summary>
        /// checkbox的单元格改变事件
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <param name="rowIndex"></param>
        internal void OnCheckBoxCellCheckedChange(int columnIndex, int rowIndex, bool value)
        {
            bool existsChecked = false, existsNoChecked = false;
            DataGridViewCheckBoxCellEx cellEx;
            foreach (DataGridViewRow row in this.Rows)
            {
                cellEx = row.Cells[columnIndex] as DataGridViewCheckBoxCellEx;
                if (cellEx == null) return;
                existsChecked |= cellEx.Checked;
                existsNoChecked |= !cellEx.Checked;
            }

            DataGridViewCheckBoxColumnHeaderCellEx headerCellEx =
                this.Columns[columnIndex].HeaderCell as DataGridViewCheckBoxColumnHeaderCellEx;

            if (headerCellEx == null) return;

            CheckState oldState = headerCellEx.CheckedAllState;

            if (existsChecked)
                headerCellEx.CheckedAllState = existsNoChecked ? CheckState.Indeterminate : CheckState.Checked;
            else
                headerCellEx.CheckedAllState = CheckState.Unchecked;

            if (oldState != headerCellEx.CheckedAllState)
                this.InvalidateColumn(columnIndex);
        }
    }

    /// <summary>
    /// CheckBox事件绑定类型，All标题头，Cell单元格
    /// </summary>
    public enum CheckBoxEventType
    {
        Cell = 1,
        All = 2
    }
}