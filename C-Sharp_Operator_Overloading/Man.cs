using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Operator_Overloading
{
    internal class Man
    {
        private string name;

        private string GetName()
        {
            return name;
        }

        private void SetName(string name)
        {
            this.name = name;
        }
        public Man(string name)
        {
            this.name = name;
        }

        public static Baby operator +(Man m, Women w)
        {
            return new Baby("Babys' father name is " + m.name + " " + "Babys' Mother name is " + w.GetName());
        }

    }
}
