using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using JarmonMeisseliPc.models;

namespace JarmonMeisseliPc.viewModels
{
    class PersonsViewModel
    {
        ObservableCollection<Person> persons = new ObservableCollection<Person>();

        public ObservableCollection<Person> Persons { get; set; }
    }
}
