using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.IService.Model.Common;

namespace Tool.Business.Common
{
    public static class DataTypeExtend
    {
        #region 私有属性
        //SqlServer长度类型字典-私有
        private static Dictionary<SqlServerDataType, List<string>> _allSqlServerLengTypeDic;

        //Sqlite   长度类型字段-私有
        private static Dictionary<SqliteDataType, List<string>> _allSqliteLengthTypeDic;
        #endregion

        #region 私有属性-包装
        //SqlServer长度类型字典-公有
        private static Dictionary<SqlServerDataType, List<string>> AllSqlServerLengTypeDic
        {
            get
            {
                if (_allSqlServerLengTypeDic == null)
                {
                    _allSqlServerLengTypeDic = CreateSqlServerDataTypeLengthInfo();
                }
                return _allSqlServerLengTypeDic;
            }
        }

        //Sqlite长度类型字典-公有
        private static Dictionary<SqliteDataType, List<string>> AllSqliteLengTypeDic
        {
            get
            {
                if (_allSqliteLengthTypeDic == null)
                {
                    _allSqliteLengthTypeDic = CreateSqliteDataTypeLengthInfo();
                }
                return _allSqliteLengthTypeDic;
            }
        }
        #endregion

        #region 私有方法-定义数据类型对应长度信息
        /// <summary>
        /// 返回数据类型长度模板-SqlServer
        /// </summary>
        /// <returns></returns>
        private static Dictionary<SqlServerDataType, List<string>> CreateSqlServerDataTypeLengthInfo()
        {
            Dictionary<SqlServerDataType, List<string>> dic = new Dictionary<SqlServerDataType, List<string>>();
            List<string> stringLengthType = new List<string> { "(10)", "(20)", "(50)", "(100)", "(200)", "(500)", "(1000)", "(MAX)" };
            List<string> decimalLengthType = new List<string> { "(18,0)", "(18,2)", "(18,6)" };
            List<string> timeLengthType = new List<string> { "(7)" };
            //string
            dic.Add(SqlServerDataType._binary, stringLengthType);
            dic.Add(SqlServerDataType._varbinary, stringLengthType);
            dic.Add(SqlServerDataType._char, stringLengthType);
            dic.Add(SqlServerDataType._nchar, stringLengthType);
            dic.Add(SqlServerDataType._varchar, stringLengthType);
            dic.Add(SqlServerDataType._nvarchar, stringLengthType);
            //decimal
            dic.Add(SqlServerDataType._decimal, decimalLengthType);
            dic.Add(SqlServerDataType._numeric, decimalLengthType);
            //time
            dic.Add(SqlServerDataType._time, timeLengthType);
            dic.Add(SqlServerDataType._datetimeoffset, timeLengthType);
            dic.Add(SqlServerDataType._datetime2, timeLengthType);

            return dic;
        }

        /// <summary>
        /// 返回数据类型长度模板-Sqlite
        /// </summary>
        /// <returns></returns>
        private static Dictionary<SqliteDataType, List<string>> CreateSqliteDataTypeLengthInfo()
        {
            Dictionary<SqliteDataType, List<string>> dic = new Dictionary<SqliteDataType, List<string>>();
            List<string> stringLengthType = new List<string> { "(10)", "(20)", "(50)", "(100)", "(200)", "(500)", "(1000)" };
            //string
            dic.Add(SqliteDataType._TEXT, stringLengthType);

            return dic;
        }
        #endregion

        #region 公共方法-根据指定数据类型获取长度信息
        //SqlServer长度类型具体集合
        public static List<string> GetSqlServerLengthTypeList(string dataType)
        {
            //长度集合定义
            List<string> lengthList = new List<string>();
            //枚举
            SqlServerDataType sqlDataType = (SqlServerDataType)Enum.Parse(typeof(SqlServerDataType), dataType, true);
            //获取集合
            if (AllSqlServerLengTypeDic.Keys.Contains(sqlDataType))
            {
                lengthList = AllSqlServerLengTypeDic[sqlDataType];
            }
            else
            {
                lengthList.Add("");
            }
            //返回
            return lengthList;
        }

        //Sqlite长度类型具体集合
        public static List<string> GetSqliteLengthTypeList(string dataType)
        {
            //长度集合定义
            List<string> lengthList = new List<string>();
            //枚举
            SqliteDataType sqlDataType = (SqliteDataType)Enum.Parse(typeof(SqliteDataType), dataType, true);
            //获取集合
            if (AllSqliteLengTypeDic.Keys.Contains(sqlDataType))
            {
                lengthList = AllSqliteLengTypeDic[sqlDataType];
            }
            else
            {
                lengthList.Add("");
            }
            //返回
            return lengthList;
        }
        #endregion

        #region 公有方法-获取能够自增的数据类型
        //SqlServer可以自增的数据类型集合
        public static List<SqlServerDataType> GetSqlServerAutoIncrementType()
        {
            List<SqlServerDataType> list = new List<SqlServerDataType>();
            list.Add(SqlServerDataType._int);
            list.Add(SqlServerDataType._tinyint);
            list.Add(SqlServerDataType._smallint);
            list.Add(SqlServerDataType._bigint);
            return list;
        }

        public static List<string> GetSqlServerAutoIncrementString()
        {
            List<string> list = new List<string>();
            list.Add(SqlServerDataType._int.ToString().Substring(1));
            list.Add(SqlServerDataType._tinyint.ToString().Substring(1));
            list.Add(SqlServerDataType._smallint.ToString().Substring(1));
            list.Add(SqlServerDataType._bigint.ToString().Substring(1));
            return list;
        }

        //Sqlite可以自增的数据类型集合
        public static List<SqliteDataType> GetSqlliteAutoIncrementType()
        {
            List<SqliteDataType> list = new List<SqliteDataType>();
            list.Add(SqliteDataType._INTEGER);
            return list;
        }

        public static List<string> GetSqlliteAutoIncrementString()
        {
            List<string> list = new List<string>();
            list.Add(SqliteDataType._INTEGER.ToString().Substring(1));
            return list;
        }
        #endregion


        public static string ChangeSqlServerDataType(SqlServerDataType dataTypeEnum)
        {
            switch (dataTypeEnum)
            {
                case SqlServerDataType._bit:
                case SqlServerDataType._tinyint:
                case SqlServerDataType._smallint:
                case SqlServerDataType._int:
                case SqlServerDataType._bigint:
                    return "int";
                case SqlServerDataType._float:
                case SqlServerDataType._real:
                case SqlServerDataType._smallmoney:
                case SqlServerDataType._money:
                case SqlServerDataType._numeric:
                case SqlServerDataType._decimal:
                    return "float";
                case SqlServerDataType._uniqueidentifier:
                case SqlServerDataType._image:
                case SqlServerDataType._binary:
                case SqlServerDataType._varbinary:
                case SqlServerDataType._char:
                case SqlServerDataType._nchar:
                case SqlServerDataType._varchar:
                case SqlServerDataType._nvarchar:
                case SqlServerDataType._text:
                case SqlServerDataType._ntext:
                case SqlServerDataType._xml:
                    return "string";
                case SqlServerDataType._time:
                case SqlServerDataType._date:
                case SqlServerDataType._smalldatetime:
                case SqlServerDataType._datetime:
                case SqlServerDataType._datetime2:
                case SqlServerDataType._datetimeoffset:
                case SqlServerDataType._timestamp:
                    return "DateTime";
                case SqlServerDataType._geography:
                case SqlServerDataType._geometry:
                case SqlServerDataType._hierarchyid:
                case SqlServerDataType._sql_variant:
                    return "string";
                default:
                    return "string";
            }
        }

    }
}
