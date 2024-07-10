using Avalonia.Controls;
using MaterialComboBoxSample.ViewModels;
namespace MaterialComboBoxSample.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}