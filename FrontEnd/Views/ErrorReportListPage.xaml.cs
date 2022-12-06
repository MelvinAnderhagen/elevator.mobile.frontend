using FrontEnd.Clients;
using FrontEnd.ViewModels;

namespace FrontEnd.Views;

public partial class ErrorReportListPage : ContentPage
{
    

    //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "errorReports.txt");

    public ErrorReportListPage(ApiClient client, ErrorReportListViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}