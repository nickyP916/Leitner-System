using PicCard.Controllers;
using PicCard.Models;
using PicCard.Repositories;

namespace Tests
{
    public class FlashcardRepositoryShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_a_flashcard_from_given_inputs()
        {
            var front = "question";
            var back = "answer";

            var flashcardRepo = new FlashcardsRepository();
            var flashcardToAdd = new Flashcard(front, back);

            var createdFlashcard = flashcardRepo.AddFlashcard(flashcardToAdd);
            Assert.IsNotNull(createdFlashcard);
            Assert.That(createdFlashcard.Front, Is.EqualTo(front));
            Assert.That(createdFlashcard.Back, Is.EqualTo(back));
        }

    }
}