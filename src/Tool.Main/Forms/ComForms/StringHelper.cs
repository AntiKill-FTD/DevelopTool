using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Business.Common;

namespace Tool.Main.Forms.ComForms
{
    public partial class StringHelper : Form
    {
        private DES_CryptHelper cryptHelper = new DES_CryptHelper();

        public StringHelper()
        {
            InitializeComponent();
        }

        #region StringListOperate

        #region 分割
        private void btn_StringList_SplitChar_Click(object sender, EventArgs e)
        {
            //获取  【拆分字符串】  和  【源字符串】
            string splitString = this.tb_StringList_SplitChar.Text;
            string originString = this.rtb_StringList_Source.Text;
            //拆分字符串
            List<string> disStringList = originString.Split(splitString).ToList();
            //去首尾空格
            List<string> disNewStringList = new List<string>();
            foreach (string item in disStringList)
            {
                disNewStringList.Add(item.Trim());
            }
            //换行拼接
            string newDistination = string.Join('\n', disNewStringList);
            this.rtb_StringList_Distination.Text = newDistination;
        }
        #endregion

        #region 首尾字符
        private void btn_StringList_AddBEChar_Click(object sender, EventArgs e)
        {
            //获取  【首尾字符串】   和  【目标字符串】
            string addString = this.tb_StringList_AddBEChar.Text;
            int addLength = addString.Length;
            string distinaString = this.rtb_StringList_Distination.Text;
            //按照换行取出目标字符串
            List<string> disListOld = distinaString.Split('\n').ToList();
            //循环判断每个字符串首尾是否存在需要添加的字符串，如果存在则删除，不存在则添加
            List<string> disListNew = new List<string>();
            disListOld.ForEach(item =>
            {
                if (item.StartsWith(addString) && item.EndsWith(addString))
                {
                    item = item.Substring(addLength).Substring(0, item.Length - addLength * 2);
                }
                else
                {
                    item = addString + item + addString;
                }
                disListNew.Add(item.Trim());
            });
            //换行拼接
            string newDistination = string.Join('\n', disListNew);
            this.rtb_StringList_Distination.Text = newDistination;
        }
        #endregion

        #region 开始字符
        private void btn_StringList_AddBeginChar_Click(object sender, EventArgs e)
        {
            //获取  【开始字符串】   和  【目标字符串】
            string addString = this.tb_StringList_AddBeginChar.Text;
            int addLength = addString.Length;
            string distinaString = this.rtb_StringList_Distination.Text;
            //按照换行取出目标字符串
            List<string> disListOld = distinaString.Split('\n').ToList();
            //循环判断每个字符串尾部是否存在需要添加的字符串，如果存在则删除，不存在则添加
            List<string> disListNew = new List<string>();
            disListOld.ForEach(item =>
            {
                //处理变量@origin，替换为自己
                string newAddString = addString.Replace("@origin", item);
                int newAddLength = newAddString.Length;
                if (item.StartsWith(newAddString))
                {
                    item = item.Substring(newAddLength);
                }
                else
                {
                    item = newAddString + item;
                }
                disListNew.Add(item.Trim());
            });
            //换行拼接
            string newDistination = string.Join('\n', disListNew);
            this.rtb_StringList_Distination.Text = newDistination;
        }
        #endregion

        #region 每行个数
        private void btn_StringList_RowSplit_Click(object sender, EventArgs e)
        {
            try
            {
                //获取  【开始字符串】   和  【目标字符串】
                string strRowCount = this.tb_StringList_RowSplit.Text;
                int rowCount = Convert.ToInt32(strRowCount);
                string distinaString = this.rtb_StringList_Distination.Text;
                //按照换行取出目标字符串
                List<string> disListOld = distinaString.Split('\n').ToList();
                //循环取出的目标字符串，每隔目标个数添加一个换行符
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < disListOld.Count; i++)
                {
                    if (cb_StringList_RowSplit.Checked)
                    {
                        sb.Append(disListOld[i] + ",");
                    }
                    else
                    {
                        sb.Append(disListOld[i]);
                    }
                    if ((i + 1) % rowCount == 0)
                    {
                        sb.Append('\n');
                    }
                }
                this.rtb_StringList_Distination.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        #region 结尾字符
        private void btn_StringList_AddEndChar_Click(object sender, EventArgs e)
        {
            //获取  【尾部字符串】   和  【目标字符串】
            string addString = this.tb_StringList_AddEndChar.Text;
            int addLength = addString.Length;
            string distinaString = this.rtb_StringList_Distination.Text;
            //按照换行取出目标字符串
            List<string> disListOld = distinaString.Split('\n').ToList();
            //循环判断每个字符串尾部是否存在需要添加的字符串，如果存在则删除，不存在则添加
            List<string> disListNew = new List<string>();
            disListOld.ForEach(item =>
            {
                if (item.EndsWith(addString))
                {
                    item = item.Substring(0, item.Length - addLength);
                }
                else
                {
                    item = item + addString;
                }
                disListNew.Add(item.Trim());
            });
            //换行拼接
            string newDistination = string.Join('\n', disListNew);
            this.rtb_StringList_Distination.Text = newDistination;
        }
        #endregion

        #endregion

        #region Encrypt

        #region 加密
        private void btn_Encrypt_Encode_Click(object sender, EventArgs e)
        {
            cryptHelper.Key = this.tb_Encrypt_Key_En.Text;
            cryptHelper.IV = this.tb_Encrypt_IV_En.Text;

            string strDecode = this.tb_Encrypt_Decode.Text;
            string strEncode = cryptHelper.EncryptString(strDecode);
            this.lb_Encrypt_Encode.Text = strEncode;
        }
        #endregion

        #region 解密
        private void btn_Encrypt_Decode_Click(object sender, EventArgs e)
        {
            cryptHelper.Key = this.tb_Encrypt_Key_De.Text;
            cryptHelper.IV = this.tb_Encrypt_IV_De.Text;

            string strEncode = this.tb_Encrypt_Encode.Text;
            string strDecode = cryptHelper.DecryptString(strEncode);
            this.lb_Encrypt_Decode.Text = strDecode;
        }
        #endregion

        #region 批量加密
        private void btnMuti_EncryptEncode_Click(object sender, EventArgs e)
        {
            cryptHelper.Key = this.tb_Encrypt_Key_En.Text;
            cryptHelper.IV = this.tb_Encrypt_IV_En.Text;

            this.rtb_Encrypt_Distination.Clear();
            string[] strEncodeList = this.rtb_Encrypt_Source.Text.Split('\n');
            foreach (string str in strEncodeList)
            {
                string strDecode = cryptHelper.EncryptString(str);
                this.rtb_Encrypt_Distination.AppendText(strDecode + "\n");
            }
        }
        #endregion

        #region 批量解密
        private void btnMuti_EncryptDecode_Click(object sender, EventArgs e)
        {
            cryptHelper.Key = this.tb_Encrypt_Key_De.Text;
            cryptHelper.IV = this.tb_Encrypt_IV_De.Text;

            this.rtb_Encrypt_Distination.Clear();
            string[] strEncodeList = this.rtb_Encrypt_Source.Text.Split('\n');
            foreach (string str in strEncodeList)
            {
                string strDecode = cryptHelper.DecryptString(str);
                this.rtb_Encrypt_Distination.AppendText(strDecode + "\n");
            }
        }
        #endregion

        #endregion

        #region Dichotomy(二分法)

        #region 获取上半部分
        private void btn_Dichotomy_UpHalf_Click(object sender, EventArgs e)
        {
            //获取【源字符串】
            string sourceString = this.rtb_Dichotomy_Source.Text;
            //按照换行取出目标字符串
            List<string> sourceList = sourceString.Split('\n').ToList();
            //获取行数
            int count = sourceList.Count;
            //获取一半的数量，增位：譬如5的一半取3
            int halfCount = (int)Math.Ceiling(count / 2.0);
            //定义新的集合存储一半的量
            List<string> newSourceList = new List<string>();
            for (int i = 0; i < halfCount; i++)
            {
                newSourceList.Add(sourceList[i]);
            }
            //输出
            this.rtb_Dichotomy_Distination.Text = String.Join('\n', newSourceList);
        }
        #endregion

        #region 获取下半部分
        private void btn_Dichotomy_DownHalf_Click(object sender, EventArgs e)
        {
            //获取【源字符串】
            string sourceString = this.rtb_Dichotomy_Source.Text;
            //按照换行取出目标字符串
            List<string> sourceList = sourceString.Split('\n').ToList();
            //获取行数
            int count = sourceList.Count;
            //获取一半的数量，减位：譬如5的一半取4到5
            int halfCount = (int)Math.Ceiling(count / 2.0);
            //定义新的集合存储一半的量
            List<string> newSourceList = new List<string>();
            for (int i = halfCount; i < count; i++)
            {
                newSourceList.Add(sourceList[i]);
            }
            //输出
            this.rtb_Dichotomy_Distination.Text = String.Join('\n', newSourceList);
        }
        #endregion

        #region 回写
        private void btn_Dichotomy_WriteBack_Click(object sender, EventArgs e)
        {
            this.rtb_Dichotomy_Source.Text = this.rtb_Dichotomy_Distination.Text;
        }
        #endregion

        #endregion

        #region 加解密 AES DES RSA 等

        #region C#代码加密 JS解密

        #region 明文改变事件
        private void tb_DE_Decrypt_NumberJS_TextChanged(object sender, EventArgs e)
        {
            //秘钥为空直接返回
            if (string.IsNullOrEmpty(this.tb_DE_PassWord_NumberJS.Text.Trim()))
            {
                this.tb_DE_Encrypt_NumberJS.Text = string.Empty;
                return;
            }
            //获取秘钥和明文
            string strPassWord = this.tb_DE_PassWord_NumberJS.Text;
            string strDecrypt = this.tb_DE_Decrypt_NumberJS.Text;
            //加密
            //1.秘钥Decimal
            string binaryPassWord = BinaryHelper.StringToBinary(strPassWord);
            string decimalPassWord = BinaryHelper.BinaryToDecimal(binaryPassWord);
            //2.源Decimal
            string binaryOrigin = BinaryHelper.StringToBinary(strDecrypt);
            string decimalOrigin = BinaryHelper.BinaryToDecimal(binaryOrigin);
            //3.相加输出
            string addBigInteger = BigInteger.Add(BigInteger.Parse(decimalPassWord), BigInteger.Parse(decimalOrigin)).ToString();
            //输出密文
            this.tb_DE_Encrypt_NumberJS.Text = addBigInteger;
        }
        #endregion

        #region JS解密方案
        //      //明文内容改变事件
        //      function tbEncode_Changed()
        //      {
        //          //秘钥和密文
        //          var strPassWord = $("#tbPassWord").val();
        //          var strEncode = $("#tbEncode").val();
        //          //秘钥 str -> decimal
        //          var binaryPass = strToBinary(strPassWord);
        //          var decimalPass = binaryToDecimal(binaryPass);
        //          //解密
        //          var strDecode = DecodeStr(strEncode, decimalPass);
        //          //输出
        //          $("#tbDecode").val(strDecode);
        //      }

        //      //解密
        //      function DecodeStr(strEncode, decimalPass)
        //      {
        //          //BigIntegerSum - decimalPass
        //          var decimalOrigin = BigInt(strEncode) - BigInt(decimalPass);
        //          //BigInteger -> Binary
        //          var binaryEncode = decimalToBinary(decimalOrigin);
        //          //Binary -> String
        //          var strEncode = binaryToStr(binaryEncode);
        //          return strEncode;
        //      }

        //      //将十进制转换为二进制，每个转换8位
        //      function decimalToBinary(num)
        //      {
        //          var binaryStr = BigInt(num).toString(2);
        //          binaryStr = new Array(8 - binaryStr.length % 8 + 1).join('0') + binaryStr;
        //          return binaryStr;
        //      }

        //      //将二进制转换为10进制
        //      function binaryToDecimal(binary)
        //      {
        //          var num = BigInt("0b" + binary);
        //          return num;
        //      }

        //      //将字符串转换成二进制形式，每个转换8位
        //      function strToBinary(str)
        //      {
        //          var result = [];
        //          var list = str.split("");
        //          for (var i = 0; i < list.length; i++)
        //          {
        //              var item = list[i];
        //              var binaryStr = item.charCodeAt().toString(2);
        //              binaryStr = new Array(8 - binaryStr.length + 1).join('0') + binaryStr;
        //              result.push(binaryStr);
        //          }
        //          return result.join("");
        //      }

        //      //将二进制字符串转换成Unicode字符串
        //      function binaryToStr(str)
        //      {
        //          var result = [];
        //          for (var i = 0; i < str.length / 8; i++)
        //          {
        //              var item = str.substr(i * 8, 8);
        //              var asciiCode = parseInt(item, 2);
        //              var charValue = String.fromCharCode(asciiCode);
        //              result.push(charValue);
        //          }
        //          return result.join("");
        //      }
        #endregion

        #endregion

        #region AES
        private void tb_DE_Decrypt_AES_TextChanged(object sender, EventArgs e)
        {
            //秘钥为空直接返回
            string key = this.tb_DE_PassWord_AES.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                this.tb_DE_Encrypt_AES.Text = string.Empty;
                return;
            }
            //获取明文
            string strDecrypt = this.tb_DE_Decrypt_AES.Text;
            //加密
            try
            {
                AES_CryptHelper crypt = new AES_CryptHelper(key);
                string strEncode = crypt.AESEncrypt(strDecrypt);
                //输出密文
                this.tb_DE_Encrypt_AES.Text = strEncode;
            }
            catch (Exception ex)
            {
                this.tb_DE_Encrypt_AES.Text = ex.Message;
            }
        }
        #endregion

        #region DES
        private void tb_DE_Decrypt_DES_TextChanged(object sender, EventArgs e)
        {
            //秘钥为空直接返回
            string key = this.tb_DE_PassWord_DES_Key.Text.Trim();
            string iv = this.tb_DE_PassWord_DES_Iv.Text.Trim();
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(iv))
            {
                this.tb_DE_Encrypt_DES.Text = string.Empty;
                return;
            }
            //获取明文
            string strDecrypt = this.tb_DE_Decrypt_DES.Text;
            //加密
            DES_CryptHelper crypt = new DES_CryptHelper();
            crypt.Key = key;
            crypt.IV = iv;
            string strEncode = crypt.EncryptString(strDecrypt);
            //输出密文
            this.tb_DE_Encrypt_DES.Text = strEncode;
        }
        #endregion

        #region MD5
        private void tb_DE_Decrypt_MD5_TextChanged(object sender, EventArgs e)
        {
            //获取明文
            string strDecrypt = this.tb_DE_Decrypt_MD5.Text;
            //加密
            string strEncode = MD5_CryptHelper.GenerateMD5(strDecrypt);
            //输出密文
            this.tb_DE_Encrypt_MD5.Text = strEncode;
        }
        #endregion

        #endregion
    }
}