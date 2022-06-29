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
        /// 是否末级
        /// </summary>
        public int IsLeaf { get; set; }
    }
}
