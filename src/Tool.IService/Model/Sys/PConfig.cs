using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.IService.Model.Sys
{
    [Table("P_Config")]
    public class PConfig
    {
        public int Id { get; set; }

        public string ConfigTypeCode1 { get; set; }

        public string ConfigTypeName1 { get; set; }

        public string ConfigTypeCode2 { get; set; }

        public string ConfigTypeName2 { get; set; }

        public string ConfigTypeCode3 { get; set; }

        public string ConfigTypeName3 { get; set; }

        public string ConfigTypeCode4 { get; set; }

        public string ConfigTypeName4 { get; set; }

        public string ConfigTypeCode5 { get; set; }

        public string ConfigTypeName5 { get; set; }

        public string ConfigValue { get; set; }

        public string Remark { get; set; }
    }
}
