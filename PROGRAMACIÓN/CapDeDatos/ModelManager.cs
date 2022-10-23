using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelManager : Model
    {
        public int Id;
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string Status { get; set; }
        public string BirthDate { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int IdAsociation { get; set; }
        public string StartDateAsociation { get; set; }
        public string EndDateAsociation { get; set; }

        public ModelManager(int id) => this.GetManagerData(id);
        public ModelManager()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else
            {
                insert();
                insertManagerAsociation();
            }

        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "MANAGER (NAME,LNAME1,LNAME2,STATUS,BIRTHDATE,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName1}','{LastName2}','{Status}','{BirthDate}','{State}','{Country}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void insertManagerAsociation()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "MANA_ASOC (ID_MANA ,ID_ASOC,STARTDATE,ENDDATE) " +
                   $"VALUES ({GetId(Name)},{IdAsociation},'{StartDateAsociation}','{EndDateAsociation}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM MANAGER WHERE NAME = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["ID"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        private void Update()
        {
            this.Command.CommandText = "UPDATE MANAGER SET " +
                 $"NAME = '{Name}'," +
                 $"LNAME1 = '{LastName1}'," +
                 $"LNAME2 = '{LastName2}'," +
                 $"STATUS = '{Status}'," +
                 $"BIRTHDATE = '{BirthDate}'," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}'" +
                 $"WHERE ID = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete MANA_ASOC.* from MANA_ASOC where ID_MANA= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"Delete MANAGER.* from MANAGER where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetManagerData(int id)
        {
            this.Command.CommandText = $"Select * From MANAGER where ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.LastName1 = this.DataReader["LNAME1"].ToString();
            this.LastName2 = this.DataReader["LNAME2"].ToString();
            this.Status = this.DataReader["STATUS"].ToString();
            this.BirthDate = this.DataReader["BIRTHDATE"].ToString();
            this.State = this.DataReader["STATE"].ToString();
            this.Country = this.DataReader["COUNTRY"].ToString();
            this.DataReader.Close();
        }
        public DataTable GetManagerDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT MANAGER.*,MANA_ASOC.ID_ASOC,MANA_ASOC.STARTDATE,MANA_ASOC.ENDDATE FROM MANAGER LEFT JOIN MANA_ASOC ON MANAGER.ID = MANA_ASOC.ID_MANA";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }
        public bool ExistManager(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM MANAGER WHERE Id = {id}";
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
                this.Command.CommandText = $"SELECT MANAGER.*,MANA_ASOC.ID_ASOC,MANA_ASOC.STARTDATE,MANA_ASOC.ENDDATE FROM MANAGER LEFT JOIN MANA_ASOC ON MANAGER.ID = MANA_ASOC.ID_MANA where MANAGER.ID = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["STATE"].ToString();
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

