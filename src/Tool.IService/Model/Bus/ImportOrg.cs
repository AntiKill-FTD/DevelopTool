using System.ComponentModel;

namespace Tool.IService.Model.Bus
{
    public class ImportOrg
    {
        [Description("带Sheet名称序号")]
        public string SheetIndex { get; set; }

        [Description("序号")]
        public int Index { get; set; }

        [Description("业务组织名称")]
        public string OrgName { get; set; }

        [Description("直接上层业务组织")]
        public string ParentName { get; set; }

        [Description("所属BU")]
        public string BuName { get; set; }

        [Description("所属BU编码")]
        public string BuNo { get; set; }

        [Description("部门负责人姓名")]
        public string EmpName { get; set; }

        [Description("部门负责人工号")]
        public string EmpNo { get; set; }

        [Description("生效月")]
        public string BeginDate { get; set; }

        [Description("业务组织编号")]
        public string OrgNo { get; set; }

        [Description("父级编号")]
        public string ParentNO { get; set; }

        [Description("部门负责人ID")]
        public string LeaderId { get; set; }

        [Description("备注")]
        public string Remark { get; set; }

        [Description("导入类型")]
        public SqlType SqlType { get; set; }
    }
}
