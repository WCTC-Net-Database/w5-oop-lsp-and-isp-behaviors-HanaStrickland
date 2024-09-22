using System.Windows.Input;
using W5_assignment_template.Models;


public class CastSpellCommand : ICommand
    {
        private readonly Wizard _wizard;
        
        public CastSpellCommand(Wizard wizard)
        {
            _wizard = wizard;
        }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        throw new NotImplementedException();
    }

    public void Execute(object? parameter)
    {
        _wizard.ExecuteCastSpell();
    }
}