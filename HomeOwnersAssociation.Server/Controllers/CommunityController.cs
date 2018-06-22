using HomeOwnersAssociation.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeOwnersAssociation.Server.Controllers
{
    [Route("api/[controller]")]
    public class CommunityController : Controller
    {
        [HttpGet("[action]")]
        public Community Details()
        {
            return new Community
            {
                Id = Guid.NewGuid(),
                Name = "Shadows of Sample River",
            };
        }
    }
}
