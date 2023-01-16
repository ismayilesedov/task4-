using System.Drawing;

namespace Task4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           programa xosh gelmisiniz");
            Console.Write("Nece kitab yaratmaq isdeyirsiz :");
            int a = yoxlama();
            book[] kitab = new book[a];
            for (int i = 0; i < kitab.Length; i++)
            {
                book s = new book();
                Console.Write($"{i + 1})Muellifin adini daxil edin :");
                s.muellif = helper.stringChecker();
                Console.Write($"{i + 1})Eserin adini daxil edin :");
                s.eser = helper.stringChecker();
                Console.Write($"{i + 1})Kitab nece sehiveden ibaretdir? :");
                label2:
                s.sehife = yoxlama2();
                if (s.sehife<10)
                {
                    Console.WriteLine("duzgun sehife daxil edin");
                    goto label2;
                }
                Console.Write($"{i + 1})Kitabin nesr ilini daxil edin :");
                s.nesr = yoxlama3();
                kitab[i] = s;
            }
            Console.WriteLine("--------------------");
            foreach (book item in kitab)
            {
                Console.WriteLine(item);
            }

            label1:
            Console.WriteLine("Nusxe yaratmaq isdeyirsizse 1-e basin eks halda 0-a basin");
            int c= yoxlama4();
            
         
        }
       







        static int yoxlama()
        {
           Label1:
            int a;
      
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }
        static int yoxlama2()
        {
            int a;
        Label1:
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Duzgun sehive daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }//sehive ucun
        static int yoxlama3()
        {
            int a;
        Label1:
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Duzgun nesr ili daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }//nesr ucun
        static int yoxlama4()//nusxe ucun
        {
            label1:
            int b=yoxlama();
            if (b == 1)
            {
                Console.WriteLine("Hansi eserin nusxesini isdeyirsiz? ");
                string c = Console.ReadLine();

            }
            else if (b==0)
            {
                Console.WriteLine("Umid edirik size komek ola bildik");
            }
            else
            {
                Console.WriteLine("Yanlis!");
                goto label1;
            }
            return b;
            
        }
        
       
    }    
	
}