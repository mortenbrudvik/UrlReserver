using System.Diagnostics;

namespace UrlReserverConsole
{
    public class UrlReserver
    {
        public void Reserve(string address, string user, string domain)
        {
            Reserve(address, $@"{domain}\{user}");
        }
        public bool Reserve(string address, string user)
        {
            var args = $@"http add urlacl url={address} user={user}";

            var psi = new ProcessStartInfo("netsh", args)
            {
                Verb = "runas",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };

            var process = Process.Start(psi);
            var output = process.StandardOutput.ReadToEnd();
                
            process?.WaitForExit();

            return output.Contains("URL reservation successfully added");
        }
    }
}