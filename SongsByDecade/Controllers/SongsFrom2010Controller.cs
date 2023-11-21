// This controller handles requests related to songs from the MySql database.
// Key Points:
// - Actions for listing, Creating, Reading, Updating, and Deleting songs.(C.R.U.D.)
// - Uses Repository for data access.

using SongsByDecade.Models;
using Microsoft.AspNetCore.Mvc;
namespace SongsByDecade.Controllers

{
    public class SongsFrom2010Controller : Controller
    {
        private readonly ISongRepository _repo;

        public SongsFrom2010Controller(ISongRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var songs = _repo.GetAllSongsFrom2010();
            return View(songs);
        }

        public IActionResult ViewSong(int id)
        {
            var song = _repo.GetSongFrom2010(id);
            return View(song);
        }

        public IActionResult UpdateSong(int id)
        {
            var song = _repo.GetSongFrom2010(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult UpdateSongToDatabase(SongsFrom2010 song)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateSongFrom2010(song);
                return RedirectToAction("Index", new { id = song.ID });
            }

            // If the model is not valid, return the view with validation errors
            return View("UpdateSong", song);
        }

        public IActionResult CreateSong()
        {
            return View();
        }

        public IActionResult AddSongToDatabase(SongsFrom2010 song)
        {
            if (ModelState.IsValid)
            {
                _repo.AddSongFrom2010(song);
                return RedirectToAction("Index");
            }

            // If the model is not valid, return the view with validation errors
            return View("CreateSong", song);
        }

        public IActionResult DeleteSong(int id)
        {
            var song = _repo.GetSongFrom2010(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult DeleteSongFromDatabase(int id)
        {
            _repo.DeleteSongFrom2010(id);
            return RedirectToAction("Index");
        }
    }
}

