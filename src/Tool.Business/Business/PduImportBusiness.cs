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
        /// 获取原始4级组织（BU）信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<BusiOriginOrgFourResult> GetOriginLevelFourOrg(ICommonDataHelper dataHelper)
        {
            string sql = @"SELECT OrgId,
                                  OrgName,
                                  OrgNo,
                                  level AS OrgLevel
                           FROM dbo.mng_OrgFive WITH (NOLOCK);";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<BusiOriginOrgFourResult>(dt);
        }

        /// <summary>
        /// 获取原始员工信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<BusiOriginEmpResult> GetOriginEmpInfo(ICommonDataHelper dataHelper)
        {
            string sql = @"SELECT emp_Id AS EmpId,
                                  emp_EmployeeNo AS EmpNo,
                                  REPLACE(emp_EmployeeName,'test','') AS EmpName,
                                  emp_Status AS EmpStatus
                           FROM PSAData..mng_Employee WITH (NOLOCK);";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<BusiOriginEmpResult>(dt);
        }

        /// <summary>
        /// 获取PDU组织信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<BusiPduDepartmentResult> GetPduDepartment(ICommonDataHelper dataHelper)
        {
            string sql = @" SELECT pduDepart.Dep_Id AS OrgId,
                                   pduDepart.Dep_DeptNo AS OrgNo,
                                   pduDepart.Dep_DeptName AS OrgName,
                                   pduDepart.Dep_ParDeptNo AS ParentOrgNo,
                                   pduDepart.Dep_Level4DeptNo AS BuNo,
                                   depart.Dep_DeptName AS BuName,
                                   pduDepart.Dep_LeaderId AS LeaderEmpId,
                                   pduDepart.Dep_EmpNo AS LeaderEmpNo,
                                   pduDepart.Dep_EmpName AS LeaderEmpName,
                                   (
                                       SELECT COUNT(*)
                                       FROM PSADATA..mng_PduDepartment
                                       WHERE Dep_ParDeptNo = pduDepart.Dep_DeptNo
                                   ) AS ChildCount
                            FROM PSADATA..mng_PduDepartment pduDepart WITH (NOLOCK)
                                LEFT JOIN PSADATA..mng_department depart WITH (NOLOCK)
                                    ON depart.Dep_DeptNo = pduDepart.Dep_Level4DeptNo;";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<BusiPduDepartmentResult>(dt);
        }

        /// <summary>
        /// 获取PDU员工信息
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<BusiPduEmployeeResult> GetPduEmployee(ICommonDataHelper dataHelper)
        {
            string sql = @"SELECT pduDepart.Dep_Id AS OrgId,
                                  pduDepart.Dep_DeptNo AS OrgNo,
                                  pduDepart.Dep_DeptName AS OrgName,
                                  pduEmp.EmployeeNo AS EmpNo,
                                  emp.emp_EmployeeName AS EmpName
                           FROM PSAData..mng_Pdu_Employee pduEmp WITH (NOLOCK)
                           LEFT JOIN PSAData..mng_PduDepartment pduDepart WITH (NOLOCK) ON pduDepart.Dep_DeptNo = pduEmp.Dep_No
                           LEFT JOIN PSAData..mng_Employee emp ON emp.emp_EmployeeNo = pduEmp.EmployeeNo;";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<BusiPduEmployeeResult>(dt);
        }

        /// <summary>
        /// 获取PDU组织信息-根据PDULevel
        /// </summary>
        /// <param name="dataHelper"></param>
        /// <returns></returns>
        public List<BusiPduDepartmentResult> GetPduDepartmentLevel(ICommonDataHelper dataHelper)
        {
            string sql = @"SELECT pduLevel.PDU_DeptID AS OrgId,
                                  pduLevel.PDU_DeptNo AS OrgNo,
                                  pduLevel.PDU_DeptName AS OrgName,
                                  pduLevel.DL_DeptNo4 AS BuNo,
                                  pduLevel.DL_DeptName4 AS BuName
                           FROM PSAData..mng_PduDepartmentLevel pduLevel WITH (NOLOCK);";
            DataTable dt = dataHelper.GetDataTable(sql, string.Empty);
            return DtToModel.GetModelFromDB<BusiPduDepartmentResult>(dt);
        }
    }
}
