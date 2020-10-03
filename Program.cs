using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDrill
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("Hello how old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                if ( age <= 0)
                {
                    throw new ArgumentException();
                }
                var age2 = DateTime.Now;
                var age3 = age2.AddYears(-age);
                Console.WriteLine(age3);
                Console.ReadLine();

            }
            catch (ArgumentException)
            {         
                 Console.WriteLine("you are not zero/ or negative please put in your age.");
                 Console.ReadLine();
                                    
            }
            catch (Exception)
            {
                Console.WriteLine("Please type your age in digts");
                Console.ReadLine();
                
            }
            
            

            Console.ReadLine();
        }
    }
}
