using GameProject.Concretes;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.add(new Gamer
            {
                id = 1,
                dateOfBirth = 2001,
                name = "Melike",
                lastName = "Özdoğan",
                identityNumber = 123456789
            });
            
        }
    }
}
