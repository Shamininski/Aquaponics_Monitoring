using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// Class Creator: Tanya
    /// This class deals with the different sensor's characteristics themselves.
    /// </summary>
    public class Sensor
    {
        private int sensorID;
        private string sensorName;
        private string location;
        private string type;

        /// <summary>
        /// Creates an Instance of this class
        /// </summary>
        /// <param name="sensorID">An integer value used to identify the sensor in the database.</param>
        /// <param name="sensorName">A user defined name, unique to each sensor</param>
        /// <param name="location">A user defined name for the tank in which the sensor is placed</param>
        /// <param name="type">Defines whether it is a Temperature or pH sensor</param>
        public Sensor(string sensorName, string location, string type, int sensorID = 0)
        {
            this.SensorID = sensorID;
            this.SensorName = sensorName;
            this.Location = location;
            this.Type = type;
        }
        public Sensor()
        {
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public string Location
        {
            get { return location; }
            set { location = value; }
        }


        public string SensorName
        {
            get { return sensorName; }
            set { sensorName = value; }
        }


        public int SensorID
        {
            get { return sensorID; }
            set { sensorID = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Sensor sensor = obj as Sensor;
            if ((object)sensor == null)
            {
                return false;
            }
            return ((this.SensorID == sensor.SensorID) && (this.SensorName == sensor.SensorName) && (this.Location == sensor.Location) && (this.Type == sensor.Type));
        }

        public override int GetHashCode()
        {

            return this.SensorID.GetHashCode() ^ this.SensorName.GetHashCode() ^ this.Location.GetHashCode() ^ this.Type.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void newSensor()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.insertSensor(this);
        }

        public void deleteSensor()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.removeSensor(this);
        }

        public List<Sensor> getAllSensors()
        {
            List<Sensor> allSensors = new List<Sensor>();
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();

            allSensors = dataHandler.getAllSensors();

            return allSensors;
        }

        // Get the names of all the Tanks in the system
        public List<string> getAllTanks()
        {
            List<string> allTanks = new List<string>();
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            allTanks = dataHandler.getAllLocations();

            return allTanks;
        }
    }
}
