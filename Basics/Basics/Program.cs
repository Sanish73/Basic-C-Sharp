using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

    class myClass
    {
        private int x;

        public void SetX(int i)
        {
            x = i + 1;
        }

        public int GetX()
        {
            return x;
        }

    }

    class mySchool
    {
        public static void Main()
        {
            myClass mc = new myClass();
            mc.SetX(3);
            int final = mc.GetX();

            Console.WriteLine(final);

        }
    }


    /* 
   class Program
   {

       //Foo method is for The ref example
       static void Foo(ref int p)
         {
             p = p + 1;
             Console.WriteLine(p);
         }


         static public  void optionalParameter(int x = 3)
         {
             Console.WriteLine(x);
         }



       static void Main(string[] args)
       {
           /*
           /////Arthematic Operation
           int bo = Convert.ToInt32(Console.ReadLine());
          bo /= 2;
           Console.WriteLine(bo);
           */


    /*  //Math class
      double a = -3.13;
      double b = 3.43;

      double demo = Math.Ceiling(a);
       demo = Math.Floor(a);
      demo = Math.Abs(a);
      Console.WriteLine(demo);

      */

    /*
                String name = "Sanish Thapa";
                name = name.Substring(0, 5);
                Console.WriteLine(name);
    */

    /*  //if else statement
      int age = Convert.ToInt32(Console.ReadLine());
      if(age >= 18 && age<=49)
      {
          Console.WriteLine("you are 18+");
      }
      else if(age>=50)
      {
          Console.WriteLine("you are Old");
      }
      else
      {
          Console.WriteLine("Child");
      }
    */

    /////Array=1.Index array
    ///         2.multi dientional array
    /*  String[] name = {"sanish" , "thapa" , "third"};
      name[2] = "sansh3";

      for(int i=0; i<name.Length; i++)
      {
           Console.WriteLine(name[i]);
      }

      Console.Read();*/

    //  2.Multi Dimensional Array =1.Rectangle Array
    //                            2.Jagged ArraY

    ////////////////////Rectangle Array
    /*  int[,] values = new int[4, 2]
   {
       {9,99},
       {3,33},
       {4,44},
       {1,11}
   };

for(int i=0; i<4; i++)
   {
       for(int j=0; j<2; j++)
       {
           Console.WriteLine(values[i,j]);
       }
   }

    ///now by using foreach loop

    foreach (var val in values)
    {
        Console.WriteLine(val);
    }


    ///////////  2.Jagged Array
    int[][] jagged = new int[][]
    {
        new int[] {1,2},
        new int[] {1,2,3},
        new int[] {1,2,4,5}
    };

    foreach (int[] array in jagged)
    {
        Console.WriteLine(array);
        foreach (int e in array)
        {
           Console.WriteLine(e);
        }
    }


    //////////Head = When ever an object is created it is allocated on the heap, and a reference to that object is returned.

    StringBuilder ref1 = new StringBuilder("object1");
    Console.WriteLine(ref1);
    StringBuilder ref2 = new StringBuilder("object2");
    StringBuilder ref3 = ref2;
    Console.WriteLine(ref3);


    /////////////////the ref Modifier -- for this i ade method nameed Foo

    int x = 8;
    Foo(ref x);
    Console.WriteLine("x is: "+x); //it tooks the ref value of x which is in foo methid


    ////////////////Optional Parameter
    optionalParameter();//if optionalParameter was not static then we cannot call inside the other method

    Console.Read();



}
}*/
}
