using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    public enum EstadoCivil { Soltero, Casado }
    public enum Genero { Masculino, Femenino }
    public enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }


    public struct Empleado
    {
        public string nombre;
        public string apellido;
        public DateTime fnac;
        public EstadoCivil estadoCivil;
        public Genero genero;
        public DateTime fing;
        public double sueldoBasico;
        public Cargo cargo;

        public Empleado()
        {
            string[] Nombres = { "Rufus", "Bear", "Dakota", "Fido", "Vanya", "Samuel", "Koani", "Volodya", "Prince", "Yiska" };

            Random rnd = new Random();
            nombre = _nombre;
            apellido = _apellido;
            fnac = _fnac;
            genero = _genero;
            fing = _fing;
            sueldoBasico = _sueldoBasico;
            cargo = _cargo;
            estadoCivil = _estadoCivil;
        }
        public int Antiguedad()
        {
            return (DateTime.Today.Year - fing.Year);
        }
        public int Edad()
        {
            int edad = DateTime.Today.Year - fnac.Date.Year;
            if(fnac.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
          
            return edad;
        }

        public int Jubilacion()
        {
            int jub;

            if (genero == Genero.Masculino)
            {
                jub = 65 - Antiguedad();
            }
            else
            {
                jub = 60 - Antiguedad();
            }
            return jub>0 ? jub: 0;
        }

        public double Salario()
        {
            double adicional;
            if (Antiguedad() < 20) {
                adicional = sueldoBasico * 0.02 * Antiguedad();
            }
            else
            {
                adicional = sueldoBasico * 0.25;
            }

            if(cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
            {
                adicional *= 1.5;
            }
            if (estadoCivil == EstadoCivil.Casado)
            {
                adicional += 5000;
            }
            return sueldoBasico + adicional;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
