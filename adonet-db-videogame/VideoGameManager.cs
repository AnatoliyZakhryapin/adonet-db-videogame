using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace adonet_db_videogame
{
    internal static class VideoGameManager
    {
        private const string STRINGA_DI_CONNESSIONE = "Data Source=localhost;Initial Catalog=db-videogames-query;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";

        internal static void AddNewGame(VideoGame newVideoGame)
        {
            //throw new NotImplementedException();

            using SqlConnection connessioneSql = new SqlConnection(STRINGA_DI_CONNESSIONE);

            try
            {
                connessioneSql.Open();
                string query = @"INSERT INTO videogames (name, overview, release_date, created_at, updated_at, software_house_id)
VALUES (@name, @overview, @release_date, @created_at, @updated_at, @sh_id)";

                using SqlCommand cmd = new SqlCommand(query, connessioneSql);
                InsertInternal(cmd, newVideoGame);
            }
            catch (Exception ex) { }
        }

        private static int InsertInternal(SqlCommand cmd, VideoGame newVideoGame)
        {
            cmd.Parameters.Add(new SqlParameter("@name", newVideoGame.Name));
            cmd.Parameters.Add(new SqlParameter("@overview", newVideoGame.Overview));
            cmd.Parameters.Add(new SqlParameter("@release_date", newVideoGame.ReleaseDate));
            cmd.Parameters.Add(new SqlParameter("@created_at", newVideoGame.CreateAt));
            cmd.Parameters.Add(new SqlParameter("@updated_at", newVideoGame.UpdateAt));
            cmd.Parameters.Add(new SqlParameter("@sh_id", newVideoGame.SoftwareHouseID));

            int affectedRows = cmd.ExecuteNonQuery();
            return affectedRows;
        }
    }
}
