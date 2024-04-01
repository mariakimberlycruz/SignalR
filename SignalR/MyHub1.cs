using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR
{
    public class MyHub1 : Hub
    { public void Send2(string name, string message)
            {
                // Call the addNewMessageToPage method to update clients.
                Clients.All.addNewMessageToPage(name, message);
            }
       
    }
}