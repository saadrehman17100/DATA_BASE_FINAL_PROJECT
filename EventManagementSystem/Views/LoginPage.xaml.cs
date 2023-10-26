using EventManagementSystem.ViewModels;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace EventManagementSystem.Views
{
    public sealed partial class LoginPage : Page
    {
        public LoginViewModel ViewModel
        {
            get;
        }

        public LoginPage()
        {
            ViewModel = App.GetService<LoginViewModel>();
            InitializeComponent();
            
        }
    }
}
