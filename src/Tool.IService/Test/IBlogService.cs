using Tool.IService.Test.Model.Blogging;

namespace Tool.IService.Test
{
    public interface IBlogService
    {
        /// <summary>
        /// 插入Post数据
        /// </summary>
        public void InsertPost();

        /// <summary>
        /// 操作Blog和Post表
        /// </summary>
        public void BlogAct();

        /// <summary>
        /// 获取Test表数据
        /// </summary>
        public List<TestTable> GetTest();
    }
}
