using System.Data;
using Tool.Business.Common;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.IService.Model.Common;
using static Tool.CusControls.DataGridViewEx.DataGridViewCommonEx;

namespace Tool.Main.Forms.DevForms
{
    public partial class EntityHelper : Form
    {
        #region initial
        public EntityHelper()
        {
            InitializeComponent();
            //注入
            ICommonDataHelper dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            this.dataViewDataTable.DataHelper = dataHelper;
            this.dataViewColumn.DataHelper = dataHelper;

            #region 设置网格属性
            //设置网格行选中
            this.dataViewDataTable.DvSelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataViewColumn.DvSelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置不显示分页
            this.dataViewDataTable.IsPage = false;
            this.dataViewColumn.IsPage = false;
            //设置显示首列checkBox
            this.dataViewColumn.IsShowFirstCheckBox = true;
            //添加行事件
            EventHandler eventHandler = new EventHandler(DGV_Dt_SelectionChanged);
            this.dataViewDataTable.DvEventBind(EventType.SelectionChanged, eventHandler);
            //添加  FirstCheckColumn---checkbox All/Cell  扩展事件
            Dictionary<CheckBoxEventType, CheckBoxEventDelegate> dicFirstCheck = new Dictionary<CheckBoxEventType, CheckBoxEventDelegate>();
            dicFirstCheck.Add(CheckBoxEventType.All, new CheckBoxEventDelegate(DGV_Co_FirstCheck));
            dicFirstCheck.Add(CheckBoxEventType.Cell, new CheckBoxEventDelegate(DGV_Co_FirstCheck));
            this.dataViewColumn.Dv.SetDelegate(CheckBoxName.FirstCheckColumn, dicFirstCheck);
            #endregion
        }
        #endregion

        #region PageLoad
        private void EntityHelper_Load(object sender, EventArgs e)
        {
            Search_Click(null, null);
            //自定义添加3个checkBox
            int colCount = this.dataViewColumn.Dv.Columns.Count;
            this.dataViewColumn.AddChkCol(CheckBoxName.CheckBox1, colCount, false, "查询");
            this.dataViewColumn.AddChkCol(CheckBoxName.CheckBox2, colCount + 1, false, "编辑");
            this.dataViewColumn.AddChkCol(CheckBoxName.CheckBox3, colCount + 2, false, "查看");
            //添加  自定义CheckColumn---checkbox All/Cell  扩展事件
            Dictionary<CheckBoxEventType, CheckBoxEventDelegate> dicCheck = new Dictionary<CheckBoxEventType, CheckBoxEventDelegate>();
            dicCheck.Add(CheckBoxEventType.All, new CheckBoxEventDelegate(DGV_Co_FirstCheck));
            dicCheck.Add(CheckBoxEventType.Cell, new CheckBoxEventDelegate(DGV_Co_FirstCheck));
            this.dataViewColumn.Dv.SetDelegate(CheckBoxName.CheckBox1, dicCheck);
            this.dataViewColumn.Dv.SetDelegate(CheckBoxName.CheckBox2, dicCheck);
            this.dataViewColumn.Dv.SetDelegate(CheckBoxName.CheckBox3, dicCheck);
        }
        #endregion

        #region DVCommonEventArgs
        private void DGV_Dt_SelectionChanged(object sender, EventArgs e)
        {
            //初始加载不需要频繁调用，界面操作时才调用
            if (((Control)sender).Focused)
            {
                BindDataViewColumn();
            }
        }
        #endregion

        #region DVCheckBoxEventArgs
        /// <summary>
        /// 全选事件委托
        /// </summary>
        /// <param name="e"></param>
        private void DGV_Co_FirstCheck(DataGridViewCellMouseEventArgs e)
        {
            BuildCode();
        }

        /// <summary>
        /// 生成业务代码逻辑
        /// </summary>
        private void BuildCode()
        {
            //拼接字符串
            string fullCode = string.Empty;
            //拼接表
            string tableName = this.dataViewDataTable.SelectRow.Cells["表名称"].Value.ToString();
            string tableChn = this.dataViewDataTable.SelectRow.Cells["表中文"].Value.ToString();
            fullCode += "/// <summary>\r\n";
            fullCode += "/// " + tableChn + "\r\n";
            fullCode += "/// </summary>\r\n";
            fullCode += "public class " + tableName + "\r\n";
            fullCode += "{" + "\r\n";
            //循环行
            foreach (DataGridViewRow r in this.dataViewColumn.Dv.Rows)
            {
                DataGridViewCheckBoxCellEx cb = (DataGridViewCheckBoxCellEx)r.Cells[CheckBoxName.FirstCheckColumn.ToString()];
                if (cb.Checked)
                {
                    //获取属性
                    string colName = r.Cells["列名称"].Value.ToString();
                    string colNameChn = r.Cells["列中文"].Value.ToString();
                    string colType = r.Cells["类型"].Value.ToString();
                    SqlServerDataType colTypeEnum = (SqlServerDataType)Enum.Parse(typeof(SqlServerDataType), colType, true);
                    string realColType = DataTypeExtend.ChangeDataType(colTypeEnum);
                    bool colQuery = r.Cells["CheckBox1"].Value == null ? false : (bool)r.Cells["CheckBox1"].Value;
                    bool colModify = r.Cells["CheckBox2"].Value == null ? false : (bool)r.Cells["CheckBox2"].Value;
                    bool colView = r.Cells["CheckBox3"].Value == null ? false : (bool)r.Cells["CheckBox3"].Value;

                    int colLength = Convert.ToInt32(r.Cells["长度"].Value.ToString());
                    //拼接列1-private
                    fullCode += "    /// <summary>\r\n";
                    fullCode += "    /// " + colNameChn + "\r\n";
                    fullCode += "    /// </summary>\r\n";
                    fullCode += "    private " + realColType + " _" + colName + ";\r\n";
                    fullCode += "\r\n";

                    //拼接列2-Attribute
                    fullCode += GetAttributeCode(colQuery, colModify, colView);

                    //拼接列3-public
                    fullCode += "    public " + realColType + " " + colName.ToUpper() + "\r\n";
                    fullCode += "    {" + "\r\n"
                             + "         get{ return _" + colName + ";}\r\n"
                             + "     }\r\n";
                    fullCode += "\r\n";
                }
            }
            //结束表
            fullCode += "}\r\n";
            //赋值
            this.rtbEntity.Text = fullCode;
        }

        /// <summary>
        /// 根据勾选获取属性代码
        /// </summary>
        /// <param name="colQuery"></param>
        /// <param name="colModify"></param>
        /// <param name="colView"></param>
        /// <returns></returns>
        private string GetAttributeCode(bool colQuery, bool colModify, bool colView)
        {
            string query = string.Empty;
            string modify = string.Empty;
            string view = string.Empty;
            if (colQuery) query = "Query";
            if (colModify) modify = "Modify";
            if (colView) view = "View";

            string full = string.Empty;
            string part = query + modify + view;
            if (!string.IsNullOrEmpty(part))
            {
                full = "    [QueryModifyAttribute(QueryEditTypeMain." + part + ")]" + "\r\n"; ;
            }

            return full;
        }
        #endregion

        #region 绑定数据方法
        private void BindDataViewTable()
        {
            //获取主sql
            Dictionary<string, string> sqlDicTable = SqlConfig.GetSql("SQLConfig/EntityHelper/TableEng/", this.dataViewDataTable.SqlType.ToString());
            //获取查询参数
            string tableEngName = txtTableEngName.Text.ToString().Trim();
            //拼接参数
            string sqlWhereTable = string.Empty;
            if (!string.IsNullOrEmpty(tableEngName))
            {
                sqlWhereTable += "AND [表名称] LIKE '%" + tableEngName + "%' ";
            }
            //拼接SQL
            if (!string.IsNullOrEmpty(sqlWhereTable))
            {
                sqlWhereTable = sqlWhereTable.Substring(0, 3) == "AND" ? sqlWhereTable.Substring(3) : sqlWhereTable;
                //组装SQL
                sqlDicTable["Query"] = sqlDicTable["Query"].Replace("1=1", sqlWhereTable);
            }

            //dv绑定数据
            DataTable dt = this.dataViewDataTable.DataHelper.GetDataTable(sqlDicTable["Query"], sqlDicTable["Order"]);
            this.dataViewDataTable.DvDataTable = dt;
            this.dataViewDataTable.ViewDataBind(DataGridViewBindType.DataTable, true, false);
            this.dataViewDataTable.SetSelectRow(0);
        }
        private void BindDataViewColumn()
        {
            //获取主sql
            Dictionary<string, string> sqlDicColumn = SqlConfig.GetSql("SQLConfig/EntityHelper/ColumnnEng/", this.dataViewColumn.SqlType.ToString());
            //获取查询参数
            string columnEngName = txtColumnEngName.Text.ToString().Trim();
            //拼接参数
            string sqlWhereColumn = string.Empty;
            //table名称
            DataGridViewRow dgr = dataViewDataTable.SelectRow;
            if (dataViewDataTable.SelectRow != null && dataViewDataTable.SelectIndex >= 0)
            {
                string tabEngName = dgr.Cells["表名称"].Value.ToString();
                //MSSql查询
                if (this.dataViewColumn.SqlType == EnumSqlType.MSSql)
                {
                    //选择表名称
                    if (!string.IsNullOrEmpty(tabEngName))
                    {
                        sqlWhereColumn += "AND [表名称] LIKE '%" + tabEngName + "%' ";
                    }
                    else
                    {
                        sqlWhereColumn += "AND 1!=1 ";
                    }
                    //列名称查询条件
                    if (!string.IsNullOrEmpty(columnEngName))
                    {
                        sqlWhereColumn += "AND [列名称] LIKE '%" + columnEngName + "%' ";
                    }
                    //拼接SQL
                    if (!string.IsNullOrEmpty(sqlWhereColumn))
                    {
                        sqlWhereColumn = sqlWhereColumn.Substring(0, 3) == "AND" ? sqlWhereColumn.Substring(3) : sqlWhereColumn;
                        //组装SQL
                        sqlDicColumn["Query"] = sqlDicColumn["Query"].Replace("1=1", sqlWhereColumn);
                    }
                }
                else if (this.dataViewColumn.SqlType == EnumSqlType.Sqlite)
                {
                    //Sqlite查询
                    sqlWhereColumn += tabEngName;
                    sqlDicColumn["Query"] = sqlDicColumn["Query"].Replace("1=1", sqlWhereColumn);
                }

                //dv绑定数据
                DataTable dt = this.dataViewDataTable.DataHelper.GetDataTable(sqlDicColumn["Query"], sqlDicColumn["Order"]);

                //如果为sqlite，需要处理列
                /**
                 * 表名称
                 * 列名称
                 * 列中文
                 * 长度
                 * 类型
                 */
                if (this.dataViewColumn.SqlType == EnumSqlType.MSSql)
                {
                    dt.Columns.Remove("表名称");
                    this.dataViewColumn.DvDataTable = dt;
                }
                else if (this.dataViewColumn.SqlType == EnumSqlType.Sqlite)
                {
                    DataTable newDt = new DataTable();
                    newDt.Columns.Add("列名称");
                    newDt.Columns.Add("列中文");
                    newDt.Columns.Add("长度");
                    newDt.Columns.Add("类型");
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataRow nr = newDt.NewRow();
                        nr["列名称"] = dr["name"];
                        nr["列中文"] = "Sqlite无中文备注";
                        string strType = dr["type"].ToString();
                        string length = "0";
                        int startIndex = strType.IndexOf("(");
                        int endIndex = strType.IndexOf(")");
                        if (startIndex > 0 && endIndex > 0 && startIndex < endIndex)
                        {
                            length = strType.Substring(startIndex + 1, endIndex - startIndex - 1);
                            strType = strType.Substring(0, startIndex);
                        }
                        nr["类型"] = strType;
                        nr["长度"] = length;                        
                        newDt.Rows.Add(nr);
                    }
                    this.dataViewColumn.DvDataTable = newDt;
                }
                this.dataViewColumn.ViewDataBind(DataGridViewBindType.DataTable, true, false);
            }
            else
            {
                this.dataViewColumn.ClearRow();
            }
        }
        #endregion

        #region 按钮事件
        private void Search_Click(object sender, EventArgs e)
        {
            BindDataViewTable();
            BindDataViewColumn();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.txtTableEngName.Text = string.Empty;
            this.txtColumnEngName.Text = string.Empty;
        }
        #endregion
    }
}
