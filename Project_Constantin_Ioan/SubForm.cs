using Project_Constantin_Ioan.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Constantin_Ioan
{
    public partial class SubForm : Form
    {
        private const string _connectionString = "Data Source=C:\\Users\\gogul\\source\\repos\\Project_Constantin_Ioan\\Project_Constantin_Ioan\\Database.db";
        private Subscription subscription;
        private readonly List<Client> _client;
        private readonly List<ExtraOption> _extraOption;
        public SubForm(List<Client> client, List<ExtraOption> extraOption)
        {
            InitializeComponent();
            _client = client;
            _extraOption = extraOption;
            DisplaySub();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplaySub()
        {
            lvSub.Items.Clear();
            foreach (Client client in subscription.Client)
                foreach (ExtraOption extraOption in subscription.ExtraOptions)
                {
                    var listViewItem1 = new ListViewItem(client.ClientId.ToString());
                    listViewItem1.SubItems.Add(extraOption.ExtraOptionId.ToString());

                }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        //private void ReadEntries()
        //{
        //    var query = "SELECT ClientId, ExtraOptionId from Client,ExtraOption";
        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        var command = new SQLiteCommand(query, connection);
        //        using (SQLiteDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var clientId = (long)reader["ClientId"];
        //                var extraOptionId = (long)reader["ExtraOptionId"];

        //                var sub = new Subscription(clientId,extraOptionId);
        //            }
        //        }
        //    }
        //}

        //private void SubForm_Load(object sender, EventArgs e)
        //{
        //    ReadEntries();
        //}
        //}
        //private void CreateSub(Client client, ExtraOption extraOption)
        //{
        //    var query = "INSERT INTO Client (LastName, FirstName, Address, PhoneNo, Ssn) VALUES (@lastName, @firstName, @address, @phoneNo, @ssn);";
        //    query += "SELECT last_insert_rowid();";

        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();

        //        var command = new SQLiteCommand(query, connection);

        //        var id = (long)command.ExecuteScalar();
        //        client.ClientId = id;
        //        extraOption.ExtraOptionId = id;
        //        subscription.Client.Add(client);
        //        subscription.ExtraOptions.Add(extraOption);
        //    }
        //}
        //private void CreateClient(Client client)
        //{
        //    var query = "INSERT INTO Client (LastName, FirstName, Address, PhoneNo, Ssn) VALUES (@lastName, @firstName, @address, @phoneNo, @ssn);";
        //    query += "SELECT last_insert_rowid();";

        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        connection.Open();

        //        var command = new SQLiteCommand(query, connection);
        //        command.Parameters.AddWithValue("@lastName", client.LastName);
        //        command.Parameters.AddWithValue("@firstName", client.FirstName);
        //        command.Parameters.AddWithValue("@address", client.Address);
        //        command.Parameters.AddWithValue("@phoneNo", client.PhoneNo);
        //        command.Parameters.AddWithValue("@ssn", client.Ssn);

        //        var id = (long)command.ExecuteScalar();
        //        client.ClientId = id;

        //        subscription.Client.Add(client);
        //    }
        //}

        //private void ReadClients()
        //{
        //    var query = "SELECT * FROM Client;";

        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();

        //        var command = new SQLiteCommand(query, connection);

        //        using (SQLiteDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var clientId = (long)reader["ClientId"];
        //                var lastName = (string)reader["LastName"];
        //                var firstName = (string)reader["FirstName"];
        //                var address = (string)reader["Address"];
        //                var phoneNo = (string)reader["PhoneNo"];
        //                var ssn = (string)reader["Ssn"];

        //                var client = new Client(clientId, lastName, firstName, address, phoneNo, ssn);
        //                subscription.Client.Add(client);
        //            }
        //        }
        //    }
        //}
        //private void CreateExtraOption(ExtraOption extraOption)
        //{
        //    var query = "INSERT INTO ExtraOption (extraOptionName, Price, Created, Benefits) VALUES (@extraOptionName, @price, @created, @benefits);";
        //    query += "SELECT last_insert_rowid();";

        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();

        //        var command = new SQLiteCommand(query, connection);
        //        command.Parameters.AddWithValue("@extraOptionName", extraOption.ExtraOptionName);
        //        command.Parameters.AddWithValue("@price", extraOption.Price);
        //        command.Parameters.AddWithValue("@created", extraOption.Created.ToString());
        //        command.Parameters.AddWithValue("@benefits", extraOption.Benefits);

        //        var id = (long)command.ExecuteScalar();
        //        extraOption.ExtraOptionId = id;

        //        subscription.ExtraOptions.Add(extraOption);
        //    }
        //}

        //private void ReadExtraOptions()
        //{
        //    var query = "SELECT * FROM ExtraOption;";

        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();

        //        var command = new SQLiteCommand(query, connection);

        //        using (SQLiteDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var extraOptionId = (long)reader["ExtraOptionId"];
        //                var extraOptionName = (string)reader["ExtraOptionName"];
        //                var price = (string)reader["Price"];
        //                var created = DateTime.Parse((string)reader["Created"]);
        //                var benefits = (string)reader["Benefits"];

        //                var extraOption = new ExtraOption(extraOptionId, extraOptionName, price, created, benefits);
        //                subscription.ExtraOptions.Add(extraOption);
        //            }
        //        }
        //    }
        //}
        //private void lvSub_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void add1_Click(object sender, EventArgs e)
        //{
        //    var client = new Client();
        //    var extraOption = new ExtraOption();
        //    try
        //    {
        //        CreateClient(client);
        //        CreateExtraOption(extraOption);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    DisplaySub();
        //}

        //private void SubForm_Load(object sender, EventArgs e)
        //{
        //    ReadClients();
        //    ReadExtraOptions();
        //}
        //}
    }
}
