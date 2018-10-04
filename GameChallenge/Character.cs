using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int ATKPower { get; set; }
        public bool IsAlive { get; set; }

        public bool CheckIfAlive(int health)
        {
            bool currentalive = false;

            if (Health > 0)
            {
                currentalive = true;
            }
            return currentalive;
        }
    }
}
