using Database.Data.Common;
using Database.Data.Models;
using Football.Core.Contracts;
using Football.Core.Models;

namespace Football.Core.Services
{
    public class FootballService : IFootballService
    {
        public readonly Repository _repo;
        public FootballService(Repository repo)
        {
            _repo = repo;
        }


        public async Task Add(TeamDTO TeamDto)
        {
            var team = new Team()
            {
                Name = TeamDto.Name,
                Budget = TeamDto.Budget,
                Players = TeamDto.Players,

            };
           
           await repo.add

        }
    }
}
