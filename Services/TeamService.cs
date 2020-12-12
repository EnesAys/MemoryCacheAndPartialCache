using System.Collections.Generic;
using MemoryCacheAndPartialCache.Models;
namespace MemoryCacheAndPartialCache.Services
{
    public class TeamService : ITeamService
    {    
        public List<Player> GetPlayers()
        {
            var players = new List<Player>{
                new Player
                {
                    Id = 1,
                    Name = "Rozier"
                },
                new Player
                {
                    Id = 2,
                    Name = "Aboubakar"
                },
                new Player
                {
                    Id = 3,
                    Name = "Ghezzal"
                },
            };
            return players;
        }
    }
}
