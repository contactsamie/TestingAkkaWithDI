using Akka.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SandBoxTest.Actors;
using SandBoxTest.Messages;

namespace SandBoxTest
{
    [TestClass]
    public class MainApp
    {
        [TestMethod]
        public void app_with_di()
        {
            ApplicationActorSystem.Create<SomeActor>(DependencyResolver.GetContainer(), ActorSystem.Create("someActorSystem"));

            var someActorRef = ApplicationActorSystem.ActorReferences.ApplicationActorRef;

            someActorRef.Tell(new Ping());
            System.Threading.Thread.Sleep(5000);
        }

        [TestMethod]
        public void app_without_di()
        {
            ApplicationActorSystem.Create<SomeActor>(DependencyResolver.GetContainer(), ActorSystem.Create("someActorSystem"));

            var someActorRef = ApplicationActorSystem.ActorReferences.ApplicationActorRef;

            someActorRef.Tell(new Ping());
            System.Threading.Thread.Sleep(5000);
        }
    }
}