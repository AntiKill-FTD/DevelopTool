using System.ComponentModel;
using System.Reflection;

namespace Tool.CusControls.Common
{
    public static class EventHelper
    {
        /// <summary>
        /// 移除Winform.Control对象原有事件调用列表
        /// </summary>
        /// <param name="control"></param>
        /// <param name="EventName"></param>
        public static void RemoveHanlder(Control control, string EventName)
        {
            //获取对象类型
            Type controlType = control.GetType();
            //定义搜索类型
            BindingFlags mFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Static;

            //获取Control属性Events：类型EventHandlerList
            PropertyInfo propertyInfo = controlType.GetProperty("Events", mFlags);
            EventHandlerList eventHandlerList = (EventHandlerList)propertyInfo.GetValue(control, null);
            //根据EventName获取字段对象
            FieldInfo fieldInfo = controlType.GetField("EVENT_DATAGRIDVIEW" + EventName.ToUpper(), mFlags);

            //如果字段对象不为空
            if (fieldInfo != null)
            {
                //获取该类型事件委托实例
                Delegate d = eventHandlerList[fieldInfo.GetValue(control)];
                if (d == null) return;
                //获取事件源对象EventInfo
                EventInfo eventInfo = controlType.GetEvent(EventName);
                //循环委托调用列表，从事件源中移除事件处理程序（调用列表）
                foreach (Delegate dx in d.GetInvocationList())
                    eventInfo.RemoveEventHandler(control, dx);
            }

        }
    }
}
