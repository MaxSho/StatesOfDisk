//using ConsoleAppStatesOfDisk;

//string serverAddress = "server_address";
//Client client = new Client(serverAddress);

//string request = "Data to be processed";
//string response = client.SendRequest(request);

//Console.WriteLine("Received response: " + response);
using ConsoleAppStatesOfDisk;
using System.Net.NetworkInformation;
using System.Threading;

Console.WriteLine(DiskViewer.GetDiskCFreeSpace());
Console.WriteLine(DiskViewer.GetComputerName());

string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
Console.WriteLine(connectionString);

using(var client = Client.Instance)
{
    client.SendRequestPCInfoInTimer();
    Console.ReadKey();
}

