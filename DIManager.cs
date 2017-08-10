using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateSolutionNuget
{
    class DIManager
    {
        public DIManager()
        {
            Container = new UnityContainer();
            RegisterTypes();
        }

        private void RegisterTypes()
        {
        }

        public IUnityContainer Container { get; set; }
    }
}
