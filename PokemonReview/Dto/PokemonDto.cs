namespace PokemonReview.Dto
{
    public class PokemonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class CreatePokemonDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
