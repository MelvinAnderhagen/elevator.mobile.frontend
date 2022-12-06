using FrontEnd.Clients;
using FrontEnd.ViewModels;

namespace FrontEnd.Views;

public partial class ErrorReportListPage : ContentPage
{

    public ErrorReportListPage(ErrorReportListViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}