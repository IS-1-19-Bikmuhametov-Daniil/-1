﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Задд2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Baza
        {
            public MySqlConnection baza()
            {
                string port = "33333";
                string host = "caseum.ru";
                string user = "test_user";
                string password = "test_pass";
                string db = "db_test";
                string connStr = $"server={host};port={port};user={user};database={db};password={password};";
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baza baza = new Baza();
            try
            {
                baza.baza().Open();
            }
            catch (Exception yxz)
            {
                MessageBox.Show($"{yxz}");
            }
            finally
            {
                MessageBox.Show("Успешное подключение");
                baza.baza().Close();
            }
        }
    }
}
