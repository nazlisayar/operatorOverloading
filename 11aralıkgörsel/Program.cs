using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11aralıkgörsel
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            prizma P1= new prizma();   
            prizma P2= new prizma();
            prizma p3 = new prizma();   
            prizma p4 = new prizma();
            P1.seten(10);
            P1.setboy(20);
            P1.setyukseklik(30);
            Console.WriteLine("sonuc:" + P1.gethacim());
            P2.seten(5);
            P2.setboy(10);
            P2.setyukseklik(15);
            Console.WriteLine("sonuc:"+P2.gethacim());
            p3=P1+P2;   
            Console.WriteLine("sonuc:"+p3.gethacim());
            p4 = P1 - P2;
            Console.WriteLine("sonuc:"+p4.gethacim());
            if (P1 == P2)
                Console.WriteLine("prizmalar eşittir");
            else
            {
                Console.WriteLine("prizmalar eşit değildir.");
            }

            if(P1 == P2)
                Console.WriteLine("prizmalar eşittir");
            else
            {
                Console.WriteLine("prizmalar eşit değildir.");
            }

            if(P2==p4)
                Console.WriteLine("prizmalar eşittir");
            else
            {
                Console.WriteLine("prizmalar eşit değildir.");
            }




            Console.Read(); 













        }
    }
}
