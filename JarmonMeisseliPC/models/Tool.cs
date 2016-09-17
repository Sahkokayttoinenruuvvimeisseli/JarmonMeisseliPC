using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmonMeisseliPc.models
{
    class Tool : INotifyPropertyChanged
    {
        private long toolid;
        private string name;

        public long Toolid { get
            {
                return toolid;
            }
            set
            {
                toolid = value;
                OnPropertyChanged("Toolid");
            }
        }
        public string Name { get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
