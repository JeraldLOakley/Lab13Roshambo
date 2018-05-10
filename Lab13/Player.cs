using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
   public abstract class Player
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private Roshambo hand;
        public Roshambo Hand { get => hand; set => hand = value; }

        public Player(string name)
        {
            Name = name;
        }

      
        
        public abstract Roshambo GenerateRoshambo();
        
    }
}
