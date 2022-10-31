using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_I
{
    public partial class App : Application
    {
        static Controllers.DBContact dBEmple;
        public static Controllers.DBContact dbemple
        {
            get
            {
                if (dBEmple == null)
                {
                    string DBName = "emple.db3";
                    string PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBEmple = new Controllers.DBContact(PathDB);
                }

                return dBEmple;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PagePrincipal());
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
