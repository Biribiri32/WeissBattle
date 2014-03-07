using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WeissBattle
{
    public partial class Weiss : Form
    {
        private enum Players { P1, P2 };
        private Dictionary<Players, string> playerLookup = new Dictionary<Players, string>()
        {
            {Players.P1, "Player 1"},
            {Players.P2, "Player 2"}
        };

        public Weiss()
        {
            InitializeComponent();

            LoadLogFromXML();

            LoadCardsFromXML();
        }

        private void LoadLogFromXML()
        {
            try
            {
                Log.Text = "";

                XmlTextReader reader = new XmlTextReader(FileStrings.LogFile);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Text:
                            Log.AppendText(reader.Value);
                        break;
                    }
                }

                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Log.SelectionColor = Color.Purple;
                Log.AppendText("\nError Loading Log.");
            }
        }

        private void LoadCardsFromXML()
        {
            try
            {
                CardDataSet.Clear();

                string filePath = FileStrings.CardFile;

                CardDataSet.ReadXml(filePath);

                SetCards(CardDataSet);

                Card_Collection.DataSource = CardDataSet;
                Card_Collection.DataMember = "Card";
            }
            catch (FileNotFoundException)
            {
                Log.SelectionColor = Color.Purple;
                Log.AppendText("\nError Loading Cards.");
            }
        }

        private void SetCards(DataSet cardData)
        {
            DataTable cards = cardData.Tables["Card"];

            foreach(DataRow dr in cards.Rows)
            {
                if ((string)dr["Owner"] == "1")
                {
                    P1_Card_Name.Text = (string)dr["Name"];
                    P1_Card_Power.Text = (string)dr["Power"];
                }
                else
                {
                    P2_Card_Name.Text = (string)dr["Name"];
                    P2_Card_Power.Text = (string)dr["Power"];
                }
            }
        }

        private void SaveToXml(List<Card> collection, string log)
        {
            // Save the log to XML
            System.Xml.Serialization.XmlSerializer logWriter =
                new System.Xml.Serialization.XmlSerializer(typeof(string));

            System.IO.StreamWriter logFile = new System.IO.StreamWriter(
                FileStrings.LogFile);

            logWriter.Serialize(logFile, log);

            logFile.Close();


            // Save the active cards to file
            System.Xml.Serialization.XmlSerializer cardWriter =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Card>));

            System.IO.StreamWriter cardFile = new System.IO.StreamWriter(
                FileStrings.CardFile);

            cardWriter.Serialize(cardFile, collection);

            cardFile.Close();

            // Reload the data from XML
            LoadCardsFromXML();
        }

        private string Battle(int p1_Power, int p2_Power)
        {
            if(p1_Power > p2_Power)
            {
                return playerLookup[Players.P1];
            }
            else if (p1_Power < p2_Power)
            {
                return playerLookup[Players.P2];
            }

            return "Tie";
        }

        private void Fight_Button_Click(object sender, EventArgs e)
        {
            string p1_Card = P2_Card_Name.Text, p2_Card = P1_Card_Name.Text;
            string battleText = string.Empty;
            try
            {
                battleText = Battle(Int32.Parse(P2_Card_Power.Text),
                    Int32.Parse(P1_Card_Power.Text));
            }
            catch(FormatException)
            {
                Log.SelectionColor = Color.Black;
                Log.AppendText("\nEnter a valid power number.");

                return;
            }

            if (battleText.Contains("2"))
            {
                Log.SelectionColor = Color.Blue;
                Log.AppendText("\n"+ p2_Card + " has higher power, ");
                Log.SelectionColor = Color.Red;
                Log.AppendText("\n" + p1_Card + " side reverses.");
            }
            else if (battleText.Contains("1"))
            {
                Log.SelectionColor = Color.Red;
                Log.AppendText("\n" + p1_Card + " has higher power, ");
                Log.SelectionColor = Color.Blue;
                Log.AppendText("\n" + p2_Card + " side reverses.");
            }
            else
            {
                Log.SelectionColor = Color.Purple;
                Log.AppendText("\nEqual Power, Both sides reverse.");
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Card p1Card = new Card();
            p1Card.Name = P1_Card_Name.Text;
            p1Card.Power = Int32.Parse(P1_Card_Power.Text.Replace(" ", "0"));
            p1Card.Soul = 1;
            p1Card.Owner = 1;

            Card p2Card = new Card();
            p2Card.Name = P2_Card_Name.Text;
            p2Card.Power = Int32.Parse(P2_Card_Power.Text.Replace(" ", "0"));
            p2Card.Soul = 1;
            p2Card.Owner = 2;

            List<Card> collection = new List<Card>();
            collection.Add(p1Card);
            collection.Add(p2Card);

            SaveToXml(collection, Log.Text);
        }
    }
}
