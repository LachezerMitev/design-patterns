using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    public interface MessageMediator
    {
        void AddUser(User user);

        void SendMessage(string message, User sender);

        public void MarkToKick(User user);

    }
}
