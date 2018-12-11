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
            try
            {
                // New XmlSerializer object
                XmlSerializer saver1 = new XmlSerializer(typeof(BindingList<Instrument>));
                // Write to file
                using (StringWriter textWriter = new StringWriter())
                {
                    saver1.Serialize(textWriter, Form1.allInstruments);
                    encryptFile(Form1.filepath + "\\InstrumentData.xml", textWriter.ToString());
                }
            }
            catch (Exception) { }

            try
            {
                // New XmlSerializer object
                XmlSerializer saver2 = new XmlSerializer(typeof(BindingList<StudentData>));
                // Write to file
                using (StringWriter textWriter = new StringWriter())
                {
                    saver2.Serialize(textWriter, Form1.students);
                    encryptFile(Form1.filepath + "\\StudentData.xml", textWriter.ToString());
                }
            }
            catch (Exception) { }

            try
            {
                XmlSerializer saver3 = new XmlSerializer(typeof(BindingList<Employees>));
                using (StringWriter textWriter = new StringWriter())
                {
                    saver3.Serialize(textWriter, Form1.currentStaff);
                    Console.WriteLine(textWriter.ToString());
                    encryptFile(Form1.filepath + "\\Employees.xml", textWriter.ToString());
                }
            }
            catch (Exception) { }

            SystemSounds.Beep.Play();
        }

        // Serializes employees
        public static string serializeEmployees()
        {
            XmlSerializer saver3 = new XmlSerializer(typeof(BindingList<Employees>));
            // New TextWriter Object
            using (StringWriter writer3 = new StringWriter())
            {
                // Write to string
                saver3.Serialize(writer3, Form1.currentStaff);
                Console.WriteLine(saver3);
                Console.WriteLine(saver3.ToString());
                return saver3.ToString();
            }
        }

        public static void deserializeEmployees()
        {
            XmlSerializer loader = new XmlSerializer(typeof(BindingList<Employees>));

            using (MemoryStream reader = new MemoryStream(Encoding.Unicode.GetBytes(decryptFile(Form1.filepath + "\\Employees.xml"))))
                Form1.currentStaff = (BindingList<Employees>)loader.Deserialize(reader);
        }

        // Reads from file
        public static void deserialize(int i)
        {
            switch (i)
            {
                // Serializes Instrument data
                case 0:
                    try
                    {
                        // New deserializer
                        XmlSerializer loader = new XmlSerializer(typeof(BindingList<Instrument>));
                        using (MemoryStream reader = new MemoryStream(Encoding.Unicode.GetBytes(decryptFile(Form1.filepath + "\\InstrumentData.xml"))))
                            Form1.allInstruments = (BindingList<Instrument>)loader.Deserialize(reader);
                    }
                    catch (Exception) { }
                    break;
                // Serializes Student Data
                case 1:
                    try
                    {
                        XmlSerializer loader = new XmlSerializer(typeof(BindingList<StudentData>));
                        using (MemoryStream reader = new MemoryStream(Encoding.Unicode.GetBytes(decryptFile(Form1.filepath + "\\InstrumentData.xml"))))
                            Form1.students = (BindingList<StudentData>)loader.Deserialize(reader);
                    }
                    catch (Exception) { }
                    break;
                // Serializes employee list
                case 2:
                    {
                        XmlSerializer loader = new XmlSerializer(typeof(BindingList<Employees>));
                        using (MemoryStream reader = new MemoryStream(Encoding.Unicode.GetBytes(decryptFile(Form1.filepath + "\\Employees.xml"))))
                        {
                            Form1.currentStaff = (BindingList<Employees>)loader.Deserialize(reader);
                        }
                    }
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
        public static void encryptFile(string filepath, string unsecuredData)
        {
            // Holder variabels
            string securedData = "";

            // Read file
            try
            {
                // Encrypt
                securedData = Encrypt(unsecuredData);

                // Save to file
                File.WriteAllText(filepath, securedData);
            }
            catch (Exception){}
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
        public static string decryptFile(string filepath)
        {
            string unsecuredData = "";

            string[] sD = File.ReadAllLines(filepath);

            unsecuredData = Decrypt(sD[0]);

            return unsecuredData;
        }
    }
}
