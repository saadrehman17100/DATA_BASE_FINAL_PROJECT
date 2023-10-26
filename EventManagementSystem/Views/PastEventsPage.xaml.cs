using EventManagementSystem.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace EventManagementSystem.Views;

public sealed partial class PastEventsPage : Page
{
    public PastEventsViewModel ViewModel
    {
        get;
    }

    public PastEventsPage()
    {
        ViewModel = App.GetService<PastEventsViewModel>();
        InitializeComponent();
    }
}
