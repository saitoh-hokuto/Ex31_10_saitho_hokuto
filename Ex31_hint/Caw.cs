using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Caw : Character
    {
        public int bullet = 0;
        public Caw(string name, float hp, float power) : base(name, hp, power) { }
        public override void Attack(Character destination)
        {
            if (hp >= 5)
            {
                bullet--;
                Console.WriteLine($"{this.name}は{destination.name}を角で突く！");
                Console.WriteLine($"{destination.name}に痛恨の一撃！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は疲れ果てている！");
            }
        }      
    }
}