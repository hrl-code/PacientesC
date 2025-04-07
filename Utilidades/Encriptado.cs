using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PacientesC.Utilidades
{
    internal class Encriptado
    {
        static readonly string Clave = "2025tareadam2025";

        public static string Encriptar(string textocifrar)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Clave);
            aes.IV = new byte[aes.BlockSize / 8];
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            MemoryStream flujodememoria = new MemoryStream();
            CryptoStream cifradodatos = new CryptoStream(flujodememoria, encryptor, CryptoStreamMode.Write);
            byte[] bytesdeltextoplano = UTF8Encoding.UTF8.GetBytes(textocifrar);
            cifradodatos.Write(bytesdeltextoplano, 0, bytesdeltextoplano.Length);
            cifradodatos.FlushFinalBlock();
            byte[] bytescifrados = flujodememoria.ToArray();
            flujodememoria.Close();
            cifradodatos.Close();
            return Convert.ToBase64String(bytescifrados);
        }

        public static string Desencriptar(string textodesencriptar)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(Clave);
            aes.IV = new byte[aes.BlockSize / 8];
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            MemoryStream flujodememoria = new MemoryStream(Convert.FromBase64String(textodesencriptar));
            CryptoStream cifradodatos = new CryptoStream(flujodememoria, decryptor, CryptoStreamMode.Read);
            StreamReader lector = new StreamReader(cifradodatos);
            string texto = lector.ReadToEnd();
            flujodememoria.Close();
            cifradodatos.Close();
            return texto;
        }


    }
}
