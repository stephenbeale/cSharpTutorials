using System.IO;

PrintDelegate PrintToConsole = (string text) => Console.WriteLine(text);
var logsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");

try
{
    
    if (!File.Exists("logs.txt"))
    {
        using (FileStream fs = File.Create(logsFilePath)) { }
    }    
}
catch (Exception ex)    
{
    Console.WriteLine(ex.Message);
}

PrintDelegate PrintToFile = (string text) => File.AppendAllText(logsFilePath, text);

static void ConnectToDatabase(PrintDelegate log)
{
    //Insert
    log("Inserting record into database\n");
    //Notify
    log("Record has been inserted into database.");
}

ConnectToDatabase(PrintToConsole);
ConnectToDatabase(PrintToFile);

delegate void PrintDelegate(string text);

