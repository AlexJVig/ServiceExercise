using System;
using System.Threading;
namespace ServiceExercise
{
    public class MyService : IService
    {
        private readonly int CONNECTION_COUNT;
        private int _finishedConnections = 0;
        private int _sum;
        private object _lock = new object();

        public int getSummary()
        {
            while (_finishedConnections < CONNECTION_COUNT)
            {
                Thread.Sleep(100);
            }

            return _sum;
        }

        public void sendRequest(Request request)
        {
            lock (_lock)
            {
                _sum += request.Command;
                ++_finishedConnections;
            }
        }

        public MyService(int connectionCount)
        {
            CONNECTION_COUNT = connectionCount;
        }
    }
}
