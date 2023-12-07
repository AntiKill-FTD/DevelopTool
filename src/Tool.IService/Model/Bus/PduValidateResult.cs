namespace Tool.IService.Model.Bus
{
    public class PduValidateResult
    {
        public List<OriginOrgFourResult> OriginLevelFourOrgResult { get; set; }

        public List<OriginEmpResult> OriginEmpResult { get; set; }

        public List<PduDepartmentResult> PduDepartmentResult { get; set; }

        public List<PduEmployeeResult> PduEmployeeResult { get; set; }
    }
}
