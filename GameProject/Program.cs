using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entites;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {//Eğer TC'no Doğru girilirse Hata almadan Doğru bir şekilde çalışacaktır.
            User user = new User(){Id = 1,FirstName = "ilker",LastName = "Uras",BirthYear = new DateTime(1996,07,19),IdentityNumber = 1234567890};
            
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user);


            Game game1 = new Game() { Id = 1, Name = "Bannerlord", Price = 150 };
            Game game2 = new Game() { Id = 1, Name = "FarCry", Price = 30 };
            Game game3 = new Game() { Id = 1, Name = "Ark Survival Evolved", Price = 90 };
            Game game4 = new Game() { Id = 1, Name = "The Elder Scrolls V Skyrim", Price = 100 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Add(game4);

            Campaign campaign1 = new Campaign() { Id = 1, Name = "Summer Sale", Discount = 50 };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "Halloween Sale", Discount = 25 };
            Campaign campaign3 = new Campaign() { Id = 3, Name = "Black Friday Sale", Discount = 90 };
            Campaign campaign4 = new Campaign() { Id = 4, Name = "Winter Sale", Discount = 50 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            campaignManager.Add(campaign4);

            OrderManager orderManager = new OrderManager();
            orderManager.CampaignSale(user, game1, campaign3);
            orderManager.GameSale(user, game3);
           
        }
    }
}
