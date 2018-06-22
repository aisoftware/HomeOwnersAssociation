using HomeOwnersAssociation.Shared;
using HomeOwnersAssociation.Shared.Members;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            return JsonConvert.DeserializeObject<List<Residence>>(System.IO.File.ReadAllText(@"./App_Data/residences.json"));

            //var rng = new Random();
            //var results = new List<Residence>();
            //var members = JsonConvert.DeserializeObject<List<Member>>(System.IO.File.ReadAllText(@"./App_Data/members.json"));
            //for (var index = 1; index < 60; index++)
            //{
            //    var residence = new Residence
            //    {
            //        Id = Guid.NewGuid(),
            //        Lot = $"A{index}",
            //        Address = new Address
            //        {
            //            Id = Guid.NewGuid(),
            //            Street = $"{18000 + index} {Streets[rng.Next(Streets.Length)]}",
            //            City = "My City",
            //            State = "XX",
            //            Zip = "77777-1234"
            //        },
            //        OwnershipHistory = new List<Ownership> {
            //            new Ownership {
            //                Id = Guid.NewGuid(),
            //                PurchaseDate = DateTimeOffset.Now.Date.AddMonths(-10),
            //                Members = members.Skip(index).Take(1).ToList()
            //            }
            //        }
            //    };
            //    results.Add(residence);
            //}
            //return results;
        }
    }
}
