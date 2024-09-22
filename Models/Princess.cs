using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Princess : IEntity, IPoisonable
{
    public string Name {get;set;}

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with vengence");
    }

    public void Move()
    {
        System.Console.WriteLine($"{Name} moves vengefully.");
    }

    public void PoisonEnemy(IEntity target)
    {
        System.Console.WriteLine($"{Name} poisons {target.Name}.");
    }
}
