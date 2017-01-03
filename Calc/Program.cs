using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {   
        
       
        static void Main(string[] args)
        { 
            bool exit = false;
            Operation operation=new Operation();
            ConsolView consol= new ConsolView();
            while(!exit)
            {
                consol.View();
            try
            { 
                
            switch(consol.Z)
            {
                case "1":
                    consol.PrintResult(consol.X,consol.Y,'+',operation.Sum(consol.X,consol.Y));break;
                case "2":
                    consol.PrintResult(consol.X,consol.Y,'*',operation.Ymn(consol.X,consol.Y));break;
                case "3":
                     consol.PrintResult(consol.X,consol.Y,'/',operation.Del(consol.X,consol.Y));break;
                case "4":
                     consol.PrintResult(consol.X,consol.Y,'-',operation.Raz(consol.X,consol.Y));break;
                case "0": exit = true; break;

            }
            }
            catch 
                {
                    Console.WriteLine("Введены не верные данные");
                }
            Console.WriteLine("---------------------------------------------");
            }
            Console.ReadLine();

        }


    }
    public class Operation
    {
        public Operation() { }
        public double Sum(string x, string y)
        {
            double x1=Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            return  x1+ y1;
        }
         public double Raz(string x, string y)
        {
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            return x1 - y1;
        }

         public double Ymn(string x, string y)
         {
             double x1 = Convert.ToDouble(x);
             double y1 = Convert.ToDouble(y);
             return x1 * y1;
         }
        public double Del(string x, string y)
        {
            double x1 = Convert.ToDouble(x);
            double y1 = Convert.ToDouble(y);
            return x1 / y1;
        }


    }

}
