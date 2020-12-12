using System.Collections.Generic;
using MemoryCacheAndPartialCache.Models;

namespace MemoryCacheAndPartialCache.Services
{
    public interface ITeamService
    {
        List<Player> GetPlayers();
    }
}
