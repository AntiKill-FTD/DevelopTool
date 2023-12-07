using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Bus
{
    public class PduDepartmentResult
    {
        /// <summary>
        /// 组织Id
        /// </summary>
        public long OrgId { get; set; }

        /// <summary>
        /// 组织编码
        /// </summary>
        public string OrgNo { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 父级编号（可能是BU，可能是PDU）
        /// </summary>
        public string ParentOrgNo { get; set; }

        /// <summary>
        /// BU编号
        /// </summary>
        public string BuNo { get; set; }

        /// <summary>
        /// BU名称
        /// </summary>
        public string BuName { get; set; }

        /// <summary>
        /// 负责人员工ID
        /// </summary>
        public long LeaderEmpId { get; set; }

        /// <summary>
        /// 负责人员工编号
        /// </summary>
        public string LeaderEmpNo { get; set; }

        /// <summary>
        /// 负责人员工姓名
        /// </summary>

        public string LeaderEmpName { get; set; }
    }
}
