using CapaDeDatos;
using System.Data;

namespace CapDeDatos
{
    public class ModelAsociation : Model
    {
        public ModelAsociation()
        {
        }
        public DataTable GetAsociationDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM asoc";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }
    }
}
