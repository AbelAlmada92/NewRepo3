using System;

namespace PracticaClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico traumatolo = new Medico();
            traumatolo.nombreM = "Carlos";
            traumatolo.apellidoM = "Sanchez";
            traumatolo.matricula = 321456432;
            traumatolo.turno = "Mañana";

            Console.WriteLine($"El doctor {traumatolo.nombreM} {traumatolo.apellidoM}" +
                $" con el NM {traumatolo.matricula} pertenece al turno {traumatolo.turno}.");
            
            Console.WriteLine("");    
            traumatolo.atiende();


            Paciente paciente = new Paciente();
            paciente.nombreP = "Pablo";
            paciente.apellidoP = "Gomez";
            paciente.condicion = "Fractura de tobillo";
            paciente.estado = "ESTABLE";
            paciente.edad = 45;
            paciente.dni = 23555391;

            Console.WriteLine("");
            paciente.informa();
            Console.WriteLine("");

            Console.WriteLine($"El paciente {paciente.nombreP} {paciente.apellidoP} con el " +
                $"DNI N° {paciente.dni} de {paciente.edad} anios, presenta {paciente.condicion}" +
                $" se encuentra con estado {paciente.estado}.");
        }
    }

    public class Medico()
    {
        public string nombreM;
        public string apellidoM;
        public string turno;
        public int matricula;

        public void atiende()
        {
            Console.WriteLine("Atiende al paciente enfermo.");
        }

        public void brindaDiagnostico()
        {
            Console.WriteLine("El doctor da su diagnostico al paciente.");
        }
    }
    public class Paciente()
    {
        public string nombreP;
        public string apellidoP;
        public string condicion;
        public string estado;
        public int edad;
        public int dni;

        public void informa()
        {
            Console.WriteLine("El paciente informa los sintomas al medico.");
        }

        public void seTrata()
        {
            Console.WriteLine("Realiza el tratamiento que el medico le da.");
        }
    }
}