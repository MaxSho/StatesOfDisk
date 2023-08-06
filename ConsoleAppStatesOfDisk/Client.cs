using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading;

namespace ConsoleAppStatesOfDisk
{
    internal sealed class Client : IDisposable
    {
        private static readonly Lazy<Client> instance = new Lazy<Client>(() => new Client());

        private Server _server;
        private Timer? _timer;

        private Client()
        {
            _server = new Server();
            
        }

        public static Client Instance => instance.Value;

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public void SendRequestPCInfo()
        {
            _server.RequestPCInfoUpdate();
        }

        public void SendRequestPCInfoInTimer()
        {
            _timer = new Timer(_ =>
            {
                SendRequestPCInfo();
            },
            null,
            0,
            30000);
        }
    }
}
