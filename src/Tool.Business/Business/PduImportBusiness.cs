using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Data.DataHelper;
using Tool.IService.Model.Bus;
using Newtonsoft.Json;
using Tool.Business.Common;

namespace Tool.Business.Business
{
    public class PduImportBusiness
    {
        /// <summary>
        /// 获取4级组织（BU）信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<OrgResult> GetLevelFourOrg(ICommonDataHelper dataHelper)
        {
            string sql = "SELECT OrgId, OrgName, OrgNo FROM dbo.mng_OrgFive WHERE Level = 4;";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<OrgResult>(dt);
        }

        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<EmpResult> GetEmpInfo(ICommonDataHelper dataHelper)
        {
            string sql = "SELECT emp_Id AS EmpId, emp_EmployeeNo AS EmpNo, REPLACE(emp_EmployeeName,'test','') AS EmpName FROM PSAData..mng_Employee WHERE emp_Status = 1;";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<EmpResult>(dt);
        }
    }
}
