using Parcial2.Views;
using Xamarin.Forms;

namespace Parcial2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PhotoPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
