// This class represents the model for songs retrieved from the MySql database.
// Key Points:
// - Properties for title, artist, genre, and year released.(It is important that these
//   names match the names in your MySql columns.)

using System.ComponentModel.DataAnnotations;

namespace SongsByDecade.Models
{
    public class SongsFrom1980
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Artist is required")]
        public string Artist { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Year Released is required")]
        public int YearReleased { get; set; }
    }
}
