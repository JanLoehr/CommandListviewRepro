using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1
{
    internal class MainPageViewModel
    {
        public ObservableCollection<ListItemViewModel> ListItems { get; set; } = new ObservableCollection<ListItemViewModel>();

        public MainPageViewModel()
        {
            ListItems.Add(new ListItemViewModel("One"));
            ListItems.Add(new ListItemViewModel("Two"));
            ListItems.Add(new ListItemViewModel("Three"));
        }
    }
}
