namespace PokemonReview.Dto
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreateCountryDto
    {
        public string Name { get; set; }
    }
}
