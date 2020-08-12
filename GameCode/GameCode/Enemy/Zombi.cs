using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode.Humanoid
{
    class Zombi : IEnemy
    {
        public int Damage { get; }
        public int Life { get; }

        public int Attack()
        {
            Console.WriteLine("Удар рукой");
            return Damage;
        }

        public int SkillAttack()
        {
            Console.WriteLine("Укус");
            return 5;
        }

        public Zombi()
        {
            Damage = 3;
            Life = 10;
        }
    }
}
