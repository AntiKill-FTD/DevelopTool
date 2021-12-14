using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.IService.Model.Sys
{
    [Table("P_Menu")]
    public class Menu
    {
        public int Id { get; set; }

        public string MenuCode { get; set; }

        public string MenuName { get; set; }

        public string ParentCode { get; set; }

        public string Assembly { get; set; }

        public string NameSpace { get; set; }

        public string EntityName { get; set; }

        public int Level { get; set; }

        public int IfEnd { get; set; }
    }

    public class FullMenuEntity
    {
        public Menu currentMenu;

        public List<FullMenuEntity> childMenu;
    }
}
