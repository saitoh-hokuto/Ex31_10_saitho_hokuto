using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("すべてを受け止める男", 9999, 128);
            Cat cat = new Cat("果てしなく強い猫", 16000, 1240);
            Caw caw = new Caw("止まることを知らない牛", 25000, 2080);
            Tank tank = new Tank("YMT-05　ヒルドルブ", 250000, 2580);
            Hornet hornet = new Hornet("ハチくん", 500, 250);
            tank.bullet = 10;
            Character[] characters = { character, tank, cat, caw, hornet};
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character);
            }
        }
    }
}
