using CapaDeDatos;
using System.Data;

namespace CapDeDatos
{
    public class ModelAsociation : Model
    {
        public int ID;
        public string Name;
        public string Status;

        public ModelAsociation()
        {
        }
        public DataTable GetAsociationDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM ASOC";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }

        public DataTable GetUserDataTableForApi(int id)
        {
            DataTable tabla = new DataTable();
            command.CommandText = $"Select asoc.*, address.CITY,address.STREET,address.NUM,address.COUNTRY,address.STATE From USER LEFT JOIN phones on asoc.id ={ID} AND address.ID =" +GetAddress(id);
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
    }
}
