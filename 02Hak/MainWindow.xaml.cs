using System.Windows;
using KMACSharp02_03Hak.ViewModels;

namespace KMACSharp02_03Hak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
