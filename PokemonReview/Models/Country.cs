namespace PokemonReview.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationship (one - many)

        //Many (i.e country has many owners) 
        // Many is always help in an i Collection or list
        public ICollection<Owner> Owners { get; set;}
    }
}
