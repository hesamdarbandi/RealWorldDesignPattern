using System;

namespace Mediator
{
    class Program
    {

        static string _hesam = "hesam";
        static string _mehrdad = "mehrdad";
        static string _armin = "armin";
        static string _hamid = "hamid";

        static void Main(string[] args)
        {
            
            /// create mediator instance
            var groupChat = new GroupChat();

            //create clients
            var hesam = new Client(_hesam);
            var mehrdad = new Client(_mehrdad);
            var armin = new Client(_armin);
            var hamid = new Client(_hamid);

            // client register to mediator
            groupChat.Register(hesam);
            groupChat.Register(mehrdad);
            groupChat.Register(armin);
            groupChat.Register(hamid);


            // send chat from client to another using mediator
            hesam.Send(_hamid, "hi hamid how are you?");
            armin.Send(_mehrdad, "waths up mehrdad");
            hamid.Send(_armin, "hi armin");
        }
    }
}
