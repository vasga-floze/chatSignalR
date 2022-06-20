using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class ChatHub : Hub
    {
        //fuction to send the messages of our chat
        public void Send(string name, string message)
        {
            //specify the method for send to all clients
            Clients.All.SendChat(name, message);
        }
    }
}