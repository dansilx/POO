using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoConstrutor
{
    public class Aluno
    {
        private static long matricula {get; set;}
        public long AddMatricula 
        {
            get {return matricula;}
            private set {matricula = value;}
        }
        public string Nome { get; set;}
        public double Prova1 { get; set;}
        public double Prova2 { get; set;}
        public double Media;

        static Aluno() 
        {
            matricula = 123456789000;
        }

        public Aluno()
        {
            AddMatricula++;
        }

        public Aluno(string nome, double p1, double p2)
        {
            Nome = nome;
            Prova1 = p1;
            Prova2 = p2;
        }  
          
        private double CalcularMedia()
        {
            Media = (Prova1+Prova2)/2;
            return Media;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matricula: {AddMatricula} \nNome: {Nome}\nProva 1: {Prova1}\nProva 2: {Prova2}\nMédia: {CalcularMedia()}");
        }
    }
}