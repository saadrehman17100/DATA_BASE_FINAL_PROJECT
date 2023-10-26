using EventManagementSystem.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace EventManagementSystem.Views
{
    public sealed partial class EventCreationPage : Page
    {
        public EventCreationViewModel ViewModel
        {
            get;
        }

        public EventCreationPage()
        {
            ViewModel = App.GetService<EventCreationViewModel>();
            InitializeComponent();
        }

        private void CreateEvent_Click(object sender, RoutedEventArgs e)
        {
            // Add your event creation logic here
            // You can access the input fields like EventNameTextBox.Text, EventTypeComboBox.SelectedItem, etc.
        }
    }
}
