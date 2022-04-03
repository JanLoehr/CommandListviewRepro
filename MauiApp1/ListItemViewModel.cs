using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1
{
    internal class ListItemViewModel : ExtendedBindableObject
    {
        public string ButtonLabel { get; set; }

        private int _clicksReceived = 0;
        public int ClicksReceived { get { return _clicksReceived; } set { _clicksReceived = value; RaisePropertyChanged(() => ClicksReceived); } }
        public ICommand ActionClickedCommand { get; set; }

        public ListItemViewModel(string label)
        {
            ButtonLabel = label;
            ActionClickedCommand = new Command(OnActionClicked);
        }

        private void OnActionClicked(object obj)
        {
            ClicksReceived++;
        }
    }
}
