using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    // $G$ CSS-999 (-3) The class must have an access modifier.
    class Program
    {
        // $G$ CSS-999 (-3) The method must have an access modifier.
        static public void Main(String[] args)
        {
            InterfaceTest interfaceTest = new InterfaceTest();
            interfaceTest.Run();
            DelegateTestcs delegateTest = new DelegateTestcs();
            delegateTest.Run();
        }
    }
}
