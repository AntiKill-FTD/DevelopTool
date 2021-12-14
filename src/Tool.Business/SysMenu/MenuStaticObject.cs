namespace Tool.Business.SysMenu
{
    public static class MenuStaticObject
    {
        /// <summary>
        /// MenuCodeUrl
        /// </summary>
        public static Dictionary<string, string> MenuCodeUrl = new Dictionary<string, string>();

        /// <summary>
        /// OpenMenuList
        /// </summary>
        public static Dictionary<string, Int32> OpenMenuList = new Dictionary<string, Int32>();

        public static string CurrentMenuCode
        {
            get { return MenuList_GetMenuCodeByIndex(1); }
        }

        public static string LastMenuCode
        {
            get { return MenuList_GetMenuCodeByIndex(2); }
        }

        public static void MenuList_OpenNewForm(string menuCode)
        {
            //循环，所有index+1
            List<string> keys = OpenMenuList.Keys.ToList<string>();
            foreach (string key in keys)
            {
                OpenMenuList[key] += 1;
            }
            //更新选中菜单为1
            OpenMenuList.Add(menuCode, 1);
        }

        public static void MenuList_OpenOldForm(string menuCode)
        {
            //获取当前序号
            int currentIndex = OpenMenuList[menuCode];
            //循环，所有index在currentIndex之前的+1
            List<string> keys = OpenMenuList.Keys.ToList<string>();
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

        public static void MenuList_CloseForm(string menuCode)
        {
            //获取当前序号
            int currentIndex = OpenMenuList[menuCode];
            //循环，所有index在currentIndex之后的-1
            List<string> keys = OpenMenuList.Keys.ToList<string>();
            foreach (string key in keys)
            {
                if (OpenMenuList[key] > currentIndex)
                {
                    OpenMenuList[key] -= 1;
                }
            }
            //更新选中菜单为1
            OpenMenuList.Remove(menuCode);
        }

        public static string MenuList_GetMenuCodeByIndex(int index)
        {
            //循环
            List<string> keys = OpenMenuList.Keys.ToList<string>();
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
