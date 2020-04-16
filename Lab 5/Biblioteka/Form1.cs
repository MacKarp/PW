using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteka
{
    public partial class Form1 : Form
    {

        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=qwe1234;database=bibliotekadb;");

        public Form1()
        {
            InitializeComponent();
            string query = "SELECT * FROM ksiazki";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            try
            {
                databaseConnection.Open();

                var reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                        listBox1.Items.Add(row[0] + ". " + row[1] + ", " + row[2]);
                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dotPosition = listBox1.SelectedItem.ToString().IndexOf(".", StringComparison.Ordinal);
            string stringID = listBox1.SelectedItem.ToString().Substring(0, dotPosition);
            string selectItemReadCommandString = "SELECT * FROM ksiazki WHERE ID=" + stringID;
            MySqlCommand selectedItemReadCommand = new MySqlCommand(selectItemReadCommandString, databaseConnection);

            try
            {
                databaseConnection.Open();

                var reader = selectedItemReadCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8) };
                        labelNazwaKsiazki.Text = row[1];
                        labelAutor.Text = "Autor: " + row[2];
                        labelGatunek.Text = "Gatunek: " + row[3];
                        labelISBN.Text = "Numer ISBN: " + row[4];
                        labelWydawnictwo.Text = "Wydawnictwo: " + row[5];
                        labelSektor.Text = "Sektor: " + row[6];
                        labelRegal.Text = "Regał: " + row[7];
                        labelPozycja.Text = "Pozycja: " + row[8];
                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
