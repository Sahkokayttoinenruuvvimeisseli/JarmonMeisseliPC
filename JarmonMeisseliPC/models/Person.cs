using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmonMeisseliPc.models
{
    class Person : INotifyPropertyChanged
    {
        private long personid;
        private string firstname;
        private string lastname;

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
        public string Firstname { get
            {
                return firstname;
            }
            set
            {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }
        public string Lastname { get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                OnPropertyChanged("Lastname");
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
