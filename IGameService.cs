using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
    interface IGameService
    {
        void add(Game game);
        void delete(Game game);
        void update(Game game);
    }
}
