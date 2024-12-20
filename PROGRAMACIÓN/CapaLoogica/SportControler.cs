﻿using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using CapDeDatos;

namespace CapaLoogica
{
    public class SportControler
    {
        public SportControler() 
        {
        }
        /*public DataTable GetEventData(string Eventname) => new ModelSport().eventTable(Eventname);
        public DataTable GetSimpifiedEventData() => new ModelSport().GetAllEventDataForTable();
        public DataTable GetPlayerData(string PlayerName) => new ModelSport().playerTable(PlayerName);*/

        public static void Alta(string name, string type)
        {

            ModelSport a = new ModelSport
            {
                Name = name,
                Type = type,
            };
            a.Save();
        }
        public static void Delete(int id) => new ModelSport(id).Delete(id);

        public int GetSportId(string Name) => new ModelSport().GetId(Name);

        public static void Modify(int id, string name, string type)
        {
            ModelSport a = new ModelSport(id)
            {
                Name = name,
                Type = type,
            };
            a.Save();
        }

        public DataTable GetSportDataTable() => new ModelSport().GetSportDataTable();
        public bool ExistSport(int id) => new ModelSport().ExistSport(id);
        public int GetId(string Name) => new ModelSport().GetId(Name);
        public bool HaveChange(int id) => new ModelSport().HaveChange(id);
    }
}
