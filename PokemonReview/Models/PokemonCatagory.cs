namespace PokemonReview.Models
{
    public class PokemonCatagory
    {
        //join table (first create these join table and then declare them to their individual tables)
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Catagory Catagory { get; set; }
    }
}
