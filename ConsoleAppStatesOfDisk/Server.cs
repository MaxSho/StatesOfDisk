using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStatesOfDisk
{
    internal class Server
    {
        string webServiceUrl = "YOUR_WEB_SERVICE_URL"; // Замініть це на реальний URL веб-сервісу
        string computerName = Environment.MachineName;
        public void ProcessRequest(string state)
        {
            RestRequest restRequest = new RestRequest("", Method.Post);
            restRequest.AddJsonBody(state);

            RestClient client = new RestClient(webServiceUrl);
            RestResponse response = client.Execute(restRequest);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("State sent successfully.");
            }
            else
            {
                Console.WriteLine("Error sending state: " + response.ErrorMessage);
            }

        }
    }
}
