using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameChallenge
{
    class HeroRepository : ICharacter
    {
        // Field 
        private Hero _hero;
        public void CreateCharacter(string name)
        {
            _hero = new Hero
            {
                Name = name,
                IsAlive = true,
                ATKPower = 10,
                Health = 100,
                NumberOfLives = 3
            };
        }
        public Character CharacterDetails()
        {
            return _hero;
        }
        public void TakeDamage(int attackDamage)
        {
            _hero.Health -= attackDamage;
        }
    }
}