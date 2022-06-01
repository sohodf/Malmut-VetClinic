using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vet_Clinic.SendSmsWS;
using System.Security.Authentication;
using System.Net;

namespace Vet_Clinic
{
    public partial class SmsDist : Form
    {

        private int leftmessages = 0;
        vetclinicDataSet.GetDataForReminderDataTable dt = new vetclinicDataSet.GetDataForReminderDataTable();
        private string sendLog;
        public const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
        public const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
        

        public SmsDist()
        {
            InitializeComponent();
            
            
        }

        private void SmsDist_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        public int GetMessagesCredit()
        {
            SendSMS22.SMSWS sendSMS = new SendSMS22.SMSWS();

            object obj = sendSMS.GetMessagesCredit(utils.smsUser, utils.smsPass);
            int LeftMessgage;
            try
            {
                LeftMessgage = Convert.ToInt32(obj);
            }
            catch
            {
                // Invalid user name or password 
                LeftMessgage = 0;
                MessageBox.Show("התרחשה שגיאה");
            }

            return LeftMessgage;
        }

        public void UpdateCredits()
        {
            leftmessages = GetMessagesCredit();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateCredits();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label5.Text = leftmessages.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // מציאת כל הלקוחות שחיסון חיתם עומד לפוג באמצעות שאילתה למסד הנתונים
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            vetclinicDataSet.EnforceConstraints = false;
            dt = new vetclinicDataSet.GetDataForReminderDataTable();

            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;
            try
            {
                getDataForReminderTableAdapter.Fill(dt, from, to); 
            }
            catch(Exception somethingHappenned)
            {
                //
            }

            label7.Text = dt.Rows.Count.ToString();

            if (label5.Text == "טוען נתונים...")
                label8.Text = "אנא המתן עד לטעינת כמות ההודעות שנותרה ובחר שוב תאריך סיום";
            
            else if (int.Parse(label5.Text) > int.Parse(label7.Text))
            {
                label8.Text = "קיימות מספיק הודעות בחבילה לפעולה המבוקשת";
                label8.ForeColor = Color.Green;
                groupBox1.Visible = true;
            }

            else
            {
                label8.Text =
                    "לא קיימות מספיק הודעות בחבילה לביצוע הפעולה המבוקשת. אנא הקטן את טווח התאריכים או רכוש הודעות נוספות";
                label8.ForeColor = Color.Red;
                groupBox1.Visible = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int succesCounter = 0;
            int failedCounter = 0;

            // יצירת ההודעה שתשלח
            string reminderText = "הנך מוזמן לוטרינרית לחיסון אשר יפוג ב-";
            reminderText += dateTimePicker2.Value.ToShortDateString();
            reminderText += ". דר גולדשטיין";
            // אתחול מד התקדמות
            progressBar1.Minimum = 0;
            progressBar1.Maximum = dt.Count;

            sendLog = "בתאריך ";
            sendLog += DateTime.Now.ToShortDateString();
            sendLog += "בוצעה שליחת תזכורות לחיסונים ";
            sendLog += System.Environment.NewLine;

            // ביצוע השליחה
            foreach(vetclinicDataSet.GetDataForReminderRow GD in dt)
            {
                if (SendSms(GD.cellPhone, reminderText))
                {
                    succesCounter++;
                     //עדכון כל חיסוני הלקוח כמותרעים
                    vetclinicDataSet.tblgivenvaccineDataTable gvdt = new vetclinicDataSet.tblgivenvaccineDataTable();
                    tblgivenvaccineTableAdapter.FillByVaccinesForCust(gvdt, GD.custNum);
                    foreach (vetclinicDataSet.tblgivenvaccineRow custVac in gvdt)
                    {
                        custVac.noticeSent = true;
                        tblgivenvaccineTableAdapter.Update(custVac);
                    }
                    

                }
                    
                else
                {
                    failedCounter++;
                }

                progressBar1.Value++;
            }

            string endText = "השליחה הסתיימה.";
            endText += System.Environment.NewLine;
            endText += succesCounter.ToString();
            endText += " הודעות נשלחו בהצלחה";
            endText += System.Environment.NewLine;
            endText += failedCounter.ToString();
            endText += " הודעות נכשלו";

            MessageBox.Show(endText, "השליחה הסתיימה", MessageBoxButtons.OK, MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

            TextWriter tw = new StreamWriter(@"C:\log.txt");
            tw.WriteLine(sendLog);
            tw.Close();
            Process.Start(@"C:\log.txt");
            this.Close();

        }

        public Boolean SendSms(string toMobile, string message)
        {

            SendSMS22.SMSWS sendSmsWS = new SendSMS22.SMSWS(); // Create new SendSmsWS 
            SendSMS22.Result result = new SendSMS22.Result(); // Create new Result 
            ServicePointManager.SecurityProtocol = Tls12;
            result = sendSmsWS.SendSms(utils.smsUser, utils.smsPass, toMobile,
                                       message, "048444462", 0, 120, "x"); // Send sms 
            System.Threading.Thread.Sleep(100);
            if (result.result == "OK")
            {
                sendLog += "השליחה ללקוח בעל מספר ";
                sendLog += toMobile.ToString();
                sendLog += " הצליחה";
                sendLog += System.Environment.NewLine;
                return true;
            }

            else
            {
                sendLog += "השליחה ללקוח בעל מספר ";
                sendLog += toMobile.ToString();
                sendLog += "נכשלה בעקבות ";
                sendLog += result.result;
                sendLog += " ";
                sendLog += System.Environment.NewLine;
                return false;
            }


        }

        
    }
}
