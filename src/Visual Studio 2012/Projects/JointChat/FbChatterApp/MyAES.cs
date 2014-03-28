using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography; 

namespace JointChatApp
{
    /// <summary>
    /// Reference: http://www.codeproject.com/Articles/5719/Simple-encrypting-and-decrypting-data-in-C
    /// </summary>
    public class MyAES
    {
        // Encrypt a byte array into a byte array 
        //      using a key and an IV 
        public static byte[] Encrypt(byte[] plaintext, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();

            // TripleDES alg = TripleDES.Create(); 
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, 
               alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(plaintext, 0, plaintext.Length);
            cs.Close();

            return ms.ToArray();
        }

        // todo: encrypt a byte array into a byte array 
        //      using a key, an IV and a cipherMode
        public static byte[] Encrypt(byte[] plaintext, byte[] Key, byte[] IV, 
            string cipherMode)
        {
            MemoryStream ms = new MemoryStream();

            // TripleDES alg = TripleDES.Create(); 
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;

            switch (cipherMode) {
                case "ECB":
                    alg.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    alg.Mode = CipherMode.CBC;
                    break;
                case "CFB":
                    alg.Mode = CipherMode.CFB;
                    break;
                /*case "OFB":
                    alg.Mode = CipherMode.OFB;
                    break; */
                default:
                    throw new System.Exception("Cipher Mode is not selected.");
            }

            CryptoStream cs = new CryptoStream(ms,
               alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(plaintext, 0, plaintext.Length);
            cs.Close();

            return ms.ToArray();
        }

        // todo: encrypt an inFile to an outFile 
        //      using a key, an IV and a cipherMode
        public static void Encrypt(string inFile, string outFile, byte[] Key, byte[] IV, 
            string cipherMode)
        {
            FileStream fsIn = new FileStream(inFile, 
                FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outFile, 
                FileMode.Create, FileAccess.Write);

            // TripleDES alg = TripleDES.Create(); 
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;

            // added padding
            //alg.Padding = PaddingMode.PKCS7;

            switch (cipherMode) 
            {
                case "ECB":
                    alg.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    alg.Mode = CipherMode.CBC;
                    break;
                case "CFB":
                    alg.Mode = CipherMode.CFB;
                    break;
                /*case "OFB":
                    alg.Mode = CipherMode.OFB;
                    break;*/
                default:
                    throw new System.Exception("Cipher Mode is not selected.");
            }

            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateEncryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();
        }
        
        // Encrypt a string into a return string using a password 
        //    Uses Encrypt(byte[], byte[], byte[]) 
        public static string Encrypt(string clearText, string Password)
        {
            byte[] clearBytes =
              System.Text.Encoding.Unicode.GetBytes(clearText);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] encryptedData = Encrypt(clearBytes,
                     pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(encryptedData);
        }

        // Encrypt a byte array into a return byte array using a password 
        //    Uses Encrypt(byte[], byte[], byte[]) 
        public static byte[] Encrypt(byte[] clearData, string Password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

           return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));
        }

        // Encrypt an inFile into an outFile using a password 
        public static void Encrypt(string inFile,
                    string outFile, string Password)
        {

            FileStream fsIn = new FileStream(inFile,
                FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outFile,
                FileMode.Create, FileAccess.Write);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            Rijndael alg = Rijndael.Create();
            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateEncryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();
        }

        // Decrypt a byte array into a return byte array 
        //      using a key and an IV 
        public static byte[] Decrypt(byte[] cipherData,
                                    byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();

            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
       
            CryptoStream cs = new CryptoStream(ms,
                alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();

            return ms.ToArray();
        }

        // todo: Decrypt a byte array into a return byte array using 
        //      a key, an IV and a cipherMode
        public static byte[] Decrypt(byte[] cipherData,
                            byte[] Key, byte[] IV, string cipherMode)
        {
            MemoryStream ms = new MemoryStream();

            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;

            switch (cipherMode)
            {
                case "ECB":
                    alg.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    alg.Mode = CipherMode.CBC;
                    break;
                case "CFB":
                    alg.Mode = CipherMode.CFB;
                    break;
                /*case "OFB":
                    alg.Mode = CipherMode.OFB;
                    break;*/
                default:
                    throw new System.Exception("Cipher Mode is not selected.");
            }

            CryptoStream cs = new CryptoStream(ms,
                alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();

            return ms.ToArray();
        }

        // todo: Decrypt an inFile into an outFile using 
        //      a key, an IV and a cipherMode
        public static void Decrypt(string inFile, string outFile,
                            byte[] Key, byte[] IV, string cipherMode)
        {
            FileStream fsIn = new FileStream(inFile,
                FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outFile,
                FileMode.Create, FileAccess.Write);

            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;

            // added padding
            //alg.Padding = PaddingMode.None;

            switch (cipherMode)
            {
                case "ECB":
                    alg.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    alg.Mode = CipherMode.CBC;
                    break;
                case "CFB":
                    alg.Mode = CipherMode.CFB;
                    break;
                /*case "OFB":
                    alg.Mode = CipherMode.OFB;
                    break;*/
                default:
                    throw new System.Exception("Cipher Mode is not selected.");
            }

            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateDecryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();
        }

        // Decrypt a string into a return string using a password 
        //    Uses Decrypt(byte[], byte[], byte[]) 
        public static string Decrypt(string cipherText, string Password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] decryptedData = Decrypt(cipherBytes,
                pdb.GetBytes(32), pdb.GetBytes(16));

            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }

        // Decrypt a byte array into a return byte array using a password 
        //    Uses Decrypt(byte[], byte[], byte[]) 
        public static byte[] Decrypt(byte[] cipherData, string Password)
        {
           PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            return Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16));
        }

        // Decrypt an inFile into an outFile using a password 
        public static void Decrypt(string inFile,
                    string outFile, string Password)
        {
            FileStream fsIn = new FileStream(inFile,
                        FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outFile,
                        FileMode.Create, FileAccess.Write);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            Rijndael alg = Rijndael.Create();

            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateDecryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            cs.Close(); 
            fsIn.Close();
        }
    }
}
