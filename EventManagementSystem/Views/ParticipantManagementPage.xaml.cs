using EventManagementSystem.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace EventManagementSystem.Views;

public sealed partial class ParticipantManagementPage : Page
{
    public ParticipantManagementViewModel ViewModel
    {
        get;
    }

    public ParticipantManagementPage()
    {
        ViewModel = App.GetService<ParticipantManagementViewModel>();
        InitializeComponent();
    }
}
