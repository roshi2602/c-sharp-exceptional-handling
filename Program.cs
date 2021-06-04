using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_shap_exceptional_handling
{

    //exceptional handling
    //process to handle runtime errors
    //try block= throws error
    //catch block=catch exception that is thrown by try block
    //finally block =it works always irrespective of  try and catch


    //exceptions in c#=
    //DivideByZeroException                 =raised when division 0 is tried
    //NullReferenceException                 =raised when refering to null object
    //FileNotFoundException                  =raised when file is not found at specific location
    //IndexOutOfRangeException            =raised when index  of array is outside upper and lower limit
    //TimeOutException                         =raised when program dont have sufficient memory


    //-----------------------------------------------------------------------------------
    //custom exception
    //first create our own exception class by inheriting Exception

    class ExceptionC : Exception
    {
        //now make a constructor with string parameter,this constructor passes string to base exception class constructor

        public ExceptionC(string v) : base(v)
        {

        }

    }
    

    //first go to class Program
    //then go to main method

    //----------------------------------------------------------------------------------
    class Program
    {
        //----------------------------------------------------------
        //custom exception
        //now create another class


        public static void point(int n)
        {
            //check for conditions
            if (n < 0)
            {
                throw new ExceptionC("not allowed");
            }
        }
        //go to main method now

        //------------------------------------------------------------------------------

        //throw example
        static int div(int g, int h)
        {
            return g / h;
        }

        //now go to main method



        //--------------------------------------------------------
        static void Main(string[] args)
        {
            //try, catch ,finally example

            try                                             //try 
            {
                int a = 10;
                int b = 0;
                int c = a / b;

            }
            catch (Exception x)                    //catch format
            {
                Console.WriteLine(x);
            }

            //finally
            finally
            {
                Console.WriteLine("finally works");
            }

            Console.WriteLine("code works");
            Console.ReadLine();

            

            //--------------------------------------------------
            //custom exception
            try
            {
                point(-5);
            }
            catch (ExceptionC ss)
            {
                Console.WriteLine(ss);
            }

            Console.ReadLine();
            //------------------------------------------------------
            //throw example
          
            int g = 10;
            int h = 0;
            //format for condition in exception handling
            if(h == 0)
            
              throw new DivideByZeroException("not allowed");
            
            else
            {
                Console.WriteLine(div(g , h));
            }
           
            //---------------------------------------------------------------------
        }
    }
}