namespace Tool.IService.SysMenu
{
    public interface IMenuService
    {
        //Static 
        public Form MainForm { get; set; }
        public List<ToolStripMenuItem> toolStripMenuItems { get; set; }

        /// <summary>
        /// 创建菜单
        /// </summary>
        public void CreateMenu();

        /// <summary>
        /// 打开菜单管理界面
        /// </summary>
        public void OpenMenuManage();
    }
}
