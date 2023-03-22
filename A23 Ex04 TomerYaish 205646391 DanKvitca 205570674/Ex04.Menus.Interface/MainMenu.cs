using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interface
{
    // $G$ CSS-999 (-12) Missing blank lines in the appropriate places.
    public class MainMenu
    {
        private const string k_TitleSeperator = "=============================";
        private const string k_ExitOption = "0) Exit";
        private const string k_BackOption = "0) Back";
        private const string k_ChooseRequest = "Please enter your choice.";
        private const string k_InvalidInputOutOfBounds = "Invalid input: input must be between 0 and {0}, please enter a valid input:";
        private const string k_InvalidInputNotADigit = "Invalid input: input must be a digit, please enter a valid input:";
        private const string k_PressToContinue = "Press any key to continue";
        private const int k_ExitOrBackNumRepresntation = 0;
        private MenuItem m_MainMenu;
        public MainMenu(MenuItem i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }
        public void Show()
        {
            showMenu(m_MainMenu, k_ExitOption);
        }
        private void showMenu(MenuItem i_Menu, string i_BackOrExitOption)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int userInput;
            int index;
            while (true)
            {
                Console.Clear();
                index = 1;
                stringBuilder.Length = 0;

                stringBuilder.Append(string.Format(
@"{0}
{1}
{2}
", i_Menu.Title, k_TitleSeperator, i_BackOrExitOption));

                foreach (MenuItem menuItem in i_Menu.SubItems)
                {
                    stringBuilder.Append(string.Format(
@"{0}) {1} 
", index, menuItem.Title));
                    index++;
                }
                Console.WriteLine(stringBuilder.ToString());
                userInput = getInput(i_Menu.SubItems.Count);
                Console.Clear();
                if (userInput == k_ExitOrBackNumRepresntation)
                {
                    break;
                }
                else
                {
                    MenuItem subItem = i_Menu.SubItems[userInput - 1];
                    if (subItem.IsSubMenu())
                    {
                        showMenu(subItem, k_BackOption);
                    }
                    else
                    {
                        (subItem as ItemMethod).DoSomething();
                        Console.WriteLine("{0}{1}", Environment.NewLine, k_PressToContinue);
                        Console.ReadKey();
                    }
                }
            }
        }
        private int getInput(int i_MaxIntValue)
        {
            int userInput;
            string stringUserInput;

            Console.WriteLine(k_ChooseRequest);
            while (true)
            {
                stringUserInput = Console.ReadLine();
                if (int.TryParse(stringUserInput, out userInput))
                {
                    if (userInput > i_MaxIntValue || userInput < 0)
                    {
                        Console.WriteLine(string.Format(k_InvalidInputOutOfBounds, i_MaxIntValue));
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(k_InvalidInputNotADigit);
                }
            }
            return userInput;
        }
    }
}
