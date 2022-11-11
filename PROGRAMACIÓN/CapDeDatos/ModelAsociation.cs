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
        public DataTable PopulateAsocByPage(int i)
        {
            this.Command.CommandText = "SELECT ASOC.*," +
                " CONCAT_WS(', ', ASOC_STATUS.STARTDATE, ASOC_STATUS.ENDDATE) AS DATES, " +
                "ASOC_STATUS.SPORT AS SPORTSTAT," +
                " ASOC_STATUS.CAT AS CATSTAT, " +
                "ASOC_STATUS.QUANTITY AS STATQUANT," +
                " ASOC_PLYR.ID_PLYR AS PLAYER," +
                " MANA_ASOC.ID_MANA AS MANAGER," +
                " TM_ASOC.ID_TEAM AS TEAM ," +
                " ASOC_SPO.ID_SPO AS SPORT, " +
                " CONCAT_WS(' - ' , ASOC_PLYR.STARTDATE , ASOC_PLYR.ENDDATE) AS PLAYERDATES, " +
                " CONCAT_WS(' - ' , MANA_ASOC.STARTDATE , MANA_ASOC.ENDDATE) AS MANAGERDATES " +
                " FROM ASOC LEFT JOIN ASOC_STATUS ON ASOC.ID=ASOC_STATUS.ID_ASOC " +
                "LEFT JOIN ASOC_SPO ON ASOC.ID=ASOC_SPO.ID_ASOC " +
                "LEFT JOIN MANA_ASOC ON ASOC.ID=MANA_ASOC.ID_ASOC " +
                "LEFT JOIN ASOC_PLYR ON ASOC.ID=ASOC_PLYR.ID_ASOC " +
                " LEFT JOIN TM_ASOC ON ASOC.ID=TM_ASOC.ID_ASOC " +
                " WHERE ASOC.ID<=@Id AND ASOC.ID>=@I ";
            this.Command.Parameters.AddWithValue("@Id", i * 5);
            this.Command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            DataTable t = new DataTable();
            DataTable schema = this.DataReader.GetSchemaTable();
            foreach (DataRow row in schema.Rows)
            {
                string colname = row.Field<string>("ColumnName");
                Type ty = row.Field<Type>("DataType");
                t.Columns.Add(colname, ty);
            }
            while (this.DataReader.Read())
            {
                var newRow = t.Rows.Add();
                foreach (DataColumn col in t.Columns)
                {
                    newRow[col.ColumnName] = this.DataReader[col.ColumnName];
                }
            }
            return t;
        }
        public DataTable PopulateAsocById(int i)
        {
            this.Command.CommandText = "SELECT ASOC.*," +
                " CONCAT_WS(', ', ASOC_STATUS.STARTDATE, ASOC_STATUS.ENDDATE) AS DATES, " +
                "ASOC_STATUS.SPORT AS SPORTSTAT," +
                " ASOC_STATUS.CAT AS CATSTAT, " +
                "ASOC_STATUS.QUANTITY AS STATQUANT," +
                " ASOC_PLYR.ID_PLYR AS PLAYER," +
                " MANA_ASOC.ID_MANA AS MANAGER," +
                " TM_ASOC.ID_TEAM AS TEAM," +
                " ASOC_SPO.ID_SPO AS SPORT, " +
                " CONCAT_WS(' - ' , ASOC_PLYR.STARTDATE , ASOC_PLYR.ENDDATE) AS PLAYERDATES, " +
                " CONCAT_WS(' - ' , MANA_ASOC.STARTDATE , MANA_ASOC.ENDDATE) AS MANAGERDATES " +
                " FROM ASOC LEFT JOIN ASOC_STATUS ON ASOC.ID=ASOC_STATUS.ID_ASOC " +
                " LEFT JOIN ASOC_SPO ON ASOC.ID=ASOC_SPO.ID_ASOC " +
                "LEFT JOIN MANA_ASOC ON   ASOC.ID=MANA_ASOC.ID_ASOC " +
                "LEFT JOIN ASOC_PLYR ON   ASOC.ID=ASOC_PLYR.ID_ASOC " +
                " LEFT JOIN TM_ASOC ON  ASOC.ID=TM_ASOC.ID_ASOC " +
                "WHERE ASOC.ID=@Id";
            this.Command.Parameters.AddWithValue("@Id", i);
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            DataTable t = new DataTable();
            DataTable schema = this.DataReader.GetSchemaTable();
            foreach (DataRow row in schema.Rows)
            {
                string colname = row.Field<string>("ColumnName");
                Type ty = row.Field<Type>("DataType");
                t.Columns.Add(colname, ty);
            }
            while (this.DataReader.Read())
            {
                var newRow = t.Rows.Add();
                foreach (DataColumn col in t.Columns)
                {
                    newRow[col.ColumnName] = this.DataReader[col.ColumnName];
                }
            }
            return t;
        }
    }
}

