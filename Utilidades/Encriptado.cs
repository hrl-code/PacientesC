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

        public static string Encriptar(string textoacifrar)
        {
            //Creamos nuestro objeto de tipo AES y convertimos nuestra clave y nuestro vector inicializador a bytes
            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(Clave);
            aes.IV = new byte[aes.BlockSize / 8];

            //Creamos nuestro objeto de tipo ICryptoTransform pasando como parametro nuestra clave y vector
            ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

            //La clase memoryStream crea un flujo de dato (stream) que usa como como almacenamiento de apoyo en vez del disco duro o red.
            //La clase MemoryStream encapsula la informacion almacenada como un arreglo (array) de bytes que se inicializa despues de la creacion del objeto MemoryStream
            MemoryStream flujodatosmemoria = new MemoryStream();

            //Creamos el flujo de datos con todos los elementos para el encriptado
            CryptoStream cifradodedatos = new CryptoStream(flujodatosmemoria, encriptador, CryptoStreamMode.Write);

            //Convertimos el texto a cifrar en un array de byte para poder operar en el proceso de cifrado
            //Ciframos los datos recorriendo el array de bytes del texto a cifrar desde el primer elemento (0)
            //al ultimo (bytesdeltextoacifrar.Length) hasta culminar el proceso: FlushFinalBlock()

            byte[] bytesdeltextoPlano = UTF8Encoding.UTF8.GetBytes(textoacifrar);
            cifradodedatos.Write(bytesdeltextoPlano, 0, bytesdeltextoPlano.Length);
            cifradodedatos.FlushFinalBlock(); //fin del proceso de cifrado



            byte[] bytescifrados = flujodatosmemoria.ToArray();

            flujodatosmemoria.Close();
            cifradodedatos.Close();


            return Convert.ToBase64String(bytescifrados);
        }

        public static string Desencriptar(string textocifrado)
        {
            //Almacenados los bytes cifrados a partir de la cadena encriptada y 
            // creamos un array de tipo byte para almacenar los resultados del desencriptador

            byte[] textoCifradoBytes = Convert.FromBase64String(textocifrado);

            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(Clave);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream(textoCifradoBytes);


            CryptoStream descifradodedatos = new CryptoStream(flujodatosmemoria, desencriptador, CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(descifradodedatos);
            return sr.ReadToEnd();
        }


    }
}
