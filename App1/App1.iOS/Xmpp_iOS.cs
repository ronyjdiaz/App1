using System;
using App1.iOS;
using Xamarin.Forms;
using Waher.Networking.XMPP;

[assembly: Dependency(typeof(Xmpp_iOS))]
namespace App1.iOS
{
    class Xmpp_iOS : IXmpp
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
            throw new NotImplementedException();
        }
    }
}