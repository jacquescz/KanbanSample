using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KanbanSample.Models
{
    public class PersonState
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int StateId { get; set; }
        public PersonState State { get; set; }
    }


    public class HomeIndexViewModel
    {
        public List<PersonState> PersonStates { get; set; }
        public List<Person> People { get; set; }

    }
}