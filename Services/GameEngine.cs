using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _wizard;
        private readonly IEntity _princess;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity wizard, IEntity princess)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _wizard = wizard;
            _princess = princess;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _wizard.Name = "Merlin";
            _princess.Name = "Peach";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);

            if (_ghost is IFlyable)
            {
               ((IFlyable)_ghost).Fly();
            }
            else
            {
                _ghost.Move();
            }

            if (_wizard is ICastable)
            {
                ((ICastable)_wizard).CastSpell();
            }

            _princess.Move();
            if (_princess is IPoisonable)
            {
                ((IPoisonable)_princess).PoisonEnemy(_goblin);
            }
        }
    }
}
