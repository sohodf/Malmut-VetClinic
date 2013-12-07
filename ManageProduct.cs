using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project1;
using Vet_Clinic.vetclinicDataSetTableAdapters;

namespace Vet_Clinic
{
    public partial class ManageProduct : Form
    {
        MySqlConnection connection = new MySqlConnection(utils.MyConString);
        private string pName;
        private Start start;
        private string action;
        
        // קונסטרקטור לעריכה של מוצר
        public ManageProduct(string pName, Start start)
        {
            InitializeComponent();
            this.tblproductsTableAdapter.FillByName(this.vetclinicDataSet.tblproducts, pName.Trim());
            this.start = start; 
            this.pName = pName;
            this.action = "edit";
            this.Text = "עריכת מוצר";
        }

        // קונסטרקטור להוספה של מוצר
        public ManageProduct(Start start)
        {
            InitializeComponent();
            this.start = start;
            this.action = "add";
            this.Text = "הוספת מוצר";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            long result;

            if (barcodeTextBox.Text == "" || !long.TryParse(barcodeTextBox.Text, out result))
            {
                pictureBox5.Visible = true;
                error = true;
            }

            if (nameTextBox.Text == "")
            {
                pictureBox2.Visible = true;
                error = true;
            }

            if (!error)
            {
                string barcode = barcodeTextBox.Text;
                string name = nameTextBox.Text;
                string desc = descTextBox.Text;
                double price = double.Parse(priceTextBox.Text);
                int stock = int.Parse(stockTextBox.Text);
                int stockAlert = int.Parse(alertStockTextBox.Text);
                
                if (action == "edit")
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE tblproducts SET barcode = @barcode, name = @name, descr = @desc, price = @price, stock = @stock, alertStock = @alertStock WHERE name = @prevName";
                    command.Parameters.AddWithValue("@barcode", barcode);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@alertStock", stockAlert);
                    command.Parameters.AddWithValue("@prevName", pName.Trim());

                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                    start.tblproductsTableAdapter.FillByName(start.vetclinicDataSet.tblproducts, name);
                    
                }

                else if (action == "add")
                {
                    vetclinicDataSet.tblproductsRow rta;
                    rta = vetclinicDataSet.tblproducts.NewtblproductsRow();
                    rta.barcode = barcode;
                    rta.name = name;
                    rta.descr = desc;
                    rta.price = price;
                    rta.stock = stock;
                    rta.alertStock = stockAlert;

                    this.vetclinicDataSet.tblproducts.AddtblproductsRow(rta);
                    this.tblproductsTableAdapter.Update(this.vetclinicDataSet.tblproducts);
                }

                start.FillProducts();
                this.Close(); 

            }
        }

        private void editProduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_Validated(object sender, EventArgs e)
        {

        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            double res;

            if (!double.TryParse(priceTextBox.Text, out res))
            {
                pictureBox1.Visible = true;
                e.Cancel = true;

            }
        }

        private void stockTextBox_Validating(object sender, CancelEventArgs e)
        {
            long result;

            if (!long.TryParse(stockTextBox.Text, out result))
            {
                pictureBox3.Visible = true;
                e.Cancel = true;
            }
        }

        private void alertStockTextBox_Validating(object sender, CancelEventArgs e)
        {
            long result;

            if (!long.TryParse(alertStockTextBox.Text, out result))
            {
                pictureBox4.Visible = true;
                e.Cancel = true;
            }
        }
        
    }
}
