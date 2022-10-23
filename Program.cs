using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
                      int m = 0;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Teste de quantidade de dias dos meses!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Para começar, observe a tabela e digite o número que represente o mês desejado.");
            Console.WriteLine("Bora Bill!");
            Console.WriteLine("");
            Console.WriteLine("_________");
            Console.WriteLine("|  Janeiro    |  (1)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Fevereiro  |  (2)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Março      |  (3)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Abril      |  (4)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Maio       |  (5)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Junho      |  (6)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Julho      |  (7)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Agosto     |  (8)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Setembro   |  (9)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Outubro    | (10)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Novembro   | (11)  |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Dezembro   | (12)  |");
            Console.WriteLine("_________");
            Console.WriteLine("");
            Console.WriteLine("Digite o número do mês desejado: ");
            m = Convert.ToInt32(Console.ReadLine());

              switch (m)
              {
               case 1:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 2:
               Console.WriteLine("O MÊS DIGITADO POSSUI 28/29 DIAS");
               break;

               case 3:
               Console.WriteLine("O MÊS DIGIATDO POSSUI 31 DIAS");
               break;

               case 4:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 5:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 6:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 7:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 8:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 9:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 10:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 11:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 12:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               default:
               Console.WriteLine("DIGITO INVÁLIDO");
               break;

              }

           
              
           

            

        }
    }
}
