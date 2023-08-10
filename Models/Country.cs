namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owner { get; set; }

    }
}
