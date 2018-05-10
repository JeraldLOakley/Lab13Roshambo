using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab13
{
    class User:Player
    {
        string UserName = Console.ReadLine();
        public User(string Name) : base(Name)
        {
            Name = UserName;
        }

        
        public  override Roshambo GenerateRoshambo()
        {           
            string UserChoice = Console.ReadLine().ToLower();
            Roshambo Uchoice = (Roshambo)Enum.Parse(typeof(Roshambo), UserChoice);
            return Uchoice;            
        }
        public override string ToString()
        {
            return $"{ UserName}";
        }

    }
}
