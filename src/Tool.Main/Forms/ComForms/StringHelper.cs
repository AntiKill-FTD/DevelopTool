using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Business.Common;

namespace Tool.Main.Forms.ComForms
{
    public partial class StringHelper : Form
    {
        private CryptHelper cryptHelper = new CryptHelper();

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
                if (item.StartsWith(addString))
                {
                    item = item.Substring(addLength);
                }
                else
                {
                    item = addString + item;
                }
                disListNew.Add(item.Trim());
            });
            //换行拼接
            string newDistination = string.Join('\n', disListNew);
            this.rtb_StringList_Distination.Text = newDistination;
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

    }
}
