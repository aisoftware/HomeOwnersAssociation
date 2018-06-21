using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeOwnersAssociation.Shared;
using HomeOwnersAssociation.Shared.Members;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeOwnersAssociation.Server.Controllers
{
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private static string[] FirstNames = new[]
        {
            "Quinten", "Abigayle", "Rylan", "Ali", "Logan", "Darnell", "Eric", "Asa", "Dario", "Erin", "Saniya", "Amari", "Clay", "Skylar", "Bianca", "Camron", "Alec", "Tianna", "Dustin", "Marlee"
        };

        private static string[] LastNames = new[]
        {
            "Guerrero", "Hicks", "Graves", "Mora", "Snow", "Merritt", "Day", "Robbins", "Tucker", "Mitchell", "Baldwin", "Santana", "Donovan", "Medina", "Simmons", "Conley", "Mooney", "Goodwin", "Duffy", "Myers", "Calderon", "Chung", "Werner", "Meadows", "Krueger", "Young", "Pearson", "Mcclain", "Mcpherson", "Roman"
        };

        [HttpGet("[action]")]
        public IEnumerable<Member> List()
        {
            var rng = new Random();
            var results = new List<Member>();

            for (var index = 1; index <= 50; index++)
            {
                var First = FirstNames[rng.Next(FirstNames.Length)];
                var Last = LastNames[rng.Next(LastNames.Length)];

                results.Add(new Member
                {
                    Id = Guid.NewGuid(),
                    FirstName = First,
                    LastName = Last,
                    EmailAddress = $"{First}.{Last}@noplace",
                    PrivacyEnabled = index % 13 == 0,
                    PhoneNumbers = new List<PhoneNumber> {
                    new PhoneNumber {
                        Id = Guid.NewGuid(),
                        AreaCode = 123,
                        Number = 5550000 + index,
                        AllowTexting = index % 5 != 0,
                        Tags = new List<Tag<PhoneNumber>>() {
                            new Tag<PhoneNumber> { Id = Guid.NewGuid(), Name = index % 5 != 0 ? "Mobile" : "Home"}
                        }
                    }
                }
                });
            }
            return results;
        }

    }
}
