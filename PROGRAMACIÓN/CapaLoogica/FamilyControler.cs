using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class FamilyControler
    {
        public DataTable GetFamilyDataTable() => new ModelFamily().GetFamilyDataTable();

        public static void Alta(string name, string Recurrency, string Domain, string Type)
        {
            ModelFamily e = new ModelFamily
            {
                Name = name,
                Recurrency = Recurrency,
                Domain = Domain,
                Type = Type
            };
            e.Save();
        }
        public static void Modificar(int Id, string name, string Recurrency, string Domain, string Type)
        {
            ModelFamily e = new ModelFamily(Id)
            {
                Name = name,
                Recurrency = Recurrency,
                Domain = Domain,
                Type = Type
            };
            e.Save();
        }
        public static void AltaParents(int Id, int ParentId, string type, string Info)
        {
            ModelFamily e = new ModelFamily
            {
                Id = Id,
                ParentId = ParentId,
                Type = type,
                Info = Info
            };
            e.SaveParents();
        }
        public static void ModifyParents(int Id, int ParentId, string type, string Info)
        {
            ModelFamily e = new ModelFamily(Id)
            {
                ParentId = ParentId,
                Type = type,
                Info = Info
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelFamily(id).Delete(id);


        public bool ExistFamilty(string name) => new ModelFamily().ExistFamily(name);
        public int GetId(string Name) => new ModelFamily().GetId(Name);
        public bool HaveChange(int id) => new ModelFamily().HaveChange(id);
    }
}
