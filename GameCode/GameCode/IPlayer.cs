using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode
{
    interface IPlayer
    {
        string Name { set; get; }
        int Damage { get; }
        int Life { get; }
        bool Block { get; }

        int Attack();
        int SkillAttack();
        void BlockAttack();
    }
}
