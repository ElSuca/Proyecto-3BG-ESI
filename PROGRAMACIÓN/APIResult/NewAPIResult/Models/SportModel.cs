using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class SportModel : Model
    {
        public DataTable PopulateSportByPage(int i)
        {
            this.command.CommandText = "SELECT SPORT.*, " +
 "T_SPO.TYPE " +
 "FROM SPORT LEFT JOIN(T_SPO) " +
 "ON(T_SPO.ID_SP = SPORT.ID) " +
 " WHERE TEAM.ID<=@Id AND TEAM.ID>=@I ";
            this.command.Parameters.AddWithValue("@Id", i * 5);
            this.command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulateSportById(int i)
        {
            this.command.CommandText = "SELECT SPORT.*, " +
"T_SPO.TYPE " +
"FROM SPORT LEFT JOIN(T_SPO) " +
"ON(T_SPO.ID_SP = SPORT.ID) " +
"  WHERE TEAM.ID=@Id";
            this.command.Parameters.AddWithValue("@Id", i);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
    }
}
