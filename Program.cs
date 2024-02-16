using System.Diagnostics;

var processes = Process.GetProcessesByName("explorer");
while (processes.Length > 0)
{
    var process = processes.First();
    process.Kill(true);
    process.WaitForExit();

    processes = Process.GetProcessesByName("explorer");
}

Process.Start(Path.Combine(Environment.GetEnvironmentVariable("windir")!, "explorer.exe"));