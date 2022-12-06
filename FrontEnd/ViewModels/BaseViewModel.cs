using FrontEnd.Models;
using FrontEnd.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public bool isLoggedIn { get; set; }

        public BaseViewModel()
        {
            Items = new ObservableCollection<ErrorReport>();
        }
        
        [ObservableProperty]
        private ObservableCollection<ErrorReport> _items;

        [ObservableProperty]
        private Guid _errorReportId;

        [RelayCommand]
        private async Task Tap(ErrorReport report)
        {
            await Shell.Current.GoToAsync($"{nameof(ReportDescriptionPage)}", new Dictionary<string, object>
            {
                { nameof(ErrorReport), report }
            });
        }




    }
}
