using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));

            Routing.RegisterRoute(nameof(BookDetailPage), typeof(BookDetailPage));
        }
        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//LoginPage");

        }
    }
}