using EventManagementSystem.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace EventManagementSystem.Views;

public sealed partial class ReportPage : Page
{
    public ReportViewModel ViewModel
    {
        get;
    }

    public ReportPage()
    {
        ViewModel = App.GetService<ReportViewModel>();
        InitializeComponent();
    }
}
