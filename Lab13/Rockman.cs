using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Rockman:Player
    {

        public Rockman(string Name):base(Name)
        {
            
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
