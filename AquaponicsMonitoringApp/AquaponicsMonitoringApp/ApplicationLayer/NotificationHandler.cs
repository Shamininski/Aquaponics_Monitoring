using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// Class Creator: Tanya
    /// </summary>
    public class NotificationHandler
    {
        private DateTime notifyDate;
        private DateTime notifyTime;
        private string location;
        private string notifyText;

        public NotificationHandler(DateTime notifyDate, DateTime notifyTime, string location, string notifyText)
        {
            this.NotifyDate = notifyDate;
            this.NotifyTime = notifyTime;
            this.Location = location;
            this.NotifyText = notifyText;
        }

        public NotificationHandler()
        {
        }

        public string NotifyText
        {
            get { return notifyText; }
            set { notifyText = value; }
        }


        public string Location
        {
            get { return location; }
            set { location = value; }
        }


        public DateTime NotifyTime
        {
            get { return notifyTime; }
            set { notifyTime = value; }
        }


        public DateTime NotifyDate
        {
            get { return notifyDate; }
            set { notifyDate = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            NotificationHandler notH = obj as NotificationHandler;
            if ((object)notH == null)
            {
                return false;
            }
            return (this.NotifyDate == notH.NotifyDate) && (this.NotifyTime == notH.NotifyTime) && (this.Location == notH.Location) && (this.NotifyText == notH.NotifyText);
        }

        public override int GetHashCode()
        {
            return this.NotifyDate.GetHashCode() ^ this.NotifyTime.GetHashCode() ^ this.Location.GetHashCode() ^ this.NotifyText.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}", this.NotifyDate.ToShortDateString(), this.NotifyTime.ToShortTimeString(), this.Location, this.notifyText);
        }

        public string saveString()
        {
            return String.Format("{0:yyyy-MM-dd}", this.NotifyDate) + "#" + String.Format("{0:hh:mm:ss}" + ".0000", this.NotifyTime) + "#" + this.Location + "#" + this.NotifyText;
        }

        public void saveNotification()
        {
            DataAccessLayer.FileHandler fh = new DataAccessLayer.FileHandler("notifications.txt");
            List<string> notifications = new List<string>();
            notifications.Add(this.saveString());
            fh.WriteToTxt(notifications);
        }

        public List<NotificationHandler> getNotifications()
        {
            int y = 0, m = 0, d = 0, hour = 0, min = 0, sec = 0;
            List<NotificationHandler> notifications = new List<NotificationHandler>();
            DataAccessLayer.FileHandler fh = new DataAccessLayer.FileHandler("notifications.txt");
            List<string> notificationsFromTxt = fh.ReadFromTxt();

            foreach (string item in notificationsFromTxt)
            {
                string[] line = item.Split('#');
                string[] dateSections = line[0].ToString().Split('-');
                y = Convert.ToInt32(dateSections[0]);
                m = Convert.ToInt32(dateSections[1]);
                d = Convert.ToInt32(dateSections[2]);
                DateTime date = new DateTime(y, m, d);

                char[] delimiters = new char[] { ':', '.' };
                string[] timeSections = line[1].ToString().Split(delimiters, StringSplitOptions.None);
                hour = Convert.ToInt32(timeSections[0]);
                min = Convert.ToInt32(timeSections[1]);
                sec = Convert.ToInt32(timeSections[2]);
                DateTime time = new DateTime(y, m, d, hour, min, sec);

                NotificationHandler nh = new NotificationHandler(date, time, line[2].ToString(), line[3].ToString());
            }
            return notifications;
        }
    }
}
