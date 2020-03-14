using System.Windows.Controls;
using KMACSharp02_03Hak.ViewModels.DatePicker;

namespace KMACSharp02_03Hak.Views.DatePicker
{
    /// <summary>
    /// Interaction logic for DateView.xaml
    /// </summary>
    internal partial class DateView : UserControl
    {
        internal DateView()
        {
            InitializeComponent();
            DataContext = new DateViewModel();
        }
    }
}
