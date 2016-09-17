using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using JarmonMeisseliPc.models;

namespace JarmonMeisseliPc.viewModels
{
    class ToolsViewModel
    {
        ObservableCollection<Tool> tools = new ObservableCollection<Tool>();

        public ObservableCollection<Tool> Tools { get; set; }
    }
}
