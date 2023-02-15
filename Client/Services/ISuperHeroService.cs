using SuperDB.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperDB.Client.Server
{
    public interface ISuperHeroService
    {
        event Action OnChange;
        List<Comic> Comics { get; set; }
        List<SuperHero> Heroes { get; set; }
        //So we create a method that returns list of super hereos 
        Task<List<SuperHero>> GetSuperHeros();
        Task GetComics();
        Task<SuperHero> GetSuperHero(int id);
        Task<List<SuperHero>> CreateSuperHero(SuperHero hero);

        Task<List<SuperHero>> UpdateSuperHero(SuperHero hero, int id);

        Task<List<SuperHero>> DeleteSuperHero(int id);

    }
}
