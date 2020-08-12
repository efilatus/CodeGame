using System;
using System.Collections.Generic;
using System.Text;

namespace GameCode
{
    class Game : IGame
    {
        private IEnemy _factory;
        private IPlayer _player;

        public IGame AddEnemy(IEnemy factory)
        {
            _factory = factory;
            return this;
        }

        public IGame AddPlayer(IPlayer player)
        {
            _player = player;
            return this;
        }

        public void Play()
        {
            if (_player == null)
            {
                throw new NullReferenceException(nameof(_player));
            }

            if (_factory == null)
            {
                throw new NullReferenceException(nameof(_factory));
            }

        }
    }
}
