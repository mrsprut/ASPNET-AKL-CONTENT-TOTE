using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace AKL_CONTENT_TOTE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AklContentToteController : ControllerBase
    {
        public List<AklContentTote> Get()
        {
            return new Fake_SAPContext().AklContentTotes.ToList();
        }
    }
}