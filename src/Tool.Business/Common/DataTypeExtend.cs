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
        public static string ChangeDataType(SqlServerDataType dataTypeEnum)
        {
            switch (dataTypeEnum)
            {
                case SqlServerDataType.BIT:
                case SqlServerDataType.INT:
                case SqlServerDataType.TINYINT:
                case SqlServerDataType.SMALLINT:
                case SqlServerDataType.BIGINT:
                case SqlServerDataType.INTEGER:
                    return "int";
                case SqlServerDataType.NUMERIC:
                case SqlServerDataType.FLOAT:
                case SqlServerDataType.REAL:
                case SqlServerDataType.DECIMAL:
                case SqlServerDataType.MONEY:
                case SqlServerDataType.SMALLMONEY:
                    return "float";
                case SqlServerDataType.UNIQUEIDENTIFIER:
                case SqlServerDataType.CHAR:
                case SqlServerDataType.NCHAR:
                case SqlServerDataType.VARCHAR:
                case SqlServerDataType.NVARCHAR:
                case SqlServerDataType.TEXT:
                case SqlServerDataType.NTEXT:
                case SqlServerDataType.XML:
                case SqlServerDataType.TIMESTAMP:
                case SqlServerDataType.BINARY:
                case SqlServerDataType.VARBINARY:
                case SqlServerDataType.CHARACTER:
                case SqlServerDataType.IMAGE:
                case SqlServerDataType.TIME:
                case SqlServerDataType.DATE:
                case SqlServerDataType.DATETIME:
                case SqlServerDataType.DATETIME2:
                case SqlServerDataType.SMALLDATETIME:
                case SqlServerDataType.DATETIMEOFFSET:
                    return "string";
                default:
                    return "string";
            }
        }

    }
}
