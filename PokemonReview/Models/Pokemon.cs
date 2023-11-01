namespace PokemonReview.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }


        //Relationship (one - many)

        //Many (i.e pokemon has reviews)
        // Many is always kept in an i collection 
        public ICollection<Review> Reviews { get; set; }


        // Creating Many to Many relationshiops
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCatagory> PokemonCatagories { get; set; }

    }
}
