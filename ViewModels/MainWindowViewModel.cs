using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MaterialComboBoxSample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<string> items;
    [ObservableProperty] private string selectedItem;
    public MainWindowViewModel()
    {
        Items = new ObservableCollection<string>()
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"

        };
    }
}