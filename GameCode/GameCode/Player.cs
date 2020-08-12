using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode
{
    class Player : IPlayer
    {
        public string Name { set; get; }
        public int Damage { get; }
        public int Life { get; }
        public bool Block { set; get; }

        public int Attack()
        {
            if (Block)
                Block = false;
            Console.WriteLine("Удар мечом");
            return Damage;
        }

        public int SkillAttack()
        {
            if (Block)
                Block = false;
            Console.WriteLine("Огненый шар");
            return 10;
        }

        public void BlockAttack()
        {
            if(!Block)
                Block = true;
            Console.WriteLine("Поднять щит");
        }

        public Player()
        {
            Damage = 7;
            Life = 30;
        }
    }
}
