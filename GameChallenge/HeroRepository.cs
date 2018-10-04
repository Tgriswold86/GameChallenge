using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    class HeroRepository 
    {
        // Field 
        public Hero _hero;


        public void CreateCharacter()
        {
            Console.Clear();
            Console.Write("What is your name, soldier? ");
            var name = Console.ReadLine();

            _hero = new Hero
            {
                Name = name,
                Health = 100,
                ATKPower = 20,

            };
        }
    }
}

