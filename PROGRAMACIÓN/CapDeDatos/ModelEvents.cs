using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapDeDatos
{
    public class ModelEvents : Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? StageId { get; set; }
        public string Type { get; set; }
        public int ParentId { get; set; }
        public string Info { get; set; }
        public int TimeNumber { get; set; }
        public string TimeDescription { get; set; }
        public int? IdFamily { get; set; }

        public List<int?> Id_Child { get; set; }
        public List<int?> Id_Parent { get; set; }
        public List<string> Type_ { get; set; }
        public List<string> Info_ { get; set; }

       // public int? StageId { get; set; }
        public string StageName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNum { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<int?> TimeID { get; set; }
        public List<int?> TimeNum { get; set; }
        public List<string> TimeDes { get; set; }

        public ModelEvents()
        {
        }
        public ModelEvents(int id) => this.GetEventData(id);


        public void GetEventData(int id)
        {
            try
            {
                this.Command.CommandText = $"Select EVENT.* FROM EVENT WHERE ID={id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.ID = int.Parse(this.DataReader["ID"].ToString());
                this.Name = this.DataReader["NAME"].ToString();
                this.StartDate = this.DataReader["STARTDATE"].ToString();
                this.EndDate = this.DataReader["ENDDATE"].ToString();
                this.StageId = Int32.Parse(this.DataReader["STAGE"].ToString());
                this.DataReader.Close();
            }
            catch(Exception)
            {

            }
        }
        public DataTable GetEventDataTable()
        {
            try
            {
                DataTable tabla = new DataTable();

                Command.CommandText = "SELECT EVENT.*," +
                    "TIME.ID,TIME.NUM," +
                    "TIME.DESCR," +
                    "EVENT_FAMILY.ID_FAM " +
                    "FROM (EVENT JOIN TIME) JOIN EVENT_FAMILY " +
                    "on EVENT.ID = TIME.ID_EVENT and " +
                    "EVENT_FAMILY.ID_EVENT = TIME.ID_EVENT";
                tabla.Load(Command.ExecuteReader());
                Conection.Close();
                RenameTableEvent(tabla);
                return tabla;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public DataTable GetEventDataTableWithFamily()
        {
            try
            {
                DataTable tabla = new DataTable();

                Command.CommandText = "SELECT EVENT.*," +
                    "PRE_EVENT.ID_CHILD," +
                    "PRE_EVENT.TYPE," +
                    "PRE_EVENT.INFO," +
                    "TIME.ID,TIME.NUM," +
                    "TIME.DESCR " +
                    "EVENT_FAMILY.ID_FAM " +
                    "FROM (EVENT JOIN PRE_EVENT) JOIN (TIME JOIN EVENT_FAMILY) " +
                    "on PRE_EVENT.ID_PARENT = EVENT.ID and EVENT.ID = TIME.ID_EVENT AND EVENT_FAMILY.ID_EVENT = TIME.ID_EVENT";
                tabla.Load(Command.ExecuteReader());
                Conection.Close();
                RenameTableEventFamily(tabla);

                return tabla;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void Save()
        {
            if (this.ID.ToString() != "0") Update();
            else
            {
                insert();
                InsertTime();
                InsertFamily();
            }
        }
        public void SaveParents()
        {
            if (this.ID.ToString() != "0") Update();
            else InsertParents();
        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "EVENT (NAME,STARTDATE,ENDDATE,STAGE) " +
                   $"VALUES ('{Name}','{StartDate}','{EndDate}',{StageId})";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertParents()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "PRE_EVENT (ID_CHILD,ID_PARENT ,TYPE ,INFO ) " +
                   $"VALUES ({GetId(Name)},{ParentId},'{Type}','{Info}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertFamily()
        {
            Command.CommandText = "INSERT INTO " +
                  "EVENT_FAMILY (ID_FAM,ID_EVENT) " +
                  $"VALUES ({IdFamily},{GetId(Name)})";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
        }
        public void InsertTime()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "TIME (ID_EVENT,NUM,DESCR) " +
                   $"VALUES ('{GetId(Name)}',{TimeNumber},'{TimeDescription}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void Update()
        {
            try
            {
                this.Command.CommandText = "UPDATE EVENT SET " +
                     $"NAME = '{Name}'," +
                     $"STARTDATE = '{StartDate}'," +
                     $"ENDDATE = '{EndDate}'," +
                     $"STAGE = {StageId} " +
                     $"WHERE ID = {this.ID}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM EVENT WHERE NAME = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.ID = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return ID;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void Delete (int Id)
        {
            try
            {
                this.Command.CommandText = $"DELETE PRE_EVENT.* FROM PRE_EVENT WHERE ID_PARENT = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"DELETE TIME.* FROM TIME WHERE ID_EVENT = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"DELETE EVENT_FAMILY.* FROM EVENT_FAMILY WHERE EVENT_FAMILY.ID_EVENT  = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"DELETE EVENT.* FROM EVENT WHERE ID = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public  void DeleteTime(int Id)
        {
           
        }
        public DataTable RenameTableEvent(DataTable t)
        {
            t.Columns[1].ColumnName = "Name";
            t.Columns[2].ColumnName = "Start Date";
            t.Columns[3].ColumnName = "End Date";
            t.Columns[4].ColumnName = "Stage";
            t.Columns[5].ColumnName = "Time ID";
            t.Columns[6].ColumnName = "Time Number";
            t.Columns[7].ColumnName = "Time Description";
            return t;
        }
        public DataTable RenameTableEventFamily(DataTable t)
        {
            t.Columns[0].ColumnName = "ID";
            t.Columns[1].ColumnName = "Name";
            t.Columns[2].ColumnName = "Start Date";
            t.Columns[3].ColumnName = "End Date";
            t.Columns[4].ColumnName = "Stage";
            t.Columns[5].ColumnName = "Time ID";
            t.Columns[6].ColumnName = "Time Number";
            t.Columns[7].ColumnName = "Time Description";
            t.Columns[8].ColumnName = "ID Chirld";
            t.Columns[9].ColumnName = "Number";
            t.Columns[10].ColumnName = "Description";
            return t;
        }
        public int GetIdTime(int num)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM TIME WHERE num = '{num}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.ID = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return ID;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool ExistEvent(string name)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM EVENT WHERE NAME = '{name}'";
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
                this.Command.CommandText = $"SELECT * FROM EVENT WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["STARTDATE"].ToString();
                this.DataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "27/10/2022 0:00:00") return true;
            else return false;
        }

        public Dictionary<int, ModelEvents> PopulateEventByPage(int i)
        {
            Dictionary<int, ModelEvents> eventtemp = new Dictionary<int, ModelEvents>();
            this.Command.CommandText = "SELECT DISTINCT EVENT.*, PRE_EVENT.*, " +
                 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO, " +
                 " STAGE.ID AS STAGEID, STAGE.NAME AS STAGENAME, STAGE.CITY, STAGE.STREET, STAGE.NUM AS STREETNUM, STAGE.STATE AS STAGESTATE, STAGE.COUNTRY AS STAGECOUNTRY , TIME.ID AS TIMEID, TIME.NUM, TIME.DESCR " +
                 "FROM EVENT LEFT JOIN PRE_EVENT ON ((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
                 "LEFT JOIN STAGE ON (EVENT.STAGE = STAGE.ID) " +
                 "LEFT JOIN TIME ON (TIME.ID_EVENT = EVENT.ID) " +
                 "LEFT JOIN EVENT_SPO ON (EVENT_SPO.ID_EVENT = EVENT.ID) " +
                 "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_EVENT = EVENT.ID)" +
                 "WHERE EVENT.ID<=@Id AND EVENT.ID>=@I ";
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
            foreach (DataRow row in t.Rows)
            {
                ModelEvents u = eventtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? eventtemp[int.Parse(row["ID"].ToString())]
                  : ModelEvents.FromRow(row);
                u.AddIds(row);
                eventtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return eventtemp;
        }
        public Dictionary<int, ModelEvents> PopulateEventById(int i)
        {
            Dictionary<int, ModelEvents> eventtemp = new Dictionary<int, ModelEvents>();
            this.Command.CommandText = "SELECT DISTINCT EVENT.*, PRE_EVENT.*, " +
                "EVENT_FAMILY.ID_FAM, " +
                "EVENT_SPO.ID_SPO, " +
                " STAGE.ID AS STAGEID, " +
                "STAGE.NAME AS STAGENAME, " +
                "STAGE.CITY, STAGE.STREET, " +
                "STAGE.NUM AS STREETNUM, " +
                "STAGE.STATE AS STAGESTATE, " +
                "STAGE.COUNTRY AS STAGECOUNTRY , " +
                "TIME.ID AS TIMEID, " +
                "TIME.NUM AS TIMENUM, " +
                "TIME.DESCR AS TIMEDES " +
                "FROM EVENT LEFT JOIN PRE_EVENT ON ((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
                "LEFT JOIN STAGE ON (EVENT.STAGE = STAGE.ID) " +
                "LEFT JOIN TIME ON (TIME.ID_EVENT = EVENT.ID) " +
                "LEFT JOIN EVENT_SPO ON (EVENT_SPO.ID_EVENT = EVENT.ID) " +
                "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_EVENT = EVENT.ID)" +
                " WHERE EVENT.ID=@Id ";
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
            foreach (DataRow row in t.Rows)
            {
                ModelEvents u = eventtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? eventtemp[int.Parse(row["ID"].ToString())]
                  : ModelEvents.FromRow(row);
                u.AddIds(row);
                eventtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return eventtemp;
        }

        public void GetEventBySport(string sport)
        {

        }
        public static ModelEvents FromRow(DataRow r)
        {
            ModelEvents t = new ModelEvents();
            t.ID = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.StartDate = r["StartDate"].ToString();
            t.EndDate = r["EndDate"].ToString();
            t.StageId = ParseInt(r["StageId"].ToString());
            t.City = r["City"].ToString();
            t.Street = r["Street"].ToString();
            t.StreetNum = r["StreetNum"].ToString();
            t.State = r["StageState"].ToString();
            t.Country = r["StageCountry"].ToString();
            t.Id_Child = new List<int?>();
            t.Id_Parent = new List<int?>();
            t.TimeID = new List<int?>();
            t.Type_ = new List<string>();
            t.Info_ = new List<string>();
            t.TimeNum = new List<int?>();
            t.TimeDes = new List<string>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Child.Add(ParseInt(r["Id_Child"].ToString()));
            this.Id_Parent.Add(ParseInt(r["Id_Parent"].ToString()));
            this.TimeID.Add(ParseInt(r["TimeId"].ToString()));
            this.TimeNum.Add(ParseInt(r["TimeNum"].ToString()));
            this.Type_.Add(r["Type"].ToString());
            this.Info_.Add(r["Info"].ToString());
            this.TimeDes.Add(r["TimeDes"].ToString());
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }




        public HashSet<int?> PopulatePlayer(int s, int p)
        {
            HashSet<int?> a = new HashSet<int?>();
            this.Command.CommandText = $"SELECT DISTINCT ID FROM EVENT LEFT JOIN (EVENT_SPO) ON (EVENT.ID = EVENT_SPO.ID_EVENT) WHERE EVENT_SPO.ID_SPO=@S ORDER BY EVENT.STARTDATE LIMIT 5 OFFSET @P";
            this.Command.Parameters.AddWithValue("@S", s);
            this.Command.Parameters.AddWithValue("@P", p);
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
            foreach (DataRow row in t.Rows)
            {
                a.Add(ParseInt(row["ID"].ToString()));
            }
            return a;
        }

    }
}
