using Akka.Actor;
using Akka.TestKit.VsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SandBoxTest.Actors;
using SandBoxTest.Messages;

namespace SandBoxTest
{
    [TestClass]
    public class TestApp : TestKit
    {
        [TestMethod]
        public void app_with_di()
        {
            //Arrange
            ApplicationActorSystem.Create<SomeActor>(DependencyResolver.GetContainer(), Sys);
            var someActorRef = ApplicationActorSystem.ActorReferences.ApplicationActorRef;

            //Act
            someActorRef.Tell(new Ping());

            //Assert
            ExpectMsg<Pong>();
        }

        [TestMethod]
        public void app_without_di()
        {
            //Arrange
            ApplicationActorSystem.Create<SomeActor>(DependencyResolver.GetContainer(), Sys);
            var someActorRef = ApplicationActorSystem.ActorReferences.ApplicationActorRef;

            //Act
            someActorRef.Tell(new Ping());

            //Assert
            ExpectMsg<Pong>();
        }
    }
}