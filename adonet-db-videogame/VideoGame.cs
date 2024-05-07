using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet_db_videogame
{
    internal class VideoGame
    {
        public long Id {  get; }
        public string Name { get; private set; }
        public string Overview { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set;}
        public long SoftwareHouseID { get; private set; }

        public VideoGame (string name, string overview, DateTime releaseDate, DateTime createAt, long softwareHouseID)
        {
            Name = name;
            Overview = overview;
            ReleaseDate = releaseDate;
            CreateAt = createAt;
            UpdateAt = createAt;
            SoftwareHouseID = softwareHouseID;
        }
    }
}
