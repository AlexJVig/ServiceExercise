using System;
namespace ServiceExercise
{
    public class MyService : IService
    {
        private readonly int CONNECTION_COUNT;

        public int getSummary()
        {
            throw new NotImplementedException();
        }

        public void sendRequest(Request request)
        {
            throw new NotImplementedException();
        }

        public MyService(int connectionCount)
        {
            CONNECTION_COUNT = connectionCount;
        }
    }
}
