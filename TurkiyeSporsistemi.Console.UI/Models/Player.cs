﻿namespace TurkiyeSporsistemi.ConsoleUI.Models;

public class Player : Entity<int>
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }

    public string Position { get; set; }
    public string Branch { get; set; }

    public double MarketValue { get; set; }

    public Guid TeamId { get; set; }


    public override string ToString()
    {
        return $"{Name}, {Surname}";
    }
}