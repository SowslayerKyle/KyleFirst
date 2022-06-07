using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHW5
{
    /// <summary>
    /// 玩家
    /// </summary>
    class Player:Npc
    {
        public int atk = 40;
        public int InventorySpace = 10;
        public int hpMax = 100;
        public override void CheckState()
        {
            if (hp <= 0 && isDead == false)
            {
                isDead = true;
                hp = 0;
                Console.WriteLine("你已經死了");
            }
        }
        public void Info() 
        {
            Console.WriteLine($"目前狀態\n攻擊力:{atk}\n生命值:{hp}");
            for (int i = 0; i < bag.Length; i++) 
            {
                Console.WriteLine($"物品欄{i+1}:{bag[i]}");
            }
        }
        
        public void NormalAttk(Ememy ememy) 
        {
            ememy.hp = ememy.hp - atk;
            Console.WriteLine($"對{ememy.name}進行攻擊");
        }
        public void NormalAttk(Villager villager)
        {
            villager.hp = villager.hp - atk;
        }
        public void NormalAttk(Guard guard) 
        {
            guard.hp = guard.hp - atk;

        }

    }
}
