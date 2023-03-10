using Database.Data.Common;
using Database.Data.Models;
using Football.Core.Contracts;
using Football.Core.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Football.Core.Services
{
    public class FootballService : IFootballService
    {
        private readonly IRepository repo;

        public FootballService(
            IRepository _repo)
        {

            repo = _repo;
        }
        public async Task Add(TeamDTO TeamDto)
        {
            var team = new Team()
            {
                Name = TeamDto.Name,
                Budget = TeamDto.Budget,
                Players = TeamDto.Players,

            };
            await repo.AddAsync(team);
            await repo.SaveChangesAsync();
        }

        public Task<IEnumerable<Team>> ShowAll()
        {
            return (Task<IEnumerable<Team>>)repo.AllReadonly<Team>();
                
        }
    }
}
