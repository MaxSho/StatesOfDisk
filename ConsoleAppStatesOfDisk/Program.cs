//using ConsoleAppStatesOfDisk;

//string serverAddress = "server_address";
//Client client = new Client(serverAddress);

//string request = "Data to be processed";
//string response = client.SendRequest(request);

//Console.WriteLine("Received response: " + response);
using ConsoleAppStatesOfDisk;

Console.WriteLine(DiskViewer.GetDiskCFreeSpace());
Console.WriteLine(DiskViewer.GetComputerName());

