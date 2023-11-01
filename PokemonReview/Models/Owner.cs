namespace PokemonReview.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }

        //Relationship (one - one)

        //Many (i.e owner can only have one country) 
        // one is a singular object, hence stored as an object
        public Country Country { get; set; }


        //Creating Many to Many relationships
        public ICollection<PokemonOwner> PokemonOwners { get; set; }


    }
}
