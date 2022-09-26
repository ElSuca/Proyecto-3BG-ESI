using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class AsociationControler
    {
        public AsociationControler()
        {
        }
        public DataTable GetAsociationDataTable() => new ModelAsociation().GetAsociationDataTable();
    }
}
