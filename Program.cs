using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationService());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Fırat",
                LastName = "İke",
                IdentityNumber = 123456789,
            });

            Console.ReadKey();
        }
    }
}
