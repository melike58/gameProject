using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
    interface IGamerService
    {
        void add(Gamer gamer);
        void delete(Gamer gamer);
        void update(Gamer gamer);
    }
}
