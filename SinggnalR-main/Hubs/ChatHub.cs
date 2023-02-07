using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SinggnalR.DAL;
using SinggnalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinggnalR.Hubs
{
    public class ChatHub:Hub
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        public ChatHub( UserManager<AppUser> userManager, DAL.Context context)
        {
            _userManager = userManager;
            _context = context;

        }

        public async Task SendMessageUser(string id, string message,string typing)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            await Clients.Client(user.ConnectionId).SendAsync("ChatUserToUser", user.Id, message);
        }

        public async Task UserKeyup(string id,string typing)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            await Clients.Client(user.ConnectionId).SendAsync("UserTyping", user.Id, typing);
        }

        public override Task OnConnectedAsync()
        {
            AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
            user.ConnectionId = Context.ConnectionId;
            _context.SaveChanges();
             Clients.All.SendAsync("Connected", user.Id);
            return  base.OnConnectedAsync();
        }
    }
}
