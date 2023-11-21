// This controller handles requests related to songs from the MySql database.
// Key Points:
// - Actions for listing, Creating, Reading, Updating, and Deleting songs.(C.R.U.D.)
// - Uses Repository for data access.

using SongsByDecade.Models;
using Microsoft.AspNetCore.Mvc;
namespace SongsByDecade.Controllers

{
    public class SongsFrom1970Controller : Controller
    {
        private readonly ISongRepository _repo;

        public SongsFrom1970Controller(ISongRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var songs = _repo.GetAllSongsFrom1970();
            return View(songs);
        }

        public IActionResult ViewSong(int id)
        {
            var song = _repo.GetSongFrom1970(id);
            return View(song);
        }

        public IActionResult UpdateSong(int id)
        {
            var song = _repo.GetSongFrom1970(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult UpdateSongToDatabase(SongsFrom1970 song)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateSongFrom1970(song);
                return RedirectToAction("Index", new { id = song.ID });
            }

            return View("UpdateSong", song);
        }

        public IActionResult CreateSong()
        {
            return View();
        }

        public IActionResult AddSongToDatabase(SongsFrom1970 song)
        {
            if (ModelState.IsValid)
            {
                _repo.AddSongFrom1970(song);
                return RedirectToAction("Index");
            }

            return View("CreateSong", song);
        }

        public IActionResult DeleteSong(int id)
        {
            var song = _repo.GetSongFrom1970(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult DeleteSongFromDatabase(int id)
        {
            _repo.DeleteSongFrom1970(id);
            return RedirectToAction("Index");
        }
    }
}

