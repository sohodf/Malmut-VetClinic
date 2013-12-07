using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Vet_Clinic.SendSmsWS;

namespace Vet_Clinic
{
    public partial class SMSSend : Form
    {
        private int custNum; 
        private string custPhone;
        private int charectesrsLeft;
        public static int smsCharecters = 70;
        public static int phoneLength = 10;
        private int messagesLeft;
        
        //שליחה ללקוח פעיל
        public SMSSend(int custNum, string custPhone)
        {
            InitializeComponent();
            this.custNum = custNum;
            this.custPhone = custPhone;
            this.Text = "שליחת הודעה ללקוח פעיל";

            custPhone = Regex.Replace(custPhone, "-", "");

            if (custPhone.Length < phoneLength)
            {
                custPhone = "0" + custPhone;
            }

            textBox1.Text = custPhone;

            //general
            this.charectesrsLeft = smsCharecters;
            label4.Text = smsCharecters.ToString();
            
         }

        // שליחה ללקוח כללי

        public SMSSend()
        {
            InitializeComponent();
            this.charectesrsLeft = smsCharecters;
            label4.Text = smsCharecters.ToString();
            this.Text = "שליחת הודעה ללקוח";
            
        }

        private void SMSSend_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        public bool SendSms(string toMobile, string message)
        {
            if (label6.Text == "0")
            {
                return false;
            }

            else
            {
                SendSmsWS.SendSmsWS sendSmsWS = new SendSmsWS.SendSmsWS(); // Create new SendSmsWS 
                Result result = new Result(); // Create new Result 
                result = sendSmsWS.SendSms(utils.smsUser, utils.smsPass, toMobile,
                                           message, "048444462", 0, 120); // Send sms 
                if (result.result == "OK")
                {
                    MessageBox.Show("ההודעה נשלחה בהצלחה");
                    return true;
                }
                else
                {
                    string notsent = "ההודעה לא נשלחה. הסיבה:";
                    notsent += "\n" + result.result;
                    MessageBox.Show(notsent);
                    return false;
                }


            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Trim().Length > smsCharecters)
            {
               textBox2.Text = textBox2.Text.Remove(textBox2.Text.Trim().Length-1, 1);
               
            }
            else
            {
                charectesrsLeft = smsCharecters - textBox2.Text.Trim().Length;
                label4.Text = charectesrsLeft.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != phoneLength)
            {
                MessageBox.Show("מספר נייד לא תקין");
            }
            else if (textBox2.Text.Length > smsCharecters)
            {
                MessageBox.Show("הוזנו יותר מדי תווים");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("לא ניתן לשלוח הודעה ריקה");
            }
           
            else
            {
                if (SendSms(textBox1.Text, textBox2.Text))
                {
                    this.Close();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int GetMessagesCredit()
        {
            SendSmsWS.SendSmsWS sendSms = new SendSmsWS.SendSmsWS();

            object obj = sendSms.GetMessagesCredit(utils.smsUser, utils.smsPass);
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
           messagesLeft = GetMessagesCredit();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateCredits();
        }

        private void SMSSend_Shown(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label6.Text = messagesLeft.ToString();
        }



    }
}
