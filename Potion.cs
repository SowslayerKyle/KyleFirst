using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHW5
{
    class Potion:Item
    {
        public override void UseItem()
        {
            name = "藥水";
        }
        public void UsePotion(Player player)
        {
            if (player.cntPotion <= 0)
            {
                Console.WriteLine("沒有可用的藥水");
            }
            else 
            {
                player.cntPotion--;
                player.hp = player.hp + 50;
                if (player.hp > player.hpMax)
                {
                    player.hp = player.hpMax;
                }
                Console.WriteLine($"{player.name}使用藥水,當前生命:{player.hp}");
            }
        }
        public void UsePotion(Ememy ememy)
        {
            ememy.cntPotion--;
            ememy.hp = ememy.hp + 50;
            if (ememy.hp > ememy.hpMax)
            {
                ememy.hp = ememy.hpMax;
            }
            Console.WriteLine($"{ememy.name}使用藥水,當前生命:{ememy.hp}");
        }
    }
}
