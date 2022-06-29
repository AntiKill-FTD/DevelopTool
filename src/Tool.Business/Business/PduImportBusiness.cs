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
            string sql = @"SELECT pdu.Dep_Id AS OrgId,
                                 pdu.Dep_DeptNo AS OrgNo,
                                 pdu.Dep_DeptName AS OrgName,
                                 CASE
                                     WHEN pduLevel.PDU_ID IS NULL THEN
                                         0
                                     ELSE
                                         1
                                 END AS IsLeaf
                          FROM PSAData..mng_PduDepartment pdu WITH (NOLOCK)
                              LEFT JOIN PSAData..mng_PduDepartmentLevel pduLevel WITH (NOLOCK)
                                  ON pduLevel.PDU_DeptID = pdu.Dep_Id;";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<PduResult>(dt);
        }
    }
}
