

namespace TurkiyeSporsistemi.Console.UI.Models;

public class Player : Entity <Guid>
{
 
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Number { get; set; }
    public string Position { get; set; }
    public string Branch { get; set; }
    public double MarketValue { get; set; }
}
