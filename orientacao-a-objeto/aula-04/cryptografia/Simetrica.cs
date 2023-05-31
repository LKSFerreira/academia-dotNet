using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CriptografiaSimetricaAndAssimetrica
{
    /*
     
     A Criptografia simétrica fornece o tipo mais rápido e mais básico de criptografia. 
    Neste tipo de criptografia, você usa a mesma chave secreta para criptografar e descriptografar dados.
     
     */
    public class Simetrica
    {
        public void EncryptAesManaged(string raw)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).
                // Cria AES que gera uma nova chave e vetor de inicialização (IV).

                // Same key must be used in encryption and decryption
                // A mesma chave deve ser usada na criptografia e descriptografia
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string
                    // Criptografa a string
                    byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);

                    // Print encrypted string
                    // Imprime a string criptografada
                    Console.WriteLine($"Dado criptografado: {System.Text.Encoding.UTF8.GetString(encrypted)}");

                    // Decrypt the bytes to a string.
                    // Descriptografa os bytes para uma string. 
                    string decrypted = Decrypt(encrypted, aes.Key, aes.IV);

                    // Print decrypted string. It should be same as raw data    
                    // Imprime a string descriptografada. Deve ser o mesmo que os dados brutos
                    Console.WriteLine($"Dado descriptografado: {decrypted}");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            // Cria um novo AesManaged
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor
                // Cria um criptografador
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);

                // Create MemoryStream
                // Cria um MemoryStream   
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption
                    // Cria um fluxo de criptografia usando a classe CryptoStream. Esta classe é a chave para a criptografia

                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream to encrypt
                    // e descriptografa dados de qualquer fluxo fornecido. Neste caso, passaremos um fluxo de memória para criptografar
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream
                        // Cria um StreamWriter e grava dados em um fluxo
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }

                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data
            // Retorna dados criptografados
            return encrypted;
        }
        private string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged
            // Cria AesManaged
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor
                // Cria um descriptografador
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);

                // Create the streams used for decryption.
                // Cria os fluxos usados para descriptografia
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    // Cria um fluxo de criptografia
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream
                        // Lê o fluxo de criptografia
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        public string EncryptData(string textData, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            //iniciar o modo de operação
            objrij.Mode = CipherMode.CBC;
            //setar o padding de operação da string
            objrij.Padding = PaddingMode.PKCS7;
            //setar o tamanho (em bits) da operação 
            objrij.KeySize = 0x80;
            //setar o tamanho do bloco    
            objrij.BlockSize = 0x80;
            //setar a chave de criptografia
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            //setar o vetor de bytes de inicialização para criptografia
            byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);

            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;

            //Cria uma chave simétrica
            ICryptoTransform objtransform = objrij.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(textData);
            
            //Converte para string e retorna
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
        }

        public string DecryptData(string EncryptedText, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.CBC;
            objrij.Padding = PaddingMode.PKCS7;

            objrij.KeySize = 0x80;
            objrij.BlockSize = 0x80;
            byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            byte[] EncryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(TextByte);  //irá retornar a string original descriptografada
        }
    }
}
