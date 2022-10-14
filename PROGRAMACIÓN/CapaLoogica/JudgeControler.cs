using CapDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLoogica
{
    public class JudgeControler
    {
        public DataTable GetJudgeDataTable() => new ModelJudge().GetJudgeDataTable();
    }
}
