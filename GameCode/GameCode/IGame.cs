using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode
{
    interface IGame
    {
        IGame AddEnemy(IEnemy enemy);

        IGame AddPlayer(IPlayer player);

        void Play();
    }
}
