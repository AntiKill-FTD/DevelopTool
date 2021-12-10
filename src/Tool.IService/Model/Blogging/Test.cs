using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.IService.Model.Blogging
{
    [Table("Test")]
    public class TestTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
