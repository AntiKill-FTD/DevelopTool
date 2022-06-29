using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Bus
{
    public class OrgResult
    {
        /// <summary>
        /// 组织ID
        /// </summary>
        public Int64 OrgId { get; set; }

        /// <summary>
        /// 组织编号
        /// </summary>
        public string OrgNo { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 组织层级
        /// </summary>
        public Int64 OrgLevel { get; set; }
    }
}
