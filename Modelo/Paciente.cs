using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesC.Modelo
{
    internal class Paciente
    {

        private int id;
        private string nombre, apellidos, direccion, ciudad;

        public Paciente(string nombre, string apellidos, string direccion, string ciudad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
        }

        public Paciente(int id, string nombre, string apellidos, string direccion, string ciudad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
