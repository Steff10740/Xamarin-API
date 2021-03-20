using SeasonAPISport.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using static SeasonAPISport.Models.SeasonInfo;

namespace SeasonAPISport.ViewModels
{
    public class SeasonVM : INotifyPropertyChanged
    {
         ISeasonLAPIService seasonLAIService; 
        public SeasonVM ()
        {
            seasonLAIService = new SeasonLAPIService();
                GetSeason = new Command(GetSeasonAsync);
        }

        public async void GetSeasonAsync()
        {
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await App.Current.MainPage.DisplayAlert("Aviso", "Conectese al internet", "OK");
                return;
            }
            IsDataVisible = false;
            IsBusy = true;
            var SeasonList = await seasonLAIService.GetSeasonInfoAsync();
            SeasonslData = SeasonList.Data;
            IsBusy = false;
            IsDataVisible = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Datum> SeasonslData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsDataVisible { get; set; }
        public ICommand GetSeason { get; }
    }
}
