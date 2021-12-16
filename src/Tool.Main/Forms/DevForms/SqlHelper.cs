using System.Text.RegularExpressions;
using Tool.CusControls.DataGridViewEx;
using Tool.IService.Model.Common;

namespace Tool.Main.Forms.DevForms
{
    public partial class SqlHelper : Form
    {
        #region initial
        public SqlHelper()
        {
            //InitializeComponent();
        }
        #endregion

        #region PageLoad
        private void SqlHelper_Load(object sender, EventArgs e)
        {
            //#region 设置网格属性
            ////不分页
            //this.dvEX.IsPage = false;
            ////不显示checkbox
            //this.dvEX.IsShowFirstCheckBox = false;
            ////Grid数据可编辑
            //this.dvEX.RowEdit = true;
            ////添加列1
            //Dictionary<string, string> colDic = new Dictionary<string, string>();
            //colDic.Add("ColEng", "列英文");
            //colDic.Add("ColChn", "列中文");
            //this.dvEX.AddColumns(colDic);
            ////添加列2            
            //List<string> dataTypes = Enum.GetNames(typeof(SqlServerDataType)).ToList<string>();
            //this.dvEX.AddColumn(this.dvEX.CreateColumn<DataGridViewComboBoxColumn>("ColDataType", "数据类型", dataTypes, 180));
            ////添加列3
            //this.dvEX.AddChkCol(CheckBoxName.CheckBox1, -1, false, "是否主键");//IsPrimarikey
            //this.dvEX.AddChkCol(CheckBoxName.CheckBox2, -1, false, "是否非空");//IsNotNull
            //#endregion
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
