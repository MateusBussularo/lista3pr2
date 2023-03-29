using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("======inicio======");
            Console.WriteLine("1 - EXERCICIO 1 ");
            Console.WriteLine("2 - EXERCICIO 2 ");
            Console.WriteLine("3 - EXERCICIO 3 ");
            Console.WriteLine("4 - EXERCICIO 4 ");
            Console.WriteLine("5 - EXERCICIO 5 ");
            Console.WriteLine("6 - EXERCICIO 6 ");

            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    int dia;
                    Console.WriteLine("digite um numero para saber o dia da semana a partir de segunda");
                    dia = int.Parse(Console.ReadLine());
                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("o dia é segunda feira ");
                            break;
                        case 2:
                            Console.WriteLine("o dia é terça feira ");
                            break;
                        case 3:
                            Console.WriteLine("o dia é quarta feira ");
                            break;
                        case 4:
                            Console.WriteLine("o dia é quinta feira ");
                            break;
                        case 5:
                            Console.WriteLine("o dia é sexta feira ");
                            break;
                        case 6:
                            Console.WriteLine("o dia é sabado ");
                            break;
                        case 7:
                            Console.WriteLine("o dia é domingo ");
                            break;
                        default:
                            Console.WriteLine("não existe dia da semana usado por esse número");
                            break;
                    }

                    break;
                case 2:
                    double va, re, fp, resss;
                    Console.WriteLine("digite o valor");
                    va = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite a forma de pagamento? 1- PIX 2-dinheiro 3- debito 4-credito");
                    fp = double.Parse(Console.ReadLine());
                    switch (fp)
                    {
                        case 1:
                            re = va * 0.10;
                            resss = va - re;

                            Console.WriteLine("o valor do desconto vai ser de: " + re + " e o valor final vai ser de: " + resss);
                            break;
                        case 2:
                            re = va * 0.15;
                            resss = va - re;

                            Console.WriteLine("o valor do desconto vai ser de: " + re + " e o valor final vai ser de: " + resss);
                            break;
                        case 3:
                            re = va * 0.05;
                            resss = va + re;

                            Console.WriteLine("o valor do desconto vai ser de: " + re + " e o valor final vai ser de: " + resss);
                            break;
                        case 4:
                            re = va * 0.10;
                            resss = va + re;

                            Console.WriteLine("o valor do desconto vai ser de: " + re + " e o valor final vai ser de: " + resss);
                            break;

                        default:
                            Console.WriteLine(" nao tem esta opção");
                            break;
                    }

                    break;

                case 3:
                    int ano, fevereiro;
                    Console.WriteLine("digite o numero do mes de 1 a 12");
                    ano = int.Parse(Console.ReadLine());

                    switch (ano)
                    {
                        case 1:
                            Console.WriteLine(" 1- JANEIRO: 31 dias ");
                            break;
                        case 2:
                            Console.WriteLine(" 2- FEVEREIRO: ==== INFORME O ANO=== ");
                            Console.WriteLine("digite o ano: ");
                            fevereiro = int.Parse(Console.ReadLine());

                            if ((fevereiro % 4 == 0 && fevereiro % 100 != 0) || (fevereiro % 400 == 0))
                            {
                                Console.WriteLine(fevereiro + " 28 dias");
                            }
                            else
                            {
                                Console.WriteLine(fevereiro + " 29 dias");
                            }
                            break;
                        case 3:
                            Console.WriteLine(" 3- MARÇO: 31 DIAS ");
                            break;
                        case 4:
                            Console.WriteLine(" 3- ABRIL: 30 dias ");
                            break;
                        case 5:
                            Console.WriteLine(" 5- MAIO: 31 dias ");
                            break;
                        case 6:
                            Console.WriteLine(" 6- JUNHO: 30 dias ");
                            break;
                        case 7:
                            Console.WriteLine(" 7- JULHO: 30 dias ");
                            break;
                        case 8:
                            Console.WriteLine(" 8- AGOSTO: 31 dias ");
                            break;
                        case 9:
                            Console.WriteLine(" 9- SETEMBRO: 30 dias ");
                            break;
                        case 10:
                            Console.WriteLine(" 10- OUTUBROO: 31 dias ");
                            break;
                        case 11:
                            Console.WriteLine(" 11-NOVEMBRO: 30 dias ");
                            break;
                        case 12:
                            Console.WriteLine(" 12- DEZEMBRO: 31 dias ");
                            break;
                    }
                    break;
                case 4:
                    int num1, num2, re;
                    char op;
                    Console.WriteLine("digite o primeiro numero?");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero?");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o operador (+, -, *, / ou ^): ");
                    op = char.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case '+':
                            re = num1 + num2;
                            Console.WriteLine("o resultado vai ser: " + re);
                            break;
                        case '-':
                            re = num1 - num2;
                            Console.WriteLine("o resultado vai ser: " + re);
                            break;
                        case '*':
                            re = num1 * num2;
                            Console.WriteLine("o resultado vai ser: " + re);
                            break;
                        case '/':
                            re = num1 / num2;
                            Console.WriteLine("o resultado vai ser: " + re);
                            break;

                        default:
                            Console.WriteLine("operador invalido");
                            return;
                    }
                    break;
                case 5:
                    double sa, f, au, di, fr;
                    Console.WriteLine("digite o salario: ");
                    sa = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite o codigo do cargo do funcionario: ");
                    f = double.Parse(Console.ReadLine());

                    switch (f)
                    {
                        case 101:
                            au = 0.075 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficofu " + fr + " a diferença é de " + au);
                            break;
                        case 102:
                            au = 0.097 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficou " + fr + " a diferença é de " + au);
                            break;
                        case 103:
                            au = 0.117 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficou " + fr + " a diferença é de " + au);
                            break;
                        case 204:
                            au = 0.089 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficou " + fr + " a diferença é de " + au);
                            break;
                        case 206:
                            au = 0.1324 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficou " + fr + " a diferença é de " + au);
                            break;
                        case 301:
                            au = 0.104 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficou " + fr + " a diferença é de " + au);
                            break;
                        case 302:
                            au = 0.146 * sa;
                            fr = au + sa;

                            Console.WriteLine("o salario antigo era de " + sa + " com o ajuste ficou " + fr + " a diferença é de " + au);
                            break;
                        default:
                            Console.WriteLine("codigo nao encontrado");
                            break;

                    }
                    break;
                case 6:
                    double sa, resul, imp, imp2;
                    Console.WriteLine("Imposto de Renda dos cidadãos brasileiros");
                    Console.WriteLine("1- Até R$ 1.903,98");
                    Console.WriteLine("2- Entre R$ 1.903,99 e R$ 2.826,65");
                    Console.WriteLine("3- Entre R$ 2.826,66 e R$ 3.751,05");
                    Console.WriteLine("4- Entre R$ 3.751,06 e R$ 4.664,68");
                    Console.WriteLine("5- Acima de R$ 4.664,68");
                    Console.WriteLine("escolha a opcao que se encaixa na sua situaçãao: ");
                    sa = double.Parse(Console.ReadLine());

                    switch (sa)
                    {
                        case 1:
                            Console.WriteLine("seu salario sera o mesmo sem impostos");
                            break;
                        case 2:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resul = imp * 0.075f;
                            imp2 = imp - resul;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resul);
                            break;
                        case 3:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resul = imp * 0.15f;
                            imp2 = imp - resul;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resul);
                            break;
                        case 4:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resul = imp * 0.225f;
                            imp2 = imp - resul;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resul);
                            break;
                        case 5:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resul = imp * 0.275f;
                            imp2 = imp - resul;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resul);
                            break;


                    }
                    break;


                default:
                    Console.WriteLine("opção invalida");
                    break;
            }
            Console.ReadKey();

        }
    }
}

        
    

