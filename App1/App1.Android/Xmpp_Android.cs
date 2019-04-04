using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.Android;
using Waher.Networking.XMPP;
using Xamarin.Forms;


[assembly: Dependency(typeof(Xmpp_Android))]
namespace App1.Android
{
    class Xmpp_Android : Java.Lang.Object, IXmpp
    {
        public void Connect(string user, string password, string domain)
        {

            XmppCredentials credentials = new XmppCredentials();
            credentials.Password = password;
            credentials.Host = domain;
            credentials.Account = user;
            credentials.Port = 5222;

            XmppClient client = new XmppClient(credentials, "en", null, null);
            client.Connect();
            Console.WriteLine("Conectado...");

        }

        public void disconect()
        {
          
        }
    }
}