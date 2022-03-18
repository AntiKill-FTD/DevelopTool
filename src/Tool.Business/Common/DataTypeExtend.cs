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
        //SqlServer长度类型字典-私有
        private static Dictionary<SqlServerDataType, List<string>> _sqlServerLengTypeDic;
        //Sqlite   长度类型字段-私有
        private static Dictionary<SqliteDataType, List<string>> _sqliteLengthTypeDic;

        //SqlServer长度类型字典-公有
        public static Dictionary<SqlServerDataType, List<string>> SqlServerLengTypeDic
        {
            get
            {
                if (_sqlServerLengTypeDic == null)
                {
                    _sqlServerLengTypeDic = GetSqlServerDataTypeLengthInfo();
                }
                return _sqlServerLengTypeDic;
            }
        }

        //Sqlite长度类型字典-公有
        public static Dictionary<SqliteDataType, List<string>> SqliteLengTypeDic
        {
            get
            {
                if (_sqliteLengthTypeDic == null)
                {
                    _sqliteLengthTypeDic = GetSqliteDataTypeLengthInfo();
                }
                return _sqliteLengthTypeDic;
            }
        }

        //SqlServer长度类型具体集合
        public static List<string> GetSqlServerLengthTypeList(string dataType)
        {
            //长度集合定义
            List<string> lengthList = new List<string>();
            //枚举
            SqlServerDataType sqlDataType = (SqlServerDataType)Enum.Parse(typeof(SqlServerDataType), dataType, true);
            //获取集合
            if (SqlServerLengTypeDic.Keys.Contains(sqlDataType))
            {
                lengthList = SqlServerLengTypeDic[sqlDataType];
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
            if (SqliteLengTypeDic.Keys.Contains(sqlDataType))
            {
                lengthList = SqliteLengTypeDic[sqlDataType];
            }
            else
            {
                lengthList.Add("");
            }
            //返回
            return lengthList;
        }

        /// <summary>
        /// 返回数据类型长度模板-SqlServer
        /// </summary>
        /// <returns></returns>
        private static Dictionary<SqlServerDataType, List<string>> GetSqlServerDataTypeLengthInfo()
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
        private static Dictionary<SqliteDataType, List<string>> GetSqliteDataTypeLengthInfo()
        {
            Dictionary<SqliteDataType, List<string>> dic = new Dictionary<SqliteDataType, List<string>>();
            List<string> stringLengthType = new List<string> { "(10)", "(20)", "(50)", "(100)", "(200)", "(500)", "(1000)", "(MAX)" };
            List<string> decimalLengthType = new List<string> { "(18,0)", "(18,2)", "(18,6)" };
            List<string> timeLengthType = new List<string> { "(7)" };
            //string
            dic.Add(SqliteDataType._binary, stringLengthType);
            dic.Add(SqliteDataType._varbinary, stringLengthType);
            dic.Add(SqliteDataType._char, stringLengthType);
            dic.Add(SqliteDataType._nchar, stringLengthType);
            dic.Add(SqliteDataType._varchar, stringLengthType);
            dic.Add(SqliteDataType._nvarchar, stringLengthType);
            //decimal
            dic.Add(SqliteDataType._decimal, decimalLengthType);
            dic.Add(SqliteDataType._numeric, decimalLengthType);
            //time
            dic.Add(SqliteDataType._time, timeLengthType);
            dic.Add(SqliteDataType._datetimeoffset, timeLengthType);
            dic.Add(SqliteDataType._datetime2, timeLengthType);

            return dic;
        }

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
