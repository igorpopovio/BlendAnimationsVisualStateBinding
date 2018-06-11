using System;
using System.Windows.Input;

namespace BlendAnimationsVisualStateBinding2
{
    public class SwitchCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public SwitchCommand(MainViewModel viewModel) =>
            _viewModel = viewModel;

        public void Execute(object parameter) =>
            _viewModel.CardinalPoint = (CardinalPoint)parameter;

        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;
        protected virtual void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}