using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading;

namespace CryptoManager
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadWalletListView();
        }

        public class WalletContent
        {
            public string Token { get; set; }
            public string Wallet { get; set; }
            public float TotalValue { get; set; }
            public float TotalPrice { get; set; }
            public float PricePerToken { get; set; }
        }

        // Create the colums and add the content
        private void LoadWalletListView()
        {

            // Set columns
            walletContentListView.View = View.Details;
            walletContentListView.Columns.Add("Wallet");
            walletContentListView.Columns.Add("Token Name");
            walletContentListView.Columns.Add("Token(s)");
            walletContentListView.Columns.Add("Value");
            walletContentListView.Columns.Add("PPT");

            // Get data
            /*
            var fileNames = Directory.GetFiles(".\\data\\");
            foreach (var fileName in fileNames)
            {
                string[] data = File.ReadAllLines(fileName).ToArray();
                foreach (string d in data)
                {
                    Console.WriteLine(d);
                    string[] items = d.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    walletContentListView.Items.Add(new ListViewItem(items));
                }
            }*/
            RefreshWalletListView(); 
            RefreshLabelsContent();

            // Auto-size the columns
            for (int i = 0; i < walletContentListView.Columns.Count; i++)
            {
                walletContentListView.Columns[i].Width = -2;
            }

            // Prevent resize
            this.walletContentListView.ColumnWidthChanging += new ColumnWidthChangingEventHandler(walletContentListView_ColumnWidthChanging);

        }

        // Refresh le list view
        private void RefreshWalletListView()
        {
            try
            {
                walletContentListView.Items.Clear();

                string jsonString = File.ReadAllText(".\\data\\" + "wallet" + ".json");
                dynamic dynJson = JsonConvert.DeserializeObject(jsonString);
                foreach (var item in dynJson)
                {
                    string[] items = { item.Wallet, item.Token, item.TotalValue.ToString(), item.TotalPrice.ToString(), item.PricePerToken.ToString() };
                    walletContentListView.Items.Add(new ListViewItem(items));
                }
            }
            catch { Console.WriteLine("No valid json file to read"); }
        }

        void walletContentListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.walletContentListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        // Refresh labels
        private void RefreshLabelsContent()
        {
            string jsonString = File.ReadAllText(".\\data\\" + "wallet" + ".json");
            dynamic dynJson = JsonConvert.DeserializeObject(jsonString);
            float total = 0.0f;
            foreach (var item in dynJson)
            {
                total += float.Parse(item.TotalPrice.ToString("####0.00"));
            }
            TotalBuyLabel.Text = $"Total spent:\t{total}";
        }

        private void buyPriceLabel_Click(object sender, EventArgs e)
        {

        }

        // When ValidateBuy button is clicked, all input data will be written to a file
        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (buyValueInput.Text != "" && buyPriceInput.Text != "" && TokenTypeList.SelectedItem != null && walletListBox.SelectedItem != null)
            {
                /*using (StreamWriter sw = File.AppendText(".\\data\\"+walletListBox.SelectedItem+".csv"))
                {
                    
                    sw.Write(TokenTypeList.SelectedItem.ToString() + ",");
                    sw.Write(walletListBox.SelectedItem.ToString() + ",");
                    sw.Write(buyValueInput.Text + ",");
                    sw.Write(buyPriceInput.Text + ",\n");
                    sw.Close();
                    
                }*/

                var path = ".\\data\\" + "wallet" + ".json";

                //Register whats already inside wallet file
                var json = File.ReadAllText(path);
                var walletContent = JsonConvert.DeserializeObject<List<WalletContent>>(json);

                bool addedToExistentEntry = false;
                // Check if its a new entry by lmooping thought existent entries
                foreach (var item in walletContent)
                {
                    Console.WriteLine(item.Token + "\t" + TokenTypeList.SelectedItem.ToString());
                    if (item.Token == TokenTypeList.SelectedItem.ToString()) { // Could be optimized by a |if __ && __| but i want to keep it for later
                        Console.WriteLine("I see that you already have some");
                        if (item.Wallet == walletListBox.SelectedItem.ToString())
                        {
                            // Create a new entry
                            Console.WriteLine("And in the same wallet");
                            //json = File.ReadAllText(path);
                            float v = float.Parse(buyValueInput.Text, CultureInfo.InvariantCulture);
                            float p = float.Parse(buyPriceInput.Text, CultureInfo.InvariantCulture);

                            json = json.Replace($"{item.TotalValue}", $"{item.TotalValue + v}");
                            json = json.Replace($"{item.TotalPrice}", $"{item.TotalPrice + p}");
                            json = json.Replace($"{item.PricePerToken}", $"{(p / v).ToString("####0.00")}");

                            Console.WriteLine($"{item.TotalValue + v}");
                            Console.WriteLine($"{item.TotalPrice + p}");
                            Console.WriteLine($"{item.PricePerToken}", $"{(p / v).ToString("####0.00")}");
                            //File.WriteAllText(path, text);
                            addedToExistentEntry = true;
                            break;
                        }
                    }
                    Console.WriteLine(item);
                }

                if (!addedToExistentEntry) 
                {
                    // Create a new entry
                    Console.WriteLine("New Entry");
                    float v = float.Parse(buyValueInput.Text, CultureInfo.InvariantCulture);
                    float p = float.Parse(buyPriceInput.Text, CultureInfo.InvariantCulture);
                    float ppt = p / v;

                    walletContent.Add(new WalletContent()
                    {
                        Token = TokenTypeList.SelectedItem.ToString(),
                        Wallet = walletListBox.SelectedItem.ToString(),
                        TotalValue = v,
                        TotalPrice = p,
                        PricePerToken = float.Parse(ppt.ToString("####0.00"))
                    });
                    json = JsonConvert.SerializeObject(walletContent);
                }

                // Write it outside the loop to avoid opening the file 2x
                File.WriteAllText(path, json);

                // Clear inputs
                buyValueInput.Text = "";
                buyPriceInput.Text = "";

                // Refresh WalletContent View
                RefreshWalletListView();

                // Show box noticing validation
                MessageBox.Show("Successdully added new buy.", "Ok !");
                
            }
            else
            {
                MessageBox.Show("You forgot something !");
            }
        }

        private void buyPriceInput_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(buyPriceInput.Text, @"^[0-9]*(?:\.[0-9]*)?$"))
            {
                //MessageBox.Show("Format: 99.99", "Please enter only numbers.");
                //buyPriceInput.Text = buyPriceInput.Text.Remove(buyPriceInput.Text.Length - 1);
                buyPriceInput.Text = buyPriceInput.Text.Replace(',', '.');
            }
        }

        private void buyValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void buyValueInput_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(buyValueInput.Text, @"^[0-9]*(?:\.[0-9]*)?$"))
            {
                //MessageBox.Show("Format: 99.99", "Please enter only numbers.");
                //buyValueInput.Text = buyValueInput.Text.Remove(buyValueInput.Text.Length - 1);
                buyValueInput.Text = buyValueInput.Text.Replace(',', '.');
            }
        }

        private void walletContentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Security
            if (editionBoxButton.Checked)
            {
                if (walletContentListView.SelectedItems.Count != 0)
                {
                    //Delete from the view
                    /*
                    var s = walletContentListView.SelectedItems[0];
                    walletContentListView.Items.Remove(s);*/

                    var path = ".\\data\\" + "wallet" + ".json";

                    //Register whats already inside wallet file
                    var json = File.ReadAllText(path);
                    var walletContent = JsonConvert.DeserializeObject<List<WalletContent>>(json);

                    var toDel = $"{walletContentListView.SelectedItems[0].SubItems[0].Text}--{walletContentListView.SelectedItems[0].SubItems[1].Text}";
                    Console.WriteLine($"Del target {toDel}");
                    for (int i = 0; i < walletContent.Count; i++)
                    {
                        var line = $"{walletContent[i].Wallet}--{walletContent[i].Token}";
                        Console.WriteLine(line);

                        if (line == toDel)
                        {
                            Console.WriteLine($"Should delete {line}");
                            walletContent.RemoveAt(i);

                        }
                    }

                    json = JsonConvert.SerializeObject(walletContent);
                    // Write it outside the loop to avoid opening the file 2x
                    File.WriteAllText(path, json);


                }
                else
                {
                    MessageBox.Show("No entry selected");
                }
            }
            else
            {
                MessageBox.Show("You are not in 'Edition mode'");
            }

            RefreshWalletListView();
            RefreshLabelsContent();
        }
    }
}
