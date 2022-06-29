using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Bus
{
    public class EmpResult
    {
        /// <summary>
        /// 员工Id
        /// </summary>
        public Int64 EmpId { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        public string EmpNo { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 员工状态
        /// </summary>
        public string EmpStatus { get; set; }
    }
}
