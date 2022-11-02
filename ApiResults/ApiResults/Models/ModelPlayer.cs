using ApiResults;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiResults.Models;
namespace ApiResults
{
    public class ModelPlayer : Model
    {
        public int Id ;
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string Status { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int IdAsoc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public ModelPlayer() : base()
        {
            base.connectDataBase();
        }
        public void PopulatePlayer(int i)
        {

            this.command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on (PLAYER.ID = ASOC_PLYR.ID_PLYR) where PLAYER.ID={i}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["ID"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.LastName1 = this.dataReader["LNAME1"].ToString();
            this.LastName2 = this.dataReader["LNAME2"].ToString();
            this.Status = this.dataReader["STATUS"].ToString();
            this.BirthDate = this.dataReader["BIRTHDATE"].ToString();
            this.City = this.dataReader["CITY"].ToString();
            this.State = this.dataReader["STATE"].ToString();
            this.Country = this.dataReader["COUNTRY"].ToString();
            this.dataReader.Close();
        }
    }
}

