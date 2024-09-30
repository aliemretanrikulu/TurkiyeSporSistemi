using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporsistemi.ConsoleUI.Models;
using TurkiyeSporsistemi.ConsoleUI.Models.ReturnModels;

namespace TurkiyeSporsistemi.Console.UI.Service;
public interface IPlayerService
{
    ReturnModel<Player> GetById(int id);
}