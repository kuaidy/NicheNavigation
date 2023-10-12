namespace NicheNavigation.Common
{
    public static class EventDispatcher
    {
        private static Dictionary<string, Action<object>> m_Actions;
        static EventDispatcher()
        {
            m_Actions = new Dictionary<string, Action<object>>();
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="action"></param>
        /// <exception cref="Exception"></exception>
        public static void AddAction(string eventName,Action<object> action) 
        {
            if (!m_Actions.ContainsKey(eventName)) 
            {
                m_Actions.Add(eventName, action);
            }
            else
            {
                throw new Exception($"事件已存在");
            }
        }
        /// <summary>
        /// 移除事件
        /// </summary>
        /// <param name="eventName"></param>
        public static void RemoveAction(string eventName)
        {
            if (m_Actions.ContainsKey(eventName)) 
            {
                m_Actions.Remove(eventName);
            }
        }
        /// <summary>
        /// 执行事件
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="value"></param>
        public static void Dispatch(string eventName,object value)
        {
            if (m_Actions.ContainsKey(eventName))
            {
                var action = m_Actions[eventName];
                action.Invoke(value);
            }
        }
    }
}
