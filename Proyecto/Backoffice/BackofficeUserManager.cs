﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaLogica;

namespace Proyecto.Backoffice
{
    public partial class BackofficeUserManager : Form
    {
        public BackofficeUserManager()
        {
            InitializeComponent();
        }
        private void BackofficeUserManager_Load(object sender, EventArgs e)
        {
        }
        private bool checkInput(string input)
        {
            List<string> dangerWords = new List<string>();
            dangerWords.Add("WHERE");
            dangerWords.Add("DROP");
            dangerWords.Add(";");
            dangerWords.Add("FROM");
            dangerWords.Add("INSERT");
            dangerWords.Add("CREATE");
            dangerWords.Add("UPDATE");
            dangerWords.Add("DELETE");
            dangerWords.Add("SELECT");

            foreach (string palabra in dangerWords)
            {
                if (input.Contains(palabra)) return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserControler.Alta(
                txtUserNameRegister.Text,
                txtApellidoRegister.Text, 
                txtTelefonoRegister.Text,
                txtEmailRegister.Text,
                txtPassword.Text
            );
            MessageBox.Show("Usuario cargado");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
                     "server = 127.0.0.1; " +
                     "uid = root;" +
                     "pwd=root;" +
                     "database=proyecto"
                    );

            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader reader;
            DataTable table = new DataTable();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM Usuario";
            reader = comando.ExecuteReader();
            table.Load(reader);
            dgrid1.DataSource = table;
        }

        private void dgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Delete_Click(object sender, EventArgs e)
        { 
            UserControler.Eliminar(Int32.Parse(txtID.Text));
        }

        private void btnModify_Click(object sender, EventArgs e)
        { 
            UserControler.Modificar(Int32.Parse(txtID.Text),
                txtUserNameRegister.Text,
                txtApellidoRegister.Text,
                txtTelefonoRegister.Text,
                txtEmailRegister.Text,
                txtPassword.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtCargar_Click(object sender, EventArgs e)
        {
            txtID.Text = "5";
            txtUserNameRegister.Text = "test";
            txtApellidoRegister.Text = "a";
            txtTelefonoRegister.Text = "12345678";
            txtEmailRegister.Text = "a";
            txtPassword.Text = "test";
        }
    }
}
