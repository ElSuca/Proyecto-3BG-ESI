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

        public ModelPlayer() : base()
        {
            base.connectDataBase();
        }
        public void PopulatePlayer(int i)
        {
            this.command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on (PLAYER.ID = ASOC_PLYR.ID_PLYR) WHERE PLAYER.ID= {i}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = GetColumnInt("ID");
            this.Name = GetColumn("NAME");
            this.LastName1 = GetColumn("LNAME1");
            this.LastName2 = GetColumn("LNAME2");
            this.Status = GetColumn("STATUS");
            this.BirthDate = GetColumn("BIRTHDATE");
            this.City = GetColumn("CITY");
            this.State = GetColumn("STATE");
            this.Country = GetColumn("COUNTRY");
            this.IdAsoc = GetColumnInt("ID_ASOC");
            this.StartDate = GetColumn("STARTDATE");
            this.EndDate = GetColumn("ENDDATE");
            this.dataReader.Close();
        }
        public void PopulatePlayer(string s)
        {
            this.command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on (PLAYER.ID = ASOC_PLYR.ID_PLYR) WHERE PLAYER.NAME={s} OR PLAYER.LNAME1={s} OR PLAYER.LNAME2={s}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = GetColumnInt("ID");
            this.Name = GetColumn("NAME");
            this.LastName1 = GetColumn("LNAME1");
            this.LastName2 = GetColumn("LNAME2");
            this.Status = GetColumn("STATUS");
            this.BirthDate = GetColumn("BIRTHDATE");
            this.City = GetColumn("CITY");
            this.State = GetColumn("STATE");
            this.Country = GetColumn("COUNTRY");
            this.IdAsoc = GetColumnInt("ID_ASOC");
            this.StartDate = GetColumn("STARTDATE");
            this.EndDate = GetColumn("ENDDATE");
            this.dataReader.Close();
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

