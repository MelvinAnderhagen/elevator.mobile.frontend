using FrontEnd.Views;

namespace FrontEnd;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ErrorReportListPage), typeof(ErrorReportListPage));
        Routing.RegisterRoute(nameof(ReportDescriptionPage), typeof(ReportDescriptionPage));
    }
}
