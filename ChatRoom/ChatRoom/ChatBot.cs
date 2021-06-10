using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    public class ChatBot : User
    {
        private static ChatBot instance;

        public static ChatBot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChatBot("BOT");
                }
                return instance;
            }
        }

        private ChatBot(string name) : base(name)
        { }

        public override void Recieve(string message, User sender)
        {
            if (message.Contains("cat"))
            {
                Console.WriteLine(sender.name + " has been kicked. Reason: Cat is a forbidden word");
                mediator.MarkToKick(sender);

            }
        }

        public override void Send(string message)
        {
        }

        public void SetChat(MessageMediator mediator)
        {
            this.mediator = mediator;
            mediator.AddUser(this);
        }
    }
}
