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
            string sql = "SELECT OrgId, OrgName, OrgNo, level AS OrgLevel FROM dbo.mng_OrgFive WITH (NOLOCK);";
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
            string sql = "SELECT emp_Id AS EmpId, emp_EmployeeNo AS EmpNo, REPLACE(emp_EmployeeName,'test','') AS EmpName, emp_Status AS EmpStatus FROM PSAData..mng_Employee WITH (NOLOCK);";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<EmpResult>(dt);
        }

        /// <summary>
        /// 获取PDU组织信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<PduResult> GetPduDepartment(ICommonDataHelper dataHelper)
        {
            string sql = @"SELECT pduLevel.PDU_DeptID AS OrgId,
                                  pduLevel.PDU_DeptNo AS OrgNo,
                                  pduLevel.PDU_DeptName AS OrgName,
                                  pduLevel.DL_DeptNo4 AS BuNo,
                                  pduLevel.DL_DeptName4 AS BuName
                           FROM PSAData..mng_PduDepartmentLevel pduLevel WITH (NOLOCK);";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<PduResult>(dt);
        }
    }
}
