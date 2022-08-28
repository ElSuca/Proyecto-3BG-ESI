using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDeDatos
{
    public class SafeSystemBuffer
    {
        public static int Menu1Choice;


        public int GetMenu1Choice() => Menu1Choice;


        public void SetMenu1Choice(int a)
        {
            Menu1Choice = a;
        }
    }
}
