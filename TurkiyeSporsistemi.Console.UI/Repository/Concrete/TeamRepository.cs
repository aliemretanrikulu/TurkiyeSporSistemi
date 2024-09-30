

using TurkiyeSporsistemi.ConsoleUI.Models;
using TurkiyeSporsistemi.ConsoleUI.Repository;
using TurkiyeSporsistemi.ConsoleUI.Repository.Abstracts;

namespace TurkiyeSporsistemi.Console.UI.Repository.Concrete;

public class TeamRepository : IRepository<Team, Guid>
{
    public Team Add(Team created)
    {
        throw new NotImplementedException();
    }

    public Team? Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Team> GetAll()
    {
        throw new NotImplementedException();
    }

    public Team? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Team? Update(Guid id, Team entity)
    {
        throw new NotImplementedException();
    }
}
