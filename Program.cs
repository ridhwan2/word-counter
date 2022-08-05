Console.Title = "waiting";
Console.ForegroundColor = ConsoleColor.Red;

string word = Console.ReadLine();
int length = word.Split(' ').Length;

Console.Title = "finished!";
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine();
Console.WriteLine(length + " words");


Thread.Sleep(5000);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("exiting.");
Thread.Sleep(1000);
Environment.Exit(1);
