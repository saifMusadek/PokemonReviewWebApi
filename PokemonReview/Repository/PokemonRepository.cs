﻿using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class PokemonRepository :IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.pokemons.Where(p=>p.Id==id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.pokemons.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.reviews.Where(p => p.Pokemon.Id == pokeId);
            if (review.Count() <= 0) { 
            }

            return ((decimal)review.Sum(r => r.Rating)/review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.pokemons.OrderBy(p=>p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.pokemons.Any(p => p.Id == pokeId);
        }
    }
}
