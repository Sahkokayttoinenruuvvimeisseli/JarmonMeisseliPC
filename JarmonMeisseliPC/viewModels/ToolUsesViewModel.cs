﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using JarmonMeisseliPc.models;

namespace JarmonMeisseliPc.viewModels
{
    class ToolUsesViewModel
    {
        ObservableCollection<ToolUse> tooluses = new ObservableCollection<ToolUse>();

        public ObservableCollection<ToolUse> Tooluses { get; set; }
    }
}
