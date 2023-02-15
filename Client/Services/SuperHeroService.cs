using SuperDB.Client.Server;
using SuperDB.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SuperDB.Client.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient httpClient;

        // so we add a contructor
        public SuperHeroService(HttpClient httpClient)// so here i made use of dependency injection by injecting HttpClient
        {
            this.httpClient = httpClient;
        }

        public List<Comic> Comics { get; set; } = new List<Comic>();

        public List<SuperHero> Heroes { get; set; } = new List<SuperHero>();

        public event Action OnChange;

        public async Task<List<SuperHero>> CreateSuperHero(SuperHero hero)
        {
         var result= await httpClient.PostAsJsonAsync<SuperHero>($"api/superhero/", hero);
            Heroes = await  result.Content.ReadFromJsonAsync<List<SuperHero>>();
            OnChange.Invoke();
            return Heroes;
        }

        public async Task<List<SuperHero>> DeleteSuperHero(int id)
        {
            var result = await httpClient.DeleteAsync($"api/superhero/{id}");
            Heroes = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            OnChange.Invoke();
            return Heroes;
        }

        public async Task GetComics()
        {
            Comics = await httpClient.GetFromJsonAsync<List<Comic>>($"api/superhero/comics");
        }

        public async Task<SuperHero> GetSuperHero(int id)
        {
            return await httpClient.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
        }

        public async Task<List<SuperHero>> GetSuperHeros()
        {
         Heroes = await httpClient.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            return Heroes;
        }

        public async Task<List<SuperHero>> UpdateSuperHero(SuperHero hero, int id)
        {
            var result = await httpClient.PutAsJsonAsync<SuperHero>($"api/superhero/{id}", hero);
            Heroes = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            OnChange.Invoke();
            return Heroes;
        }
    }
}
