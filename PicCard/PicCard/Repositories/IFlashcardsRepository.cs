using PicCard.Models;

namespace PicCard.Repositories
{
    public interface IFlashcardsRepository
    {
        Flashcard AddFlashcard(Flashcard flashcard);
        Flashcard UpdateFlashcard(Flashcard flashcard);
        Flashcard GetFlashcard(string id);
        void DeleteFlashcard(string id);
        IEnumerable<Flashcard> GetAllFlashcards();
    }
}
