using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmonMeisseliPc.models
{
    class ToolUse : INotifyPropertyChanged
    {
        private long tooluseid;
        private long personid;
        private long toolid;

        public long Tooluseid { get
            {
                return tooluseid;
            }
            set
            {
                tooluseid = value;
                OnPropertyChanged("Tooluseid");
            }
        }
        public long Personid { get
            {
                return personid;
            }
            set
            {
                personid = value;
                OnPropertyChanged("Personid");
            }
        }
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
