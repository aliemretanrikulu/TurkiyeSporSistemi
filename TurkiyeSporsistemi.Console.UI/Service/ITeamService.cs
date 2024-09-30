

using TurkiyeSporsistemi.ConsoleUI.Models.ReturnModels;
using TurkiyeSporsistemi.ConsoleUI.Models;

namespace TurkiyeSporsistemi.Console.UI.Service;

public interface ITeamService
{
    ReturnModel<Team> GetById(Guid id);

}
