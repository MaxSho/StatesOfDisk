using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStatesOfDisk
{
    internal class Client
    {
        public Client()
        {

        }
        public void SendRequest(string request)
        {
            // Логіка відправки запиту на сервер
             ConnectToServer(request);
           
        }

        private void ConnectToServer(string request)
        {
            // Логіка підключення до сервера (наприклад, через мережу)
            Server server = new Server();
            server.ProcessRequest("");
        }
        public void SendResponse(Server server)
        {
            server.ProcessRequest("");

        }
    }
}
