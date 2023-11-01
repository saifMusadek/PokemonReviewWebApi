namespace PokemonReview.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relationship (one - many)

        //Many (i.e Reviewer has many reviews) 
        // Many is always help in an i Collection or list
        public ICollection<Review> Reviews { get; set;}
    }
}
