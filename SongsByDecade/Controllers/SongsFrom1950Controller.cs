// This controller handles requests related to songs from the MySql database.
// Key Points:
// - Actions for listing, Creating, Reading, Updating, and Deleting songs.(C.R.U.D.)
// - Uses Repository for data access.

using SongsByDecade.Models;
using Microsoft.AspNetCore.Mvc;
namespace SongsByDecade.Controllers
{
    public class SongsFrom1950Controller : Controller
    {
        private readonly ISongRepository _repo;

        public SongsFrom1950Controller(ISongRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var songs = _repo.GetAllSongsFrom1950();
            return View(songs);
        }

        public IActionResult ViewSong(int id)
        {
            var song = _repo.GetSongFrom1950(id);
            return View(song);
        }

        public IActionResult UpdateSong(int id)
        {
            var song = _repo.GetSongFrom1950(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult UpdateSongToDatabase(SongsFrom1950 song)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateSongFrom1950(song);
                return RedirectToAction("Index", new { id = song.ID });
            }

            // If the model is not valid, return the view with validation errors
            return View("UpdateSong", song);
        }

        public IActionResult CreateSong()
        {
            return View();
        }

        public IActionResult AddSongToDatabase(SongsFrom1950 song)
        {
            if (ModelState.IsValid)
            {
                _repo.AddSongFrom1950(song);
                return RedirectToAction("Index");
            }

            // If the model is not valid, return the view with validation errors
            return View("CreateSong", song);
        }

        public IActionResult DeleteSong(int id)
        {
            var song = _repo.GetSongFrom1950(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }

        public IActionResult DeleteSongFromDatabase(int id)
        {
            _repo.DeleteSongFrom1950(id);
            return RedirectToAction("Index");
        }
    }
}

{
    public class SongsFrom1950Controller : Controller
    {
        private readonly ISongRepository _repo;

        public SongsFrom1950Controller(ISongRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var songs = _repo.GetAllSongs();
            return View(songs);
        }

        public IActionResult ViewSong(int id)
        {
            var song = _repo.GetSong(id);
            return View(song);
        }

        public IActionResult UpdateSong(int id)
        {
            SongsFrom1950 song = _repo.GetSong(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }
        public IActionResult UpdateSongToDatabase(SongsFrom1950 song)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateSong(song);
                return RedirectToAction("Index", new { id = song.ID });
            }

            // If the model is not valid, return the view with validation errors
            return View("UpdateSong", song);
        }
        public IActionResult CreateSong()
        {
            return View();
        }
        public IActionResult AddSongToDatabase(SongsFrom1950 song)
        {
            if (ModelState.IsValid)
            {
                _repo.AddSong(song);
                return RedirectToAction("Index");
            }

            return View("CreateSong", song);
        }
        public IActionResult DeleteSong(int id)
        {
            var song = _repo.GetSong(id);
            if (song == null)
            {
                return View("Song Not Found");
            }
            return View(song);
        }
        public IActionResult DeleteSongFromDatabase(int id)
        {
            _repo.DeleteSong(id);
            return RedirectToAction("Index");
        }
    }
}
