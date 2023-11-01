namespace PokemonReview.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //creating Many to Many relationships
        public ICollection<PokemonCatagory> PokemonCatagories { get; set; }
    }
}
