using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesC.Modelo
{
    internal class Usuario
    {
        private int id;
        private string nombre, usuario, pass;

        public Usuario(string nombre, string usuario, string pass)
        {
            this.Nombre = nombre;
            this.Usuarios = usuario;
            this.Pass = pass;
        }

        public Usuario(int id, string nombre, string usuario, string pass)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Usuarios = usuario;
            this.Pass = pass;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuarios { get => usuario; set => usuario = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
