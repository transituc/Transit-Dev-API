using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Transit_Dev_API_1.Models;
using Transit_Dev_API_1.Services;

namespace Transit_Dev_API_1.Controllers
{
    // The following endpoints will be accesible on http://localhost:57089/api/punctualitydriverinformation

    [Route("api/[controller]")]
    public class PunctualityDriverInformationController : Controller
    {
        private readonly ProgrammedStopService _stopService;

        public PunctualityDriverInformationController(ProgrammedStopService service)
        {
            this._stopService = service;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // The following statement gets all the programmed stops. 
            // TODO: Replace it appropriately.
            var result = this._stopService.Get();

            // TODO: Implement your logic.

            // TODO: The following line is just a placeholder you should replace. You can change this method's return type, too.
            return new string[] { "value1", "value2" };
        }


        //IActionResult<NextStopResponse> Get([FromBody] NextStop nextStop ) netcore2.2
        [HttpGet(Name = "GetNextStop")]
        public NextStopResponse Get([FromBody] NextStop nextStop)
        {
            //En caso de ser una peticion correcta, retorno el Json con estructura solicitada con condigo de status 200.
            return nextStop.CalculateNextStop(nextStop);
            //En caso contrario un BadRequest o una Exception Personalizada.
        }

    }
}
