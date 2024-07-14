using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PicCard.Repositories;

namespace PicCard.Controllers
{
    public class FlashcardsController : Controller
    {
        // GET: FlashcardsController
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult ListFlashcards()
        {
            var flaschcardRepository = new FlashcardsRepository();
            var flashcards = flaschcardRepository.GetAllFlashcards();
            return View(flashcards);
        }

        // GET: FlashcardsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlashcardsController/Create
        public ActionResult CreateFlashcards()
        {
            return View();
        }

        // POST: FlashcardsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlashcardsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlashcardsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlashcardsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlashcardsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
