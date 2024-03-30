using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoConstrutor
{
    public class Aluno
    {
        private static long matricula;

        public long Matricula
        {
            get { return matricula; }
            private set { matricula = value; }
        }
        public string Nome { get; set; }
        public double Prova1 { get; set; }
        public double Prova2 { get; set; }

        public double media;

        static Aluno() 
        {
            matricula = 1234567890000;
        }

        public Aluno()
        {
            Matricula++;
        }
        public double CalcularMedia(double Prova1, double Prova2)
        {
            return media = Prova1+Prova2/2;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Prova 1: {Prova1}");
            Console.WriteLine($"Prova 2: {Prova2}");
            Console.WriteLine($"Média: {media}");
        }
    }
}