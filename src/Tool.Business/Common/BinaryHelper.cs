using System.Numerics;
using System.Text;

namespace Tool.Business.Common
{
    public static class BinaryHelper
    {
        #region  string -> 2,10,16 进制转换

        /// <summary>
        /// String To 2进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 2进制 To String
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string BinaryToString(string data)
        {
            //补齐8位
            int padLength = (8 - data.Length % 8) % 8;
            data = data.PadLeft(data.Length + padLength, '0');
            //每8位转出为ASCII码
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        /// <summary>
        /// String To 10进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string StringToDecimal(string data)
        {
            byte[] byteList = new byte[data.Length];
            char[] dataArray = data.ToCharArray();
            for (int i = 0; i < dataArray.Length; i++)
            {
                byteList[i] = Convert.ToByte(dataArray[i]);
            }
            //index大的是高位，需要倒转
            byteList = byteList.Reverse().ToArray();
            return new BigInteger(byteList).ToString();
        }

        /// <summary>
        /// 10summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DecimalToString(string data)
        {
            BigInteger bigValue = BigInteger.Parse(data);
            byte[] bytes = bigValue.ToByteArray();
            //index大的是高位，需要倒转
            bytes = bytes.Reverse().ToArray();

            return Encoding.ASCII.GetString(bytes.ToArray());
        }

        /// <summary>
        /// String To 16进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string StringToHex(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 16).PadLeft(2, '0'));
            }
            return "0x" + sb.ToString();
        }

        /// <summary>
        /// 16进制 To String
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HexToString(string data)
        {
            //移除0x
            if (data.StartsWith("0x")) data = data.Substring(2);
            //补齐2位
            int padLength = (2 - data.Length % 2) % 2;
            data = data.PadLeft(data.Length + padLength, '0');
            //每2位转出为ASCII码
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < data.Length; i += 2)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 2), 16));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        #endregion

        #region 2,10,16 进制转换

        /// <summary>
        /// 10进制 To 2进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DecimalToBinary(string data)
        {
            BigInteger bigValue = BigInteger.Parse(data);
            byte[] bytes = bigValue.ToByteArray();
            //index大的是高位，需要倒转
            bytes = bytes.Reverse().ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (byte c in bytes)
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 10进制 To 16进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DecimalToHex(string data)
        {
            BigInteger bigValue = BigInteger.Parse(data);
            byte[] bytes = bigValue.ToByteArray();
            //index大的是高位，需要倒转
            bytes = bytes.Reverse().ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (byte c in bytes)
            {
                sb.Append(Convert.ToString(c, 16).PadLeft(2, '0'));
            }
            return "0x" + sb.ToString();
        }

        /// <summary>
        /// 2进制 To 10进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string BinaryToDecimal(string data)
        {
            //补齐8位
            int padLength = (8 - data.Length % 8) % 8;
            data = data.PadLeft(data.Length + padLength, '0');
            int eightCount = data.Length / 8;
            //每8位截取成一个string，然后组成List
            List<string> list = new List<string>();
            for (int i = 0; i < eightCount; i++)
            {
                list.Add(data.Substring(i * 8, 8));
            }
            //高位放后面，list需要倒转
            list.Reverse();
            //转换为10进制存入bytes
            byte[] byteList = new byte[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                int item = Convert.ToInt32(list[i], 2);
                byteList[i] = (byte)item;
            }
            //bytes转换为整型的字符串
            return new BigInteger(byteList).ToString();
        }

        /// <summary>
        /// 2进制 To 16进制 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string BinaryToHex(string data)
        {
            //补齐8位
            int padLength = (8 - data.Length % 8) % 8;
            data = data.PadLeft(data.Length + padLength, '0');
            int eightCount = data.Length / 8;
            //每8位截取成一个string，然后组成List
            List<string> list = new List<string>();
            for (int i = 0; i < eightCount; i++)
            {
                list.Add(data.Substring(i * 8, 8));
            }
            //转换为16制存入StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                string tempHex = string.Format("{0:x}", Convert.ToInt64(list[i], 2)).PadLeft(2, '0');
                sb.Append(tempHex);
            }
            return "0x" + sb.ToString();
        }

        /// <summary>
        /// 16进制 To 2进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HexToBinary(string data)
        {
            //移除0x
            if (data.StartsWith("0x")) data = data.Substring(2);
            //补齐2位
            int padLength = (2 - data.Length % 2) % 2;
            data = data.PadLeft(data.Length + padLength, '0');
            int twoCount = data.Length / 2;
            //每2位截取成一个string，然后组成List
            List<string> list = new List<string>();
            for (int i = 0; i < twoCount; i++)
            {
                list.Add(data.Substring(i * 2, 2));
            }
            //转换为16制存入StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                int tempBinary = Convert.ToInt32(list[i], 16);
                sb.Append(Convert.ToString(tempBinary, 2).PadLeft(8, '0'));
            }
            return "0x" + sb.ToString();
        }

        /// <summary>
        /// 16进制 To 10进制
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HexToDecimal(string data)
        {
            //移除0x
            if (data.StartsWith("0x")) data = data.Substring(2);
            //补齐2位
            int padLength = (2 - data.Length % 2) % 2;
            data = data.PadLeft(data.Length + padLength, '0');
            int twoCount = data.Length / 2;
            //每8位截取成一个string，然后组成List
            List<string> list = new List<string>();
            for (int i = 0; i < twoCount; i++)
            {
                list.Add(data.Substring(i * 2, 2));
            }
            //高位放后面，list需要倒转
            list.Reverse();
            //转换为10进制存入bytes
            byte[] byteList = new byte[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                int item = Convert.ToInt32(list[i], 16);
                byteList[i] = (byte)item;
            }
            //bytes转换为整型的字符串
            return new BigInteger(byteList).ToString();
        }

        #endregion
    }
}
