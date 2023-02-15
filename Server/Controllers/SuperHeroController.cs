using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperDB.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperDB.Server.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase //so this is a base class for an mvc model view controller, i.e controller without view support and 
                                                      //that because our view in the case is the blazor web assembly client 
    {
        //we could use enums but let make use of class in form of list
       static List<Comic> comics = new List<Comic>
        {
            new Comic { Id = 1, Name = "Marvel"},
            new Comic {Id = 2, Name = "DC"}
        };

        //so because we dont have a data base yet we will create a list 
      static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman", Comic= comics[0] },
            new SuperHero { Id =2, FirstName ="Bruce", LastName = "Wayne", HeroName = "Batman", Comic = comics[1] },
        };

        [HttpGet("comics")]
        public async Task<IActionResult> GetComics()
        {
            return Ok(comics);
        }
        //so we create our first Get call methed to read superHero 
        [HttpGet]
        public async Task<IActionResult> GetSuperHeros()
        // <IActionResult> enbles us to return an HTTP Status code 
        {
            return Ok(heroes);
        }
        [HttpGet("{id}")]
       // [Route("")]
        public async Task<IActionResult> GetSingleSuperHero(int id)
        {
            var hero = heroes.FirstOrDefault(h=> h.Id == id);
            if (hero == null)
                return NotFound("Super Hero Wasn't Found. To bad!!!");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSuperHero(SuperHero hero)
        {
            hero.Id = heroes.Max(h => h.Id + 1);
            heroes.Add(hero);
            return Ok(heroes);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSuperHero(SuperHero hero, int id)
        {

            var dbHero = heroes.FirstOrDefault(h => h.Id == id);
            if (dbHero == null)
                return NotFound("Super Hero Wasn't Found. To bad!!!");
            var index = heroes.IndexOf(dbHero);
            heroes[index] = hero;
            return Ok(heroes);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuperHero( int id)
        {

            var dbHero = heroes.FirstOrDefault(h => h.Id == id);
            if (dbHero == null)
                return NotFound("Super Hero Wasn't Found. To bad!!!");
           heroes.Remove(dbHero);
            return Ok(heroes);
        }
    }
}
