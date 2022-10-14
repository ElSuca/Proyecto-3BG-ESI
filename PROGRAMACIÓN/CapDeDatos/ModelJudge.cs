using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDeDatos
{
    public class ModelJudge : Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastaName1 { get; set; }
        public string LastaName2 { get; set; }


        public void GetEventData(int id)
        {
            this.command.CommandText = $"Select JUDGE.* FROM EVENT WHERE ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.ID = int.Parse(this.dataReader["ID"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.LastaName1 = this.dataReader["LNAME1"].ToString();
            this.LastaName2 = this.dataReader["LNAME2"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetJudgeDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM JUDGE";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }
    }
}
