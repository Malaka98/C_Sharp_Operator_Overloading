using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Operator_Overloading
{
    internal class Women
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public Women(string Name)
        {
            this.SetName(Name);
        }
    }
}
