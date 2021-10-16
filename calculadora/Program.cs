using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double Entrada1;
            double Entrada2;
            //double resultado;
            bool validate = true;
            Program program = new Program();

            Console.WriteLine("### sejam bem vindos a calculadora DOTNET####");
            do
            {
                Console.WriteLine("Qual a operação desjada ? :");
                Console.WriteLine("(1)Calculo IMC");
                Console.WriteLine("(2)Calculo Salario");
                Console.WriteLine("(3)Calculo Esfera");
                Console.WriteLine("(4)Calculo media escolar ");
                Console.WriteLine("(5)Banco de animais ");
                Console.WriteLine("(6)Finalizar Progama");

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

              

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Quanto vocÊ pesa ? ");
                        Entrada1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Qual a sua altura ? ");
                        Entrada2 = Convert.ToInt32(Console.ReadLine());

                        if( Entrada1 > 0 && Entrada2 > 0 )
                        {
                            CalculoImc imc = new CalculoImc();
                            imc.Main(Entrada1, Entrada2);

                        } else
                        {
                            Console.WriteLine("Os valores devem ser maiores que 0");
                            return ;
                        }

                        break;
                    case 2:
                      
                        break;
                    case 3:
                        Console.WriteLine("Digite um valor : ");
                        int R = Convert.ToInt32(Console.ReadLine());
                        Esfera calculoEsfera = new Esfera();
                        calculoEsfera.CalculoEsfera(R);
                        break;
                    case 4:
                        Console.WriteLine("teste ");
                        break;
                    case 5:
                        Console.WriteLine("teste ");
                        break;
                    case 6:
                        validate = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.Clear();
                        break;
                }

                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validate);
        }
    }
}




