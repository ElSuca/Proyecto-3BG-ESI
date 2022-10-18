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
        public string City { get; set; }
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
                command.CommandText = "INSERT " +
                   "MANAGER (NAME,LNAME1,LNAME2,STATUS,BIRTHDATE,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName1}','{LastName2}','{Status}','{BirthDate}','{State}','{Country}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
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
                command.CommandText = "INSERT " +
                   "MANA_ASOC (ID_MANA ,ID_ASOC,STARTDATE,ENDDATE) " +
                   $"VALUES ({Id},{IdAsociation},'{StartDateAsociation}','{EndDateAsociation}')";
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
            this.command.CommandText = "UPDATE MANAGER SET " +
                 $"NAME = '{Name}'," +
                 $"LNAME1 = '{LastName1}'," +
                 $"LNAME2 = '{LastName2}'," +
                 $"STATUS = '{Status}'," +
                 $"BIRTHDATE = '{BirthDate}'," +
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
                this.command.CommandText = $"Delete MANAGER.* from MANAGER where Id= {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetManagerData(int id)
        {
            this.command.CommandText = $"Select * From MANAGER where ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.LastName1 = this.dataReader["LNAME1"].ToString();
            this.LastName2 = this.dataReader["LNAME2"].ToString();
            this.Status = this.dataReader["STATUS"].ToString();
            this.BirthDate = this.dataReader["BIRTHDATE"].ToString();
            //this.City = this.dataReader["CITY"].ToString();
            this.State = this.dataReader["STATE"].ToString();
            this.Country = this.dataReader["COUNTRY"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetManagerDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT MANAGER.*,MANA_ASOC.ID_ASOC,MANA_ASOC.STARTDATE,MANA_ASOC.ENDDATE FROM MANAGER LEFT JOIN MANA_ASOC ON MANAGER.ID = MANA_ASOC.ID_MANA";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }
    }
}

