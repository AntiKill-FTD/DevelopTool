using System.Text.RegularExpressions;
using Tool.Business.Common;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.IService.Model.Common;

namespace Tool.Main.Forms.DevForms
{
    public partial class SqlHelper : Form
    {
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

        #region initial
        public SqlHelper()
        {
            InitializeComponent();
            //注入
            ICommonDataHelper dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;
            this.dvEX.DataHelper = dataHelper;

            #region 设置网格属性
            //不分页
            this.dvEX.IsPage = false;
            //不显示checkbox
            this.dvEX.IsShowFirstCheckBox = false;
            //Grid数据可编辑
            this.dvEX.RowEdit = true;
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
            #endregion
        }
        #endregion

        #region PageLoad
        private void SqlHelper_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Common

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
            if (string.IsNullOrEmpty(Validate()))
            {
                Build();
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
            //校验1:表中文只能是【字母、数字、下划线、汉字】
            string regExprTableNameChn = "";
            result = RegexCheck(this.tbTChn.Text.Trim(), regExprTableNameChn);
            if (!result) return "表中文只能是【字母、数字、下划线、汉字】";
            //校验2:表英文只能是【字母、数字、下划线】
            string regExprTableNameEng = "";
            result = RegexCheck(this.tbTEng.Text.Trim(), regExprTableNameEng);
            if (!result) return "表英文只能是【字母、数字、下划线】";
            //校验3:循环行数据
            for (int i = 0; i < dvEX.Dv.RowCount; i++)
            {
                DataGridViewRow dr = dvEX.Dv.Rows[i];
                //校验列数据
                var colEng = dr.Cells["ColEng"].Value;
                if (colEng == null || string.IsNullOrEmpty(colEng.ToString().Trim()))
                {
                    return "第" + i.ToString() + "行，列英文名称不能为空;";
                }
                string regExprColEng = "";
                result = RegexCheck(colEng.ToString().Trim(), regExprColEng);
                if (!result) return "列英文只能是【字母、数字、下划线】";

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

        }

        #endregion

    }
}
