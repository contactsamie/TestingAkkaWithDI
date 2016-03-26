using SandBoxTest.Messages;

namespace SandBoxTest.Services
{
    public class WorkerService : IWorkerService
    {
        public Pong Pong()
        {
          return  new Pong();
        }
    }
}