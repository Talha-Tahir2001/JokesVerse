namespace JokesVerse.Models
{
    public class Joke
    {
        public int id { get; set; }
        public required string JokeQuestion { get; set; }
        public required string JokeAnswer { get; set; }

        
    }
}
