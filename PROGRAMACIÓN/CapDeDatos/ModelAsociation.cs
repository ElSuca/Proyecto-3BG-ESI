using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelAsociation : Model
    {
        public int Id;
        public string Name { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Num { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Sport { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public ModelAsociation()
        {
        }
        public ModelAsociation(int id) => this.GetAsociationData(id);

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else
            {
                Insert();
                InsertStatus();
            }
        }

        public void GetAsociationData(int id)
        {
            this.command.CommandText = $"Select * From ASOC where ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.Status = this.dataReader["STATUS"].ToString();
            this.City = this.dataReader["CITY"].ToString();
            this.Street = this.dataReader["STREET"].ToString();
            this.Num = Int32.Parse(this.dataReader["NUM"].ToString());
            this.State = this.dataReader["STATE"].ToString();
            this.Country = this.dataReader["COUNTRY"].ToString();           
            this.dataReader.Close();
        }

        public DataTable GetAsociationDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT ASOC.*,ASOC_STATUS.STARTDATE,ASOC_STATUS.ENDDATE,ASOC_STATUS.SPORT,ASOC_STATUS.CAT,ASOC_STATUS.QUANTITY FROM ASOC LEFT JOIN ASOC_STATUS on ASOC.ID = ASOC_STATUS.ID_ASOC";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }

  
        public int GetAddress(int id)
        {
            this.command.CommandText = $"Select ID_ADD From asoc_address where ID_ASOC = {id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            int AdressID = int.Parse(this.dataReader["ID_ADD"].ToString());
            this.dataReader.Close();
            return AdressID;
        }

        private void Insert()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "ASOC (NAME,STATUS,CITY,STREET,NUM,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{Status}','{City}','{Street}',{Num},'{State}','{Country}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery(); 
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void InsertStatus()
        {
            commanditou.CommandText = "INSERT INTO " +
                  "ASOC_STATUS (ID_ASOC,STARTDATE ,ENDDATE ,SPORT ,CAT ,QUANTITY) " +
                  $"VALUES ({GetId(Name)},'{StartDate}','{EndDate}',{Sport},'{Category}',{Quantity})";
            this.commanditou.Prepare();
            this.commanditou.ExecuteNonQuery();
        }

        private void Update()
        {
            this.command.CommandText = "UPDATE ASOC SET " +
                 $"NAME = '{Name}'," +
                 $"STATUS = '{Status}'," +
                 $"CITY = '{City}'," +
                 $"STREET = '{Street}'," +
                 $"NUM = {Num}," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}' " +
                 $"WHERE ID = {this.Id}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"Delete ASOC_STATUS.* from ASOC_STATUS where ID_ASOC = {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
                this.command.CommandText = $"Delete ASOC.* from ASOC where Id= {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GetId(string name)
        {
            try
            {
                this.command.CommandText = $"SELECT ID FROM ASOC WHERE NAME = '{name}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
                this.dataReader.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public bool ExistAsociation(int id)
        {
            bool exist;
            try
            {
                this.command.CommandText = $"SELECT * FROM ASOC WHERE Id = {id}";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                exist = this.dataReader.HasRows;
                this.dataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (exist) return true;
            else return false;
        }
        public bool HaveChange(int id)
        {
            string Check;
            try
            {
                this.command.CommandText = $"SELECT * FROM ASOC WHERE Id = {id}";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                Check = this.dataReader["City"].ToString();
                this.dataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "n") return true;
            else return false;
        } 
    }
}

