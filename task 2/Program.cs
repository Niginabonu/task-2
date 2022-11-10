using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string name1,name2;
             Console.WriteLine("    Assalomu alaykum my sweatheard , What is your name? ");
             name1 = Console.ReadLine();

             string b = Convert.ToString(name1);
             Console.WriteLine("   Ohh great  {0}", b);
             Console.WriteLine("    And who are you ?");
             name2 = Console.ReadLine();
             string a = Convert.ToString(name2);
             Console.WriteLine("   Nice to meet you {0}", a);
            */


            /* int n ,boolean=0;
             n = int.Parse(Console.ReadLine());
             for (int i = 2; i <= n/2; i++)
             {
                 if (n % i == 0)
                 {
                     Console.WriteLine(" Not prime number");
                     boolean = 1;
                     break;

                 }     
             }
                 if(boolean==0)
                 Console.WriteLine(" Prime number ");*/
            /* Console.WriteLine(" Siz kiritgan son sizni harakterizni aniqlab beradi");
             int variant;
             variant = int.Parse(Console.ReadLine());
             if (variant %45==5)
                 Console.WriteLine("  Qatiyatli ekansiz ");
            else  if  (variant %50==0)
                 Console.WriteLine("  Bo'yiz baland ekanmi");
            else if (variant %62==12)
                 Console.WriteLine(" OOO Erinchoqmisiz");
            else if (variant %10==0)
                 Console.WriteLine(" Chiroylisiz ");

            else if (variant %89==25)
                 Console.WriteLine("  O'zingizni erkin his qiling");
           else  if (variant %4==3)
                 Console.WriteLine("  Qulayroq joylashib oling");
           else  if (variant %11==10)
                 Console.WriteLine(" Muhammadkarim akani tanishimisiz?");

           else  if (variant %9==0)
                 Console.WriteLine("  Sabrli inson ekansiz,sabr qilib tugashini shuncha kutdizaaa");
            else if (variant %5==1)
                 Console.WriteLine("  Afsuski siz topolmadiz");
            else if (variant % 21 == 10)
                 Console.WriteLine(" CONGRATULATION !!! You manage to find key:)");
             else
                 Console.WriteLine(" O'yin tugadi, Omadingizni kelgusi yil sinab ko'rishingiz mumkin");
            */

            /* int leapyear;
             leapyear = int.Parse(Console.ReadLine());
             if (leapyear % 4 == 0 && leapyear % 100 != 0)
                 Console.WriteLine(" Leap year");
             else if (leapyear % 400 == 0)
                 Console.WriteLine(" Leapyear");
             else Console.WriteLine(" Not leapyear");*/

            /* int k;
             double a,s=0;
             k = int.Parse(Console.ReadLine());
             for(int i = 0; i < k; i++)
             {
                  a = Math.Pow(-1,i+1)/(2*i-1);
                 s += a;
             }
             Console.WriteLine(s);*/
            int[] a = new int[100];
            int n ,s=0;
            Console.Write(" massiv elementlar sonini kiriting :");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int number;
            Console.Write(" yig'indini kiriting:");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {

                    if (a[i] + a[j] == number)
                        Console.WriteLine(" a[" + i + "," + j + "]") ;


                }
               
                

            }//Console.WriteLine( Array.Empty<int>());
            

           
            Console.ReadKey();
            
        }
    }
}
