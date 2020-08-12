using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode
{
    /// <summary>
    /// Абстракция присущее всем хуманойдам
    /// </summary>
    interface IEnemy
    {
        int Damage { get; }
        int Life { get; }

        int Attack();
        int SkillAttack();
    }
}
