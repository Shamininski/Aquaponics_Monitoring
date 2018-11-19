using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsMonitoringApp.DataAccessLayer
{
    /// <summary>
    /// Class Creator: Tanya
    /// This class is used to give the necessary stored procedure names and their parameter values through to
    /// other developers, without necessarily giving them access to the database.
    /// </summary>
    public static class QueryBuilder
    {
        public static string procNewSensor = "newSensor";
        public static string procParamNewSensorName = "@name";                      //Datatype: VARCHAR(50)
        public static string procParamNewSensorLoc = "@location";                   //Datatype: VARCHAR(100)
        public static string procParamNewSensorType = "@type";                      //Datatype: VARCHAR(12)

        public static string procRemoveSensor = "removeSensor";
        public static string procParamRemoveSensorId = "@sensorId";                 //Datatype: INT

        public static string procInsertUser = "insertUser";
        public static string procParamInsertUserUsername = "@username";             //Datatype: VARCHAR(50)
        public static string procParamInsertUserPassword = "@password";             //Datatype: VARCHAR(50)
        public static string procParamInsertUserEmail = "@email";                   //Datatype: VARCHAR(50)
        public static string procParamInsertUserSecQ = "@question";                 //Datatype: VARCHAR(200)
        public static string procParamInsertUserSecA = "@answer";                   //Datatype: VARCHAR(100)

        public static string procUpdateUser = "updateUser";
        public static string procParamUpdateUserId = "@id";                         //Datatype: INT
        public static string procParamUpdateUserUsername = "@username";             //Datatype: VARCHAR(50)
        public static string procParamUpdateUserPassword = "@password";             //Datatype: VARCHAR(50)
        public static string procParamUpdateUserEmail = "@email";                   //Datatype: VARCHAR(50)
        public static string procParamUpdateUserSecQ = "@question";                 //Datatype: VARCHAR(200)
        public static string procParamUpdateUserSecA = "@answer";                   //Datatype: VARCHAR(100)

        public static string procRemoveUser = "removeUser";
        public static string procParamRemoveUserId = "@userID";                     //Datatype: INT
        public static string procParamRemoveUserUsername = "@username";             //Datatype: VARCHAR(50)
        public static string procParamRemoveUserPassword = "@password";             //Datatype: VARCHAR(50)
        public static string procParamRemoveUserEmail = "@email";                   //Datatype: VARCHAR(50)

        public static string procNewNotification = "newNotification";
        public static string procParamNewNotificationSensorId = "@sensorID";        //Datatype: INT
        public static string procParamNewNotificationBottomVal = "@bottomVal";      //Datatype: INT
        public static string procParamNewNotificationTopVal = "@topVal";            //Datatype: INT
        public static string procParamNewNotificationFrequency = "@frequency";      //Datatype: INT

        public static string procUpdateNotification = "updateNotification";
        public static string procParamUpdateNotifcationSensorId = "@sensorID";      //Datatype: INT
        public static string procParamUpdateNotifcationBottomVal = "@bottomVal";    //Datatype: INT
        public static string procParamUpdateNotifcationTopVal = "@topVal";          //Datatype: INT
        public static string procParamUpdateNotifcationFrequency = "@frequency";    //Datatype: INT

        public static string procNewContact = "newContact";
        public static string procParamNewContactSensorId = "@sensorID";             //Datatype: INT
        public static string procParamNewContactEmail = "@email";                   //Datatype: VARCHAR(50)

        public static string procUpdateContact = "updateContact";
        public static string procParamUpdateContactSensorId = "@sensorId";          //Datatype: INT
        public static string procParamUpdateContactPriorEmail = "@priorEmail";      //Datatype: VARCHAR(50)
        public static string procParamUpdateContactNewEmail = "@newEmail";          //Datatype: VARCHAR(50)

        public static string procRemoveContact = "removeContact";
        public static string procParamRemoveContactSensorId = "@sensorId";          //Datatype: INT
        public static string procParamRemoveContactEmail = "@email";                //Datatype: VARCHAR(50)

        public static string procInsertFreq = "insertFrequency";
        public static string procParamInsertFreqDate = "@date";                     //Datatype: DATETIME
        public static string procParamInsertFreqValue = "@freq";                    //Datatype: INT
    }
}
