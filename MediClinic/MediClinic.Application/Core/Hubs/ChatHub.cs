using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Core.Hubs
{
    public class ChatHub : Hub
    {
        readonly MediClinicDbContext db;
        public ChatHub(MediClinicDbContext db)
        {
            this.db = db;
        }


        public async Task AddNewGroup()
        {
            if (ClientSource.Clients.Where(e => e.Name == "admin").Count() == 0)
            {
                var client = new Client();
                client.Name = "admin";
                client.Connectionid = Context.ConnectionId;

                await Groups.AddToGroupAsync(Context.ConnectionId, "admin");
            }

        }

        public async Task AddUserToGroup()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "admin");

        }

        public async Task SendMessage(string message, string name)
        {
            await Clients.OthersInGroup("admin").SendAsync("giveMessage", message, name);

        }

        public async Task AddGroup(int? sendedId)
        {

            if (ClientSource.Clients.Where(e => e.Name == sendedId.ToString()).Count() == 0)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, sendedId.ToString());

                var client = new Client();
                client.Name = sendedId.ToString();
                client.Connectionid = Context.ConnectionId;

                ClientSource.Clients.Add(client);

                foreach (var item in ClientSource.Clients.Where(e => e.Name == "admin"))
                {
                    await Groups.AddToGroupAsync(item.Connectionid, sendedId.ToString());
                }
            }
        }

        public async Task SendMessageToGroup(string message, int? sendedId, int? achieveId)
        {
            //var model = new Message();
            //model.Text = message;
            //model.SendedUserId = sendedId;
            //model.AchievedUserId = achieveId;

            //await db.Messages.AddAsync(model);
            //await db.SaveChangesAsync();

            await Clients.Group(sendedId.ToString()).SendAsync("receiveMessage", message);

        }


        //adminde bir ustundeki mesajin idsini achieve ver
        public async Task SendMessageToGroupAdmin(string message, int? sendedId, int? achieveId)
        {
            //var model = new Message();
            //model.Text = message;
            //model.SendedUserId = sendedId;
            //model.AchievedUserId = achieveId;

            //await db.Messages.AddAsync(model);
            //await db.SaveChangesAsync();

            await Clients.Group(achieveId.ToString()).SendAsync("receiveMessageAdmin", message);

        }

        // bide qeyd sendidni bosh eleme nese gonder hemwe
        //admin terefde bunlari istifade eliyecem
        public async Task AddGroupAdmin()
        {
            //if (GroupSource.Groups.Where(e => e.GroupName == "admin").FirstOrDefault() == null)
            //{
            //    await Groups.AddToGroupAsync(Context.ConnectionId, "admin");

            //    var group = new Group();
            //    group.GroupName = "admin";
            //    group.Connectionid = Context.ConnectionId;

            //    GroupSource.Groups.Add(group);
            //}

            var client = new Client();
            client.Name = "admin";
            client.Connectionid = Context.ConnectionId;

            ClientSource.Clients.Add(client);

            foreach (var item in ClientSource.Clients.Where(e => e.Name != "admin"))
            {
                await Groups.AddToGroupAsync(item.Connectionid, item.Name);
            }

        }

        //public async Task AddClientToGroupAdmin()
        //{
        //    if(GroupSource.Groups.Where(e => e.GroupName == "admin").FirstOrDefault() != null){
                
        //        await Groups.AddToGroupAsync(Context.ConnectionId, "admin");
        //    }
           
        //}
    }
}
