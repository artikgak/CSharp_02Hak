using System.ComponentModel;
using System.Windows;

namespace KMACSharp02_03Hak.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
