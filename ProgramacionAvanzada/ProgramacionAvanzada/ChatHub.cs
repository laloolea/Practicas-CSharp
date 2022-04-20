using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ProgramacionAvanzada
{
    public class ChatHub:Hub
    {
        public ChatHub()
        {
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user,message);
        }
    }
}
