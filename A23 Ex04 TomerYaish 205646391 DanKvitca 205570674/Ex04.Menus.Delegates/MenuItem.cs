using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    // $G$ CSS-999 (-12) Missing blank lines in the appropriate places.
    public class MenuItem
    {
        public event Action<MenuItem> Selected;
        // $G$ DSN-999 (-3) This List should be readonly.
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
        public void OnSelected()
        {
            if (Selected != null)
            {
                Selected(this);
            }
        }
    }
}
