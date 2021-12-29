using System.Data;
using System.Data.Common;

namespace Tool.Data.DataHelper
{
    public interface ICommonDataHelper
    {
        public DataSet GetDataSet(string sql);

        public DataTable GetDataTable(string sqlMain, string sqlOrder);

        public DataTable GetDataTableByPage(string sqlMain, string sqlOrder, ref int allDataCount, int currentPageIndex = 1, int perPageCount = 100);

        public DataRow GetDataRow(string sql);

        public int ExcuteNoQuery(string sql);

        public T ExcuteScalar<T>(string sql, ref bool result);

        public DataSet ExcuteProc(string procName, DbParameter[] parameters);
    }
}
