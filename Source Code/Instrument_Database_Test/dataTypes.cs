using System;
using System.Collections.Generic;

namespace Instrument_Database_Test
{
    // Holds all of the data classes for this project

    // Holds the data for each individual instrument
    [Serializable]
    public class Instrument
    {
        // Different catagories of instruments
        public enum Catagory { Brass, Percussion, Strings, Woodwinds, EMA, Microphone, Mute, Other };
        // Missing/found status
        public enum Status { Missing, Found}

        // Instance variables
        public Catagory type;
        public Status status = (Status) 1;
        public int cabinate;
        public string name;
        public string id;
        public string bow;
        public string brand;
        public string model;
        public string vendor;
        public string serialNumber;
        public int value;
        public string note = "N/A";

        // List of the transactions done for this instrument
        public List<Checkout> checkouts = new List<Checkout>();

        // Main constructor
        public Instrument(Catagory type, int cabinate, string name, string id,
                          string bow, string brand, string model, string vendor,
                          string serialNumber, int value, string note)
        {
            this.type = type;
            this.cabinate = cabinate;
            this.name = name;
            this.id = id;
            this.bow = bow;
            this.brand = brand;
            this.model = model;
            this.vendor = vendor;
            this.serialNumber = serialNumber;
            this.value = value;
            if (note.Length>0)
                this.note = note;
        }

        // Parameterless constructor for XML serialization
        public Instrument() { }

        // ToString override
        public override string ToString()
        {
            switch (status)
            {
                case Status.Missing:
                    // Indicates missing
                    return name + ": " + id + " - M";
                case Status.Found:
                    return name + ": " + id;
            }
            return "";
        }

        // Returns a string that contains all of the instrument data for display
        public string returnData()
        {
            return "Name: " + name + "\n" +
                   "Status: " + status + " \n" +
                   "Catagory: " + type + "\n" +
                   "Cabinate: " + cabinate + "\n" +
                   "Chapman #: " + id + "\n" +
                   "Bow: " + bow + "\n" +
                   "Brand: " + brand + "\n" +
                   "Model: " + model + "\n" +
                   "Serial #: " + serialNumber + "\n" +
                   String.Format("Value: ${0}", value) + "\n" +
                   "Notes: " + note;
        }
    }

    // Holds the data for each individual instrument
    [Serializable]
    public class InstrumentData
    {
        // Instance variables
        public Instrument.Catagory type;
        //public Status status = (Status)1;
        public int cabinate;
        public string name;
        public string id;
        public string bow;
        public string brand;
        public string model;
        public string vendor;
        public string serialNumber;
        public int value;
        public string note = "N/A";

        // Main constructor
        public InstrumentData(Instrument.Catagory type, int cabinate, string name, string id,
                          string bow, string brand, string model, string vendor,
                          string serialNumber, int value, string note)
        {
            this.type = type;
            this.cabinate = cabinate;
            this.name = name;
            this.id = id;
            this.bow = bow;
            this.brand = brand;
            this.model = model;
            this.vendor = vendor;
            this.serialNumber = serialNumber;
            this.value = value;
            if (note.Length > 0)
                this.note = note;
        }

        // Parameterless constructor for XML serialization
        public InstrumentData() { }
    }

    // Contains all of the information and methods for transaction notes
    [Serializable]
    public class Note
    {
        public string content = "";

        public Note(string c)
        {
            content = c;
        }

        // Parameterless constructor for XML serialization
        public Note() { }

        // Override ToString method
        public override string ToString()
        {
            return content;
        }
    }

    // Contains all of the information for each transaction
    [Serializable]
    public class Checkout
    { 
        // Whether check in or check out
        public enum Type {checkin, checkout };

        // Instance variables
        public string sName;
        public int sID;
        public string emailAddress;
        public string date;
        public string staff;
        public string semester;
        public Note note = new Note();
        public Type type;
        public InstrumentData instrument;

        // Constructor
        public Checkout(string n, int i, string e, string d, string s, string semester, Type t, InstrumentData inst)
        {
            sName = n;
            sID = i;
            emailAddress = e;
            date = d;
            staff = s;
            type = t;
            // i.e. Fall 2018
            this.semester = semester + " " + date.Substring(date.LastIndexOf("/") + 1);
            instrument = inst;
        }

        // Parameterless Constructor for XML serialization
        public Checkout() { }

        // ToString override - I don't think that this is actually used anywhere yet
        public override string ToString()
        {
            string temp = "Student Name: " + sName + "\n" +
                          "Student ID: " + sID.ToString() + "\n" +
                          "Student Email: " + emailAddress + "\n" +
                          "Checkout Date: " + date + "\n" +
                          "Assisted by: " + staff + "\n" +
                          "Semester: " + semester;
            return temp;
        }
    }

    // Contains all of the information for student data
    [Serializable]
    public class StudentData
    {
        // Instance variables
        public string sName;
        public int sID;
        public string emailAddress;

        // Constructor
        public StudentData(string n, int i, string e)
        {
            sName = n;
            sID = i;
            emailAddress = e;
        }

        // Parameterless Constructor for XML serialization
        public StudentData() { }

        // ToString override
        public override string ToString()
        {
            return sName;
        }
    }

    // Contains the information and methods for employees
    [Serializable]
    public class Employees
    {
        // Instance variable
        public string eName;
        public string password;

        // Constructor
        public Employees(string name)
        {
            eName = name;
        }

        // Parameterless Constructor for XML serialization
        public Employees() { }

        // Override ToString
        public override string ToString()
        {
            return eName; 
        }
    }
}
