using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[]args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2000, FirstName = "Esra", LastName = "Akat", IdentityNumber = 12345});
        }
    }
}