namespace PokemonReview.Models
{
    public class PokemonOwner
    {
        //join table (first create these join table and then declare them to their individual tables)
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }

        public Pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }

    }
}
