namespace Tool.IService.Model.Bus
{
    public class BusinessData
    {
        public List<BusiOriginOrgFourResult> OriginLevelFourOrgResult { get; set; }

        public List<BusiOriginEmpResult> OriginEmpResult { get; set; }

        public List<BusiPduDepartmentResult> PduDepartmentResult { get; set; }

        public List<BusiPduEmployeeResult> PduEmployeeResult { get; set; }
    }
}
