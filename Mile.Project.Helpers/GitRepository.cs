using System.Diagnostics;
using System.IO;

namespace Mile.Project.Helpers
{
    public class GitRepository
    {
        public static string GetRootPath()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    FileName = "git.exe",
                    Arguments = "rev-parse --show-toplevel"
                }
            };

            if (process.Start())
            {
                process.WaitForExit();
                if (process.ExitCode == 0)
                {
                    string result = process.StandardOutput.ReadLine();
                    if (!string.IsNullOrEmpty(result))
                    {
                        return Path.GetFullPath(result);
                    }
                }
            }

            return string.Empty;
        }
    }
}
