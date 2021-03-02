using System;
namespace Mediator
{
    //base mediator class
    public abstract class ChatRoom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }
}
