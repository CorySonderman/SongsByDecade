// This class implements the ISongRepository interface for data access to songs from
// the MySql database.
// Key Points:
// - Implements methods for retrieving, updating, adding, and deleting songs.
// - Uses Dapper for database interactions.

using Dapper;
using SongsByDecade.Models;
using SongsByDecade;
using System.Data;

namespace PracticeFinalProject
{
    public class SongsRepository : ISongRepository
    {
        private readonly IDbConnection _conn;

        public SongsRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<SongsFrom1950> GetAllSongsFrom1950()
        {
            return _conn.Query<SongsFrom1950>("SELECT * FROM songs_1950s;");
        }
        public SongsFrom1950 GetSongFrom1950(int id)
        {
            return _conn.QuerySingle<SongsFrom1950>("SELECT * FROM songs_1950s WHERE ID = @id", new { id = id });
        }
        public void UpdateSongFrom1950(SongsFrom1950 song)
        {
            _conn.Execute("UPDATE songs_1950s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }
        public void AddSongFrom1950(SongsFrom1950 song)
        {
            _conn.Execute("INSERT INTO songs_1950s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }
        public void DeleteSongFrom1950(int id)
        {
            _conn.Execute("DELETE FROM songs_1950s WHERE ID = @id", new { id });
        }

        public IEnumerable<SongsFrom1960> GetAllSongsFrom1960()
        {
            return _conn.Query<SongsFrom1960>("SELECT * FROM songs_1960s;");
        }

        public SongsFrom1960 GetSongFrom1960(int id)
        {
            return _conn.QuerySingle<SongsFrom1960>("SELECT * FROM songs_1960s WHERE ID = @id", new { id = id });
        }

        public void UpdateSongFrom1960(SongsFrom1960 song)
        {
            _conn.Execute("UPDATE songs_1960s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }

        public void AddSongFrom1960(SongsFrom1960 song)
        {
            _conn.Execute("INSERT INTO songs_1960s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }

        public void DeleteSongFrom1960(int id)
        {
            _conn.Execute("DELETE FROM songs_1960s WHERE ID = @id", new { id });
        }

        public IEnumerable<SongsFrom1970> GetAllSongsFrom1970()
        {
            return _conn.Query<SongsFrom1970>("SELECT * FROM songs_1970s;");
        }

        public SongsFrom1970 GetSongFrom1970(int id)
        {
            return _conn.QuerySingle<SongsFrom1970>("SELECT * FROM songs_1970s WHERE ID = @id", new { id = id });
        }

        public void UpdateSongFrom1970(SongsFrom1970 song)
        {
            _conn.Execute("UPDATE songs_1970s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }

        public void AddSongFrom1970(SongsFrom1970 song)
        {
            _conn.Execute("INSERT INTO songs_1970s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }

        public void DeleteSongFrom1970(int id)
        {
            _conn.Execute("DELETE FROM songs_1970s WHERE ID = @id", new { id });
        }

        public IEnumerable<SongsFrom1980> GetAllSongsFrom1980()
        {
            return _conn.Query<SongsFrom1980>("SELECT * FROM songs_1980s;");
        }

        public SongsFrom1980 GetSongFrom1980(int id)
        {
            return _conn.QuerySingle<SongsFrom1980>("SELECT * FROM songs_1980s WHERE ID = @id", new { id = id });
        }

        public void UpdateSongFrom1980(SongsFrom1980 song)
        {
            _conn.Execute("UPDATE songs_1980s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }

        public void AddSongFrom1980(SongsFrom1980 song)
        {
            _conn.Execute("INSERT INTO songs_1980s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }

        public void DeleteSongFrom1980(int id)
        {
            _conn.Execute("DELETE FROM songs_1980s WHERE ID = @id", new { id });
        }

        public IEnumerable<SongsFrom1990> GetAllSongsFrom1990()
        {
            return _conn.Query<SongsFrom1990>("SELECT * FROM songs_1990s;");
        }

        public SongsFrom1990 GetSongFrom1990(int id)
        {
            return _conn.QuerySingle<SongsFrom1990>("SELECT * FROM songs_1990s WHERE ID = @id", new { id = id });
        }

        public void UpdateSongFrom1990(SongsFrom1990 song)
        {
            _conn.Execute("UPDATE songs_1990s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }

        public void AddSongFrom1990(SongsFrom1990 song)
        {
            _conn.Execute("INSERT INTO songs_1990s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }

        public void DeleteSongFrom1990(int id)
        {
            _conn.Execute("DELETE FROM songs_1990s WHERE ID = @id", new { id });
        }

        public IEnumerable<SongsFrom2000> GetAllSongsFrom2000()
        {
            return _conn.Query<SongsFrom2000>("SELECT * FROM songs_2000s;");
        }

        public SongsFrom2000 GetSongFrom2000(int id)
        {
            return _conn.QuerySingle<SongsFrom2000>("SELECT * FROM songs_2000s WHERE ID = @id", new { id = id });
        }

        public void UpdateSongFrom2000(SongsFrom2000 song)
        {
            _conn.Execute("UPDATE songs_2000s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }

        public void AddSongFrom2000(SongsFrom2000 song)
        {
            _conn.Execute("INSERT INTO songs_2000s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }

        public void DeleteSongFrom2000(int id)
        {
            _conn.Execute("DELETE FROM songs_2000s WHERE ID = @id", new { id });
        }

        public IEnumerable<SongsFrom2010> GetAllSongsFrom2010()
        {
            return _conn.Query<SongsFrom2010>("SELECT * FROM songs_2010s;");
        }

        public SongsFrom2010 GetSongFrom2010(int id)
        {
            return _conn.QuerySingle<SongsFrom2010>("SELECT * FROM songs_2010s WHERE ID = @id", new { id = id });
        }

        public void UpdateSongFrom2010(SongsFrom2010 song)
        {
            _conn.Execute("UPDATE songs_2010s SET Title = @Title, Artist = @Artist, Genre = @Genre, YearReleased = @YearReleased WHERE ID = @ID", song);
        }

        public void AddSongFrom2010(SongsFrom2010 song)
        {
            _conn.Execute("INSERT INTO songs_2010s (Title, Artist, Genre, YearReleased) VALUES (@Title, @Artist, @Genre, @YearReleased)", song);
        }

        public void DeleteSongFrom2010(int id)
        {
            _conn.Execute("DELETE FROM songs_2010s WHERE ID = @id", new { id });
        }

    }
}

