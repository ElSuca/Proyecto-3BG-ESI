namespace CapDeDatos
{
    public class SafeSystemBuffer
    {
        public static int Menu1Choice;
        public static string startPath;

        public int GetMenu1Choice() => Menu1Choice;


        public void SetMenu1Choice(int a) => Menu1Choice = a;
        public void SetStartAdPath(string p) => startPath = p;
    }
}
