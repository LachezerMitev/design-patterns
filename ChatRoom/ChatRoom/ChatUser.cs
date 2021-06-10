using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    public class ChatUser : User
    {
        public ChatUser(MessageMediator mediator, string name) : base(mediator, name)
        {
            mediator.AddUser(this);
        }

        public override void Send(string message)
        {
            Console.WriteLine(name + " says: " + message);
            mediator.SendMessage(message, this);
        }
        public override void Recieve(string message, User sender)
        {
            Console.WriteLine("==================" + name + " recieves: " + message + "==================");
        }
    }
}
