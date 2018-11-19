using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class represents users that are allowed full access to the system.
    /// Users will be required to log in whenever the settings and customization of sensors are changed.
    /// </summary>
    public class User
    {
        private int userID;
        private string username;
        private string password;
        private string email;
        private string securityQ;
        private string securityA;


        public User(string username, string password,int userID = 0)
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
        }
        public User(string username, string password, string email = "", string securityQ = "", string securityA = "", int userID = 0)
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.SecurityQ = securityQ;
            this.SecurityA = securityA;
        }

        public User()
        {
        }

        public string SecurityA
        {
            get { return securityA; }
            set { securityA = value; }
        }


        public string SecurityQ
        {
            get { return securityQ; }
            set { securityQ = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            User user = obj as User;
            if ((object)user == null)
            {
                return false;
            }
            return ((this.UserID == user.UserID) && (this.Username == user.Username) && (this.Password == user.Password) && (this.Email == user.Email) && (this.SecurityQ == user.SecurityQ) && (this.SecurityA == user.SecurityA));
        }

        public override int GetHashCode()
        {
            return this.UserID.GetHashCode() ^ this.Username.GetHashCode() ^ this.Password.GetHashCode() ^ this.Email.GetHashCode() ^ this.SecurityQ.GetHashCode() ^ this.SecurityA.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void newUser()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.insertUser(this);
        }

        public void updateUsers()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.updateUser(this);
        }

        public void deleteUsers()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.removeUser(this);
        }
    
        public List<string> getSecurityQuestions()
        {
            List<string> securityQuestions = new List<string>();

            DataAccessLayer.FileHandler filehandler = new DataAccessLayer.FileHandler("SecurityQuestions.txt");
            securityQuestions = filehandler.ReadFromTxt();
            return securityQuestions;
        }
    
        public List<User> getAllRegisteredUsers()
        {
            List<User> users = new List<User>();

            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            users = dataHandler.getAllUsers();

            return users;
        }

        public List<string> getAllRegisteredEmails()
        {
            List<string> allEmails = new List<string>();
            List<User> allUsers = getAllRegisteredUsers();

            foreach (User item in allUsers)
            {
                allEmails.Add(item.Email);
            }

            return allEmails;
        }

        public bool testLogin()
        {
            bool accessAllowed = false;
            List<User> loginUsers = new List<User>();
            loginUsers = getAllRegisteredUsers();
            foreach (User item in loginUsers)
            {
              if ((item.Username == this.Username) && (item.Password == this.Password))
              {
                  accessAllowed = true;
              }
            }

            return accessAllowed;
        }

        public void mailPassword()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("additionaladdress.tanya@gmail.com");
                mail.To.Add(this.Email);
                mail.Subject = "Password Recovery";
                mail.Body = string.Format(
                    @"Dear {0},
                      Your Password for the La Pieus Aqua Aquaponics Monitoring application is: {1}", this.Username, this.Password);
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("additionaladdress.tanya", "LaPieusAqua");
                smtp.EnableSsl = true;

                smtp.Send(mail);
             }
            catch (Exception)
            {
                DataAccessLayer.FileHandler file = new DataAccessLayer.FileHandler("emailErrors.csv");
                List<string> error = new List<string> { "The password email could not be sent to user: " + this.Username };
                file.WriteToTxt(error);
            }
        }

        public string getCurrentLoggedUser()
        {
            string user = "";
            DataAccessLayer.FileHandler fileHandler = new DataAccessLayer.FileHandler("CurrentLoggedUser.csv");
            List<string> currentLoggedUser = fileHandler.ReadFromTxt();
            user = currentLoggedUser[0];
            return user;
        }


        public void saveLoggedUser()
        {
            string loggedUserDetails = this.Username + ";" + this.Password;
            List<string> activeUser = new List<string>();

            activeUser.Add(loggedUserDetails);
            DataAccessLayer.FileHandler fileHandler = new DataAccessLayer.FileHandler("CurrentLoggedUser.csv");
            fileHandler.WriteUserAccess(activeUser);
        }
    }
}
