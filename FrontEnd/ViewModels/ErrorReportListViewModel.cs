using FrontEnd.Clients;
using FrontEnd.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.ViewModels
{
    //[QueryProperty(nameof(List<ErrorReport>), "ErrorReport")]
    public partial class ErrorReportListViewModel : ObservableObject
    {
        private readonly ApiClient _client;

        [ObservableProperty]
        private List<ErrorReport> _errorReports;


        public ErrorReportListViewModel(ApiClient client)
        {
            _client = client;
            Task.Run(Initialize).ConfigureAwait(false);
        }
        public async Task Initialize()
        {
            ErrorReports = await _client.GetAllErrorReports();
        }

        
    }

    
}
