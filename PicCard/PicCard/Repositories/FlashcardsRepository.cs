using PicCard.Models;

namespace PicCard.Repositories
{
    public class FlashcardsRepository : IFlashcardsRepository
    {
        public FlashcardsRepository()
        {
                
        }
        public Flashcard AddFlashcard(Flashcard flashcard)
        {
            //TODO: add to db
            return flashcard;
        }

        public void DeleteFlashcard(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flashcard> GetAllFlashcards()
        {
            return [new Flashcard("1+1", "2"),
                new Flashcard("what do cows eat?", "grass"),
                new Flashcard("largest planet in solar system", "Jupiter"),
                new Flashcard("what is after t in alphabet?", "u")];
        }

        public Flashcard GetFlashcard(string id)
        {
            throw new NotImplementedException();
        }

        public Flashcard UpdateFlashcard(Flashcard flashcard)
        {
            throw new NotImplementedException();
        }
    }
}
