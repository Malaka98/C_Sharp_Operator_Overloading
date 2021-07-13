using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Operator_Overloading
{
    internal class Baby
    {
        private readonly string Parent;
        public Baby(string Parent)
        {
            this.Parent = Parent;
        }

        public void ShowParent()
        {
            Console.WriteLine(Parent + "{ 0 }");
        }
     }
}
