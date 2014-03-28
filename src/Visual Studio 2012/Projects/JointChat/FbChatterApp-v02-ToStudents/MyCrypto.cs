using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoPerformance
{
    class MyCrypto
    {
        // Key //
        // keySize in number of bytes

        public static byte[] getKey(String password, int keySize)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            return pdb.GetBytes(keySize);
        }

        public static byte[] getAES128Key(String password)
        {
            return getKey(password, 16);
        }

        public static byte[] getAES192Key(String password)
        {
            return getKey(password, 24);
        }

        public static byte[] getAES256Key(String password)
        {
            return getKey(password, 32);
        }

        public static byte[] getDESKey(String password)
        {
            return getKey(password, 8);
        }

        // IV //
        // ivSize in number of bytes

        public static byte[] getIV(String password, int ivSize)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            return pdb.GetBytes(ivSize);
        }

        public static byte[] getAESIV(String password)
        {
            return getIV(password, 16);
        }

        public static byte[] getDESIV(String password)
        {
            return getIV(password, 8);
        }

        // AES

        public static string AESEncrypt(string plainText, string password, int keySize, string cipherMode)
        {
            byte[] plainTextBytes =
              System.Text.Encoding.Unicode.GetBytes(plainText);
            byte[] key;

            switch (keySize)
            {
                case 128:
                    key = getAES128Key(password);
                    break;
                case 192:
                    key = getAES192Key(password);
                    break;
                case 256:
                    key = getAES256Key(password);
                    break;
                default:
                    key = getAES256Key(password);
                    break;
            }

            byte[] cipherTextBytes = MyAES.Encrypt(plainTextBytes,
                     key, getAESIV(password));

            return Convert.ToBase64String(cipherTextBytes);
        }

        public static void AESEncrypt(string inFile, string outFile, string password, int keySize, string cipherMode)
        {
            byte[] key;

            switch (keySize)
            {
                case 128:
                    key = getAES128Key(password);
                    break;
                case 192:
                    key = getAES192Key(password);
                    break;
                case 256:
                    key = getAES256Key(password);
                    break;
                default:
                    key = getAES256Key(password);
                    break;
            }

            MyAES.Encrypt(inFile, outFile, key, getAESIV(password), cipherMode);
        }

        public static string AESDecrypt(string cipherText, string password, int keySize, string cipherMode)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] key;

            switch (keySize)
            {
                case 128:
                    key = getAES128Key(password);
                    break;
                case 192:
                    key = getAES192Key(password);
                    break;
                case 256:
                    key = getAES256Key(password);
                    break;
                default:
                    key = getAES256Key(password);
                    break;
            }

            byte[] decryptedTextBytes = MyAES.Decrypt(cipherTextBytes,
                key, MyCrypto.getAESIV(password), cipherMode);

            return System.Text.Encoding.Unicode.GetString(decryptedTextBytes);
        }

        public static void AESDecrypt(string inFile, string outFile, string password, int keySize, string cipherMode)
        {
            byte[] key;

            switch (keySize)
            {
                case 128:
                    key = getAES128Key(password);
                    break;
                case 192:
                    key = getAES192Key(password);
                    break;
                case 256:
                    key = getAES256Key(password);
                    break;
                default:
                    key = getAES256Key(password);
                    break;
            }

            MyAES.Decrypt(inFile, outFile, key, getAESIV(password), cipherMode);
        }

        public static void DESEncrypt(string inFile, string outFile, string password, string cipherMode)
        {
            MyDES.Encrypt(inFile, outFile, getDESKey(password), getDESIV(password), cipherMode);
        }

        public static void DESDecrypt(string inFile, string outFile, string password, string cipherMode)
        {

            MyDES.Decrypt(inFile, outFile, getDESKey(password), getDESIV(password), cipherMode);
        }

    }
}
