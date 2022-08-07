using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXamarinApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender ,EventArgs e)
        {
            string username= usernameEntry.Text;
            string password = passwordEntry.Text;
            if(username!=null && password != null)
            {
                if (username.Equals(password.ToLower()))
                {
                    DisplayAlert("Opps", "username or password are similar please try others", "Ok");
                }
                else if(username=="admin" && password=="121"){
                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("Opps","username or password is wrong","Ok");
                }
            }
            else
            {

                DisplayAlert("Opps", " provide a valid username or password ", "Ok");
            }
        }
    }
}