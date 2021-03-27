using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrderManager
    {
        void CampaignSale(User gamer, Game game, Campaign campaign);
        void GameSale(User gamer,Game game);


    }
}
