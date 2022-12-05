using FrontEnd.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.ViewModels
{
    [QueryProperty(nameof(List<ErrorReport>), "Todo")]
    public class ErrorReportListViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ErrorReport> errorReports;
    }
}
