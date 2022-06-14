using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.IService.Model.Dev
{
    public class IndexFieldListResult
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

    public class IndexStrResult
    {
        private string _indexStr = string.Empty;

        private string _indexQueryStr = string.Empty;

        /// <summary>
        /// 索引列
        /// </summary>
        public string IndexList
        {
            get
            {
                return _indexStr;
            }

            set
            {
                _indexStr = value;
            }
        }

        /// <summary>
        /// 索引查询列
        /// </summary>
        public string IndexQueryList
        {
            get
            {
                return _indexQueryStr;
            }

            set
            {
                _indexQueryStr = value;
            }
        }
    }
}
