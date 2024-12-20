﻿using CapDeDatos;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

namespace CapaLoogica
{
    public class EventControler 
    {
        public EventControler()
        {
        }
        public DataTable GetEventDataTable()
        {
            return new ModelEvents().GetEventDataTable();
        }
        public DataTable GetEventFamilyDataTable()
        {
            return new ModelEvents().GetEventDataTableWithFamily();
        }

        public static void Alta(string name, string startDate, string endDate, int stageid, int timeNumber, string timeDescription, int? idFamily)
        {
            ModelEvents e = new ModelEvents
            {
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                StageId = stageid,
                TimeDescription = timeDescription,
                TimeNumber = timeNumber,
                IdFamily = idFamily
            };
            e.Save();
        }
        public static void Modify(int id, string name, string startDate, string endDate, int stageid, int timeNumber, string timeDescription)
        {
            ModelEvents e = new ModelEvents(id)
            {
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                StageId = stageid,
                TimeDescription = timeDescription,
                TimeNumber = timeNumber
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelEvents(id).Delete(id);
        public static void DeleteTime(int id) => new ModelEvents(id).DeleteTime(id);

        public static void AltaParents(int ParentId, string type, string Info, string Name)
        {
            ModelEvents e = new ModelEvents
            {
                ParentId = ParentId,
                Type = type,
                Info = Info,
                Name = Name
            };
            e.SaveParents();
        }
        public static void AltaTime(int EventId, int num, string Description)
        {
            ModelEvents e = new ModelEvents
            {
                ID = EventId,
                TimeNumber = num,
                TimeDescription = Description
            };
            e.InsertTime();
        }
        public void GetEventBySport(string sport) => new ModelEvents().GetEventBySport(sport);
        public bool ExistEvent(string name) => new ModelEvents().ExistEvent(name);
        public int GetId(string Name) => new ModelEvents().GetId(Name);
        public int GetIdTime(int num) => new ModelEvents().GetIdTime(num);
        public bool HaveChange(int id) => new ModelEvents().HaveChange(id);

        public string GetStartDate() => new ModelEvents().StartDate;
    }
}
