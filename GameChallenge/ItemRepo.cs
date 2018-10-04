using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    class ItemRepo
        {
            private void NanoHeal(Hero hero)
            {
                if (hero.Health + 20 > hero.MaxHealth)
                {
                    hero.Health = hero.MaxHealth;
                }
                else
                {
                    hero.Health += 20;
                }
            }
        }
    }

