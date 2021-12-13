using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.IService.Model.Blogging;

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
