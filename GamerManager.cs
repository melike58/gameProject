using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class GamerManager : IGamerService

    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void add(Gamer gamer)
        {
            if (_userValidationService.validate(gamer) == true)
            {
               Console.WriteLine("Oyuncu Sisteme Eklendi : "+gamer.name);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız ");
            }
            
        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Sistemden Silindi :  " + gamer.name);
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Sistemde Güncellendi :  " + gamer.name);
        }
    }
}
