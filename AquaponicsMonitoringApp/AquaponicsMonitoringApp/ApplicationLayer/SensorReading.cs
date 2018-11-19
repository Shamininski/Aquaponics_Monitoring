using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class is used to create an object that represents a sensor reading received from the sensors.
    /// </summary>
    public class SensorReading
    {
        private DateTime date;
        private decimal readingVal;
        private int sensorId;


        /// <summary>
        /// Creates an Instance of this class.
        /// </summary>
        /// <param name="date">Defines the date at which the reading was taken.</param>
        /// <param name="readingVal">represents the value received from the sensor.</param>
        /// <param name="sensorId">Uniquely identifies the sensor in the database.</param>
        public SensorReading(DateTime date, decimal readingVal, int sensorId)
        {
            this.Date = date;
            this.ReadingVal = readingVal;
            this.SensorId = sensorId;
        }

        public SensorReading()
        {
        }

        public int SensorId
        {
            get { return sensorId; }
            set { sensorId = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        public decimal ReadingVal
        {
            get { return readingVal; }
            set { readingVal = value; }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            SensorReading reading = obj as SensorReading;
            if ((object)reading == null)
            {
                return false;
            }
            return ((this.Date == reading.Date) && (this.ReadingVal == reading.ReadingVal) && (this.SensorId == reading.SensorId));
        }

        public override int GetHashCode()
        {
            return this.Date.GetHashCode() ^ this.ReadingVal.GetHashCode() ^ this.SensorId.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void addReading()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.insertSensorReading(this);
        }

        public void newSensorReading(Sensor sensor)
        {
            string filename = sensor.Location + "_" + sensor.SensorName + ".txt";
            List<string> allSensorValues = new List<string>();
            List<SensorReading> allSensorReadings = new List<SensorReading>();
            List<string> allSavedDates = new List<string>();
            DateTime dateOfReading = new DateTime();
            decimal reading = 0;
                
            DataAccessLayer.FileHandler fh = new DataAccessLayer.FileHandler(filename);
            allSensorValues = fh.ReadFromTxt();

            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            allSensorReadings = dh.getSensorReadings(sensor);

            foreach (SensorReading item in allSensorReadings)
            {
                allSavedDates.Add(item.Date.ToString());
            }

            foreach (string item in allSensorValues)
            {
                string[] fields = item.Split('#');
                dateOfReading = Convert.ToDateTime(fields[0]);
                reading = Convert.ToDecimal(fields[1]);
                if (!allSavedDates.Contains(dateOfReading.ToString()))
                {
                    this.Date = dateOfReading;
                    this.ReadingVal = reading;
                    this.SensorId = sensor.SensorID;
                    addReading();
                }
                
            }
            
        }

        public List<SensorReading> getAllSensorReadings(Sensor sensor)
        {
            List<SensorReading> readings = new List<SensorReading>();

            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            readings = dataHandler.getSensorReadings(sensor);

            return readings;
        }

        public Dictionary<string,string> currentReadingPerSensor(List<Sensor> sensors)
        {
            Dictionary<string, string> sensorData = new Dictionary<string, string>();
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            Sensor s = new Sensor();
            List<string> allTanks = s.getAllTanks();
            string reading = "";

            foreach (string tank in allTanks)
            {
                foreach (Sensor sen in sensors)
                {
                    if (sen.Location == tank)
                    {
                        reading += Convert.ToString(dataHandler.getCurrentSensorReading(sen))+"#";
                    }
                }

                sensorData.Add(tank, reading);
                reading = "";
            }

            return sensorData;
        }

        public List<SensorReading> getDayReadings(Sensor sensor)
        {
            List<SensorReading> readings = new List<SensorReading>();
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            readings = dataHandler.getSensorReadingsForDayPeriod(sensor);

            return readings;
        }

    }
}
