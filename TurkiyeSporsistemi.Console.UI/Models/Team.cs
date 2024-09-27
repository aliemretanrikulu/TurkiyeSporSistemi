
namespace TurkiyeSporsistemi.Console.UI.Models;

public class Team : Entity <Guid>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime Since { get; set; }

}
