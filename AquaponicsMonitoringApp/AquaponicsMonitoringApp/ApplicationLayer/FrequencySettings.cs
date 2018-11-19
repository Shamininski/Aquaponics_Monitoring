using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    public class FrequencySettings
    {
        private DateTime freqDate;
        private int frequency;

        public FrequencySettings(DateTime freqDate, int frequency)
        {
            this.FreqDate = freqDate;
            this.Frequency = frequency;
        }

        public FrequencySettings()
        { }

        public int Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }


        public DateTime FreqDate
        {
            get { return freqDate; }
            set { freqDate = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            FrequencySettings fs = obj as FrequencySettings;
            if ((object)fs == null)
            {
                return false;
            }
            return (this.FreqDate == fs.FreqDate) && (this.Frequency == fs.Frequency);
        }

        public override int GetHashCode()
        {
            return this.FreqDate.GetHashCode() ^ this.Frequency.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void newFrequency()
        {
            DataAccessLayer.DataHandler dh = DataAccessLayer.DataHandler.getInstance();
            dh.insertFrequency(this);
        }

        public int getFrequency()
        {
            int frequency = 1;

            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            frequency = dataHandler.getCurrentFrequency();
            return frequency;
        }

        public DateTime getLastUpdatedFrecencyDateTime()
        {
            DateTime lastUpdatedFrequency;
            DataAccessLayer.DataHandler dataHandler = DataAccessLayer.DataHandler.getInstance();
            lastUpdatedFrequency = dataHandler.getLastUpdatedFrequencyDate();
       
            return lastUpdatedFrequency;
        }
    }
}

