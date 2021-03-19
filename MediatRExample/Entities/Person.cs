using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Entities
{
    public class Person : IEntity<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }


    public interface  IEntity<T>
    {
          T  ID { get; set; }
    }
}
