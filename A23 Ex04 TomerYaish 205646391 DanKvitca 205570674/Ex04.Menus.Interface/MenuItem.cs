using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interface
{
    public class MenuItem
    {
        private List<MenuItem> m_SubItems;
        private string m_Title;
        public MenuItem(string i_Title)
        {
            m_SubItems = new List<MenuItem>();
            m_Title = i_Title;
        }
        public List<MenuItem> SubItems
        {
            get { return m_SubItems; }
        }
        public string Title
        {
            get { return m_Title; }
        }
        internal bool IsSubMenu()
        {
            bool isSubMenu = true;
            if (m_SubItems.Count == 0)
            {
                isSubMenu = false;
            }
            return isSubMenu;
        }
    }
}
