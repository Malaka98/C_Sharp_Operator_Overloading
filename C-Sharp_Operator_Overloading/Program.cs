using System;

namespace C_Sharp_Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man("abc");
            Women w = new Women("xyz");

            Baby b = m + w;
            b.ShowParent();
        }
    }
}
