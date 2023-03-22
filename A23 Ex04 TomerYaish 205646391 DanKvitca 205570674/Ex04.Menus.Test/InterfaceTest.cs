using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Test;
using Ex04.Menus.Interface;
namespace Ex04.Menus.Test
{

    // $G$ CSS-999 (-5) Unnecessary blank lines.

    internal class InterfaceTest
    {
        private MainMenu m_Menu;
        public InterfaceTest()
        {
            createMainMenu();
        }
        public void Run()
        {
            m_Menu.Show();
        }
        private void createMainMenu()
        {
            MenuItem mainMenu = new MenuItem("Interface Main Menu");
            MenuItem infoMenu = createVersionAndUpeercaseMenu();
            MenuItem showDateTimeMenu = createShowDateTimeMenu();
            mainMenu.SubItems.Add(infoMenu);
            mainMenu.SubItems.Add(showDateTimeMenu);
            m_Menu = new MainMenu(mainMenu);
        }
        private MenuItem createVersionAndUpeercaseMenu()
        {
            MenuItem VersionAndUppercase = new MenuItem("Version and Uppercase");
            ShowVersion showVersion = new ShowVersion();
            CountUpperLetters countUppercase = new CountUpperLetters();
            VersionAndUppercase.SubItems.Add(showVersion);
            VersionAndUppercase.SubItems.Add(countUppercase);
            return VersionAndUppercase;
        }
        private MenuItem createShowDateTimeMenu()
        {
            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");
            ShowDate showDate = new ShowDate();
            ShowTime showTime = new ShowTime();
            showDateTimeMenu.SubItems.Add(showDate);
            showDateTimeMenu.SubItems.Add(showTime);
            return showDateTimeMenu;
        }
        private class ShowVersion : MenuItem, ItemMethod
        {
            public ShowVersion()
                : base("Show Version") { }
            public void DoSomething()
            {
                LogicalMethods.ShowVersion();
            }
        }
        private class CountUpperLetters : MenuItem, ItemMethod
        {
            public CountUpperLetters()
                : base("Count Uppercase letters") { }
            public void DoSomething()
            {
                LogicalMethods.CountUpperCaseLetters();
            }
        }
        private class ShowTime : MenuItem, ItemMethod
        {
            public ShowTime()
                : base("Show Time") { }
            public void DoSomething()
            {
                LogicalMethods.ShowTime();
            }
        }
        private class ShowDate : MenuItem, ItemMethod
        {
            public ShowDate()
                : base("Show Date") { }
            public void DoSomething()
            {
                LogicalMethods.ShowDate();
            }
        }
    }
}

