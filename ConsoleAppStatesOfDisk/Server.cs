using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStatesOfDisk
{
    internal class Server
    {
        string _webServiceUrl;
        public Server()
        {
            _webServiceUrl = ConfigurationManager.AppSettings["URLService"] ?? throw new ArgumentException();
            if (!IsCreatedPCInfo())
            {
                RequestPCInfoCreate();
            }
        }
        public void RequestPCInfoUpdate()
        {
            string pcController = ConfigurationManager.AppSettings["pc"] ?? throw new ArgumentException();
            string endPoint = _webServiceUrl + pcController;
            ProcessRequestPut(DiskViewer.GetJsonPCInfo(), endPoint);
        }
        private void ProcessRequestPut(string jsonBody, string endpoint)
        {
            RestRequest restRequest = new RestRequest("", Method.Put);
            restRequest.AddJsonBody(jsonBody);

            RestClient client = new RestClient(endpoint);
            RestResponse response = client.Execute(restRequest);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("State sent successfully.");
            }
            else
            {
                Console.WriteLine("Error sending state. Status Code: " + response.StatusCode);
                Console.WriteLine("Error Response Content: " + response.Content);
            }
        }
        private void RequestPCInfoCreate()
        {
            string pcController = ConfigurationManager.AppSettings["pc"] ?? throw new ArgumentException();
            string endPoint = _webServiceUrl + pcController;
            ProcessRequestPost(DiskViewer.GetJsonPCInfo(), endPoint);
        }
        private void ProcessRequestPost(string jsonBody, string endpoint)
        {
            RestRequest restRequest = new RestRequest("", Method.Post);
            restRequest.AddJsonBody(jsonBody);

            RestClient client = new RestClient(endpoint);
            RestResponse response = client.Execute(restRequest);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("State sent successfully.");
            }
            else
            {
                Console.WriteLine("Error sending state. Status Code: " + response.StatusCode);
                Console.WriteLine("Error Response Content: " + response.Content);
            }
        }
        public bool IsCreatedPCInfo()
        {
            string pcController = ConfigurationManager.AppSettings["pc"] ?? throw new ArgumentException();
            string endPoint = _webServiceUrl + pcController;
            return ProcessRequestGetId(endPoint, DiskViewer.GetMACAddress() ?? throw new ArgumentException());
        }
        private bool ProcessRequestGetId(string endpoint, string id)
        {
            RestRequest restRequest = new RestRequest("/{id}", Method.Get);
            restRequest.AddUrlSegment("id", id);

            RestClient client = new RestClient(endpoint);
            RestResponse response = client.Execute(restRequest);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("GET request successful.");
                Console.WriteLine("Response Content: " + response.Content);
                return true;
            }
            else
            {
                Console.WriteLine("Error sending GET request. Status Code: " + response.StatusCode);
                Console.WriteLine("Error Response Content: " + response.Content);
                return false;
            }
        }

        
    }
}
