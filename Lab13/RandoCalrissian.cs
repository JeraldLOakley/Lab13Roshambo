using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RandoCalrissian:Player
    {

        public RandoCalrissian(string Name) : base(Name)
        {

        }
         Random choice = new Random();
        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)choice.Next(0,3);
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
