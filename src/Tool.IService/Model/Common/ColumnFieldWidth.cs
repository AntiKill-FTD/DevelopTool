using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Common
{
    public class ColumnFieldWidth
    {
        /// <summary>
        /// 列中文名称
        /// </summary>
        public string? ColumnField { get; set; }

        /// <summary>
        /// 列类型
        /// </summary>
        public FieldType FieldType { get; set; }

        /// <summary>
        /// 列宽度
        /// </summary>
        public int ColumnWidth { get; set; }
    }

    public enum FieldType
    {
        Absolute = 1,
        Percent = 2
    }
}
