namespace FrontEnd.Views;

public partial class ErrorReportListPage : ContentPage
{
    //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "errorReports.txt");

    public ErrorReportListPage()
	{
		InitializeComponent();

        //if (File.Exists(_fileName))
        //    TextEditor.Text = File.ReadAllText(_fileName);
    }
}