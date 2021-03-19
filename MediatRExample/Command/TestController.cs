using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Command
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IMediator _mediator;

        public TestController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> About()
        {
            // example of request/response messages
            var result = await _mediator.Send(new Ping());
            //ViewData["Message"] = $"Your application description page: {result}";

            return Ok(result);
        }
    }

    public class Ping : IRequest<string> { }
    public class Ping2Handler : IRequestHandler<Ping, string>
    {


        public async Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return "dddd";
        }
    }
    public class PingHandler : IRequestHandler<Ping, string>
    {
        

        public   async  Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return "Merhaba";
        }
    }
    // optional to show what happens with multiple handlers
    
}
