using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Hornet : Character
    {
        public Hornet(string name, float hp, float power) : base(name, hp, power)
        {
        }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に毒針を刺す！");
            if (destination.poisonResistance == false)
            {
                destination.hp = 0;
                Console.WriteLine($"{destination.name}は致死毒を受け倒れた...");
            }
            else
            {
                Console.WriteLine($"しかし{destination.name}には効果がなかった...");
            }
        }
    }
}
