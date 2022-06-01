using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;

namespace Vet_Clinic
{
    class utils
    {
        // mysql connection string
    //    public const string MyConString = "SERVER=localhost;" + "DATABASE=vetclinic;" + "UID=root;" + "PASSWORD=123456;";
        public const string MyConString = "Server=localhost;Port=3306;Database=vetclinic;Uid=root;Pwd=123456;";

        //gadi
        //public const string crys = "C:\\Dropbox\\Project\\Project\\Vet Clinic\\Vet Clinic\\";
        //david
        //public const string crys = "C:\\Users\\David\\Desktop\\Dropbox\\University\\Project\\Project\\Vet Clinic\\Vet Clinic\\";
        //david laptop
        //public const string crys = "C:\\Users\\David\\Desktop\\My Dropbox\\University\\Project\\Project\\Vet Clinic\\Vet Clinic\\";
        //Aguda
        //public const string crys = "C:\\Documents and Settings\\BAKARA\\Desktop\\Dropbox\\University\\Project\\Project\\Vet Clinic\\Vet Clinic\\";
        //merav
        public const string crys = "C:\\reports\\";
        
        //שם משתמש וססמא עבור שליחת סמסים
        public const string smsUser = "meiravet";
        public const string smsPass = "663bb81c62d54b758c3d3f0ae8a31d77";
        

        //remove digits from string
        public static string RemoveDigits(string key)
        {
            return Regex.Replace(key, @"\d", "");
        }

        //check if string doesn't contains numbers
        public static bool isLetters(string key)
        {
            return Regex.IsMatch(key, @"\d");
        }
       
        public static string ExtractNumbers(string expr)  //extracts a number from a string
        {
            return string.Join(null, System.Text.RegularExpressions.Regex.Split(expr, "[^\\d]"));
        }

        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            if (service.Status == System.ServiceProcess.ServiceControllerStatus.Stopped
                || service.Status == System.ServiceProcess.ServiceControllerStatus.Paused)
            {
                try
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                catch
                {
                    // ...
                }
            }
        }

        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch
            {
                // ...
            }
        }


    }
}
