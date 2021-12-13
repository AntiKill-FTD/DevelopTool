using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.IService.Test.Model.Blogging
{
    [Table("Test")]
    public class TestTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
