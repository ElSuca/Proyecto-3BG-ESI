using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewAPIResult
{
    public class ModelPlayer : Model
    {
        public int? Id ;
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string Status { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? IdAsoc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? IdMana { get; set; }
        public int? IdTeam { get; set; }


        public ModelPlayer() : base()
        {
            base.connectDataBase();
        }
        public DataTable PopulatePlayer(int i)
        {
            this.command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC, CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, ID_TEAM AS TEAM FROM PLAYER LEFT JOIN (ASOC_PLYR, PLYR_TI, MANA_PLYR) on (PLAYER.ID = ASOC_PLYR.ID_PLYR AND PLAYER.ID=PLYR_TI.ID_PLYR AND PLAYER.ID=MANA_PLYR.ID_PLYR) WHERE PLAYER.ID <= @Id AND PLAYER.ID >=@I";
            this.command.Parameters.AddWithValue( "@Id", i*5);
            this.command.Parameters.AddWithValue("@I", ((i-1)*5) +1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulatePlayer(string s)
        {
            this.command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on (PLAYER.ID = ASOC_PLYR.ID_PLYR) WHERE PLAYER.NAME=@S OR PLAYER.LNAME1=@S OR PLAYER.LNAME2=@S";
            this.command.Parameters.AddWithValue("@S", s);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulatePlayerById(int i)
        {
            this.command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC, CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, ID_TEAM AS TEAM FROM PLAYER LEFT JOIN (ASOC_PLYR, PLYR_TI, MANA_PLYR) on (PLAYER.ID = ASOC_PLYR.ID_PLYR AND PLAYER.ID=PLYR_TI.ID_PLYR AND PLAYER.ID=MANA_PLYR.ID_PLYR) WHERE PLAYER.ID = @Id";
            this.command.Parameters.AddWithValue("@Id", i);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        private string GetColumn(string key, string defaultValue = null)
        {
            int ordinal = this.dataReader.GetOrdinal(key);
            if (this.dataReader.IsDBNull(ordinal)) return defaultValue;
            return this.dataReader.GetString(ordinal);
        }

        private int? GetColumnInt(string key)
        {
            int ordinal = this.dataReader.GetOrdinal(key);
            if (this.dataReader.IsDBNull(ordinal)) return null;
            return this.dataReader.GetInt32(ordinal);
        }
    }
}

