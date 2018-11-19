using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class is used to work with the notification details per sensor, therefore determines
    /// when the listed contacts should be notified of changes within the system.
    /// </summary>
    public class Notifications
    {
        private int notifyID;
        private int sensorID;
        private decimal bottomValue;
        private decimal topValue;



        /// <summary>
        /// Creates an Instance of this class
        /// </summary>
        /// <param name="sensorID">An integer value used to identify the sensor in the database.</param>
        /// <param name="bottomValue">Defines the lower boundary of the critical range.</param>
        /// <param name="topValue">Defines the upper boundary of the critical range,</param>
        /// <param name="notifyID">An integer value that is used to identify this notification setting in the database.</param>
        public Notifications(int sensorID, decimal bottomValue, decimal topValue, int notifyID = 0)
        {
            this.NotifyID = notifyID;
            this.SensorID = sensorID;
            this.BottomValue = bottomValue;
            this.TopValue = topValue;
        }

        public Notifications()
        {
        }

        public decimal TopValue
        {
            get { return topValue; }
            set { topValue = value; }
        }


        public decimal BottomValue
        {
            get { return bottomValue; }
            set { bottomValue = value; }
        }


        public int SensorID
        {
            get { return sensorID; }
            set { sensorID = value; }
        }


        public int NotifyID
        {
            get { return notifyID; }
            set { notifyID = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Notifications notify = obj as Notifications;
            if ((object)notify == null)
            {
                return false;
            }
            return ((this.NotifyID == notify.NotifyID) && (this.SensorID == notify.SensorID) && (this.BottomValue == notify.BottomValue) && (this.TopValue == notify.TopValue));
        }

        public override int GetHashCode()
        {
            return this.NotifyID.GetHashCode() ^ this.SensorID.GetHashCode() ^ this.BottomValue.GetHashCode() ^ this.TopValue.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void insertNotification()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.newNotification(this);
        }

        public void updateNotifications()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.updateNotification(this);
        }

        public List<Notifications> getAllCriticalRanges()
        {
            List<Notifications> allRanges = new List<Notifications>();
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            allRanges = dataHandler.getAllNotifications();

            return allRanges;
        }

        public decimal getTopvalue(int sensorID)
        {
            decimal topValue = 0;
            List<Notifications> criticalRanges = new List<Notifications>();
            criticalRanges = getAllCriticalRanges();
            foreach (Notifications item in criticalRanges)
            {
                if (item.SensorID == sensorID)
                {
                    topValue = item.TopValue;
                }
            }

            return topValue;
        }

        public decimal getBottomValue(int sensorID)
        {
            decimal bottomValue = 0;
            List<Notifications> criticalRanges = new List<Notifications>();
            criticalRanges = getAllCriticalRanges();
            foreach (Notifications item in criticalRanges)
            {
                if (item.SensorID == sensorID)
                {
                    bottomValue = item.BottomValue;
                }
            }

            return bottomValue;
        }

        public void mailNotifcation(string email, string tankName, string sensorName, string boundStatus ,decimal outOfBoundValue)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("additionaladdress.tanya@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Sensor reading out of bounds";
                if (boundStatus == "Bottom")
                {
                    mail.Body = string.Format(
                    @"IMPORTANT NOTIFICATION!,
                      The {0} sensor found in {1} is currently {2} lower than the critical range", sensorName, tankName, outOfBoundValue);
                }

                if (boundStatus  == "Top")
                {
                    mail.Body = string.Format(
                    @"IMPORTANT NOTIFICATION!,
                      The {0} sensor found in {1} is currently {2} higher than the critical range", sensorName, tankName, outOfBoundValue);
                }
               
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("additionaladdress.tanya", "LaPieusAqua");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception)
            {
                DataAccessLayer.FileHandler file = new DataAccessLayer.FileHandler("emailErrors.csv");
                List<string> error = new List<string> { "The notification email could not be sent to user: " + email };
                file.WriteToTxt(error);
            }
        }
    }
}
