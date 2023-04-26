using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumaniMoilaPart1
{
    internal class Step
    {
        private string description = "";

        public Step(string description)
        {
            this.description = description;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }

    }
}
