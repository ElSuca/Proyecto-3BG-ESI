using CapDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
