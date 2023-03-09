using Football.Core.Models;

namespace Football.Core.Contracts
{
    public interface IFootballService
    {
        Task Add(TeamDTO TeamDto);

    }
}
