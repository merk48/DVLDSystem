using DVLD_Mery_Buisness;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Mery
{
    static public class clsGlobal
    {
        static public clsUser CurrentUser = null;

        const string KeyPath = @"HKEY_CURRENT_USER\Software\DVLD_Mery_Project";
        //const string KeyPath = @"HKEY_CURRENT_USER\Software\YourSoftware";
        const string DVLD_Current_User_Username_Name = "Username";
        const string DVLD_Current_User_Username_Passward = "Password";

        const string sourceApp = "DVLD_Mery_Project";
        const string aesKey = "1234567890123456";

        public static void RememberUsernameAndPassword(string Username, string Password)
        {
            /*
            try
            {
                // Write the value to the Registry
                Registry.SetValue(KeyPath, DVLD_Current_User_Username_Name, Username, RegistryValueKind.String);
                Registry.SetValue(KeyPath, DVLD_Current_User_Username_Passward, Password, RegistryValueKind.String);


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }*/
            try
            {
                using (var key = Registry.CurrentUser.CreateSubKey(KeyPath))
                {
                    key.SetValue(DVLD_Current_User_Username_Name, Username, RegistryValueKind.String);
                    key.SetValue(DVLD_Current_User_Username_Passward, Encrypt(Password, aesKey), RegistryValueKind.String);
                    //key.SetValue(DVLD_Current_User_Username_Passward, Password, RegistryValueKind.String);
                    //MessageBox.Show($"Passowrd saved to registry after encryption: {Encrypt(Password, aesKey)}\nBefore: {Password}");

                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"An error occurred while saving credentials: {ex.Message}");
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(KeyPath))
                {
                    if (key != null)
                    {
                        Username = key.GetValue(DVLD_Current_User_Username_Name, null) as string;
                        Password = Decrypt(key.GetValue(DVLD_Current_User_Username_Passward, null) as string, aesKey);
                        //Password = key.GetValue(DVLD_Current_User_Username_Passward, null) as string;
                        //MessageBox.Show($"Passowrd comes from registry: {key.GetValue(DVLD_Current_User_Username_Passward, null) as string} before decryption \nAfter:{Password} ");


                        if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"An error occurred while retrieving credentials: {ex.Message}");
            }

            return false;
        }

        static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        static public void LogException(string EventMessage, EventLogEntryType eventLogEntryType)
        {
            try
            {
                if (!EventLog.SourceExists(sourceApp))
                    EventLog.CreateEventSource(sourceApp, "Application");

                EventLog.WriteEntry(sourceApp, EventMessage, eventLogEntryType);

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(sourceApp,"Exception in LogException method: "+ ex.Message, EventLogEntryType.Error);
            }

        }

        static public string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

    }


}
