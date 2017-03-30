using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quiz_app_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,c,d;
            Console.WriteLine("what is your name ?");
            d = Convert.ToString(Console.ReadLine());
            

            Console.WriteLine("what is programming?");
            a = Convert.ToString(Console.ReadLine());
           
            Console.WriteLine("what is the capital of pakistan?");
            b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("what is the capital of turkey?");
            c = Convert.ToString(Console.ReadLine());

            var correct = 0;

            if (a.ToLower() == "problem solving")
            {

                correct++;
            }
            if (b.ToLower() == "islamabad")
            {

                correct++;
            }

            if (c.ToLower() == "istambul")
            {

                correct++;
            }


            string[] strArray = new string[] { "You must work very hard", "You are fail", "Congrats you nailed it "};
             
        if (correct < 1){
            Console.WriteLine(strArray[0]);
            
        }

         if (correct > 0 &&  correct <3  ){
            Console.WriteLine(strArray[1]);
             
        }

         if (correct > 2){
             Console.WriteLine(strArray[2]);
          
        }
         
         
             Console.WriteLine(d.ToUpper()+ " You got : " + correct + " correct");
             Console.ReadLine();
         
         
             
         
          
        }
    }
}
