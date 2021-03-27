using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderManager : IOrderManager
    {
        public void CampaignSale(User gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " +"Used for"+ game.Name + gamer.FirstName);
        }

        public void GameSale(User gamer, Game game)
        {
            Console.WriteLine(game.Name + " " + "\n" +"Sold to"+ " " + gamer.FirstName + " " + gamer.LastName);
        }

    }
}
