using AutoMapper;
using PokemonReview.Models;
using PokemonReview.Dto;
namespace PokemonReview.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Model to Dto
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();

            // Dto to Model (For creating new objects)
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<CreateCountryDto, Country>();
            CreateMap<CreateOwnerDto, Owner>();
            CreateMap<CreatePokemonDto, Pokemon>();
            CreateMap<CreateReviewDto, Review>();
            CreateMap<CreateReviewerDto, Reviewer>();

            // Dto to Model (For updating exisiting objects)
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
        }
    }
}

