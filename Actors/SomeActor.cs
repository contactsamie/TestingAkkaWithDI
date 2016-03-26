using Akka.Actor;
using SandBoxTest.Messages;
using SandBoxTest.Services;

namespace SandBoxTest.Actors
{
    public class SomeActor : ReceiveActor
    {
        public SomeActor(IWorkerService service)
        {
            Receive<Ping>(message => Sender.Tell(service.Pong()));
        }
    }
}