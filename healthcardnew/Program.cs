using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace healthcardnew
{
    class Program
    {
        public static void Main(string[] args)
        {
            
                        
            Console.WriteLine(" Enter Your Health Card Number: ");  //print on output strim
            string accept = Console.ReadLine();                     //get input from user
            Console.WriteLine("number is " + accept);                //print the number

            char[] health_c_number = accept.ToCharArray();//creat char array and convert string to char array
           var healtharray = Array.ConvertAll<char,int>(health_c_number,c => (int)char.GetNumericValue(c));
            
           int[] answer = new int[10];// creat an int array
         //  int sum = answer.Sum();
        //   int fsum =  (sum % 10);

        /*   if (answer[9].CompareTo.fsum)
           {
               Console.WriteLine("valid health card");
           }
           else
           {
               Console.WriteLine("Invalid health card");
           }*/
            
            for (int i = 0; i <= 9; ++i)
            {
              
          
                if( i % 2==0  )
                {

                    var dbl = healtharray[i] * 2;
                    answer[i]=(dbl % 10) + (int)(dbl / 10);

                }
             

                else
                {
                    answer[i] = healtharray[i];

                }
           
            }



                

            
            
           
            }

    }
}
