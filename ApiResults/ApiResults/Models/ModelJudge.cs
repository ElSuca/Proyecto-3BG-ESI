using ApiResults;
using System;
using System.Data;

namespace ApiResults
{
    public class ModelJudge : Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastaName1 { get; set; }
        public string LastaName2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public ModelJudge() { }
        public ModelJudge(int id) => this.GetJudgeData(id);

        public void GetJudgeData(int id)
        {
            this.command.CommandText = $"Select * FROM JUDGE LEFT JOIN JUD_FOUL, ACTION ON (JUDGE.ID = JUD_FOUL.ID_JUD AND JUD_FOUL.ID_FL = ACTION.ID) WHERE ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.ID = int.Parse(this.dataReader["ID"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.LastaName1 = this.dataReader["LNAME1"].ToString();
            this.LastaName2 = this.dataReader["LNAME2"].ToString();
            this.Country = this.dataReader["COUNTRY"].ToString();
            this.State = this.dataReader["STATE"].ToString();
            this.City = this.dataReader["CITY"].ToString();
            this.dataReader.Close();
        }

        public DataTable GetJudgeDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM JUDGE ";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }

        public void Save()
        {
            if (this.ID.ToString() != "0") Update();
            else
            {

                insertJudge();
            }
        }

        private void insertJudge()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "JUDGE (NAME,LNAME1,LNAME2,COUNTRY,STATE,CITY) " +
                   $"VALUES ('{Name}','{LastaName1}','{LastaName2}','{Country}','{State}','{City}')";
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
            this.command.CommandText = "UPDATE JUDGE SET " +
                 $"NAME = '{Name}'," +
                 $"LNAME1 = '{LastaName1}'," +
                 $"LNAME2 = '{LastaName2}'," +
                 $"COUNTRY = '{Country}'," +
                 $"STATE = '{State}'," +
                 $"CITY = '{City}'," +
                 $"WHERE ID = {this.ID}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE JUDGE.* FROM EVENT WHERE ID = {Id}";
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
