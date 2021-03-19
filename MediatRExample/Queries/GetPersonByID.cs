using MediatR;

using MediatRExample.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Queries
{
    public static class GetPersonByID
    {


        public record Query(int ID) : IRequest<Response>;

        public record Response(int ID, string Name, bool IsActive);
        public class Handler : IRequestHandler<Query, Response>
        {
            public readonly Repository repository;
           public  Handler(Repository repository)
            {
                this.repository = repository;
            }
            public   async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {

                 var  person= repository.Peoples.FirstOrDefault(y => y.ID == request.ID);
                return person == null ? null : new Response(person.ID,person.Name,person.IsActive);

            }
        }
    }
}
