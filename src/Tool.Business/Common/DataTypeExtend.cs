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
                case SqlServerDataType.bit:
                case SqlServerDataType.tinyint:
                case SqlServerDataType.smallint:
                case SqlServerDataType._int:
                case SqlServerDataType.bigint:
                    return "int";
                case SqlServerDataType._float:
                case SqlServerDataType.smallmoney:
                case SqlServerDataType.money:
                case SqlServerDataType.numeric___18__2_:
                case SqlServerDataType._decimal___18__0_:
                    return "float";
                case SqlServerDataType.uniqueidentifier:
                case SqlServerDataType.binary___50_:
                case SqlServerDataType.varbinary___50_:
                case SqlServerDataType._char___10_:
                case SqlServerDataType.varchar___50_:
                case SqlServerDataType.nchar___10_:
                case SqlServerDataType.nvarchar___50_:
                case SqlServerDataType.text:
                case SqlServerDataType.ntext:
                case SqlServerDataType.xml:
                    return "string";
                default:
                    return "string";
            }
        }

    }
}
