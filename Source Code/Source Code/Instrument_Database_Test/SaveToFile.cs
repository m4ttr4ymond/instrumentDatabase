using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.IO.Compression;

namespace Instrument_Database_Test
{
    // This code backs up and serializes the information
    class SaveToFile
    {
        // Variables
        static readonly string passwordHash = "passwordHash";
        static readonly string saltKey = "saltKeyy";
        static readonly string VIKey = "aaaabbbbccccdddd";


        // Whether the backup is going to be loaded
        public static bool backupStatus = false;

        // Read from backup into the RAM
        public static void populateBackup(string fP)
        {
            // Empty the binding lists
            foreach (BindingList<Instrument> list in Form1.libraryRecords)
                list.Clear();

            

            // If the backup is going to happen
            if (backupStatus)
            {
                // Create a file explorer to find where we want to import from
                string library = Form1.filepath;
                DirectoryInfo d = new DirectoryInfo(library);
                FileInfo[] files = d.GetFiles("*.xml")
                     .Where(p => p.Extension == ".xml").ToArray();

                // Delete all of the files
                foreach (FileInfo file in files)
                    File.Delete(file.FullName);

                // Extract files from backup
                ZipFile.ExtractToDirectory(fP, Form1.filepath);

                // Deserialize all of the information
                for (int i = 0; i <= 2; i++)
                    deserialize(i);
            }
                
            backupStatus = false;
        }

        public static void serializeAll()
        {
           // if (Form1.allInstruments.Count > 0)
            {
                // New XmlSerializer object
                XmlSerializer saver1 = new XmlSerializer(typeof(BindingList<Instrument>));
                // New TextWriter Object
                TextWriter writer1 = new StreamWriter(Form1.filepath + "\\InstrumentData.xml");
                // Write to file
                saver1.Serialize(writer1, Form1.allInstruments);
                writer1.Close();
                //encryptFile(Form1.filepath + "\\InstrumentData.xml");
            }

           // if (Form1.students.Count > 0)
            {
                XmlSerializer saver2 = new XmlSerializer(typeof(BindingList<StudentData>));
                // New TextWriter Object
                TextWriter writer2 = new StreamWriter(Form1.filepath + "\\StudentData.xml");
                // Write to file
                saver2.Serialize(writer2, Form1.students);
                writer2.Close();
                //encryptFile(Form1.filepath + "\\StudentData.xml");
            }

           // if (Form1.students.Count > 0)
                saveEmployeeNames();

            SystemSounds.Beep.Play();
        }

        public static void saveEmployeeNames()
        {

            //try
            {
                XmlSerializer saver3 = new XmlSerializer(typeof(BindingList<Employees>));
                // New TextWriter Object
                using (StreamWriter writer3 = new StreamWriter(Form1.filepath + "\\Employees.xml"))
                {
                    // Write to string
                    saver3.Serialize(writer3, Form1.currentStaff);
                }
                //encryptFile(Form1.filepath + "\\Employees.xml");
            }
            //catch (Exception)
            { /* ToDo: Figure out what to do here when something is already using the file */}
        }

        public static string serializeEmployees()
        {
            XmlSerializer saver3 = new XmlSerializer(typeof(BindingList<Employees>));
            // New TextWriter Object
            using (StringWriter writer3 = new StringWriter())
            {
                // Write to string
                saver3.Serialize(writer3, Form1.currentStaff);
                return saver3.ToString();
            }
        }

        public static void deserializeEmployees()
        {
            decryptFile(Form1.filepath + "\\Employees.xml");

            XmlSerializer loader = new XmlSerializer(typeof(BindingList<Employees>));

            using (StringReader reader = new StringReader(Form1.filepath + "\\Employees.xml"))
            {
                Form1.currentStaff = (BindingList<Employees>)loader.Deserialize(reader);
            }
        }

        // Reads from file
        public static void deserialize(int i)
        {
            switch (i)
            {
                // Serializes Instrument data
                case 0:
                    // Uses try in case there's nothing written to the file
                    try
                    {
                        decryptFile(Form1.filepath + "\\InstrumentData.xml");
                    }
                    catch (Exception){}
                    try
                    {
                        // New deserializer
                        XmlSerializer loader = new XmlSerializer(typeof(BindingList<Instrument>));
                        // Using statement so that it automatically closes the file
                        using (TextReader reader = new StreamReader(Form1.filepath + "\\InstrumentData.xml"))
                            Form1.allInstruments = (BindingList<Instrument>)loader.Deserialize(reader);
                        encryptFile(Form1.filepath + "\\InstrumentData.xml");
                    }
                    catch (System.InvalidOperationException) { }
                    break;
                // Serializes Student Data
                case 1:
                    try
                    {
                        decryptFile(Form1.filepath + "\\StudentData.xml");
                    }
                    catch (Exception){}
                    try
                    {
                        // New deserializer
                        XmlSerializer loader = new XmlSerializer(typeof(BindingList<StudentData>));
                        // Using statement so that it automatically closes the file
                        using (TextReader reader = new StreamReader(Form1.filepath + "\\StudentData.xml"))
                        {
                            Form1.students = (BindingList<StudentData>)loader.Deserialize(reader);
                        }
                        encryptFile(Form1.filepath + "\\StudentData.xml");
                    }
                    catch (System.InvalidOperationException) { }
                    break;
                // Serializes employee list
                case 2:
                    try
                    {
                        decryptFile(Form1.filepath + "\\Employees.xml");
                    }
                    catch (Exception){}
                    try
                    {
                        
                        // New deserializer
                        XmlSerializer loader = new XmlSerializer(typeof(BindingList<Employees>));
                        // Using statement so that it automatically closes the file
                        using (TextReader reader = new StreamReader(Form1.filepath + "\\Employees.xml"))
                        {
                            Form1.currentStaff = (BindingList<Employees>)loader.Deserialize(reader);
                        }
                        encryptFile(Form1.filepath + "\\Employees.xml");
                    }
                    catch (System.InvalidOperationException) { }
                    break;
            }
        }

        // Encrypts the information
        public static string Encrypt(string input)
        {
            // Bytes for encryption
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(input);

            byte[] keyBytes = new Rfc2898DeriveBytes(passwordHash, Encoding.ASCII.GetBytes(saltKey)).GetBytes(256 / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] encryptedTextBytes;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    encryptedTextBytes = memoryStream.ToArray();
                }
            }
            return Convert.ToBase64String(encryptedTextBytes);
        }

        // Encrypt the file
        public static void encryptFile(string filepath)
        {
            // Holder variabels
            string unsecuredData = "";
            string securedData = "";

            // Read file
            string[] uD = File.ReadAllLines(filepath);

            if (uD.Length > 0)
            {
                // Append
                foreach (var item in uD)
                    unsecuredData += item + "\n";

                unsecuredData = unsecuredData.Remove(unsecuredData.LastIndexOf("\n"));

                // Encrypt
                securedData = Encrypt(unsecuredData);

                // Save to file
                File.WriteAllText(filepath, securedData);
            }
        }

        // Decrypt a string
        public static string Decrypt(string encryptedInput)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedInput);
            byte[] keyBytes = new Rfc2898DeriveBytes(passwordHash, Encoding.ASCII.GetBytes(saltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            
            // return unencrypted
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        // Decrypt a file
        public static void decryptFile(string filepath)
        {
            string unsecuredData = "";

            string[] sD = File.ReadAllLines(filepath);

            unsecuredData = Decrypt(sD[0]);
            
            File.WriteAllText(filepath, unsecuredData);
        }

    }
}
