// This interface defines the contract for data access to songs.
// Key Points:
// - Methods for adding(Creating), retrieving(Reading), Updating, and Deleting
//   data in the database.  This is also referred to C.R.U.D.
using SongsByDecade.Models;

namespace SongsByDecade
{
    public interface ISongRepository
    {
        IEnumerable<SongsFrom1950> GetAllSongsFrom1950();
        SongsFrom1950 GetSongFrom1950(int id);
        void UpdateSongFrom1950(SongsFrom1950 song);
        void AddSongFrom1950(SongsFrom1950 song);
        void DeleteSongFrom1950(int id);

        IEnumerable<SongsFrom1960> GetAllSongsFrom1960();
        SongsFrom1960 GetSongFrom1960(int id);
        void UpdateSongFrom1960(SongsFrom1960 song);
        void AddSongFrom1960(SongsFrom1960 song);
        void DeleteSongFrom1960(int id);

        IEnumerable<SongsFrom1970> GetAllSongsFrom1970();
        SongsFrom1970 GetSongFrom1970(int id);
        void UpdateSongFrom1970(SongsFrom1970 song);
        void AddSongFrom1970(SongsFrom1970 song);
        void DeleteSongFrom1970(int id);

        IEnumerable<SongsFrom1980> GetAllSongsFrom1980();
        SongsFrom1980 GetSongFrom1980(int id);
        void UpdateSongFrom1980(SongsFrom1980 song);
        void AddSongFrom1980(SongsFrom1980 song);
        void DeleteSongFrom1980(int id);

        IEnumerable<SongsFrom1990> GetAllSongsFrom1990();
        SongsFrom1990 GetSongFrom1990(int id);
        void UpdateSongFrom1990(SongsFrom1990 song);
        void AddSongFrom1990(SongsFrom1990 song);
        void DeleteSongFrom1990(int id);

        IEnumerable<SongsFrom2000> GetAllSongsFrom2000();
        SongsFrom2000 GetSongFrom2000(int id);
        void UpdateSongFrom2000(SongsFrom2000 song);
        void AddSongFrom2000(SongsFrom2000 song);
        void DeleteSongFrom2000(int id);

        IEnumerable<SongsFrom2010> GetAllSongsFrom2010();
        SongsFrom2010 GetSongFrom2010(int id);
        void UpdateSongFrom2010(SongsFrom2010 song);
        void AddSongFrom2010(SongsFrom2010 song);
        void DeleteSongFrom2010(int id);
    }
}
