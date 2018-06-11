using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BlendAnimationsVisualStateBinding2
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand SwitchCommand { get; set; }

        public MainViewModel()
        {
            SwitchCommand = new SwitchCommand(this);
        }

        private CardinalPoint cardinalPoint;
        public CardinalPoint CardinalPoint
        {
            get { return cardinalPoint; }
            set
            {
                cardinalPoint = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
