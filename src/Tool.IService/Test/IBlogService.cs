using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
