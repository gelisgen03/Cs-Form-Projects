using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _16_12_2024_Gorsel_Lab

{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            string connectionString = "Server=localhost;Database=depodb;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);


            string selectQuery = "SELECT * FROM depodb";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Kolon1: {reader["urunAD"]}, Kolon2: {reader["urunMIKTAR"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }


            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
