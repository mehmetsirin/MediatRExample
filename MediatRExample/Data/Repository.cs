using MediatRExample.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Data
{
    public class Repository
    {

        public List<Person> Peoples { get; } = new List<Person>()
        {
            new Person(){ ID=1, IsActive=true, Name="Mehmet"},
            new Person(){ ID=2, IsActive=true, Name="Şirin"},
            new Person(){ ID=3, IsActive=false, Name="Işık"},

        };
    }
}
