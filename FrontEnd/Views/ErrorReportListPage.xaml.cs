using FrontEnd.Clients;
using FrontEnd.ViewModels;

namespace FrontEnd.Views;

public partial class ErrorReportListPage : ContentPage
{
    private readonly ApiClient _client;

    //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "errorReports.txt");

    public ErrorReportListPage(ApiClient client, ErrorReportListViewModel viewModel)
	{
		InitializeComponent();
        _client = client;
        Task.Run(async () =>
        {
            await _client.GetAllErrorReports();
        });

        BindingContext = viewModel;
    }
}