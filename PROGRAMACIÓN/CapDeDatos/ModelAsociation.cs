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
            if (this.Id.ToString() != "0") update();
            else
            {
                insert();
                insertStatus();
            }
        }

        public void GetAsociationData(int id)
        {
            this.Command.CommandText = $"Select * From ASOC where ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.Status = this.DataReader["STATUS"].ToString();
            this.City = this.DataReader["CITY"].ToString();
            this.Street = this.DataReader["STREET"].ToString();
            this.Num = Int32.Parse(this.DataReader["NUM"].ToString());
            this.State = this.DataReader["STATE"].ToString();
            this.Country = this.DataReader["COUNTRY"].ToString();           
            this.DataReader.Close();
        }

        public DataTable GetAsociationDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT ASOC.*,ASOC_STATUS.STARTDATE,ASOC_STATUS.ENDDATE,ASOC_STATUS.SPORT,ASOC_STATUS.CAT,ASOC_STATUS.QUANTITY FROM ASOC LEFT JOIN ASOC_STATUS on ASOC.ID = ASOC_STATUS.ID_ASOC";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

  
        public int GetAddress(int id)
        {
            this.Command.CommandText = $"Select ID_ADD From asoc_address where ID_ASOC = {id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            int AdressID = int.Parse(this.DataReader["ID_ADD"].ToString());
            this.DataReader.Close();
            return AdressID;
        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "ASOC (NAME,STATUS,CITY,STREET,NUM,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{Status}','{City}','{Street}',{Num},'{State}','{Country}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery(); 
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void insertStatus()
        {
            Commanditou.CommandText = "INSERT INTO " +
                  "ASOC_STATUS (ID_ASOC,STARTDATE ,ENDDATE ,SPORT ,CAT ,QUANTITY) " +
                  $"VALUES ({GetId(Name)},'{StartDate}','{EndDate}',{Sport},'{Category}',{Quantity})";
            this.Commanditou.Prepare();
            this.Commanditou.ExecuteNonQuery();
        }

        private void update()
        {
            this.Command.CommandText = "UPDATE ASOC SET " +
                 $"NAME = '{Name}'," +
                 $"STATUS = '{Status}'," +
                 $"CITY = '{City}'," +
                 $"STREET = '{Street}'," +
                 $"NUM = {Num}," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}' " +
                 $"WHERE ID = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete ASOC_STATUS.* from ASOC_STATUS where ID_ASOC = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"Delete ASOC.* from ASOC where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
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
                this.Command.CommandText = $"SELECT ID FROM ASOC WHERE NAME = '{name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool ExistAsociation(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM ASOC WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                exist = this.DataReader.HasRows;
                this.DataReader.Close();
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
                this.Command.CommandText = $"SELECT * FROM ASOC WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["City"].ToString();
                this.DataReader.Close();
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

