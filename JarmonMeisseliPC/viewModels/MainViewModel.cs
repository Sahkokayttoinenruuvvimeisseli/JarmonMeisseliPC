using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmonMeisseliPc.viewModels
{
    class MainViewModel
    {
        public PersonsViewModel Personsviewmodel { get; set; }
        public ToolsViewModel Toolsviewmodel { get; set; }
        public ToolUsesViewModel Toolusesviewmodel { get; set; }

        public MainViewModel()
        {
            Personsviewmodel = new PersonsViewModel();
            Toolsviewmodel = new ToolsViewModel();
            Toolusesviewmodel = new ToolUsesViewModel();
        }
    }
}
