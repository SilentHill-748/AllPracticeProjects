using System.Diagnostics;

Console.Title = "OBS Studio Killer 1.0.1";

Console.WriteLine("Press enter for continue...");
ConsoleKeyInfo keyInfo = Console.ReadKey();

Process? obsStudio = null;

if (keyInfo.Key == ConsoleKey.Enter)
    obsStudio = Process.GetProcesses()
        .FirstOrDefault(process => process.ProcessName == "obs64");

if (obsStudio is not null)
{
    obsStudio.Kill();
    Console.WriteLine("Process as 'OBS Studio' was killed!");
}
else
    Console.WriteLine("Process as 'OBS Studio' was not found!");

Console.ReadKey();
