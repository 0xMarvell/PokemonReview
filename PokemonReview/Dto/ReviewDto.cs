namespace PokemonReview.Dto
{    public class ReviewDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }

    public class CreateReviewDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
