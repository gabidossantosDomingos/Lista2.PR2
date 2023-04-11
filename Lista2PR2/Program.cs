using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            //float l1 = 0.35f, l2 = 0.28f, quant, resultado;
            //Console.WriteLine("digite quantas laranjas você comprou");
            //quant = float.Parse(Console.ReadLine());

            //if (quant < 12)
            //{
            //    resultado = l1 * quant;
            //    Console.WriteLine("o valor da compra é r$:" + resultado);
            //}

            //else
            //{
            //    resultado = l2 * quant;
            //    Console.WriteLine("o valor da compra é r$" + resultado);

            //}
            //Console.ReadKey();

            //Exercício 2
            //int ano;
            //Console.WriteLine("digite a sua data de nascimento");
            //ano = int.Parse(Console.ReadLine());

            //if (ano >= 2007)
            //{
            //    Console.WriteLine("Você não pederá exercer o direito de voto");
            //}
            //else
            //{
            //    Console.WriteLine("Você  pederá exercer o direito de voto");
            //}
            //Console.ReadKey();



            // atividade 3

            //    int a, b, c;
            //Console.WriteLine("Digite o valor do lado a");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do lado b");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do lado c");
            //c = int.Parse(Console.ReadLine());

            //if (a == b && b == c)
            //{
            //    Console.WriteLine("O triângulo equilátero");

            //}
            //else if (a == b || a == c || b == c)
            //{
            //    Console.WriteLine("o triângulo isóceles");
            //}
            //else 
            //{
            //    Console.WriteLine("o triângulo é escaleno");

            //}
            //Console.ReadKey();

            //exercício 4
            //double a, b, c, delta, x1, x2;
            //Console.WriteLine("digite o valor de a");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor de b");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor de c");
            //c = double.Parse(Console.ReadLine());

            //delta = (b * b) - 4 * a * c;

            //if (delta < 0)
            //{
            //    Console.WriteLine("não existe raiz real");

            //}
            //else if (delta == 0)
            //{
            //    Console.WriteLine("existe uma raiz");
            //    x1 = -b + Math.Sqrt(delta) / 2 * a;
            //    Console.WriteLine("x1 é " + x1);
            //}

            //else
            //{
            //    Console.WriteLine("existe duas raizes");
            //    x2 = -b - Math.Sqrt(delta) / 2 * a;
            //    Console.WriteLine("x1 é " + x2);
            //    x1 = -b + Math.Sqrt(delta) / 2 * a;
            //    Console.WriteLine("X2 é " + x1);
            //}




            //Console.ReadKey();





            //exercício 5
            // int N;
            // Console.WriteLine("digite um número");
            // N = int.Parse(Console.ReadLine());

            // if (N % 3 == 0)
            // {

            //Console.WriteLine("O número é divisível  por 3" );
            // }

            // else if (N % 5 == 0)
            // {

            //     Console.WriteLine("O número é divisível  por 5");
            // }

            // else if (N % 3 == 0 && N % 5 == 0)
            //     {

            //     Console.WriteLine("O número é divisível  por  3 e 5");
            // }
            // else 
            //     {

            //     Console.WriteLine("O número não é divisível  por  3 e 5");
            // }
            // Console.ReadKey();

            //Exercício 6 
            //int A, B, C;
            //Console.WriteLine("digite o valor do 1° ângulo do triângulo");
            //A = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor do 2° ângulo do triângulo");
            //B = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor do 3° ângulo do triângulo");
            //C = int.Parse(Console.ReadLine());

            //if (A != 180 && B != 180 && C != 180)
            //{
            //    Console.WriteLine("O valor não é correspondente ao total da soma dos ângulos de um triângulo que é 180 ");
            //}


            //else if (A == 90 || B == 90 || C == 90)
            //{
            //    Console.WriteLine("O triângulo é retângulo");
            //}

            //else if (A > 90 || B > 90 || C > 90)
            //{
            //    Console.WriteLine("O triângulo é Obtusângulo");
            //}

            //else if (A < 90 && B < 90 && C < 90)
            //{
            //    Console.WriteLine("O triângulo é Actângulo");
            //}
            //Console.ReadKey();

            //exercício 7 
            //int valor1, valor2, valor3;
            //Console.WriteLine("digite o  1° valor");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o  2° valor");
            //valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite o  3° valor");
            //valor3 = int.Parse(Console.ReadLine());

            //if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3)
            //{
            //    Console.WriteLine("Valores iguais não são permitidos");
            //}

            //else if (valor1 < valor2 && valor2 < valor3)
            //{
            //    Console.WriteLine(valor1 + " " + valor2 + " " + valor3);
            //}

            //else if (valor1 < valor3 && valor3 < valor2)
            //{
            //    Console.WriteLine(valor1 + " " + valor3 + " " + valor2);
            //}


            //else if (valor1 < valor3 && valor2 < valor1)
            //{
            //    Console.WriteLine(valor1 + " " + valor2 + " " + valor3);
            //}

            //else if (valor3 < valor1 && valor2 < valor3)
            //{
            //    Console.WriteLine(valor2 + " " + valor3 + " " + valor1);
            //}

            //else if (valor1 < valor2 && valor3 < valor1)
            //{
            //    Console.WriteLine(valor3 + " " + valor1 + " " + valor2);
            //}

            //Console.ReadKey();


            //Exercício 8


            //int ano;

            //Console.WriteLine("Digite um ano: ");
            //ano = int.Parse( Console.ReadLine() );

            //if(ano % 4 == 0)
            //{
            //    Console.WriteLine("Esse é um ano bissexto");
            //}
            //else
            //{
            //    Console.WriteLine("Esse não é um ano bissexto");
            //}

            //Console.ReadKey();

            //Exercício 9


            //float num1, num2, R;
            //char op;

            //Console.WriteLine("Digite o primeiro número: ");
            //num1 = float.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o segundo número: ");
            //num2 = float.Parse( Console.ReadLine() );
            //Console.WriteLine("Escolha uma operação (+, -, *, /): ");
            //op = char.Parse(Console.ReadLine());

            //if(op == '+')
            //{
            //    R = num1 + num2;
            //    Console.WriteLine("Resultado = " + R);
            //}
            //else if(op == '-')
            //{
            //    R = num1 - num2;
            //    Console.WriteLine("Resultado = " + R);
            //}
            //else if (op == '*')
            //{
            //    R = num1 * num2;
            //    Console.WriteLine("Resultado = " + R);
            //}
            //else
            //{
            //    R = num1 / num2;
            //    Console.WriteLine("Resultado = " + R);
            //}

            //Console.ReadKey();

            //exercício 10

            //Para gerar números inteiros e reais aleatórios é preciso usar a classe random. Para poder fazer isso precisamos usar o método next() dessa mesma classe, passando o valor mínimo e máximo desejado como argumentos.
            //Por exemplo, para gerar um número interior entre 1 e 10, usa o seguinte código:

            //Random random = new Random();
            //int randomNumber = random.Next(1, 11); 

            //Para gerar um número real aleatório em um determinado intervalo, podemos usar o método NextDouble() dessa mesma classe random, que retorna um número aleatório entre 0 e 1. Podemos então ajustar o valor do número gerado para o intervalo desejado.
            //Por exemplo, para gerar um número real aleatório entre 1 e 10, podemos usar o seguinte código:

            //Random rand = new Random();
            //int randomNumber = rand.Next(10);
























        }
    }
}
