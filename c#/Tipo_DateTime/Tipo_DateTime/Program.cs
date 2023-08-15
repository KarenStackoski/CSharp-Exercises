using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 09, 23);
            DateTime datahora = new DateTime(2022, 03, 15, 15, 23, 20);

            //Acessando separadamente cada parâmetro
            Console.WriteLine("Ano: " + datahora.Year);
            Console.WriteLine("Mês: " + datahora.Month);
            Console.WriteLine("Dia: " + datahora.Day);
            Console.WriteLine("---------------------");
            Console.WriteLine("Hora: " + datahora.Hour);
            Console.WriteLine("Minuto: " + datahora.Minute);
            Console.WriteLine("Segundo: " + datahora.Second);
            Console.WriteLine("---------------------");
            Console.WriteLine("Dia da Semana: " + datahora.DayOfWeek);
            Console.WriteLine("---------------------");
            Console.WriteLine(data.ToString());
            Console.WriteLine(datahora.ToString());
            Console.WriteLine("---------------------");

            DateTime dataatual = DateTime.Now;
            Console.WriteLine("Data e Hora atual: " + dataatual.ToString());
            Console.WriteLine("---------------------");

            //Convertendo string p/ datetime
            DateTime dataconvertida = Convert.ToDateTime("21/03/2023");
            DateTime datahoraconvertida = Convert.ToDateTime("21/03/2023 14:45:25");
            Console.WriteLine(dataconvertida);
            Console.WriteLine(datahoraconvertida);
            Console.WriteLine("---------------------");

            //Formatando data e hora impressa
            Console.WriteLine(datahoraconvertida.ToString("yyyy/MM"));
            Console.WriteLine(datahoraconvertida.ToString("yyyy/MM/dd"));
            Console.WriteLine(datahoraconvertida.ToString("yyyy-MM"));
            Console.WriteLine(datahoraconvertida.ToString("HH-mm-ss"));
            Console.WriteLine(datahoraconvertida.ToString("HH:mm:ss"));
            Console.WriteLine("---------------------");

            //Operações c/ Datetime
            DateTime datahora2 = new DateTime(1990, 04, 09, 14, 05, 22);
            datahora2 = datahora2.AddDays(35); // adicionando 35 dias na data
            /* 
               datahora2.AddYears();
               datahora2.AddMonths();
            */
            Console.WriteLine(datahora2.ToString("dd/MM/yyyy"));

            datahora2 = datahora2.Add(new TimeSpan(01, 55, 30));
            Console.WriteLine(datahora2.ToString("HH:mm:ss"));
            Console.WriteLine("---------------------");

            //Subtraindo datas
            DateTime datahora3 = new DateTime(2022, 03, 01, 14, 05, 20);
            datahora3 = datahora3.Subtract(new TimeSpan(01, 5, 20));
            Console.WriteLine(datahora3.ToString("HH:mm:ss"));
            datahora3 = datahora3.AddDays(-3);
            Console.WriteLine(datahora3.ToString("dd/MM/yyyy"));

            Console.WriteLine("---------------------");
            Console.WriteLine("Pressione qualquer tecla para sair:");
            Console.ReadKey();
        }
    }
}
