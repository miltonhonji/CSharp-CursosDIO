using System;

namespace CalculadoraImc
{
    class Program
    {
        static void Main(string[] args)
        {        
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do paciente:");
                        var paciente = new Paciente();
                        paciente.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o peso do paciente:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal peso))
                        {
                            paciente.Peso = peso;
                        }
                        else
                        {
                            throw new ArgumentException("O valor do peso deve ser em decimal");
                        }

                        Console.WriteLine("Informe a altura do paciente:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal altura))
                        {
                            paciente.Altura = altura;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da altura deverá ser em decimal");
                        }

                        //var imc;
                        decimal imc = peso / (altura * altura);
                        /*Classificacao classificacaoGeral;

                        if(imc < 18)
                        {
                            classificacaoGeral = Classificacao.Abaixo;
                        }
                        else if (imc > 18)
                        {
                            classificacaoGeral = Classificacao.Normal;
                        }
                        else if (imc > 25)
                        {
                            classificacaoGeral = Classificacao.Sobrepeso;
                        }
                        else if (imc > 30)
                        {
                            classificacaoGeral = Classificacao.Obesidade1;
                        }
                        else if (imc > 35)
                        {
                            classificacaoGeral = Classificacao.Obesidade2;
                        }
                        else if (imc > 40)
                        {
                            classificacaoGeral = Classificacao.Obesidade3;
                        }*/
                        Console.WriteLine($"O PACIENTE {paciente.Nome}, ESTÁ COM O IMC DE: {imc}.");

                        break;                                       

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Calculadora IMC do Milton");
            Console.WriteLine();
            Console.WriteLine("1- Informar o paciente e fazer o calculo");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
