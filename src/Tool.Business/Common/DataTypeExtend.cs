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
        /// <summary>
        /// 返回数据类型长度模板
        /// </summary>
        /// <returns></returns>
        public static Dictionary<SqlServerDataType, List<string>> SqlServerDataTypeLengthInfo()
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
