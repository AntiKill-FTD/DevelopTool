using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Bus
{
    public class PduValidateResult
    {
        public List<OrgResult> orgResults { get; set; }

        public List<EmpResult> empResults { get; set; }
    }
}
