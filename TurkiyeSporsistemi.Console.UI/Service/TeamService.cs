
using TurkiyeSporsistemi.ConsoleUI.Models;
using TurkiyeSporsistemi.ConsoleUI.Models.ReturnModels;
using TurkiyeSporsistemi.Console.UI.Repository.Concrete;

namespace TurkiyeSporsistemi.Console.UI.Service;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();

    public ReturnModel<Team> GetById(Guid id)
    {
        try
        {
            Team? team = teamRepository.GetById(id);
            return new ReturnModel<Team>
            {
                Data = team,
                Message = "Aradığınız id'ye göre Team bulunamadı",
                Success = true,
            };
        }
        catch (Exception ex) {
            return new ReturnModel<Team>
            {
                Success = false,
                Message = ex.Message,
                Data = null
            };
        }
    }
}