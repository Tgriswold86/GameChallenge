using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    class ItemRepo
        {
            public void UseI(Hero hero, IShopItem item)
            {
                switch (item.Name)
                {
                    case "Overdrive":
                        player.Weapon.Damage += 20;
                        break;
                }


                player._inventory.Remove(item);
            }

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

