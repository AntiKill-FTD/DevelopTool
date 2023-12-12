using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using Tool.CusControls.Common;
using Tool.Data.DataHelper;
using Tool.IService.Model.Common;

namespace Tool.CusControls.DataGridViewEx
{
    public partial class DataGridViewEx : UserControl
    {
        #region 注入数据接口
        private ICommonDataHelper iDataHelper;
        private EnumSqlType _sqlType;
        public EnumSqlType SqlType
        {
            get
            {
                return _sqlType;
            }
        }
        public ICommonDataHelper DataHelper
        {
            set
            {
                iDataHelper = value;
                if (value == null) return;
                //数据类型
                if (iDataHelper.GetType() == typeof(MSSqlDataHelper))
                {
                    _sqlType = EnumSqlType.MSSql;
                }
                else if (iDataHelper.GetType() == typeof(SqliteDataHelper))
                {
                    _sqlType = EnumSqlType.Sqlite;
                }
                else
                {
                    _sqlType = EnumSqlType.MSSql;
                }
            }
            get
            {
                return iDataHelper;
            }
        }
        #endregion

        #region Dv get
        /// <summary>
        /// _dv
        /// </summary>
        private DataGridViewCommonEx _dv;

        public DataGridViewCommonEx Dv
        {
            get { return _dv; }
        }
        #endregion

        #region 属性对象 public 
        /// <summary>
        /// 行选择模式
        /// </summary>
        public DataGridViewSelectionMode DvSelectionMode
        {
            get { return _dv.SelectionMode; }
            set { _dv.SelectionMode = value; }
        }

        /// <summary>
        /// 当前选中行Index（单选）
        /// </summary>
        public int SelectIndex
        {
            get
            {
                //优先返回选中行，否则返回选中单元格
                if (_dv.SelectedRows.Count > 0)
                {
                    return _dv.SelectedRows[0].Index;
                }
                else if (_dv.SelectedCells.Count > 0)
                {
                    return _dv.SelectedCells[0].RowIndex;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// 当前选中行DataGridViewRow（单选）
        /// </summary>
        public DataGridViewRow SelectRow
        {
            get
            {
                if (_dv.SelectedRows.Count > 0)
                {
                    return _dv.SelectedRows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        private bool _rowEdit = false;
        /// <summary>
        /// 设置列是否可编辑
        /// </summary>
        public bool RowEdit
        {
            get
            {
                //取值
                return this._rowEdit;
            }
            set
            {
                //设置只读
                this.dataGridView1.ReadOnly = !value;
                //赋值
                this._rowEdit = value;
            }
        }
        #endregion

        #region 方法对象 public
        /// <summary>
        /// 设置选中行
        /// </summary>
        /// <param name="rowIndex"></param>
        public void SetSelectRow(int rowIndex)
        {
            if (rowIndex >= 0 && _dv.Rows.Count > rowIndex)
            {
                foreach (DataGridViewRow r in _dv.SelectedRows)
                {
                    r.Selected = false;
                }
                _dv.Rows[rowIndex].Selected = true;
            }
            else
            {
                return;
            }
        }

        public DataGridViewRow GetRow(int index)
        {
            return this.dataGridView1.Rows[index];
        }

        public DataGridViewRow[] GetSelectRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow r in _dv.SelectedRows)
            {
                if (r.Selected)
                {
                    rows.Add(r);
                }
            }
            return rows.ToArray();
        }

        public DataGridViewRow[] GetCheckRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            if (this.dataGridView1.Columns[0].GetType() == typeof(DataGridViewCheckBoxColumnEx))
            {
                foreach (DataGridViewRow r in _dv.Rows)
                {
                    if (((DataGridViewCheckBoxCellEx)r.Cells[0]).Checked)
                    {
                        rows.Add(r);
                    }
                }
            }

            return rows.ToArray();
        }

        public DataGridViewRow[] GetAllRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow r in _dv.Rows)
            {
                rows.Add(r);
            }
            return rows.ToArray();
        }

        /// <summary>
        /// 添加列
        /// </summary>
        /// <param name="colName">列字段名称</param>
        /// <param name="headerText">列标题</param>
        public void AddColumn(string colName, string headerText)
        {
            if (!this.dataGridView1.Columns.Contains(colName))
            {
                this.dataGridView1.Columns.Add(colName, headerText);
            }
        }

        /// <summary>
        /// 插入列
        /// </summary>
        /// <param name="colName">列字段名称</param>
        /// <param name="headerText">列标题</param>
        /// <param name="index">列序号</param>
        public void InsertColumn(string colName, string headerText, int index)
        {
            if (index < 0 || index >= this.dataGridView1.ColumnCount) return;
            if (!this.dataGridView1.Columns.Contains(colName))
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name = colName;
                col.HeaderText = headerText;
                this.dataGridView1.Columns.Insert(index, col);
            }
        }

        /// <summary>
        /// 根据标题等数据创建DataGridViewColumn
        /// </summary>
        /// <param name="colName">列字段名称</param>
        /// <param name="HeaderText">列标题</param>
        /// <returns></returns>
        public T CreateColumn<T>(string colName, string HeaderText, List<string> items = null, int width = 150, bool isEdit = false, bool isValidate = false) where T : DataGridViewColumn, new()
        {
            if (typeof(T) == typeof(DataGridViewComboBoxColumn))
            {
                if (items == null) return null;

                DataGridViewComboBoxColumnEx colCombo = new DataGridViewComboBoxColumnEx(isEdit, isValidate);
                colCombo.Name = colName;
                colCombo.HeaderText = HeaderText;
                colCombo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                colCombo.Width = width;
                colCombo.DropDownWidth = width;
                colCombo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colCombo.DefaultCellStyle.BackColor = Color.AliceBlue;

                foreach (string i in items)
                {
                    colCombo.Items.Add(i);
                }

                return (T)(DataGridViewColumn)colCombo;
            }
            else
            {
                T col = new T();
                col.Name = colName;
                col.HeaderText = HeaderText;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                col.Width = width;
                return col;
            }
        }

        /// <summary>
        /// 添加列
        /// </summary>
        /// <param name="col">列</param>
        public void AddColumn(DataGridViewColumn col)
        {
            if (!this.dataGridView1.Columns.Contains(col))
            {
                this.dataGridView1.Columns.Add(col);
            }
        }

        /// <summary>
        /// 插入列
        /// </summary>
        /// <param name="col">列</param>
        /// <param name="index">列序号</param>
        public void InsertColumn(DataGridViewColumn col, int index)
        {
            if (index < 0 || index >= this.dataGridView1.ColumnCount) return;
            if (!this.dataGridView1.Columns.Contains(col))
            {
                this.dataGridView1.Columns.Insert(index, col);
            }
        }

        /// <summary>
        /// 添加多列
        /// </summary>
        /// <param name="collection"></param>
        public void AddColumns(DataGridViewColumnCollection collection)
        {
            foreach (DataGridViewColumn col in collection)
            {
                if (!this.dataGridView1.Columns.Contains(col))
                {
                    this.dataGridView1.Columns.Add(col);
                }
            }
        }

        /// <summary>
        /// 添加多列
        /// </summary>
        /// <param name="dic">列字典[<ColName,HeaderText>]</param>
        public void AddColumns(Dictionary<string, string> dic)
        {
            foreach (string col in dic.Keys)
            {
                if (!this.dataGridView1.Columns.Contains(col))
                {
                    this.dataGridView1.Columns.Add(col, dic[col]);
                }
            }
        }

        /// <summary>
        /// 添加多列
        /// </summary>
        /// <param name="dic">列字典[<ColName,HeaderText>]</param>
        public void AddColumns(Dictionary<string, ColumnFieldWidth> dic)
        {
            foreach (string col in dic.Keys)
            {
                if (!this.dataGridView1.Columns.Contains(col))
                {
                    this.dataGridView1.Columns.Add(col, dic[col].ColumnField);
                }
            }
            int fullSize = this.dataGridView1.Width;
            foreach (string col in dic.Keys)
            {
                if (dic[col].FieldType == FieldType.Absolute)
                {
                    this.dataGridView1.Columns[col].Width = dic[col].ColumnWidth;
                }
                else if (dic[col].FieldType == FieldType.Percent)
                {
                    this.dataGridView1.Columns[col].Width = dic[col].ColumnWidth * fullSize / 100;
                }
            }
        }

        /// <summary>
        /// 删除列
        /// </summary>
        /// <param name="index"></param>
        public void RemoveColumns(int index)
        {
            this.dataGridView1.Columns.RemoveAt(index);
        }

        /// <summary>
        /// 插多列
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="index">列序号</param>
        public void InsertColumns(DataGridViewColumnCollection collection, int index)
        {
            if (index < 0 || index >= this.dataGridView1.ColumnCount) return;
            foreach (DataGridViewColumn col in collection)
            {
                if (!this.dataGridView1.Columns.Contains(col))
                {
                    this.dataGridView1.Columns.Insert(index, col);
                    index++;
                }
            }
        }

        /// <summary>
        /// 插入多列
        /// </summary>
        /// <param name="dic">列字典[<ColName,HeaderText>]<</param>
        /// <param name="index">列序号</param>
        public void InsertColumns(Dictionary<string, string> dic, int index)
        {
            if (index < 0 || index >= this.dataGridView1.ColumnCount) return;
            foreach (string col in dic.Keys)
            {
                if (!this.dataGridView1.Columns.Contains(col))
                {
                    DataGridViewColumn colR = new DataGridViewColumn();
                    colR.Name = col;
                    colR.HeaderText = dic[col];
                    this.dataGridView1.Columns.Insert(index, colR);
                    index++;
                }
            }
        }

        /// <summary>
        /// 清除字段
        /// </summary>
        public void ClearColumns()
        {
            this.dataGridView1.Columns.Clear();
        }

        /// <summary>
        /// 添加空行
        /// </summary>
        public void AddEmptyRow()
        {
            this.dataGridView1.Rows.Add();
        }

        /// <summary>
        /// 添加行
        /// </summary>
        /// <param name="values"></param>
        public void AddRow(params object[] values)
        {
            this.dataGridView1.Rows.Add(values);
        }

        /// <summary>
        /// 插入空行
        /// </summary>
        /// <param name="index"></param>
        public void InsertEmptyRow(int index)
        {
            this.dataGridView1.Rows.Add(index);
        }

        /// <summary>
        /// 删除行
        /// </summary>
        public void DeleteRow()
        {
            if (this.dataGridView1.Rows.Count <= 0) return;
            //默认删除最后一行
            int delIndex = this.dataGridView1.Rows.Count - 1;
            //如果选中行，删除选中行
            if (this.SelectIndex >= 0) delIndex = this.SelectIndex;

            //定义行并删除
            DataGridViewRow row = this.dataGridView1.Rows[delIndex];
            this.dataGridView1.Rows.Remove(row);
        }

        /// <summary>
        /// 删除行
        /// </summary>
        /// <param name="delIndex"></param>
        public void DeleteRow(int delIndex)
        {
            //定义行并删除
            DataGridViewRow row = this.dataGridView1.Rows[delIndex];
            this.dataGridView1.Rows.Remove(row);
        }

        /// <summary>
        /// 删除行
        /// </summary>
        /// <param name="delIndex"></param>
        public void DeleteRow(DataGridViewRow row)
        {
            //定义行并删除
            this.dataGridView1.Rows.Remove(row);
        }

        /// <summary>
        /// 清除网格
        /// </summary>
        public void ClearRow()
        {
            try
            {
                this.dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                while (this.dataGridView1.Rows.Count > 0)
                {
                    this.DeleteRow();
                }
            }
        }

        #endregion

        #region Dv事件对象 public
        /// <summary>
        /// 绑定事件
        /// </summary>
        /// <param name="eventType">事件类型枚举</param>
        /// <param name="eh">事件委托</param>
        /// <param name="removeOthers">是否删除该事件其他绑定委托</param>
        public void DvEventBind(EventType eventType, EventHandler eh, bool removeOthers = true)
        {
            try
            {
                //移除原有绑定方法事件
                if (removeOthers)
                {
                    string strEventName = Convert.ToString(eventType);
                    EventHelper.RemoveHanlder(this._dv, strEventName);
                }

                //GridView选择改变事件
                if (eventType == EventType.SelectionChanged)
                {
                    this.dataGridView1.SelectionChanged += eh;
                }
                //GridView双击事件
                else if (eventType == EventType.DoubleClick)
                {
                    this.dataGridView1.DoubleClick += eh;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 数据源 public
        /// <summary>
        /// 是否排序
        /// </summary>
        private bool _isSort;

        /// <summary>
        /// 设置是否排序，需要在所有列添加完成后设置
        /// </summary>
        public bool IsSort
        {
            get { return _isSort; }
            set
            {
                _isSort = value;
                if (!_isSort)
                {
                    for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
                    {
                        this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
        }

        /// <summary>
        /// 是否分页
        /// </summary>
        private bool _isPage;

        /// <summary>
        /// 是否分页
        /// </summary>
        public bool IsPage
        {
            get { return _isPage; }
            set
            {
                _isPage = value;
                if (_isPage)
                {
                    this.CurrentPageIndex = 1;
                    this.PerPageCount = 100;
                    this.panelPage.Visible = true;
                }
                else
                {
                    this.CurrentPageIndex = 1;
                    this.PerPageCount = int.MaxValue;
                    this.panelPage.Visible = false;
                }
            }
        }

        /// <summary>
        /// 数据绑定方式
        /// </summary>
        private DataGridViewBindType _dvDataGridViewBindType;

        /// <summary>
        /// 数据绑定方式
        /// </summary>
        private DataGridViewBindType DvDataGridViewBindType
        {
            get { return _dvDataGridViewBindType; }
            set { _dvDataGridViewBindType = value; }
        }

        /// <summary>
        /// 数据源SQL
        /// </summary>
        private Dictionary<string, string> _dataSourceSql;

        /// <summary>
        /// 数据源SQL
        /// </summary>
        public Dictionary<string, string> DataSourceSql
        {
            get { return _dataSourceSql; }
            set { _dataSourceSql = value; }
        }

        /// <summary>
        /// 数据源DataTable
        /// </summary>
        private DataTable _dvDataTabel;

        /// <summary>
        /// 数据源DataTable
        /// </summary>
        public DataTable DvDataTable
        {
            get { return _dvDataTabel; }
            set { _dvDataTabel = value; }
        }
        #endregion

        /// <summary>
        /// 数据源实体
        /// </summary>
        private List<dynamic> _dvObject;

        /// <summary>
        /// 数据源实体类型
        /// </summary>
        private Type _dvObjectType;

        /// <summary>
        /// 数据源实体
        /// </summary>
        public void SetDvObject<T>(List<T> obj)
        {
            if (_dvObject == null)
            {
                _dvObject = new();
            }
            else
            {
                _dvObject.Clear();
            }
            obj.ForEach(item =>
            {
                _dvObject.Add(item);
            });
            _dvObjectType = typeof(T);
        }

        /// <summary>
        /// 数据源实体
        /// </summary>
        /// <returns></returns>
        public List<dynamic> GetDvObject()
        {
            return _dvObject;
        }

        #region CheckBox

        #region 是否展示首列单选框
        /// <summary>
        /// 是否展示首列单选框
        /// </summary>
        private bool _isShowFirstCheckBox;

        /// <summary>
        /// 是否显示首列单选框
        /// </summary>
        public bool IsShowFirstCheckBox
        {
            get { return _isShowFirstCheckBox; }
            set
            {
                //设置列
                if (value)
                {
                    AddChkCol_Private(CheckBoxName.FirstCheckColumn, 0, false, "");
                }
                else
                {
                    RemoveChkCol_Private(CheckBoxName.FirstCheckColumn);
                }
                //回写值
                _isShowFirstCheckBox = value;

            }
        }
        #endregion

        #region CheckBox公有方法
        public void AddChkCol(CheckBoxName chkName, int index, bool isChangeHeaderToText = false, string headerText = "")
        {
            //自定义添加列，不能使用FirstCheckColumn，不能加到首列
            if (chkName == CheckBoxName.FirstCheckColumn || index == 0)
            {
                return;
            }
            //调用私有方法
            AddChkCol_Private(chkName, index, isChangeHeaderToText, headerText);
        }
        #endregion

        #region CheckBox私有方法
        private void AddChkCol_Private(CheckBoxName chkName, int index, bool isChangeHeader, string headerText)
        {
            try
            {
                //获取列
                DataGridViewColumnCollection colColection = this._dv.Columns;
                //判断是否已存在该列
                bool isHave = false;
                int haveIndex = -1;
                if (colColection.Count > 0)
                {
                    foreach (DataGridViewColumn col in colColection)
                    {
                        if (col.Name == chkName.ToString() && col.GetType() == typeof(DataGridViewCheckBoxColumnEx))
                        {
                            isHave = true;
                            haveIndex = col.Index;
                            break;
                        }
                    }
                }
                //如果存在，显示列，不存在添加列
                if (isHave)
                {
                    colColection[0].Visible = true;
                    return;
                }
                else
                {
                    //添加
                    DataGridViewCheckBoxColumnEx checkColumn = new DataGridViewCheckBoxColumnEx(isChangeHeader);
                    checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    checkColumn.Width = isChangeHeader ? headerText.Trim().Length * 30 : 35;
                    checkColumn.Name = chkName.ToString();
                    checkColumn.HeaderText = headerText.Trim();
                    checkColumn.Visible = true;
                    if (index < 0) index = this._dv.ColumnCount;
                    this._dv.Columns.Insert(index, checkColumn);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void RemoveChkCol_Private(CheckBoxName chkName)
        {
            try
            {
                //获取列
                DataGridViewColumnCollection colColection = this._dv.Columns;
                //判断是否已存在该列
                bool isHave = false;
                int haveIndex = -1;
                if (colColection.Count > 0)
                {
                    foreach (DataGridViewColumn col in colColection)
                    {
                        if (col.Name == chkName.ToString() && col.GetType() == typeof(DataGridViewCheckBoxColumnEx))
                        {
                            isHave = true;
                            haveIndex = col.Index;
                            break;
                        }
                    }
                }
                //如果存在，显示列，不存在不处理
                if (isHave)
                {
                    colColection[0].Visible = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        #endregion

        #region 翻页控件对象 private
        /// <summary>
        /// _txtCurrentPage
        /// </summary>
        private TextBox _txtCurrentPageIndex;
        private bool _bTCurrentPageIndexChange;

        private long? _currentPageIndex;
        private long? CurrentPageIndex
        {
            get
            {
                if (_currentPageIndex == null)
                {
                    _currentPageIndex = Convert.ToInt64(_txtCurrentPageIndex.Text.ToString().Trim());
                }
                return _currentPageIndex;
            }
            set
            {
                _currentPageIndex = value;
                _txtCurrentPageIndex.Text = value.ToString();
            }
        }

        /// <summary>
        /// _labPageCount
        /// </summary>
        private Label _labPageCount;

        private long PageCount
        {
            get
            {
                return Convert.ToInt32(_labPageCount.Text.ToString().Trim().Replace("/", ""));
            }
            set
            {
                _labPageCount.Text = "/" + value.ToString();
            }
        }

        /// <summary>
        /// _txtPerPageCount
        /// </summary>
        private TextBox _txtPerPageCount;
        private bool _bTPerPageCountChange;

        private int? _perPageCount;
        private int? PerPageCount
        {
            get
            {
                if (_perPageCount == null)
                {
                    _perPageCount = Convert.ToInt32(_txtPerPageCount.Text.ToString().Trim());
                }
                return _perPageCount;
            }
            set
            {
                _perPageCount = value;
                _txtPerPageCount.Text = value.ToString();
            }
        }

        /// <summary>
        /// _labDataCount
        /// </summary>
        private Label _labDataCount;

        private long DataCount
        {
            get
            {
                return Convert.ToInt64(_labDataCount.Text.ToString().Trim());
            }
            set
            {
                _labDataCount.Text = value.ToString();
            }
        }
        #endregion 翻页控件对象

        #region 翻页按钮对象 private
        /// <summary>
        /// _btnFirstPage
        /// </summary>
        private Label _btnFirstPage;

        /// <summary>
        /// _btnPreviewPage
        /// </summary>
        private Label _btnPreviewPage;

        /// <summary>
        /// _btnNextPage
        /// </summary>
        private Label _btnNextPage;

        /// <summary>
        /// _btnLastPage
        /// </summary>
        private Label _btnLastPage;
        #endregion

        #region DataView初始化
        public DataGridViewEx()
        {
            InitializeComponent();
            //对象初始化
            _dv = dataGridView1;
            //翻页控件对象初始化
            _txtCurrentPageIndex = this.txtCurrentPageIndex;
            _bTCurrentPageIndexChange = false;
            _labPageCount = this.labPageCount;
            _txtPerPageCount = this.txtPerPageCount;
            _bTPerPageCountChange = false;
            _labDataCount = this.labDataCount;
            //翻页按钮对象初始化
            _btnFirstPage = this.btnFirstPage;
            _btnPreviewPage = this.btnPreviewPage;
            _btnNextPage = this.btnNextPage;
            _btnLastPage = this.btnLastPage;
            //翻页控件对象数据化
            this.IsPage = true;
            this.CurrentPageIndex = 1;
            this.PageCount = 1;
            this.PerPageCount = 100;
            this.PageCount = 0;
            //是否显示单选框
            this.IsShowFirstCheckBox = false;
        }
        #endregion

        #region ViewDataBind绑定数据 public
        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="dataViewBindType"></param>
        /// <param name="isQuery">默认查询进入，需先修改CurrentPageIndex=1，翻页不允许修改</param>
        public void ViewDataBind(DataGridViewBindType dataGridViewBindType, bool isQuery = true, bool isPage = true)
        {
            if (dataGridViewBindType == DataGridViewBindType.DicSql)
            {
                if (_dataSourceSql != null
                     && _dataSourceSql.Keys.Contains("Query")
                     && !string.IsNullOrEmpty(_dataSourceSql["Query"]))
                {
                    //如果是查询，置为首页
                    if (isQuery)
                    {
                        CurrentPageIndex = 1;
                    }
                    //查询DataTable

                    long iDataCount = 0;
                    DataTable dt = iDataHelper.GetDataTableByPage(_dataSourceSql["Query"], _dataSourceSql["Order"], ref iDataCount, (int)CurrentPageIndex, (int)PerPageCount);
                    //绑定数据
                    if (dt != null)
                    {
                        if (dt.Columns.Contains("RowNum"))
                        {
                            dt.Columns.Remove("RowNum");
                        }
                        _dv.DataSource = dt;
                        DataCount = iDataCount;
                        PageCount = DataCount % (int)PerPageCount == 0 ? DataCount / (int)PerPageCount : DataCount / (int)PerPageCount + 1;
                    }
                    else
                    {
                        _dv.DataSource = null;
                        DataCount = 0;
                        PageCount = 0;
                    }
                    //更新绑定方式记录
                    DvDataGridViewBindType = DataGridViewBindType.DicSql;
                }
            }
            else if (dataGridViewBindType == DataGridViewBindType.DataTable)
            {
                if (_dvDataTabel != null)
                {
                    //如果是查询，置为首页
                    if (isQuery)
                    {
                        CurrentPageIndex = 1;
                    }
                    //根据分页加载需要显示dt
                    int beginRowNum = ((int)CurrentPageIndex - 1) * (int)PerPageCount + 1;
                    int endRowNum = (int)CurrentPageIndex * (int)PerPageCount;
                    if (isPage)
                    {
                        DataTable tempDt = _dvDataTabel.Clone();
                        for (int i = beginRowNum; i <= endRowNum; i++)
                        {
                            tempDt.Rows.Add(_dvDataTabel.Rows[i]);
                        }
                        //绑定数据
                        if (_dvDataTabel.Columns.Contains("RowNum"))
                        {
                            _dvDataTabel.Columns.Remove("RowNum");
                        }
                        _dv.DataSource = tempDt;
                    }
                    else
                    {
                        _dv.DataSource = _dvDataTabel;
                    }
                    DataCount = _dvDataTabel.Rows.Count;
                    PageCount = DataCount % (int)PerPageCount == 0 ? DataCount / (int)PerPageCount : DataCount / (int)PerPageCount + 1;
                    //更新绑定方式记录
                    DvDataGridViewBindType = DataGridViewBindType.DataTable;
                }
                else
                {
                    DataCount = 0;
                    PageCount = 0;
                }
            }
            else if (dataGridViewBindType == DataGridViewBindType.Object)
            {
                if (_dvObject != null)
                {
                    //dvObject 转换为 DataTable
                    PropertyInfo[] pis = _dvObjectType.GetProperties();
                    DataTable dt = new DataTable();
                    foreach (var item in pis)
                    {
                        dt.Columns.Add(item.Name);
                    }
                    //循环实体创建row
                    foreach (var row in GetDvObject())
                    {
                        DataRow dataRow = dt.NewRow();
                        foreach (var field in pis)
                        {
                            dataRow[field.Name] = field.GetValue(row);
                        }
                        dt.Rows.Add(dataRow);
                    }
                    //存放到dvDataTable
                    _dvDataTabel = dt.Copy();
                    //如果是查询，置为首页
                    if (isQuery)
                    {
                        CurrentPageIndex = 1;
                    }
                    //根据分页加载需要显示dt
                    int beginRowNum = ((int)CurrentPageIndex - 1) * (int)PerPageCount + 1;
                    int endRowNum = (int)CurrentPageIndex * (int)PerPageCount;
                    if (isPage)
                    {
                        DataTable tempDt = _dvDataTabel.Clone();
                        for (int i = beginRowNum; i <= endRowNum; i++)
                        {
                            tempDt.Rows.Add(_dvDataTabel.Rows[i]);
                        }
                        //绑定数据
                        if (_dvDataTabel.Columns.Contains("RowNum"))
                        {
                            _dvDataTabel.Columns.Remove("RowNum");
                        }
                        _dv.DataSource = tempDt;
                    }
                    else
                    {
                        _dv.DataSource = _dvDataTabel;
                    }
                    DataCount = _dvDataTabel.Rows.Count;
                    PageCount = DataCount % (int)PerPageCount == 0 ? DataCount / (int)PerPageCount : DataCount / (int)PerPageCount + 1;
                    //更新绑定方式记录
                    DvDataGridViewBindType = DataGridViewBindType.DataTable;
                }
                else
                {
                    DataCount = 0;
                    PageCount = 0;
                }
            }

            //设置按钮显示
            SetPageBtn();
        }
        #endregion

        #region SetPageBtn 设置按钮显示 private
        /// <summary>
        /// SetPageBtn 设置按钮显示
        /// </summary>
        private void SetPageBtn()
        {
            //如果当前是首页，首页、上页 灰选，点击无效
            if (CurrentPageIndex == 1)
            {
                btnFirstPage.Enabled = false;
                btnPreviewPage.Enabled = false;
            }
            else
            {
                btnFirstPage.Enabled = true;
                btnPreviewPage.Enabled = true;
            }
            //如果当前是末页，下页、末页 灰选，点击无效
            if (CurrentPageIndex >= PageCount)
            {
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
        }
        #endregion

        #region 当前页、每页 更新事件 private
        private void txtCurrentPageIndex_TextChanged(object sender, EventArgs e)
        {
            string sPageIndex = ((TextBox)sender).Text.ToString().Trim();
            int iPageIndex;
            if (int.TryParse(sPageIndex, out iPageIndex))
            {
                if (iPageIndex < 1 || iPageIndex > PageCount)
                {
                    //只能是第1页到最后一页
                    ((TextBox)sender).Text = CurrentPageIndex.ToString();
                    return;
                }
            }
            else
            {
                //非数字不允许
                ((TextBox)sender).Text = CurrentPageIndex.ToString();
                return;
            }
            //change成功，更新属性
            _currentPageIndex = Convert.ToInt32(((TextBox)sender).Text.ToString().Trim());
            _bTCurrentPageIndexChange = true;
        }
        private void txtCurrentPageIndex_Leave(object sender, EventArgs e)
        {
            //当前页失去焦点，如果发生过变化，重新加载界面
            if (_bTCurrentPageIndexChange)
            {
                CurrentPageIndex = Convert.ToInt32(((TextBox)sender).Text.ToString().Trim());
                ViewDataBind(DvDataGridViewBindType, false);
                _bTCurrentPageIndexChange = false;
            }
        }

        private void txtPerPageCount_TextChanged(object sender, EventArgs e)
        {
            string sPerPageCount = ((TextBox)sender).Text.ToString().Trim();
            int iPerPageCount = 0;
            if (Int32.TryParse(sPerPageCount, out iPerPageCount))
            {
                if (iPerPageCount < 1 || iPerPageCount > 1000)
                {
                    //每页只能1-1000
                    ((TextBox)sender).Text = PerPageCount.ToString();
                    return;
                }
            }
            else
            {
                //非数字不允许
                ((TextBox)sender).Text = PerPageCount.ToString();
                return;
            }
            //change成功，更新属性
            _perPageCount = Convert.ToInt32(((TextBox)sender).Text.ToString().Trim());
            _bTPerPageCountChange = true;
        }
        private void txtPerPageCount_Leave(object sender, EventArgs e)
        {
            //每页数失去焦点，如果发生过变化，重新加载界面
            if (_bTPerPageCountChange)
            {
                PerPageCount = Convert.ToInt32(((TextBox)sender).Text.ToString().Trim());
                ViewDataBind(DvDataGridViewBindType, false);
                _bTPerPageCountChange = false;
            }
        }
        #endregion

        #region SetPageBtn 按钮事件 private
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = 1;
            ViewDataBind(DvDataGridViewBindType, false, IsPage);
        }

        private void btnPreviewPage_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = CurrentPageIndex - 1;
            ViewDataBind(DvDataGridViewBindType, false, IsPage);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = CurrentPageIndex + 1;
            ViewDataBind(DvDataGridViewBindType, false, IsPage);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = PageCount;
            ViewDataBind(DvDataGridViewBindType, false, IsPage);
        }
        #endregion

        #region 子类
        protected class ComboxObject
        {
            public string Text;

            public string Value;
        }
        #endregion

    }

    #region 枚举

    public enum CheckBoxName
    {
        FirstCheckColumn = 0,
        CheckBox1 = 1,
        CheckBox2 = 2,
        CheckBox3 = 3,
        CheckBox4 = 4,
        CheckBox5 = 5,
        CheckBox6 = 6,
        CheckBox7 = 7,
        CheckBox8 = 8
    }

    /// <summary>
    /// 事件枚举
    /// </summary>
    public enum EventType
    {
        SelectionChanged = 1,
        DoubleClick = 2
    }

    /// <summary>
    /// 绑定数据源方式类型
    /// </summary>
    public enum DataGridViewBindType
    {
        DicSql = 1,
        DataTable = 2,
        Object = 3,
    }

    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum EnumSqlType
    {
        MSSql = 1,
        Sqlite = 2,
    }

    #endregion
}
