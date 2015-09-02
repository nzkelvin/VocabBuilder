using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VocabBuilder.Model;
using VocabBuilder.Model.Interfaces;

namespace VocabBuilder.Web.Controllers
{
    public class WordViewModel
    {
        public VocabBuilder.Model.Word Word { get; set; }
        public IEnumerable<VocabBuilder.Model.Word> Words { get; set; }
    }

    public class WordController : Controller
    {
        private readonly IWordRepo _wordRepo;

        public WordController(IWordRepo repo)
        {
            _wordRepo = repo;
        }

        //
        // GET: /Word/
        public ActionResult Index()
        {
            var wordViewModel = new WordViewModel();
            wordViewModel.Words = _wordRepo.GetWords();

            return View(wordViewModel);
        }

        //
        // GET: /Word/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Word/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Word/Create
        [HttpPost]
        public ActionResult Create(Word word)
        {
            try
            {
                _wordRepo.AddWord(word);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Word/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Word/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Word/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Word/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
