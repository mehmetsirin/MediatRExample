using MediatR;

using MediatRExample.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Command
{
    public    static class AddPerson
    {
     public  record  Command(string Name):IRequest<int>;


        public class Handler : IRequestHandler<Command, int>
        {
            private readonly Repository repository;
            public Handler(Repository repository)
            {
                this.repository = repository;

            }
            public  async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                repository.Peoples.Add(new Entities.Person() { ID = 10, Name = request.Name,IsActive=true });
                return 10;
            }
        }

    }
}
