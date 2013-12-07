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

namespace Vet_Clinic
{
    public partial class viewVac : Form
    {
        MySqlConnection connection = new MySqlConnection(utils.MyConString);
        public long visitNum;

        public viewVac(long vNum)
        {
            InitializeComponent();
            this.visitNum = vNum;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewVac_Load(object sender, EventArgs e)
        {
            fillVac();
        }

        public void fillVac()
        {
            typeListBox.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select type from tblgivenvaccine where vNum = '" + visitNum + "'";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                typeListBox.Items.Add(thisrow);
            }
            connection.Close();
        }
    }
}
