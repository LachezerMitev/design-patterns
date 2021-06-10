using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageMediator chat = new Chat();

            User user1 = new ChatUser(chat, "Niki");
            User user2 = new ChatUser(chat, "Lubo");
            User user3 = new ChatUser(chat, "Veso");

            user1.Send("test");
            user2.Send("Hello");
            user1.Send("addBot");
            user3.Send("cat");
            user2.Send("Why was he kicked?");
        }
    }
}
