using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
namespace MauiApp1.View_Model
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() {
            items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;
        
        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(Text))
                return;
            items.Add(Text);
            //add our item
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(String s)
        {
            if (items.Contains(s))
                items.Remove(s);
        }
    }
}
