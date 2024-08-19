PrintDelegate PrintToFile = (string text) => Console.WriteLine(text);
PrintDelegate PrintConsole = (string text) => File.AppendAllText("/logs.txt", text);

PrintToFile("Hello World!");

delegate void PrintDelegate(string text);

