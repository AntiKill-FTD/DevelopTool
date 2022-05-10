using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Business.Common
{
    public class AES_CryptHelper
    {
        private ICryptoTransform encryptor;
        private ICryptoTransform decryptor;

        /// <summary>
        /// key is required to be 32bit
        /// </summary>
        /// <param name="key"></param>
        public AES_CryptHelper(string key)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;
            encryptor = aes.CreateEncryptor();
            decryptor = aes.CreateDecryptor();
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="plainStr">明文字符串</param>
        /// <returns>密文</returns>
        public string AESEncrypt(string encryptStr)
        {

            byte[] toEncryptArray = Encoding.UTF8.GetBytes(encryptStr);
            byte[] resultArray = encryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string AESDecrypt(string encryptStr)
        {
            byte[] toEncryptArray = Convert.FromBase64String(encryptStr);
            byte[] resultArray = decryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }
    }
}
