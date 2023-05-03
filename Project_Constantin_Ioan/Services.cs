using Project_Constantin_Ioan.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project_Constantin_Ioan
{
    public partial class Services : Form
    {
        private const string _connectionString = "Data Source=C:\\Users\\gogul\\source\\repos\\Project_Constantin_Ioan\\Project_Constantin_Ioan\\Database.db";
        private int _currentClientsIndex;
        private int _currentExtraOptionIndex;
        private Subscription Subscription;
        public Services()
        {
            InitializeComponent();
            Subscription = new Subscription();
        }
        private void DisplayClientsEO()
        {
            lvClient.Items.Clear();
            lvExtraOption.Items.Clear();
            foreach (Client client in Subscription.Client){
                var listViewItem1 = new ListViewItem(client.ClientId.ToString());
                listViewItem1.SubItems.Add(client.LastName);
                listViewItem1.SubItems.Add(client.FirstName);
                listViewItem1.SubItems.Add(client.Address);
                listViewItem1.SubItems.Add(client.PhoneNo);
                listViewItem1.SubItems.Add(client.Ssn);
                listViewItem1.Tag = client;
                lvClient.Items.Add(listViewItem1);
            }
            foreach (ExtraOption extraOption in Subscription.ExtraOptions)
            {
                var listViewItem2 = new ListViewItem(extraOption.ExtraOptionId.ToString());
                listViewItem2.SubItems.Add(extraOption.ExtraOptionName);
                listViewItem2.SubItems.Add(extraOption.Price);
                listViewItem2.SubItems.Add(extraOption.Created.ToShortDateString());
                listViewItem2.SubItems.Add(extraOption.Benefits);
                listViewItem2.Tag = extraOption;
                lvExtraOption.Items.Add(listViewItem2);
            }
        }
        #region Client
        private void CreateClient(Client client)
        {
            var query = "INSERT INTO Client (LastName, FirstName, Address, PhoneNo, Ssn) VALUES (@lastName, @firstName, @address, @phoneNo, @ssn);";
            query += "SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@lastName", client.LastName);
                command.Parameters.AddWithValue("@firstName", client.FirstName);
                command.Parameters.AddWithValue("@address", client.Address);
                command.Parameters.AddWithValue("@phoneNo", client.PhoneNo);
                command.Parameters.AddWithValue("@ssn", client.Ssn);

                var id = (long)command.ExecuteScalar();
                client.ClientId = id;

                Subscription.Client.Add(client);
            }
        }

        private void ReadClients()
        {
            var query = "SELECT * FROM Client;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clientId = (long)reader["ClientId"];
                        var lastName = (string)reader["LastName"];
                        var firstName = (string)reader["FirstName"];
                        var address = (string)reader["Address"];
                        var phoneNo = (string)reader["PhoneNo"];
                        var ssn = (string)reader["Ssn"];

                        var client = new Client(clientId, lastName, firstName, address, phoneNo, ssn);
                        Subscription.Client.Add(client);
                    }
                }
            }
        }

        private void UpdateClient(Client client)
        {
            var query = "UPDATE Client SET LastName = @lastName, FirstName = @firstName, Address = @address, PhoneNo=@phoneNo, Ssn=@ssn WHERE ClientId = @clientId;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@clientId", client.ClientId);
                command.Parameters.AddWithValue("@lastName", client.LastName);
                command.Parameters.AddWithValue("@firstName", client.FirstName);
                command.Parameters.AddWithValue("@address", client.Address);
                command.Parameters.AddWithValue("@phoneNo", client.PhoneNo);
                command.Parameters.AddWithValue("@ssn", client.Ssn);

                command.ExecuteScalar();
            }
        }

        private void DeleteClient(Client client)
        {
            var query = "DELETE FROM Client WHERE ClientId = @clientId;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@clientId", client.ClientId);
                command.ExecuteNonQuery();
                Subscription.Client.Remove(client);
            }
        }
        #endregion
        #region Extraoption
        private void CreateExtraOption(ExtraOption extraOption)
        {
            var query = "INSERT INTO ExtraOption (extraOptionName, Price, Created, Benefits) VALUES (@extraOptionName, @price, @created, @benefits);";
            query += "SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@extraOptionName", extraOption.ExtraOptionName);
                command.Parameters.AddWithValue("@price", extraOption.Price);
                command.Parameters.AddWithValue("@created", extraOption.Created.ToString());
                command.Parameters.AddWithValue("@benefits", extraOption.Benefits);

                var id = (long)command.ExecuteScalar();
                extraOption.ExtraOptionId = id;

                Subscription.ExtraOptions.Add(extraOption);
            }
        }

        private void ReadExtraOptions()
        {
            var query = "SELECT * FROM ExtraOption;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var extraOptionId = (long)reader["ExtraOptionId"];
                        var extraOptionName = (string)reader["ExtraOptionName"];
                        var price = (string)reader["Price"];
                        var created = DateTime.Parse((string)reader["Created"]);
                        var benefits = (string)reader["Benefits"];

                        var extraOption = new ExtraOption(extraOptionId,extraOptionName,price,created,benefits);
                        Subscription.ExtraOptions.Add(extraOption);
                    }
                }
            }
        }

        private void UpdateExtraOption(ExtraOption extraOption)
        {
            var query = "UPDATE ExtraOption SET ExtraOptionName = @extraOptionName, Price = @price, Created = @created, Benefits=@benefits, WHERE ExtraOptionId = @extraOptionId;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@extraOptionId", extraOption.ExtraOptionId);
                command.Parameters.AddWithValue("@extraOptionName", extraOption.ExtraOptionName);
                command.Parameters.AddWithValue("@price", extraOption.Price);
                command.Parameters.AddWithValue("@address", extraOption.Created.ToString());
                command.Parameters.AddWithValue("@benefits", extraOption.Benefits);

                command.ExecuteScalar();
            }
        }

        private void DeleteExtraOption(ExtraOption extraOption)
        {
            var query = "DELETE FROM ExtraOption WHERE ExtraOptionId = @extraOptionId;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@extraOptionId", extraOption.ExtraOptionId);
                command.ExecuteNonQuery();
                Subscription.ExtraOptions.Remove(extraOption);
            }
        }
        #endregion

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text);
        }
        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text);
        }

        private void addEdit_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(addEdit, 0, addEdit.Height);
        }

        private void addEditClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClient.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a client");
                return;
            }

            ClientForm clientForm = new ClientForm((Client)lvClient.SelectedItems[0].Tag);
            if (clientForm.ShowDialog() == DialogResult.OK)
                DisplayClientsEO();
        }

        private void addEditExtraOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvExtraOption.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an extra option");
                return;
            }

            ExtraOptionForm extraOptionForm = new ExtraOptionForm((ExtraOption)lvExtraOption.SelectedItems[0].Tag);
            if (extraOptionForm.ShowDialog() == DialogResult.OK)
                DisplayClientsEO();
        }

        private void Services_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt&&e.KeyCode==Keys.D)
            {
                delete.PerformClick();
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            ReadClients();
            ReadExtraOptions();
            DisplayClientsEO();
            this.KeyPreview = true;
            ControlExtension.Draggable(button1, true);
            ControlExtension.Draggable(addClient, true);
            ControlExtension.Draggable(delete,true);
            ControlExtension.Draggable(addEdit, true);
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter text = new StreamWriter("Database.txt");
            text.Write("Clients: \n");
            text.Write(lvClient);
            text.Write("\rExtra Options: \n");
            text.Write(lvExtraOption);
            text.Close();
        }

        private void binaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary File | *.bin";
            saveFileDialog.Title = "Save as a file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".bin"))
                {
                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, Subscription);
                    }
                }
            }
        }

        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML File | *.xml";
            saveFileDialog.Title = "Save as a file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".xml"))
                {
                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Subscription));
                        serializer.Serialize(fs, Subscription);
                    }
                }
            }
        }


        private void xMLFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML File | *.xml";
            openFileDialog.Title = "Read from file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".xml"))
                {
                    using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Subscription));
                        Subscription = serializer.Deserialize(fs) as Subscription;
                        DisplayClientsEO();
                    }
                }
            }
        }

        private void binaryFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary File | *.bin";
            openFileDialog.Title = "Read from file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".bin"))
                {
                    using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Subscription = formatter.Deserialize(fs) as Subscription;
                        DisplayClientsEO();
                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(delete, 0, delete.Height);
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text;
            string firstName = ctrlFirstName.Text;
            string ssn = ctrlSsn.Text;
            string address=ctrlAddress.Text;
            string phoneNo=ctrlPhoneNumber.Text;
            var client = new Client(lastName,firstName,address,phoneNo,ssn);
            try
            {
                CreateClient(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisplayClientsEO();
            textBox1.Clear();
            ctrlFirstName.Clear();
            ctrlSsn.Clear();
            ctrlAddress.Clear();
            ctrlPhoneNumber.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name=ctrlName.Text;
            string price=ctrlPrice.Text;
            DateTime created = ctrlCreated.Value;
            string benefits=ctrlBenefits.Text;
            var extraOption = new ExtraOption(name, price, created, benefits);
            try
            {
                CreateExtraOption(extraOption);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DisplayClientsEO();
            ctrlName.Clear();
            ctrlPrice.Clear();
            ctrlBenefits.Clear();
        }


        private void deleteExtraOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvExtraOption.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an extra option");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                try
                {
                    DeleteExtraOption((ExtraOption)lvExtraOption.SelectedItems[0].Tag);
                    DisplayClientsEO();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClient.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a client");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                try
                {
                    DeleteClient((Client)lvClient.SelectedItems[0].Tag);
                    DisplayClientsEO();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 24);

            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = e.MarginBounds.Left;
            var marginTop = e.MarginBounds.Top;
            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }
            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;
            var currentY = marginTop;
            while (_currentClientsIndex < Subscription.Client.Count&& _currentExtraOptionIndex<Subscription.ExtraOptions.Count)
            {
                var currentX = marginLeft;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    Subscription.Client[_currentClientsIndex].ClientId.ToString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    Subscription.Client[_currentClientsIndex].LastName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    Subscription.Client[_currentClientsIndex].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                  Pens.Black,
                  currentX,
                  currentY,
                  columnWidth,
                  rowHeight);
                e.Graphics.DrawString(
                    Subscription.Client[_currentClientsIndex].Address,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                  Pens.Black,
                  currentX,
                  currentY,
                  columnWidth,
                  rowHeight);
                e.Graphics.DrawString(
                    Subscription.Client[_currentClientsIndex].PhoneNo,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                  Pens.Black,
                  currentX,
                  currentY,
                  columnWidth,
                  rowHeight);
                e.Graphics.DrawString(
                    Subscription.Client[_currentClientsIndex].Ssn,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                  Pens.Black,
                  currentX,
                  currentY,
                  columnWidth,
                  rowHeight);
                e.Graphics.DrawString(
                    Subscription.ExtraOptions[_currentExtraOptionIndex].ExtraOptionId.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                 Pens.Black,
                 currentX,
                 currentY,
                 columnWidth,
                 rowHeight);
                e.Graphics.DrawString(
                    Subscription.ExtraOptions[_currentExtraOptionIndex].ExtraOptionName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                 Pens.Black,
                 currentX,
                 currentY,
                 columnWidth,
                 rowHeight);
                e.Graphics.DrawString(
                    Subscription.ExtraOptions[_currentExtraOptionIndex].Price,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                 Pens.Black,
                 currentX,
                 currentY,
                 columnWidth,
                 rowHeight);
                e.Graphics.DrawString(
                    Subscription.ExtraOptions[_currentExtraOptionIndex].Created.ToShortDateString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                 Pens.Black,
                 currentX,
                 currentY,
                 columnWidth,
                 rowHeight);
                e.Graphics.DrawString(
                    Subscription.ExtraOptions[_currentExtraOptionIndex].Benefits,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                _currentClientsIndex++;
                _currentExtraOptionIndex++;
                currentY += rowHeight;
                if (currentY - marginTop + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentClientsIndex = 0;
            _currentExtraOptionIndex = 0;
        }

        private void ctrlName_TextChanged(object sender, EventArgs e)
        {

        }
        private void newSub_Click(object sender, EventArgs e)
        {
            //SubForm sf = new SubForm(Subscription.Client, Subscription.ExtraOptions);
            //sf.ShowDialog();
        }
    }
}
