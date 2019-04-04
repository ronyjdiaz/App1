using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public interface IXmpp
    {
        void Connect(string user, string password, string domain);
        void disconect();
    }
}
