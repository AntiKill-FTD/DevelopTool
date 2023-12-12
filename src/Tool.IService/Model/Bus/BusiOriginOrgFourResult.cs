namespace Tool.IService.Model.Bus
{
    public class BusiOriginOrgFourResult
    {
        /// <summary>
        /// 组织ID
        /// </summary>
        public long OrgId { get; set; }

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
        public long OrgLevel { get; set; }
    }
}
