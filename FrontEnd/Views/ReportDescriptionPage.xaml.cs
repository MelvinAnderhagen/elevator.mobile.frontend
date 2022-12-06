using FrontEnd.ViewModels;

namespace FrontEnd.Views;

public partial class ReportDescriptionPage : ContentPage
{
	public ReportDescriptionPage(ErrorReportDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}