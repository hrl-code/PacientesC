﻿using PacientesC.Modelo;
using PacientesC.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesC.bbdd
{
    internal class Conexion
    {
        private static readonly string url = "Data Source=JPexamen.db";

        public static bool Acceder(string user, string pass)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario = @user AND pass = @pass";
            SQLiteConnection conn = new SQLiteConnection(url);

            conn.Open();

            SQLiteCommand command = new SQLiteCommand(consulta, conn);

            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);

            SQLiteDataReader resultados = command.ExecuteReader();
            try
            {
                return resultados.Read();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                resultados.Close();
                conn.Close();
            }
        }

        public static void CargarComboCiudades(System.Windows.Forms.ComboBox cb)
        {
            string consulta = "SELECT ciudad FROM ciudades";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();

            //DataTable dt = new DataTable();

            SQLiteCommand command = new SQLiteCommand(consulta, conn);
            SQLiteDataReader resultados = command.ExecuteReader();

            while (resultados.Read())
            {
                cb.Items.Add(resultados.GetString(0));
            }

            resultados.Close();
            conn.Close();
        }

        public static bool RegistrarPaciente(Paciente p)
        {
            string consulta = "INSERT INTO Pacientes (nombre, apellidos, direccion, ciudad) VALUES (@nom, @ape, @dir, @ciu)";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();
            try
            {

                SQLiteCommand comando = new SQLiteCommand(consulta, conn);

            comando.Parameters.AddWithValue("@nom", p.Nombre);
            comando.Parameters.AddWithValue("@ape", p.Apellidos);
            comando.Parameters.AddWithValue("@dir", p.Direccion);
            comando.Parameters.AddWithValue("@ciu", p.Ciudad);

            comando.ExecuteNonQuery();
                return true;

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool RegistrarUsuario(Usuario u)
        {
            string consulta = "INSERT INTO Usuarios (nombre, usuario, pass) VALUES (@nom, @usu, @pass)";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();
            try
            {

                SQLiteCommand comando = new SQLiteCommand(consulta, conn);

                comando.Parameters.AddWithValue("@nom", u.Nombre);
                comando.Parameters.AddWithValue("@usu", u.Usuarios);
                comando.Parameters.AddWithValue("@pass", u.Pass);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool CompruebaUsuario(string usuario)
        {
            string consultausuario = "SELECT usuario FROM usuarios WHERE usuario=@usu";
            SQLiteConnection conn = new SQLiteConnection(url);
            conn.Open();

            using (SQLiteCommand command = new SQLiteCommand(consultausuario, conn))
            {
                command.Parameters.AddWithValue("@usu", usuario);
                SQLiteDataReader resultados = command.ExecuteReader();
                if (resultados.HasRows)
                {
                    conn.Close();
                    resultados.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    resultados.Close();
                    return false;

                }
            }
        }
    }
}
