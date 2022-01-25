using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Business.Common
{
    public class CryptHelper
    {
        private string _key;

        private string _iv;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public string IV
        {
            get { return _iv; }
            set { _iv = value; }
        }

        public string EncryptString(string strContent)
        {
            string result = "";
            if (string.IsNullOrEmpty(strContent) || strContent == "NULL" || strContent.Trim() == "")
            {
                return strContent;
            }

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = null;
            try
            {
                byte[] byKey = Encoding.UTF8.GetBytes(this._key.Substring(0, 8));
                byte[] byIV = Encoding.UTF8.GetBytes(this._iv);
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strContent);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                cs = new CryptoStream(ms, des.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

                cs.Write(inputByteArray);
                cs.FlushFinalBlock();
                cs.Close();
                ms.Close();

                result = Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                if (cs != null)
                {
                    cs.Close();
                }
                if (ms != null)
                {
                    ms.Close();
                }
                result = null;
            }
            return result;
        }

        public string DecryptString(string strContent)
        {
            string result = "";
            if (string.IsNullOrEmpty(strContent) || strContent == "NULL" || strContent.Trim() == "")
            {
                return strContent;
            }

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = null;
            try
            {
                byte[] byKey = Encoding.UTF8.GetBytes(this._key.Substring(0, 8));
                byte[] byIV = Encoding.UTF8.GetBytes(this._iv);
                byte[] inputByteArray = Convert.FromBase64String(strContent);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                cs = new CryptoStream(ms, des.CreateDecryptor(byKey, byIV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                cs.Close();
                ms.Close();

                result = Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                if (cs != null)
                {
                    cs.Close();
                }
                if (ms != null)
                {
                    ms.Close();
                }
                result = null;
            }
            return result;
        }
    }
}
