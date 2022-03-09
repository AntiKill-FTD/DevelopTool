using System.Data;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting;
using Tool.Business.SysMenu;
using Tool.Data;
using Tool.IService.Model.Sys;
using Tool.IService.SysMenu;

namespace Tool.Service.SysMenu
{
    public class MenuService : IMenuService
    {
        //Static 
        public Form MainForm { get; set; }
        public List<ToolStripMenuItem> toolStripMenuItems { get; set; }

        //MenuObject
        private List<Menu> menus;
        private List<FullMenuEntity> fullMenuList;

        //DbContext
        private DeveloperToolContext _developerToolContext;

        /// <summary>
        /// Ctor
        /// </summary>
        public MenuService(DeveloperToolContext _iDeveloperToolContext)
        {
            //Injection
            _developerToolContext = _iDeveloperToolContext;

            //菜单管理对应实例
            if (!MenuStaticObject.MenuCodeUrl.ContainsKey("00.01"))
            {
                MenuStaticObject.MenuCodeUrl.Add("00.01", "Tool.Main|Tool.Main.Forms.MainForms|MenuSet");
            }
        }

        /// <summary>
        /// 创建菜单
        /// </summary>
        public void CreateMenu()
        {
            //获取所有菜单
            menus = _developerToolContext.Menus.Where(item => 1 == 1).ToList();

            //递归创建菜单实体
            CreateFirstMenu();

            //创建菜单控件
            CreateMenuControl();
        }

        /// <summary>
        /// 打开菜单管理界面
        /// </summary>
        public void OpenMenuManage()
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem();

            //菜单管理的menuCode定义为00.01
            menuItem.Name = "00.01";
            menuItem.Text = "菜单管理";

            //调用公共事件打开窗体
            MenuClick(menuItem, null);
        }

        #region Private Create Recursion

        /// <summary>
        /// 创建一级菜单
        /// </summary>
        /// <param name="menuDt"></param>
        private void CreateFirstMenu()
        {
            //获取所有一级菜单
            List<Menu> menuLF = menus.Where(item => item.Level == 1).ToList();
            //定义一级菜单集合
            fullMenuList = new List<FullMenuEntity>();
            //循环创建一级实例
            foreach (Menu item in menuLF)
            {
                FullMenuEntity fullMenuEntity = new FullMenuEntity { currentMenu = item, childMenu = new List<FullMenuEntity>() };
                fullMenuList.Add(fullMenuEntity);
            }
            //递归一级实例插入子集
            foreach (FullMenuEntity fullMenuEntity in fullMenuList)
            {
                //插入全局静态MenuCodeUrl，事件使用
                string menuUrl = fullMenuEntity.currentMenu.Assembly + "|" + fullMenuEntity.currentMenu.NameSpace + "|" + fullMenuEntity.currentMenu.EntityName;
                MenuStaticObject.MenuCodeUrl.Add(fullMenuEntity.currentMenu.MenuCode, menuUrl);
                //递归
                RecursionEntity(fullMenuEntity);
            }
        }

        /// <summary>
        /// 递归子集菜单
        /// </summary>
        /// <param name="RecursionEntity"></param>
        private void RecursionEntity(FullMenuEntity fullMenuEntity)
        {
            //获取所有子集
            List<Menu> childMenus = menus.Where(item => item.ParentCode == fullMenuEntity.currentMenu.MenuCode).ToList();

            //循环创建子集实例
            foreach (Menu item in childMenus)
            {
                //转换对象
                FullMenuEntity childMenu = new FullMenuEntity { currentMenu = item, childMenu = new List<FullMenuEntity>() };
                //插入全局静态MenuCodeUrl，事件使用
                string menuUrl = childMenu.currentMenu.Assembly + "|" + childMenu.currentMenu.NameSpace + "|" + childMenu.currentMenu.EntityName;
                MenuStaticObject.MenuCodeUrl.Add(childMenu.currentMenu.MenuCode, menuUrl);
                //递归子集
                RecursionEntity(childMenu);
                //子集归入父级
                fullMenuEntity.childMenu.Add(childMenu);
            }
        }

        /// <summary>
        /// 创建菜单控件
        /// </summary>
        private void CreateMenuControl()
        {
            toolStripMenuItems = new List<ToolStripMenuItem>();
            foreach (FullMenuEntity fullMenu in fullMenuList)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                RecursionControl(fullMenu, toolStripMenuItem);
                toolStripMenuItems.Add(toolStripMenuItem);
            }
        }

        /// <summary>
        /// 递归创建菜单控件
        /// </summary>
        /// <param name="fullMenu"></param>
        /// <returns></returns>
        private void RecursionControl(FullMenuEntity fullMenu, ToolStripMenuItem toolStripParentMenuItem)
        {
            //赋值当前父级菜单控件
            toolStripParentMenuItem.Text = fullMenu.currentMenu.MenuName;
            toolStripParentMenuItem.Name = fullMenu.currentMenu.MenuCode;
            if (fullMenu.currentMenu.IfEnd == 1)
            {
                toolStripParentMenuItem.Click += MenuClick;
                toolStripParentMenuItem.ForeColor = Color.DarkBlue;
            }
            else if (fullMenu.currentMenu.Level != 1)
            {
                toolStripParentMenuItem.BackColor = Color.LightBlue;
            }

            //循环子集DropDown
            foreach (FullMenuEntity fullChildMenu in fullMenu.childMenu)
            {
                //创建子集菜单控件
                ToolStripMenuItem toolStripChildMenuItem = new ToolStripMenuItem();
                toolStripChildMenuItem.Text = fullChildMenu.currentMenu.MenuName;
                toolStripChildMenuItem.Name = fullChildMenu.currentMenu.MenuCode;
                //递归处理子集菜单控件
                RecursionControl(fullChildMenu, toolStripChildMenuItem);
                //添加到父级
                toolStripParentMenuItem.DropDown.Items.Add((ToolStripItem)toolStripChildMenuItem);
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// MenuClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClick(object sender, EventArgs e)
        {
            try
            {
                //转换为菜单
                ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                //获取跳转地址
                string menuCode = menuItem.Name;
                string menuText = menuItem.Text;
                string instanceName = MenuStaticObject.MenuCodeUrl[menuCode];
                //检查是否已经打开
                if (!MenuStaticObject.OpenMenuList.ContainsKey(menuCode))
                {
                    //打开窗体
                    OpenNewForm(menuCode, instanceName);
                    //添加菜单清单
                    AddMenuList(menuCode, menuText);
                }
                else
                {
                    //打开原有窗体
                    OpenOldForm(menuCode);
                }
                //设置菜单栏状态
                ChangeToolItemStatus();
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// OpenNewForm
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="instanceName"></param>
        private void OpenNewForm(string menuCode, string instanceName)
        {
            try
            {
                //拆分instanceName
                string[] instanceLists = instanceName.Split('|');
                string assembly = instanceLists[0];
                string nameSpace = instanceLists[1];
                string entityName = instanceLists[2];
                //创建窗体实例
                ObjectHandle obj = Activator.CreateInstance(assembly, nameSpace + "." + entityName);
                Form childForm = (Form)obj.Unwrap();
                //设置窗体属性
                childForm.MdiParent = MainForm;
                childForm.Name = menuCode;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                //插入到容器panelMdiContainer
                Panel containerPanel = (Panel)MainForm.Controls["panelMain"].Controls["panelMdiContainer"];
                containerPanel.Controls.Add(childForm);
                //显示窗体
                childForm.Show();
                //1.更新当前窗口为最新窗口
                MenuStaticObject.MenuList_OpenNewForm(menuCode);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// AddMenuList
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="menuText"></param>
        private void AddMenuList(string menuCode, string menuText)
        {
            try
            {
                //定义打开菜单
                ToolStripButton menuItem = new ToolStripButton();
                //属性定义
                ResourceManager resourceManager = new ResourceManager("Tool.Service.Properties.Resources", Assembly.GetAssembly(Type.GetType("Tool.Service.Properties.Resources")));
                Bitmap bitmapClose = (Bitmap)(resourceManager.GetObject("menuClose64"));
                Bitmap bitmapBlueBack = (Bitmap)(resourceManager.GetObject("BackColorBlue"));
                //属性赋值
                menuItem.CheckState = CheckState.Checked;
                menuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                menuItem.Image = bitmapClose;
                menuItem.BackgroundImage = bitmapBlueBack;
                menuItem.BackgroundImageLayout = ImageLayout.Stretch;
                menuItem.Name = menuCode;
                menuItem.Text = menuText;
                menuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
                menuItem.AutoToolTip = false;
                //添加点击事件
                menuItem.Click += SwitchMenuClick;
                //添加到打开列表
                ToolStrip menuListPanel = (ToolStrip)MainForm.Controls["panelMain"].Controls["panelMenuList"].Controls["toolStripMenuList"];
                menuListPanel.Items.Insert(0, menuItem);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// OpenOldForm
        /// </summary>
        /// <param name="menuCode"></param>
        private void OpenOldForm(string menuCode)
        {
            try
            {
                //1.更新当前窗口为最新窗口
                MenuStaticObject.MenuList_OpenOldForm(menuCode);
                //2.切换菜单
                Panel mdiPanel = (Panel)MainForm.Controls["panelMain"].Controls["panelMdiContainer"];
                foreach (Control co in mdiPanel.Controls)
                {
                    if (co.Name == menuCode)
                    {
                        ((Form)co).Visible = true;
                    }
                    else
                    {
                        ((Form)co).Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// ChangeToolItemStatus
        /// </summary>
        private void ChangeToolItemStatus()
        {
            try
            {
                //获取菜单清单中，index分别为1,2的菜单
                string currentMenuCode = MenuStaticObject.CurrentMenuCode;
                string nextMenuCode = MenuStaticObject.NextMenuCode;

                //获取toolStrip，循环设置状态
                ToolStrip menuListPanel = (ToolStrip)MainForm.Controls["panelMain"].Controls["panelMenuList"].Controls["toolStripMenuList"];
                foreach (ToolStripItem item in menuListPanel.Items)
                {
                    //获取并转换对象
                    ToolStripButton sb = (ToolStripButton)item;
                    //1.修改上次打开窗体属性
                    if (nextMenuCode != string.Empty && sb.Name == nextMenuCode)
                    {
                        //赋值属性
                        sb.BackgroundImage = null;
                        sb.CheckState = CheckState.Unchecked;
                        sb.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    }
                    //2.修改本次打开窗体属性
                    if (currentMenuCode != string.Empty && sb.Name == currentMenuCode)
                    {
                        //属性定义
                        ResourceManager resourceManager = new ResourceManager("Tool.Service.Properties.Resources", Assembly.GetAssembly(Type.GetType("Tool.Service.Properties.Resources")));
                        Bitmap bitmapBlueBack = (Bitmap)(resourceManager.GetObject("BackColorBlue"));
                        //赋值属性
                        sb.BackgroundImage = bitmapBlueBack;
                        sb.BackgroundImageLayout = ImageLayout.Stretch;
                        sb.CheckState = CheckState.Checked;
                        sb.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// OpenMenuClick:切换菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchMenuClick(object sender, EventArgs e)
        {
            try
            {
                //转换为菜单
                ToolStripButton toolStripButton = (ToolStripButton)sender;
                //获取menuCode
                string menuCode = toolStripButton.Name;
                //获取当前菜单Code
                string currentMenuCode = MenuStaticObject.CurrentMenuCode;

                //如果选中菜单不是当前展示菜单,切换菜单
                if (menuCode != currentMenuCode)
                {
                    //OpenOldForm
                    OpenOldForm(menuCode);
                    //设置菜单栏状态
                    ChangeToolItemStatus();
                }
                else
                {
                    //判断是否点击了关闭
                    //按钮占用了  (字符长度 + 24px)   *     24px
                    Rectangle rectButton = toolStripButton.Bounds;
                    rectButton.X = rectButton.X + rectButton.Width - 24;
                    rectButton.Width = 24;
                    //获取点击的相对位置
                    ToolStrip menuListPanel = (ToolStrip)MainForm.Controls["panelMain"].Controls["panelMenuList"].Controls["toolStripMenuList"];
                    Point p = menuListPanel.PointToClient(Control.MousePosition);
                    //判断点击位置是否在rectButton内部（点击了关闭）
                    if (rectButton.Contains(p))
                    {
                        //当前toolTrip中移除该菜单
                        menuListPanel.Items.RemoveByKey(menuCode);
                        //panelMdiContainer容器中移除该Form
                        Panel containerPanel = (Panel)MainForm.Controls["panelMain"].Controls["panelMdiContainer"];
                        containerPanel.Controls.RemoveByKey(menuCode);
                        //全局静态变量移除该菜单
                        MenuStaticObject.MenuList_CloseForm(menuCode);

                        //1.获取最新显示菜单并展示窗体
                        string newCurrentMenuCode = MenuStaticObject.CurrentMenuCode;
                        //2.切换菜单
                        Panel mdiPanel = (Panel)MainForm.Controls["panelMain"].Controls["panelMdiContainer"];
                        foreach (Control co in mdiPanel.Controls)
                        {
                            if (co.Name == newCurrentMenuCode)
                            {
                                ((Form)co).Visible = true;
                            }
                            else
                            {
                                ((Form)co).Visible = false;
                            }
                        }

                        //设置菜单栏状态
                        ChangeToolItemStatus();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

    }
}
