using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UpdateSolutionNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionPath = args[0];
            var nugetToUpdate = args[1];

            var dIManager = new DIManager();
            var nugetProxy = dIManager.Container.Resolve<NugetProxy>();

            nugetProxy.UpdateNuget(solutionPath, nugetToUpdate);

        }
    }
}
