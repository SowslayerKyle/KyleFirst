using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpHW5
{
    class Npc
    {
        /// <summary>
        /// 設定NPC的基本數值
        /// </summary>
        public int hp;
        /// <summary>
        /// 確認單位是否死亡
        /// </summary>
        public bool isDead = false;
        /// <summary>
        /// 人物的名稱
        /// </summary>
        public string name;
        /// <summary>
        /// 物品欄內物品數量
        /// </summary>
        public int cntBag = 0;
        /// <summary>
        /// 物品欄
        /// </summary>
        public string[] bag = new string[10];
        /// <summary>
        /// 藥水數量
        /// </summary>
        public int cntPotion = 0;
        /// <summary>
        /// 可使用的裝甲
        /// </summary>
        public int armor = 0;
        /// <summary>
        /// 可使用的炸彈
        /// </summary>
        public int bomb = 0;

        /// <summary>
        /// 與其互動的反應
        /// </summary>
        public virtual void AI() 
        {
            Console.WriteLine("Hi，我是"+name);
        }
        public virtual void CheckState()
        {
            if (hp <= 0 && isDead == false)
            {
                isDead = true;
                hp = 0;
                Console.WriteLine("目標死了");
            }
        }
        public void GetItem() 
        {
            Random random = new Random();
            int choose = random.Next(1,4);
            Console.WriteLine($"顯示數字為{choose}");
            switch (choose) 
            {
                case 1:
                    cntPotion++;
                    Console.WriteLine($"{name}獲得藥水一瓶");
                    break;
                case 2:
                    for (int i=0;i<bag.Length;i++)
                    {
                        if (cntBag >= 10)
                        {
                            Console.WriteLine("物品欄已滿");
                            break;
                        }
                        else 
                        {
                            if (bag[i] == null)
                            {
                                cntBag++;
                                bag[i] = "裝甲";
                                armor++;
                                Console.WriteLine($"{name}獲得裝甲");
                                break;
                            }                            
                        }
                        
                    }
                    break;
                case 3:
                    for (int i = 0; i < bag.Length; i++)
                    {
                        if (cntBag >= 10)
                        {
                            Console.WriteLine("物品欄已滿");
                            break;
                        }
                        else
                        {
                            if (bag[i] == null)
                            {
                                cntBag++;
                                bag[i] = "炸彈";
                                bomb++;
                                Console.WriteLine($"{name}獲得炸彈");
                                break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
