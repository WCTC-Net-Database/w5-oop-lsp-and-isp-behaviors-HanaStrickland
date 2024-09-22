using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Wizard : IEntity, ICastable
    {
        public string Name {get;set;}

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with magic.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves on a broom.");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a repelling spell.");
        }
    }
}