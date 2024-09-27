using TurkiyeSporsistemi.Console.UI.Models;
using System;
using System.Collections.Generic;

namespace TurkiyeSporsistemi.Console.UI.Repository
{
    public class BaseRepository
    {
        //aaa
        static BaseRepository()
        {

            teams = new List<Team>
            {
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Trabzon",
                    Description = "tr açıklaması",
                    Since = new DateTime(1967, 1, 4)
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Fenerbahçe",
                    Description = "şikebahçe",
                    Since = new DateTime(1907, 7, 7)
                }
            };
        }
        public static List<Team> teams { get; private set; }
    }
}
