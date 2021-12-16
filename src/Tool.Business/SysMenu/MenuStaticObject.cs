namespace Tool.Business.SysMenu
{
    public static class MenuStaticObject
    {
        /// <summary>
        /// MenuCodeUrl
        /// T String : MenuCode
        /// T String : MenuUrl
        /// </summary>
        public static Dictionary<string, string> MenuCodeUrl = new Dictionary<string, string>();

        /// <summary>
        /// OpenMenuList
        /// T String : MenuCode
        /// T Int32  : Index
        /// </summary>
        public static Dictionary<string, int> OpenMenuList = new Dictionary<string, int>();

        /// <summary>
        /// 获取当前打开的窗口
        /// </summary>
        public static string CurrentMenuCode
        {
            get { return MenuList_GetMenuCodeByIndex(1); }
        }

        /// <summary>
        /// 获取第二个菜单,当切换菜单的时候,第二个打开的菜单就是切换之前打开的菜单
        /// </summary>
        public static string NextMenuCode
        {
            get { return MenuList_GetMenuCodeByIndex(2); }
        }

        /// <summary>
        /// 打开新的窗口,将打开的新窗口置为CurrentMenu
        /// </summary>
        /// <param name="menuCode"></param>
        public static void MenuList_OpenNewForm(string menuCode)
        {
            //循环，所有index+1
            List<string> keys = OpenMenuList.Keys.ToList();
            foreach (string key in keys)
            {
                OpenMenuList[key] += 1;
            }
            //更新选中菜单为1
            OpenMenuList.Add(menuCode, 1);
        }

        /// <summary>
        /// 切换到已经打开的窗口,将已打开的窗口置为CurrentMenu
        /// </summary>
        /// <param name="menuCode"></param>
        public static void MenuList_OpenOldForm(string menuCode)
        {
            //获取当前序号
            int currentIndex = OpenMenuList[menuCode];
            //循环，所有index在currentIndex之前的+1
            List<string> keys = OpenMenuList.Keys.ToList();
            foreach (string key in keys)
            {
                if (OpenMenuList[key] < currentIndex)
                {
                    OpenMenuList[key] += 1;
                }
            }
            //更新选中菜单为1
            OpenMenuList[menuCode] = 1;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="menuCode"></param>
        public static void MenuList_CloseForm(string menuCode)
        {
            //获取当前序号
            int currentIndex = OpenMenuList[menuCode];
            //循环，所有index在currentIndex之后的-1
            List<string> keys = OpenMenuList.Keys.ToList();
            foreach (string key in keys)
            {
                if (OpenMenuList[key] > currentIndex)
                {
                    OpenMenuList[key] -= 1;
                }
            }
            //移除关闭的菜单
            OpenMenuList.Remove(menuCode);
        }

        /// <summary>
        /// 根据Index序号获取菜单
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string MenuList_GetMenuCodeByIndex(int index)
        {
            //循环
            List<string> keys = OpenMenuList.Keys.ToList();
            foreach (string key in keys)
            {
                if (OpenMenuList[key] == index)
                {
                    return key;
                }
            }

            return string.Empty;
        }
    }
}