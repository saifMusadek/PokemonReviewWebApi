namespace PokemonReview.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public int Rating { get; set; }

        //Relationship (one - one)

        //Many (i.e each review can be made by an individual reviewer)) 
        // one is a singular object, hence stored as an object
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
