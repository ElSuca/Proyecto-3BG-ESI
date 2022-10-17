using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDeDatos
{
    public class ModelPlayer : Model
    {
        public int Id;
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

        public ModelPlayer(int id) => this.GetTeamData(id);
        public ModelPlayer()
        {

        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else insert();

        }

        private void insert()
        {
            try
            {
                command.CommandText = "INSERT " +
                   "PLAYER (NAME,LNAME1,LNAME2,STATUS,BIRTHDATE,CITY,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName1}','{LastName2}','{Status}','{BirthDate}','{City}','{State}','{Country}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void Update()
        {
            this.command.CommandText = "UPDATE PLAYER SET " +
                 $"NAME = '{Name}'," +
                 $"LNAME1 = '{LastName1}',"+
                 $"LNAME2 = '{LastName2}'," +
                 $"STATUS = '{Status}'," +
                 $"BIRTHDATE = '{BirthDate}'," +
                 $"CITY = '{City}'," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}'" +
                 $"WHERE ID = {this.Id}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"Delete PLAYER.* from PLAYER where Id= {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetTeamData(int id)
        {
            this.command.CommandText = $"Select * From PLAYER where ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
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
        public DataTable GetPlayerDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on PLAYER.ID = ASOC_PLYR.ID_PLYR";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }

        public void insertAsociation()
        {
            try
            {
                command.CommandText = "INSERT " +
                   "ASOC_PLYR (ID_ASOC,ID_PLYR,STARTDATE ,ENDDATE) " +
                   $"VALUES ({IdAsoc},{Id},'{StartDate}','{EndDate}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

