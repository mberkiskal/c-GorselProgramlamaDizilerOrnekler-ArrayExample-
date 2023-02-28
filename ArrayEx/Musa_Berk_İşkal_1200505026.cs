using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {

        yeniden:
            Console.WriteLine("Lutfen yapmak istediginiz İslemi seciniz: \n" +
                "*************************************************************** \n" +
                "1.Dizinin son indeksindeki eleman bir arttırmak icin lutfen 1'e basiniz. \n" +
                "*************************************************************** \n" +
                "2.Sayinin Polindrom olup olmadıgini kontrol etmek icin lutfen 2'ye basiniz. \n" +
                "*************************************************************** \n" +
                "3.Girilen metindeki son kelimenin uzunlugunu bulmak icin lutfen 3'e basiniz\n" +
                "*************************************************************** \n");

            int islemNumarasi;
            islemNumarasi = Convert.ToInt32(Console.ReadLine());

            if (islemNumarasi == 1)
            {
                Console.WriteLine("------->BIRINCI ISLEM SECILDI<-------");
                int array = 0;
                Console.Write("Kac elemanli bir dizi olusturmak istediginizi giriniz: ");
                array = Convert.ToInt32(Console.ReadLine());


                int value1;
                int[] value2 = new int[array];


                for (int i = 0; i < array; i++)
                {
                    Console.Write("Dizinin elemanlarini girin: ");
                    value2[i] = Convert.ToInt32(Console.ReadLine());


                }

                value1 = value2[value2.Length - 1] + 1;
                Console.WriteLine("Dizinin son elemaninin artmis hali : {0}", value1);



                Console.WriteLine("Dizin yeni hali:\n");
                foreach (int res in value2)
                {
                    Console.Write(res + ",");
                }
                Console.Write(value1);

                int dongu;
                Console.WriteLine("\nIslemlere devam etmek icin 1'e basiniz.");
                dongu = Convert.ToInt32(Console.ReadLine());

                if (dongu == 1)
                {
                    goto yeniden;
                }


            }
            else if (islemNumarasi == 2)
            {
                Console.WriteLine("------->IKINCI ISLEM SECILDI<-------");
                int pol, rem, sum = 0, rose;

                Console.Write("\n Lutfen Br Sayi Giriniz: ");
                pol = Convert.ToInt32(Console.ReadLine());
                rose = pol;
                while (pol > 0)
                {
                    rem = pol % 10;
                    pol = pol / 10;
                    sum = sum * 10 + rem;
                }
                if (rose == sum)
                {
                    Console.WriteLine("\n Girdiginiz Sayi Polindrom\n");
                }
                else
                {
                    Console.WriteLine("\nGirdiginiz Sayi Polindrom Degil");
                }

                int dongu;
                Console.WriteLine("\nIslemlere devam etmek icin 1'e basiniz.");
                dongu = Convert.ToInt32(Console.ReadLine());

                if (dongu == 1)
                {
                    goto yeniden;
                }
                else
                {
                    Console.WriteLine("Konsol kapanıyor!");

                }
            }
            else if (islemNumarasi == 3)
            {
                Console.WriteLine("------->UCUNCU ISLEM SECILDI<-------");
                string lastword;
                Console.Write("\nBir Metin Giriniz:\n");
                lastword = Console.ReadLine();
                Console.Write("Girdiğiniz metindeki son kelimenin uzunluğu:\n" + lastword.Split().Last().Length);
                int dongu;
                Console.WriteLine("\nIslemlere devam etmek icin 1'e basiniz.");
                dongu = Convert.ToInt32(Console.ReadLine());

                if (dongu == 1)
                {
                    goto yeniden;
                }
            }
            else
            {

                Console.WriteLine("Geçersiz bir işlem seçtiniz.");
                int dongu;
                Console.WriteLine("Devam etmek için 1'e basınız");
                dongu = Convert.ToInt32(Console.ReadLine());

                if (dongu == 1)
                {
                    goto yeniden;
                }


            }



            Convert.ToInt32(Console.ReadLine());





        }


    }
}
