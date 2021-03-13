using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_MVVM.Models
{
   public class Agenda
    {
        public string Name { get; }
        public string Number { get; }


        public Agenda(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
