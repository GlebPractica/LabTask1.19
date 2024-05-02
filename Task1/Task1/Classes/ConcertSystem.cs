using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class ConcertSystem
    {
        private string _dbPath;
        private string connectionString;

        private User _currentUsers;

        public ConcertSystem() 
        {
            _dbPath = Environment.CurrentDirectory;
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={_dbPath}\\VoiceVotingDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public void AddUser(User user)                                 
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Запрос для получения последнего UserID
                string lastUserIDQuery = "SELECT MAX(UserID) FROM Users;";

                SqlCommand getLastUserIDCmd = new SqlCommand(lastUserIDQuery, conn);

                int lastUserID = 0;

                conn.Open();
                var result = getLastUserIDCmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    lastUserID = (int)result;
                }

                // Увеличиваем последний UserID на единицу для нового пользователя
                int newUserID = lastUserID + 1;

                // Запрос на добавление нового пользователя с указанным UserID
                string query = $"INSERT INTO Users (UserID, Name, Login, Password) VALUES (@UserID, @Name, @Login, @Password);";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Передаем параметры запроса
                cmd.Parameters.AddWithValue("@UserID", newUserID);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Login", user.Login);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                cmd.ExecuteNonQuery();
            }
        }

        public User GetUser(string login, string pass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"SELECT UserID,Name,Login,Password FROM Users WHERE Login = '{login}' AND Password = '{pass}';";

                SqlCommand com = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userid = Convert.ToInt16(reader["UserID"].ToString());
                        string name = reader["Name"].ToString();
                        string log = reader["Login"].ToString();
                        string pas = reader["Password"].ToString();

                        _currentUsers = new User() { UserID = userid, Login = log, Name = name, Password = pas };

                        return _currentUsers;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public bool IsUserVote(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $"SELECT UserID FROM Votes WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);

                    con.Open();

                    object res= cmd.ExecuteScalar();

                    if (res == null)
                        return false;
                    else
                        return true;
                }
            }
        }

        public void AddSongVote(Vote vote)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"INSERT INTO Votes VALUES (@VoteID, @UserID, @Singer, @Song);";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                string lastVoteIDQuery = "SELECT MAX(VoteID) FROM Votes;";

                SqlCommand getLastVoteIDCmd = new SqlCommand(lastVoteIDQuery, conn);

                int lastVoteID = 0;

                var result = getLastVoteIDCmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    lastVoteID = (int)result;
                }

                // Увеличиваем последний VoteID на единицу для нового пользователя
                int newVoteID = lastVoteID + 1;

                cmd.Parameters.AddWithValue("@VoteID", newVoteID);
                cmd.Parameters.AddWithValue("@UserID", vote.UserID);
                cmd.Parameters.AddWithValue("@Singer", vote.Singer);
                cmd.Parameters.AddWithValue("@Song", vote.Song);

                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetTopSongs()
        {
            List<string> topSongs = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"SELECT Singer, Song, COUNT(*) AS VotesCount FROM Votes GROUP BY Singer, Song ORDER BY VotesCount DESC;";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string singer = reader["Singer"].ToString();
                        string song = reader["Song"].ToString();
                        int votesCount = Convert.ToInt32(reader["VotesCount"]);

                        string songInfo = $"{singer} - {song} ({votesCount} голосов)";
                        topSongs.Add(songInfo);
                    }
                }
            }

            return topSongs;
        }

        public void AddConcert(ConcertSettings concert)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string lastConcertIDQuery = "SELECT MAX(ConcertID) FROM ConcertSettings;";

                SqlCommand getLastConcertIDCmd = new SqlCommand(lastConcertIDQuery, conn);

                int lastConcertID = 0;

                conn.Open();
                var result = getLastConcertIDCmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    lastConcertID = (int)result;
                }

                // Увеличиваем последний ConcertID на единицу для нового концерта
                int newConcertID = lastConcertID + 1;

                string query = $"INSERT INTO ConcertSettings VALUES (@ConcertID, @Name, @TicketPrice, @Venue, @MaxSongs);";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ConcertID", newConcertID);
                cmd.Parameters.AddWithValue("@Name", concert.Name);
                cmd.Parameters.AddWithValue("@TicketPrice", concert.TicketPrice);
                cmd.Parameters.AddWithValue("@Venue", concert.Venue);
                cmd.Parameters.AddWithValue("@MaxSongs", concert.MaxSongs);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
