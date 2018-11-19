using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class is used to work with the contact details that will be set up for a person to get
    /// notified per tank, should the environmental values proof infavourable.
    /// </summary>
    public class Contact
    {
        private int contactID;
        private int sensorID;
        private string email;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        /// <param name="sensorID">An integer values used to identify the sensor in the database.</param>
        /// <param name="email">The email address to which the notification should be sent.</param>
        /// <param name="contactID">An integer value used to identify the contact in the database.</param>
        public Contact(int sensorID, string email, int contactID = 0)
        {
            this.ContactID = contactID;
            this.SensorID = sensorID;
            this.Email = email;
        }

        public Contact()
        {
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int SensorID
        {
            get { return sensorID; }
            set { sensorID = value; }
        }


        public int ContactID
        {
            get { return contactID; }
            set { contactID = value; }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Contact contact = obj as Contact;
            if ((object)contact == null)
            {
                return false;
            }

            return ((this.ContactID == contact.ContactID) && (this.SensorID == contact.SensorID) && (this.Email == contact.Email));
        }

        public override int GetHashCode()
        {
            return this.ContactID.GetHashCode() ^ this.SensorID.GetHashCode() ^ this.Email.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void insertContact()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.newContact(this);
        }

        public void updateContact(string prevEmail)
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.updateContact(this, prevEmail);
        }

        public void deleteContact()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.removeContact(this);
        }

        public List<Contact> getAllContacts()
        {
            List<Contact> allContacts = new List<Contact>();
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            allContacts = dataHandler.getAllContacts();

            return allContacts;
        }

        public List<string> getEmailsToReceiveNotification(int sensorID)
        {
            List<string> allEmails = new List<string>();

            List<Contact> allContacts = new List<Contact>();
            allContacts = getAllContacts();

            foreach (Contact item in allContacts)
            {
                if (item.SensorID == sensorID)
                {
                    allEmails.Add(item.Email);
                }
            }

            return allEmails;
        }
    }

}
