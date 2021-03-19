using MediatR;

using MediatRExample.Command;
using MediatRExample.Queries;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonController:ControllerBase
    {

        private IMediator mediator;
       public PersonController(IMediator mediator)
        {
            //mediator.Send(new GetPersonByID.Query(1))/*;*/
            this.mediator = mediator;
        }
        [HttpGet]
        public   async  Task<IActionResult> GetPersonByID(int Id)
        {
            var response = await mediator.Send(new GetPersonByID.Query(Id));
            return response == null ? NotFound() : Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddPerson(AddPerson.Command command)
        {
            var response = await mediator.Send(command);
            return response == null ? NotFound() : Ok(response);
        }

    }

}
