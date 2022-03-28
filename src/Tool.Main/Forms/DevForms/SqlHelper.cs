﻿using System.Text;
using System.Text.RegularExpressions;
using Tool.Business.Common;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.IService.Model.Common;

namespace Tool.Main.Forms.DevForms
{
    public partial class SqlHelper : Form
    {
        #region private prob
        //数据库类型
        private string DataBaseType
        {
            get
            {
                if (rb_DataBase_SqlServer.Checked)
                {
                    return "SqlServer";
                }
                else if (rb_DataBase_Sqlite.Checked)
                {
                    return "Sqlite";
                }
                else
                {
                    //默认SqlServer
                    return "SqlServer";
                }
            }
        }
        #endregion

        #region initial
        public SqlHelper()
        {
            InitializeComponent();
            //注入
            ICommonDataHelper dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            this.dvEX.DataHelper = dataHelper;

            //设置网格属性
            SetDVProb();
        }
        #endregion

        #region PageLoad
        private void SqlHelper_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region SetDVProb
        private void SetDVProb()
        {
            //不分页
            this.dvEX.IsPage = false;
            //不显示checkbox
            this.dvEX.IsShowFirstCheckBox = false;
            //Grid数据可编辑
            this.dvEX.RowEdit = true;
            //移除所有列
            this.dvEX.ClearColumns();
            //添加列1-列中文、列英文
            Dictionary<string, string> colDic = new Dictionary<string, string>();
            colDic.Add("ColEng", "列英文");
            colDic.Add("ColChn", "列中文");
            this.dvEX.AddColumns(colDic);
            //添加列2-获取列类型
            List<string> dataTypes;
            if (DataBaseType == "SqlServer")
            {
                dataTypes = Enum.GetNames(typeof(SqlServerDataType)).ToList<string>();
            }
            else if (DataBaseType == "Sqlite")
            {
                dataTypes = Enum.GetNames(typeof(SqliteDataType)).ToList<string>();
            }
            else
            {
                //默认SqlServer
                dataTypes = Enum.GetNames(typeof(SqlServerDataType)).ToList<string>();
            }
            //移除枚举前面的下划线
            dataTypes = ChangeDataTypeName(dataTypes);
            //添加列2-添加具体列
            DataGridViewComboBoxColumn dataTypeCol = this.dvEX.CreateColumn<DataGridViewComboBoxColumn>("ColDataType", "数据类型", dataTypes, 180);
            this.dvEX.AddColumn(dataTypeCol);
            //添加列2-添加事件
            this.dvEX.Dv.SetComboBoxDelegate("ColDataType", ColDateTypeSelectIndexChange);
            //添加列3-列长度
            this.dvEX.AddColumn(this.dvEX.CreateColumn<DataGridViewComboBoxColumn>("ColLength", "数据长度", new List<string>(), 180, true));
            //添加列4-是否主键、是否费控
            this.dvEX.AddChkCol(CheckBoxName.CheckBox1, -1, true, "是否主键");//IsPrimarikey
            this.dvEX.AddChkCol(CheckBoxName.CheckBox2, -1, true, "是否非空");//IsNotNull
            //禁止排序
            this.dvEX.IsSort = false;
        }
        #endregion

        #region ChangeDataTypeName

        /// <summary>
        /// 格式处理：
        /// 移除首位下划线
        /// </summary>
        /// <param name="origin"></param> 
        /// <returns></returns>
        private List<string> ChangeDataTypeName(List<string> origin)
        {
            List<string> vs = new List<string>();
            origin.ForEach(item =>
            {
                item = item.Substring(1);
                vs.Add(item);
            });
            return vs;
        }

        #endregion

        #region DataTypeCheckChanged
        private void rb_DataBase_SqlServer_CheckedChanged(object sender, EventArgs e)
        {
            SetDVProb();
        }
        #endregion

        #region ComboBoxEvent
        private void ColDateTypeSelectIndexChange(object? sender, EventArgs e)
        {
            try
            {
                //选中数据类型
                string dataType = ((ComboBox)sender).Text;
                if (string.IsNullOrEmpty(dataType)) return;
                dataType = "_" + dataType;
                //长度集合定义
                List<string> lengthList = new List<string>();
                //获取数据长度信息
                lengthList = GetLengthInfo(dataType);

                //获取数据长度单元格
                DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)sender;
                DataGridView dv = cb.EditingControlDataGridView;
                int rowIndex = dv.CurrentCell.RowIndex;
                int colIndex = dv.CurrentCell.ColumnIndex;
                DataGridViewComboBoxCell lengthCell = (DataGridViewComboBoxCell)dv.Rows[rowIndex].Cells[colIndex + 1];
                //绑定
                lengthCell.DataSource = lengthList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
        #endregion

        #region GetLengthInfo
        private List<string> GetLengthInfo(string dataType)
        {
            List<string> lengthList;
            //获取长度定义
            if (DataBaseType == "SqlServer")
            {
                lengthList = DataTypeExtend.GetSqlServerLengthTypeList(dataType);
            }
            else if (DataBaseType == "Sqlite")
            {
                lengthList = DataTypeExtend.GetSqliteLengthTypeList(dataType);
            }
            else
            {
                //默认SqlServer
                lengthList = DataTypeExtend.GetSqlServerLengthTypeList(dataType);
            }

            return lengthList;
        }
        #endregion

        #region 按钮事件

        /// <summary>
        /// 插入行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            this.dvEX.AddEmptyRow();
        }

        /// <summary>
        /// 删除行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            this.dvEX.DeleteRow();
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbTChn.Text = string.Empty;
            this.tbTEng.Text = string.Empty;
            this.dvEX.ClearRow();
        }

        /// <summary>
        /// 生成脚本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuild_Click(object sender, EventArgs e)
        {
            //校验
            string strVali = Validate();
            if (string.IsNullOrEmpty(strVali))
            {
                Build();
            }
            else
            {
                this.rtbScript.Text = strVali;
            }
        }

        #endregion

        #region Validate

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private string Validate()
        {
            //临时结果
            bool result = false;
            //正则表达式
            string regExprNameChn = "^[a-z,A-Z,0-9,_,\u4e00-\u9fa5]+$";
            string regExprNameEng = "^[a-z,A-Z,0-9,_]+$";
            RegexCheck("123", regExprNameChn);
            //校验1:表中文英文校验
            //1.1校验表中文英文-不为空
            if (string.IsNullOrEmpty(this.tbTChn.Text.Trim()) || string.IsNullOrEmpty(this.tbTEng.Text.Trim()))
            {
                return "表中文名称、英文名称不能为空;";
            }
            //1.2校验表中文英文-规范
            result = RegexCheck(this.tbTChn.Text.Trim(), regExprNameChn);
            if (!result) return "表中文只能是【字母、数字、下划线、汉字】";
            result = RegexCheck(this.tbTEng.Text.Trim(), regExprNameEng);
            if (!result) return "表英文只能是【字母、数字、下划线】";
            //校验2:校验字段个数
            if (dvEX.Dv.RowCount < 1)
            {
                return "表包含列数不能为空";
            }
            //校验3:循环行数据
            List<string> colNameList = new List<string>();
            for (int i = 0; i < dvEX.Dv.RowCount; i++)
            {
                //获取数据行
                DataGridViewRow dr = dvEX.Dv.Rows[i];
                //获取列数据
                var colChn = dr.Cells["ColChn"].Value;
                var colEng = dr.Cells["ColEng"].Value;
                var colDataType = dr.Cells["ColDataType"].Value;
                var colLength = dr.Cells["ColLength"].Value;
                //3.1 校验列数据-不为空
                //3.1.1 列中文、列英文、列类型
                if (colChn == null || string.IsNullOrEmpty(colChn.ToString().Trim())
                    || colEng == null || string.IsNullOrEmpty(colEng.ToString().Trim())
                    || colDataType == null || string.IsNullOrEmpty(colDataType.ToString().Trim()))
                {
                    return "第" + (i + 1).ToString() + "行，列英文名称、中文名称、数据类型 不能为空;";
                }
                //3.1.2数据长度
                List<string> lengthInfo = GetLengthInfo("_" + colDataType.ToString().Trim());
                if (lengthInfo.Count > 0 && lengthInfo[0] != ""
                    && (colLength == null || string.IsNullOrEmpty(colLength.ToString().Trim())))
                {
                    return "第" + (i + 1).ToString() + "行，数据长度 不能为空;";
                }
                //3.2校验列数据-规范
                result = RegexCheck(colChn.ToString().Trim(), regExprNameChn);
                if (!result) return "列中文只能是【字母、数字、下划线、汉字】";
                result = RegexCheck(colEng.ToString().Trim(), regExprNameEng);
                if (!result) return "列英文只能是【字母、数字、下划线】";
                //3.3列英文不能重复
                if (colNameList.Contains(colEng.ToString().Trim()))
                {
                    return "第" + (i + 1).ToString() + "行，列英文重复;";
                }
                else
                {
                    colNameList.Add(colEng.ToString().Trim());
                }
            }

            return string.Empty;
        }

        private bool RegexCheck(string content, string expr)
        {
            try
            {
                Regex regex = new Regex(expr);
                bool result = regex.IsMatch(content);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Build
        /// <summary>
        /// 生成脚本
        /// </summary>
        private void Build()
        {
            if (DataBaseType == "SqlServer")
            {
                Build_SqlServer();
            }
            else if (DataBaseType == "Sqlite")
            {
                Build_Sqlite();
            }
            else
            {
                Build_SqlServer();
            }
        }
        #endregion

        #region SqlServerBuild
        private void Build_SqlServer()
        {
            StringBuilder sbSql = new StringBuilder();
            StringBuilder sbExtend = new StringBuilder();
            //Begin.开始事务
            sbSql.AppendLine("BEGIN TRANSACTION");
            sbSql.AppendLine("GO");
            //1.表外层
            string tbEng = tbTEng.Text.Trim();
            string tbChn = tbTChn.Text.Trim();
            sbSql.AppendLine($"CREATE TABLE dbo.{tbEng}");
            sbSql.AppendLine($"        (");
            //2.表扩展说明
            sbExtend.AppendLine($"EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'{tbChn}' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'{tbEng}'");
            sbExtend.AppendLine("GO");
            //3.循环字段
            int rowCount = dvEX.Dv.RowCount;
            List<string> primaryKeyFieldList = new List<string>();
            for (int i = 0; i < rowCount; i++)
            {
                //获取数据行
                DataGridViewRow dr = dvEX.Dv.Rows[i];
                //获取列数据
                var colChn = dr.Cells["ColChn"].Value;
                var colEng = dr.Cells["ColEng"].Value;
                var colDataType = dr.Cells["ColDataType"].Value;
                var colLength = dr.Cells["ColLength"].Value;
                var colIsPrimaryKey = dr.Cells["CheckBox1"].Value;
                var colIsNull = dr.Cells["CheckBox2"].Value;
                //3.1表字段
                string strIsNull = colIsNull != null && (bool)colIsNull ? "NOT NULL" : "";
                string strSplit = i != rowCount - 1 ? "," : "";
                if (colIsPrimaryKey != null && (bool)colIsPrimaryKey)
                {
                    if (string.IsNullOrEmpty(strIsNull))
                    {
                        this.rtbScript.Text = "不能在非空列上设置主键！";
                        return;
                    }
                    primaryKeyFieldList.Add(colEng.ToString());
                }
                sbSql.AppendLine($"        {colEng} {colDataType}{colLength} {strIsNull} {strSplit}");
                //3.2字段扩展说明
                sbExtend.AppendLine($"EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'{colChn}' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'{tbEng}', @level2type=N'COLUMN',@level2name=N'{colEng}'");
                sbExtend.AppendLine("GO");
            }
            sbSql.AppendLine($"        )");
            sbSql.AppendLine("GO");
            //4.添加主键
            if (primaryKeyFieldList.Count > 0)
            {
                sbSql.AppendLine($"ALTER TABLE dbo.{tbEng} ADD CONSTRAINT");
                sbSql.AppendLine($"        PK_{tbEng} PRIMARY KEY CLUSTERED");
                sbSql.AppendLine("         (");
                for (int i = 0; i < primaryKeyFieldList.Count; i++)
                {
                    string tempSplit = i != primaryKeyFieldList.Count - 1 ? "," : "";
                    sbSql.AppendLine($"{primaryKeyFieldList[i]}{tempSplit}");
                }
                sbSql.AppendLine("         ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
                sbSql.AppendLine("GO");
            }
            //End.结束事务
            sbSql.AppendLine("COMMIT");

            this.rtbScript.Text = sbSql.ToString() + "\n\n" + sbExtend.ToString();
        }
        #endregion

        #region SqliteBuild
        private void Build_Sqlite()
        {
            StringBuilder sb = new StringBuilder();

            this.rtbScript.Text = sb.ToString();
        }
        #endregion
    }
}
