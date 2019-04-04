using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Refit;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnConnect.Clicked += (sender, e) => {
                Console.WriteLine("CLieck");
                DependencyService.Get<IXmpp>().Connect(txtName.Text, txtPassword.Text, "52.71.60.65") ;

            };
        
        }
    }
}
