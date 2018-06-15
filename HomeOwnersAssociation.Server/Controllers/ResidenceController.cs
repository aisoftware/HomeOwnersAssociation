using HomeOwnersAssociation.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeOwnersAssociation.Server.Controllers
{
    [Route("api/[controller]")]
    public class ResidenceController : Controller
    {
        private static string[] Streets = new[]
       {
            "My Street", "That Other Street", "Your Drive"
        };

        [HttpGet("[action]")]
        public IEnumerable<Residence> List()
        {
            var rng = new Random();
            return Enumerable.Range(1, 25).Select(index => new Residence
            {
                Id = Guid.NewGuid(),
                Lot = $"A{index}",
                Address = new Address
                {
                    Id  = Guid.NewGuid(),
                    Street = $"{18000 + index} {Streets[rng.Next(Streets.Length)]}",
                    City = "My City",
                    State = "XX",
                    Zip = "77777-1234"
                }
            });
        }
    }
}
