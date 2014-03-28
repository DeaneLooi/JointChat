using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JointChatApp
{
    class MyDES
    {
        // todo: encrypt an inFile to an outFile 
        //      using a key, an IV and a cipherMode
        public static void Encrypt(string inFile, string outFile, byte[] Key, byte[] IV,
            string cipherMode)
        {
            FileStream fsIn = new FileStream(inFile,
                FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outFile,
                FileMode.Create, FileAccess.Write);

            DES alg = DES.Create();
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

        // todo: Decrypt an inFile into an outFile using 
        //      a key, an IV and a cipherMode
        public static void Decrypt(string inFile, string outFile,
                            byte[] Key, byte[] IV, string cipherMode)
        {
            FileStream fsIn = new FileStream(inFile,
                FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outFile,
                FileMode.Create, FileAccess.Write);

            DES alg = DES.Create();
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
