using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class AdControler
    {
        public static void Alta(string name, string cat, string path)
        {

            ModelAd a = new ModelAd
            {
                Name = name,
                Category = cat,
                Path = path,
            };
            a.Save();
        }
        public static void Delete(int id) => new ModelAd(id).Delete(id);

        public int GetAdId(string Name) => new ModelAd().GetId(Name);

        public static void Modify(string name, int id, string Cat, string Path)
        {
            ModelAd a = new ModelAd(id)
            {
                Name = name,
                Category = Cat,
                Path = Path
            };
            a.Save();
        }

        public static void setStartPath(string path) => SafeSystemBuffer.startPath = path;
        public static string GetStartPath() => SafeSystemBuffer.startPath;
        public DataTable GetAdDataTable() => new ModelAd().GetAdDataTable();
    }
}
