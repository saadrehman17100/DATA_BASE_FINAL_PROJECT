using EventManagementSystem.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace EventManagementSystem.Views;

public sealed partial class AddParticipantsPage : Page
{
    public AddParticipantsViewModel ViewModel
    {
        get;
    }

    public AddParticipantsPage()
    {
        ViewModel = App.GetService<AddParticipantsViewModel>();
        InitializeComponent();
    }
}
