using AutoMapper;
using PokemonReview.Dto;
using PokemonReview.Models;
using System.Runtime.InteropServices;

namespace PokemonReview.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
