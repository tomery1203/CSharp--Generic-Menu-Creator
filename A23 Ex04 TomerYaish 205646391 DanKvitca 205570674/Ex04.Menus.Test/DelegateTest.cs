using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;


namespace Ex04.Menus.Test
{
    internal class DelegateTestcs
    {
        private MainMenu m_Menu;
        public DelegateTestcs()
        {
            createMainMenu();
        }
        public void Run()
        {
            m_Menu.Show();
        }
        private void createMainMenu()
        {
            MenuItem mainMenu = new MenuItem("Delegate Main Menu");
            MenuItem showDateTimeMenu = createShowVersionAndUppercaseMenu();
            MenuItem infoMenu = createShowDateAndTimeMenu();
            mainMenu.SubItems.Add(showDateTimeMenu);
            mainMenu.SubItems.Add(infoMenu);
            m_Menu = new MainMenu(mainMenu);
        }
        private MenuItem createShowVersionAndUppercaseMenu()
        {
            MenuItem ShowVersionAndUppercase = new MenuItem("Version and Upercase");
            MenuItem ShowVersion = new MenuItem("Show Version");
            ShowVersion.Selected += showVersion_Selected;
            MenuItem countUppercaseLetters = new MenuItem("Count Uppercase");
            countUppercaseLetters.Selected += countUppercase_Selected;
            ShowVersionAndUppercase.SubItems.Add(ShowVersion);
            ShowVersionAndUppercase.SubItems.Add(countUppercaseLetters);
            return ShowVersionAndUppercase;

        }
        private MenuItem createShowDateAndTimeMenu()
        {
            MenuItem DateAndTimeMenu = new MenuItem("Show Date/Time");
            MenuItem ShowDate = new MenuItem("Show Date");
            ShowDate.Selected += showDate_Selected;
            MenuItem showTime = new MenuItem("Show Time");
            showTime.Selected += showTime_Selected;
            DateAndTimeMenu.SubItems.Add(ShowDate);
            DateAndTimeMenu.SubItems.Add(showTime);
            return DateAndTimeMenu;
        }
        private void showVersion_Selected(MenuItem i_MenuItem)
        {
            LogicalMethods.ShowVersion();
        }
        private void countUppercase_Selected(MenuItem i_MenuItem)
        {
            LogicalMethods.CountUpperCaseLetters();
        }
        private void showDate_Selected(MenuItem i_MenuItem)
        {
            LogicalMethods.ShowDate();
        }
        private void showTime_Selected(MenuItem i_MenuItem)
        {
            LogicalMethods.ShowTime();
        }
    }
}
