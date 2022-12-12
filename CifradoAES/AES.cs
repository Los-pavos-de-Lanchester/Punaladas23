using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmoEncriptacion;
using ModeloDominio;

using System.Security.Cryptography;
using System.IO;

namespace CifradoAES
{
    public class AES : Algoritmo
    {
        private Aes myAes;
        public AES(string nombre, string descripcion) : base(nombre, descripcion) { 
            myAes = Aes.Create();
        }

        //Los cuatro siguientes métodos abstraen el algoritmo de la clase Mensaje
        public override Mensaje encriptarMensaje(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            return new Mensaje(this.encriptacion(mensaje));
        }
        public override Mensaje desEncriptarMensaje(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            return new Mensaje(this.desencriptacion(mensaje));
        }
        public override void encriptar(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            mensaje.CadenaI = this.encriptarMensaje(mensaje, clave).CadenaI;
        }
        public override void desEncriptar(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            mensaje.CadenaI = this.desEncriptarMensaje(mensaje, clave).CadenaI;
        }


        private string encriptacion(Mensaje mensaje)
        {
            
            

                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes_Aes(mensaje.CadenaS, myAes.Key, myAes.IV);

                // Decrypt the bytes to a string.
                string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

            /*
            //Display the original data and the decrypted data.
            Console.WriteLine("Original:   {0}", mensaje.CadenaS);
            Console.WriteLine("Round Trip: {0}", roundtrip);
            */

            string resultado = "";
            foreach (byte b in encrypted)
            {
                resultado = resultado + b;
            }

            return resultado;
            
            
        }


        private string desencriptacion(Mensaje mensaje)
        {



            // Encrypt the string to an array of bytes.
            byte[] encrypted = EncryptStringToBytes_Aes(mensaje.CadenaS, myAes.Key, myAes.IV);

            // Decrypt the bytes to a string.
            string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

            /*
            //Display the original data and the decrypted data.
            Console.WriteLine("Original:   {0}", mensaje.CadenaS);
            Console.WriteLine("Round Trip: {0}", roundtrip);
            */


            return roundtrip;


        }
        private int codificarClave(Mensaje clave)
        {
            return Convert.ToInt32(clave.CadenaS);
        }


        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }

}




