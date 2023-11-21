// This controller handles requests related to songs from the MySql database.
// Key Points:
// - Actions for listing, Creating, Reading, Updating, and Deleting songs.(C.R.U.D.)
// - Uses Repository for data access.

using SongsByDecade.Models;
using Microsoft.AspNetCore.Mvc;
namespace SongsByDecade.Controllers
{
    public class SongsFrom1990Controller : Controller
    {
        private readonly ISongRepository _repo;

        public SongsFrom1990Controller(ISongRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var songs = _repo.GetAllSongsFrom1990();
            return View(songs);
        }

        public IActionResult ViewSong(int id)
        {
            var song = _repo.GetSongFrom1990(id);
            return View(song);
        }

        public IActionResult UpdateSong(int id)
        {
            var song = _repo.GetSongFrom1990(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult UpdateSongToDatabase(SongsFrom1990 song)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateSongFrom1990(song);
                return RedirectToAction("Index", new { id = song.ID });
            }

            // If the model is not valid, return the view with validation errors
            return View("UpdateSong", song);
        }

        public IActionResult CreateSong()
        {
            return View();
        }

        public IActionResult AddSongToDatabase(SongsFrom1990 song)
        {
            if (ModelState.IsValid)
            {
                _repo.AddSongFrom1990(song);
                return RedirectToAction("Index");
            }

            // If the model is not valid, return the view with validation errors
            return View("CreateSong", song);
        }

        public IActionResult DeleteSong(int id)
        {
            var song = _repo.GetSongFrom1990(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult DeleteSongFromDatabase(int id)
        {
            _repo.DeleteSongFrom1990(id);
            return RedirectToAction("Index");
        }
    }
}
