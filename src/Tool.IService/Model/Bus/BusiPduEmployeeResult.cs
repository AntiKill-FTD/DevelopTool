namespace Tool.IService.Model.Bus
{
    public class BusiPduEmployeeResult
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
        /// 员工编号
        /// </summary>
        public string EmpNo { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName { get; set; }
    }
}
