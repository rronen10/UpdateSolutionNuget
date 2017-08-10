using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateSolutionNuget
{
    public class NugetProxy
    {
        public void UpdateNuget(string solutionPath, string nugetToUpdate)
        {
            RunCommand($@"update ""{solutionPath}"" {nugetToUpdate}");
        }

        private void RunCommand(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "nuget.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
