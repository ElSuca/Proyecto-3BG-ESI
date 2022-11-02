﻿using ApiResults;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiResults
{
    public class ModelTeam : Model
    {
        public int Id;
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public ModelTeam(int id) => this.GetTeamData(id);
        public ModelTeam()
        {

        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else insert();
            
        }

        private void insert()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "TEAM (Name,City,Country,State) " +
                   $"VALUES ('{Name}','{City}','{Country}','{State}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void Update()
        {
            this.command.CommandText = "UPDATE TEAM SET " +
                 $"NAME = '{Name}'," +
                 $"CITY = '{City}'," +
                 $"COUNTRY = '{Country}'," +
                 $"STATE = '{State}'" +
                 $"WHERE ID = {this.Id}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"Delete TEAM.* from TEAM where Id= {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetTeamData(int id)
        {
            this.command.CommandText = $"Select * From TEAM where ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.City = this.dataReader["CITY"].ToString();
            this.Country = this.dataReader["COUNTRY"].ToString();
            this.State = this.dataReader["STATE"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetTeamDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM TEAM";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }
    }
}
