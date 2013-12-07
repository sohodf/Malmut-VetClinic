using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project1;

namespace Vet_Clinic
{
    public partial class lastVacs : Form
    {
        MySqlConnection connection = new MySqlConnection(utils.MyConString);
        private int custNum;
        private String aName;
        public Start start;
        private bool heat = false;
        private bool meshusheB = false;
        private bool meshusheC = false;
        private bool meruba = false;

        public lastVacs(int custNum, String aName, Start start)
        {
            InitializeComponent();
            this.custNum = custNum;
            this.aName = aName;
            this.start = start;
           // start.label15.Visible = false;
            start.pictureBox2.Visible = false;
            getLastVacs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //gets when the animal was last given any vaccine
        public void getLastVacs()
        {

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select DISTINCT type from tblgivenvaccine where aName LIKE @aName and custNum like @custNum order by type ASC";
            command.Parameters.AddWithValue("@aName", aName.TrimEnd() + "%");
            command.Parameters.AddWithValue("@custNum", custNum);

            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                while (thisrow.Length < 20)
                    thisrow += " ";
                listBox1.Items.Add(thisrow);  //adds vaccine names to the listbox
            }
            connection.Close();

            MySqlCommand command2 = connection.CreateCommand();
            connection.Open();
            string type;
            string theAName;

            command2.CommandText =
                    "select dateGiven from tblgivenvaccine where aName LIKE @aName and custNum like @custNum and type like @type order by dateGiven DESC LIMIT 1";
            theAName = aName.TrimEnd();

            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                command2.Parameters.Clear();
                command2.Parameters.AddWithValue("@aName", theAName + "%");
                command2.Parameters.AddWithValue("@custNum", custNum);
                type = listBox1.Items[i].ToString().Replace("\r", "");
                type = type.TrimEnd();
                type = type + "%";
                command2.Parameters.AddWithValue("@type", type);
                String temp = command2.ExecuteScalar().ToString();
                if (temp != "")
                {
                    DateTime dt = Convert.ToDateTime(temp);
                    temp = "     " + dt.ToShortDateString() + "                  ";
                }
                listBox1.Items[i] += temp;  //adds the recieving date
            }
            connection.Close();

            listBox1.SelectedIndex = -1;

            MySqlCommand command3 = connection.CreateCommand();
            connection.Open();

            command3.CommandText =
                    "select nextVac from tblgivenvaccine where aName LIKE @aName and custNum like @custNum and type like @type order by dateGiven DESC LIMIT 1";

            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                command3.Parameters.Clear();
                command3.Parameters.AddWithValue("@aName", theAName + "%");
                command3.Parameters.AddWithValue("@custNum", custNum);
                type = utils.RemoveDigits(listBox1.Items[i].ToString().Replace("\r", ""));
                Regex rgx = new Regex("[^a-zA-Z0-9א-ת -]");
                type = rgx.Replace(type, "");
                type = type.TrimEnd();
                type = type + "%";
                command3.Parameters.AddWithValue("@type", type);
                String temp = command3.ExecuteScalar().ToString();
                if (type == "נגד ייחום ב%")
                    heat = true;
                if (type == "משושה ב%")
                    meshusheB = true;
                if (type == "משושה שנתי%")
                    meshusheC = true;
                if (type == "מרובע שנתי%")
                    meruba = true;
                if (temp != "")
                {
                    DateTime dt = Convert.ToDateTime(temp);
                    temp = dt.ToShortDateString();
                    if (dt <= DateTime.Now.AddDays(7) && ((type == "מרובע א%" && meruba != true) || (type == "נגד ייחום א%" && heat != true) || (type == "משושה א%" && meshusheB != true) || (type == "משושה ב%" && meshusheC != true)))
                    {
                        //start.label15.Visible = true;
                        temp += "   פג תוקף!";
                        start.pictureBox2.Visible = true;
                        start.toolTip1.SetToolTip(start.pictureBox2,"קיימים חיסונים פגי תוקף או שעומד לפוג תוקפם");
                    }
                    else if (dt <= DateTime.Now.AddDays(7) && ((type != "מרובע א%" || meruba != true) && (type != "נגד ייחום א%" || heat != true) && (type != "משושה א%" || meshusheB != true) && (type != "משושה ב%" || meshusheC != true)))
                    {
                        //start.label15.Visible = true;
                        temp += "   פג תוקף!";
                        start.pictureBox2.Visible = true;
                        start.toolTip1.SetToolTip(start.pictureBox2, "קיימים חיסונים פגי תוקף או שעומד לפוג תוקפם");
                    }
                }
                listBox1.Items[i] += temp;  //adds expiry date
            }
            connection.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string vacDetails = listBox1.SelectedItem.ToString();
        }


    }
}
