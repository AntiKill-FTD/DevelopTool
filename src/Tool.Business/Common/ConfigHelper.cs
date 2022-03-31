using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Data.DataHelper;

namespace Tool.Business.Common
{
    public class ConfigHelper
    {
        #region 私有变量

        private ICommonDataHelper _dataHelper;

        #endregion

        #region Ctor
        public ConfigHelper(ICommonDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }
        #endregion

        public string GetValue(string configParam)
        {
            string[] configCodeGroup = configParam.Split(".");
            string strSql = string.Empty;
            if (_dataHelper.GetType() == typeof(MSSqlDataHelper))
            {
                strSql = "SELECT TOP 1 ConfigValue FROM P_Config WHERE 1=1";
            }
            else if (_dataHelper.GetType() == typeof(SqliteDataHelper))
            {
                strSql = "SELECT ConfigValue FROM P_Config WHERE 1=1 LIMIT 1";
            }
            else
            {
                strSql = "SELECT TOP 1 ConfigValue FROM P_Config WHERE 1=1";
            }
            //循环拼接查询条件
            string strWhere = string.Empty;
            for (int i = 0; i < configCodeGroup.Length; i++)
            {
                strWhere += $" AND ConfigTypeCode{(i + 1).ToString()} = '{configCodeGroup[i]}' ";
            }
            if (strWhere.StartsWith(" AND")) strWhere = strWhere.Substring(4);
            strSql = strSql.Replace("1=1", strWhere);
            //执行
            bool result = false;
            string configValue = _dataHelper.ExcuteScalar<string>(strSql, ref result);
            //返回
            return configValue;
        }
    }
}
