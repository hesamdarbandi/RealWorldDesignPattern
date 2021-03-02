using System;
using System.Collections.Generic;

namespace Mediator
{
    //mediator class
    public class GroupChat : ChatRoom
    {
        private Dictionary<string, Participant> _participants;

        public GroupChat() => _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
                _participants[participant.Name] = participant;

            participant.GroupChat = this;
        }

        public override void Send(string from, string to, string message)
        {
            var toParticipant = _participants[to];
            if (toParticipant == null)
                throw new Exception("invalid participant");

            toParticipant.Receive(from, message);
        }
    }
}
