using System.Data;
using System.Xml;
using Tool.Data.DataHelper;

namespace Tool.Data.SqlConfig
{
    public static class SqlConfig
    {
        private static XmlDocument xmlDoc = null;

        /// <summary>
        /// 初始化加载sqlConfig
        /// </summary>
        static SqlConfig()
        {
            try
            {
                //初始化加载sqlConfig
                if (xmlDoc == null)
                {
                    //初始化
                    xmlDoc = new XmlDocument();
                    //路径
                    string xmlPath = System.AppDomain.CurrentDomain.BaseDirectory + @"SqlConfig\SqlConfig.xml";
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreComments = true;//忽略文档里面的注释
                    //读取
                    XmlReader reader = XmlReader.Create(xmlPath, settings);
                    xmlDoc.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// GetSql
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetSql(string xmlPath, string sqlType = "MSSql")
        {
            //处理xmlPath
            if (xmlPath.EndsWith("/"))
            {
                xmlPath = xmlPath.Substring(0, xmlPath.Length - 1);
            }
            //定义返回结果
            Dictionary<string, string> result = new Dictionary<string, string>();
            //1.获取查询
            XmlNode xnQuery = xmlDoc.SelectSingleNode(xmlPath + "/" + sqlType + "/Query");
            string strQuery = string.Empty;
            if (xnQuery != null)
            {
                strQuery = xnQuery.InnerText.Trim();
                strQuery = strQuery.EndsWith(";") ? strQuery.Substring(0, strQuery.Length - 1) : strQuery;
                result.Add("Query", strQuery);
            }
            else
            {
                result.Add("Query", "");
            }
            //2.获取排序
            XmlNode xnOrder = xmlDoc.SelectSingleNode(xmlPath + "/" + sqlType + "/Order");
            string strOrder = string.Empty;
            if (xnOrder != null)
            {
                string xnText = xnOrder.InnerText;
                string[] orders = xnText.Split(',');
                //循环
                foreach (string o in orders)
                {
                    //处理o的多空格
                    string oR = o.Trim();
                    if (string.IsNullOrEmpty(oR)) continue;
                    while (oR.Contains("  "))
                    {
                        oR = oR.Replace("  ", " ");
                    }
                    //按单空格拆分
                    string oInfoR = string.Empty;
                    string[] oInfo = oR.Trim().Split(' ');
                    if (oInfo.Length < 1 || oInfo.Length > 2)
                    {
                        continue;
                    }
                    if (oInfo.Length == 1)
                    {
                        oInfoR = "," + oInfo[0] + " ASC ";
                    }
                    else if (oInfo.Length == 2)
                    {
                        oInfoR = "," + oInfo[0] + " " + oInfo[1] + " ";
                    }
                    strOrder += oInfoR;
                }
                //如果排序不为空
                if (!string.IsNullOrEmpty(strOrder))
                {
                    strOrder = " ORDER BY " + strOrder.Substring(1, strOrder.Length - 1);
                }
                //添加到dic
                result.Add("Order", strOrder);
            }
            else
            {
                result.Add("Order", "");
            }
            //返回结果
            return result;
        }
    }
}
