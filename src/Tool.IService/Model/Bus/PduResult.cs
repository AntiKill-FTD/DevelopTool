using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Bus
{
    public class PduResult
    {
        /// <summary>
        /// 组织Id
        /// </summary>
        public Int64 OrgId { get; set; }

        /// <summary>
        /// 组织编码
        /// </summary>
        public string OrgNo { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// BU编号
        /// </summary>
        public string BuNo { get; set; }

        /// <summary>
        /// BU名称
        /// </summary>
        public string BuName { get; set; }
    }
}
