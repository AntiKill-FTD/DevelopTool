﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.CusControls.DataGridViewEx;
using Tool.Data.DataHelper;
using Tool.Data.SqlConfig;
using Tool.Service.Common;

namespace Tool.Main.Forms.MainForms.ChildForms
{
    public partial class MenuSetChild : Form
    {
        private EnumSqlType _sqlType;
        private ICommonDataHelper _dataHelper;

        public MenuSetChild(ChildMenuType type, EnumSqlType sqlType)
        {
            InitializeComponent();
            //注入
            _dataHelper = Program.ServiceProvider.GetService(typeof(ICommonDataHelper)) as ICommonDataHelper;

            //更改标题
            _sqlType = sqlType;
            if (type == ChildMenuType.Add)
            {
                this.Text = "新增菜单";
            }
            else if (type == ChildMenuType.Edit)
            {
                this.Text = "编辑菜单";
            }
            //初始化查询
            GetParentMenu();
            GetProgram();
        }

        #region 按钮

        #region 保存
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 退出
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        #endregion

        #endregion

        #region 私有方法

        #region 查询父级菜单
        private void GetParentMenu()
        {
            //获取主sql
            Dictionary<string, string> sqlDic = SqlConfig.GetSql("SQLConfig/BaseForm/MenuSet/", _sqlType.ToString());
            DataTable dt = _dataHelper.GetDataTable(sqlDic["Query"].ToString(), sqlDic["Order"].ToString());
            //处理菜单
            DataTable newDt = new DataTable();
            newDt.Columns.Add("菜单编码");
            newDt.Columns.Add("菜单名称");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //原有数据
                DataRow dr = dt.Rows[i];
                int level = (int)dr["层级"];
                string strBegin = dr["是否末级"].ToString() == "是" ? "" : "-";
                //新拼装数据
                DataRow newRow = newDt.NewRow();
                newRow["菜单编码"] = dr["菜单编码"].ToString() + "///" + dr["层级"].ToString();
                newRow["菜单名称"] = strBegin + "".PadLeft((level - 1) * 5, ' ') + dr["菜单名称"].ToString();
                newDt.Rows.Add(newRow);
            }
            this.cbx_ParentName.DataSource = newDt;
            this.cbx_ParentName.ValueMember = "菜单编码";
            this.cbx_ParentName.DisplayMember = "菜单名称";
            this.cbx_ParentName.SelectedIndex = -1;
        }
        #endregion

        #region 获取程序集
        private void GetProgram()
        {

        }
        #endregion

        #endregion


        #region 下拉框改变事件

        //父级菜单改变
        private void cbx_ParentName_SelectedValueChanged(object sender, EventArgs e)
        {
            this.tb_ParentCode.Text = String.Empty;
            this.tb_ParentLevel.Text = String.Empty;
            if (this.cbx_ParentName.SelectedValue != null)
            {
                string codeAndLevel = this.cbx_ParentName.SelectedValue.ToString();
                string[] clList = codeAndLevel.Split("///");
                if (clList.Length == 2)
                {
                    this.tb_ParentCode.Text = clList[0];
                    this.tb_ParentLevel.Text = clList[1];
                }
            }
        }
        #endregion
    }
}
