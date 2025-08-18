using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //primeiro para ficar completinho vou fazer uma emtrada com nome dos dois alunos
            Console.WriteLine("digite o nome do primeiro aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("digite o nome do segundo aluno");
            string nome2 = Console.ReadLine();
            Console.WriteLine("digite a idade do primeiro aluno");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a idade do segundo aluno");
            int idade2 = int.Parse(Console.ReadLine()); // aqui usei um parse mais com detalhe mao existe conferencia para saber se o oque eu digitei e convetivel por isso pade dar bug poderia usar try para evitar o crash
            if (idade > idade2)
            {
                Console.WriteLine($"o aluno {nome}  é o mais velho com {idade} "); //aqui nao comcatenei achei melhor assim acho que se pricisar fazer operacoes posso fazer no print e nao salvar a variavel 
            }
            if (idade2 > idade) // aqui as condlcoes sao excludentes poderia usar else if  para poupar processamento mas nao vou usar 
            {
                Console.WriteLine($"o aluno {nome2} é o mais velho com {idade2} ");
            }
            else
            {
                 Console.WriteLine($"ambos alunos {nome} e {nome2} possuem a mesma idade {idade} ");
            }


        }
    }
}
