using System.Windows.Controls;
using KMACSharp02Hak.ViewModels.DatePicker;

namespace KMACSharp02Hak.Views.DatePicker
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
