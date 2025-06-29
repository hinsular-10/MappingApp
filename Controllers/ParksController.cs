using Microsoft.AspNetCore.Mvc;
using ParksApi.Models;

namespace ParksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetParks()
        {
            var parks = new List<Park>
        {
                new Park
    {
        Id = 1,
        Name = "Banff National Park",
        Location = "Alberta",
        Description = "A beautiful national park in the Canadian Rockies.",
        Area = 6641,
        EstablishedDate = new DateTime(1885, 1, 1),
        Activities = new[] { "Hiking", "Camping", "Wildlife Viewing" }
    },
    new Park
    {
        Id = 2,
        Name = "Jasper National Park",
        Location = "Alberta",
        Description = "Known for its vast wilderness and wildlife.",
        Area = 10878,
        EstablishedDate = new DateTime(1907, 1, 1),
        Activities = new[] { "Hiking", "Canoeing", "Skiing" }
    },
    new Park
    {
        Id = 3,
        Name = "Pacific Rim National Park",
        Location = "British Columbia",
        Description = "Famous for its rugged coastline and rainforests.",
        Area = 511,
        EstablishedDate = new DateTime(1970, 1, 1),
        Activities = new[] { "Surfing", "Hiking", "Beachcombing" }
    }
        };

            // [HttpGet]
            // public ActionResult<IEnumerable<Park>> GetParks()
            {
                return Ok(parks);
            }
        }
    }
}
