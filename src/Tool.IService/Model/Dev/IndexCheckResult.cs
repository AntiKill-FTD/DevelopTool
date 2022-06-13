using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Dev
{
    public class IndexCheckResult
    {
        private List<string> _indexList;

        private List<string> _indexQueryList;

        /// <summary>
        /// 索引列
        /// </summary>
        public List<string> IndexList
        {
            get
            {
                if (_indexList == null)
                {
                    _indexList = new List<string>();
                }
                return _indexList;
            }

            set
            {
                _indexList = value;
            }
        }

        /// <summary>
        /// 索引查询列
        /// </summary>
        public List<string> IndexQueryList
        {
            get
            {
                if (_indexQueryList == null)
                {
                    _indexQueryList = new List<string>();
                }
                return _indexQueryList;
            }

            set
            {
                _indexQueryList = value;
            }
        }
    }
}
