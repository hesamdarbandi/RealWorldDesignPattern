using System;
namespace Mediator
{
    //client base class
    public class Participant
    {
        private GroupChat _chat;
        public GroupChat GroupChat
        {
            set { _chat = value; }
            get { return _chat; }
        }

        private string _name;
        public string Name => _name;

        public Participant(string name) => _name = name;

        public void Send(string to, string message) => _chat.Send(_name, to, message);

        public virtual void Receive(string from, string message) => Console.WriteLine($"receive message  {from}  {_name} {message}");
    }
}
