using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

   // static constructor vs instance construction

    public class StopWatch
    {
        static StopWatch()
        {
            Console.WriteLine("this is static ");
        }

        public StopWatch()
        {
            Console.WriteLine("this is static "); Console.WriteLine("this is static ");
        }

    }

    /*
  //static
  using System;

  public class Program
  {
      public static void Main()
      {
          var result = Calculator.Sum(10, 25); // calling static method
          Calculator.Store(result);
          Console.WriteLine(result);



          Calculator.Type = "Scientific"; // assign value to static variable
          var calcType = Calculator.Type; // accessing static variable
          Console.WriteLine(calcType);




      }
  }

  public static class Calculator
  {
      private static int _resultStorage = 0;

      public static string Type = "Arithmetic";

      public static int Sum(int num1, int num2)
      {
          return num1 + num2;
      }

      public static void Store(int result)
      {
          _resultStorage = result;
      }
  }


//interface
interface IFile
{
  void WritingFile(String text);
  void ReadFile();
}

class FileInfo : IFile 
{
   void IFile.ReadFile()
  {
      Console.WriteLine("Reading File");
  }

  void IFile.WritingFile(String text)
  {
      Console.WriteLine("Reading File");
  }

  public void searching()
  {
      Console.WriteLine("Searching File");
  }
}

class Program
{
  public static void Main()
  {
      FileInfo file = new FileInfo();
      IFile file2 = new FileInfo();

      file2.WritingFile("content");
      file.searching();

  }
}



//Nullable value
class Program
{
 public static void Main()
 {
     Nullable<int> i = null;

     if(i.HasValue)

         Console.WriteLine(i.Value);


     else
         Console.WriteLine("null");

 }
}


  //dynamic types
  class Program
  {
      public static void Main()
      {

          dynamic num = 100;
          Console.WriteLine("Value: {0}, Type: {1}", num, num.GetType());


          num = "sanish";
          Console.WriteLine("Value: {0}, Type: {1}", num, num.GetType());


          num = false;
          Console.WriteLine("Value: {0}, Type: {1}", num, num.GetType());

      }
  }


         // Anonymous Type

        public  class Student
         {
             public int Id { get; set; }
             public string Name { get; set; }
             public int Class { get; set; }
         }

         class Program
         {
             public static void Main()
             {
                 IList<Student> studentList = new List<Student>()
                 {
                       new Student() { Id = 1 ,  Name = "sanish" , Class = 10 },
                 new Student() { Id = 2, Name = "Samundra", Class = 11 },
                 new Student() { Id = 3, Name = "sonima", Class = 12 },
                 new Student() { Id = 4, Name = "nirik", Class = 13 }
                 };

                 var students = from s in studentList
                                select s;

                 Console.WriteLine(students);

                              //  select new(id = s.Id, name = s.Name, clas = Class);


             }
         }

      class Builder
      {
          public static void Main()
          {
              //string builder
              StringBuilder sb = new StringBuilder();
              sb.Append("hi");
              sb.AppendLine("sanish");
              sb.AppendLine("Nice To Meet You!!!");

              Console.Write(sb);


          }


      }



      //enum 
      class eenum
      {
          enum value_no
          {
              one = 5,
              two = 2,
              three = 3,
              four = 4,
              five = 50
          }

          public static void Main()
          {
             // Console.WriteLine((int)value_no.one);

              var value = (value_no)50;
              Console.WriteLine(value);
          }
      }




      //Static member of a class

      static class person
      {
          public static int id;
          public static string name;
          public static int age;

          public static void Display()
          {
              Console.WriteLine("ID is: " + id + " and you name is:" + name + " and age is :" + age);
          }
      }

      class program
      {
          static void Main()
          {
              person.id = 1;
              person.name = "sanish";
              person.age = 21;

              person.Display();
          }
      }

      //Argumnet List

      class program
      {
          class IndexerClass
          {
              private string[] names = new string[10];

              public string this[int i]
              {
                  get
                  {
                      return names[i];
                  }
                  set
                  {
                      names[i] = value;
                  }
              }
          }

          static void Main()
          {
              IndexerClass ic = new IndexerClass();
              ic[0] = "sanish";
              ic[1] = "karan";
              ic[2] = "some";
              ic[3] = "s";
              ic[4] = "h";
              ic[5] = "n";
              ic[6] = "ssdf";

              for(int i = 0; i < 10; i++)
              {
                  Console.WriteLine(ic[i]);
              }

          }
      }

      //Automatic propertie Get/set

      class demo
      {
          public int a {get; set; }

          public int b { get; set; }

          public int sum
          {
              get
              {
                  return a + b;
              }
          }
      }

      class test
      {
          public static void Main()
          {
              demo demo = new demo();
              demo.a = 1;
              demo.b = 2;
              Console.WriteLine("sum of " + demo.a + " and " + demo.b + " = " + demo.sum);
          }
      }

       * 
      class pattern
      {
         //Static Constructor

         public pattern()
         {
             Console.WriteLine("I am not static  constructor");
         }

         static pattern()
         {
             Console.WriteLine("I am  static  constructor");
         }
      }

      class program
      {

         public static void Main()
         {
             new pattern();
             //new pattern();
         }
      }


        //heart pattern
      public static void Main()
      {
       int fore = 4;
       int fore2 = 4;
       int ten = 8;
       int twientyOne = 22;

       for (int i = 0; i < 3; i++)
       {
           for (int j = 3; j > i; j--)
           {
               Console.Write(" ");
           }

           for(int k = 0; k < fore; k++)
           {

               Console.Write("*");
           }

           fore = fore + 3;

           for(int l = 1; l<ten; l++)
           {
               Console.Write(" ");
           }

           ten = ten - 3;

           for (int k = 0; k < fore2; k++)
           {

               Console.Write("*");
           }
           fore2 = fore2 + 3;



           Console.WriteLine();
       }

       for(var i= 1; i<12; i++)
       {
           for(var j = 0; j<i; j++)
           {
               Console.Write(" ");
           }

           for(var k = 1; k<twientyOne; k++)
           {
               Console.Write("*");
           }
           twientyOne = twientyOne - 2;

           Console.WriteLine();
       }



          int four = 4;
          for(int i = 0; i<3; i++)
          {
              for(int j= 3; j>i; j--)
              {
                  Console.Write("0");
              }
          //    Console.WriteLine();
          for(int k = 1; k<=four; k++)
              {
                  four = four + 2;

                  Console.Write("*");
              }
              Console.WriteLine();
          }
      }
      }*/


    /*
    //diamond pattern
    class pattern
    {

        public static void Main()
        {
            for(int i = 0; i<4; i++)
            {
                for(int j= 0; j<=i; j++)
                {
                    Console.Write(" ");

                }

                for (int k = 4; k > i; k--)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();


            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");

                }

               for (int k = 0; k <= i; k++)
              {
                   Console.Write("*");
                   Console.Write(" ");
               }
                Console.WriteLine();


            }
        }
    }


          class pattern
          {

              public static void Main()
              {
                  for(int i = 0; i<4; i++)
                  {
                      for(int j = 0; j <=i; j++)
                      {
                          Console.Write("*");
                      }
                      Console.WriteLine();
                  }
                  for (int i = 0; i < 5; i++)
                  {
                      for (int j = 5; j > i; j--)
                      {
                          Console.Write("*");
                      }
                      Console.WriteLine();
                  }
              }
          }


        //single level inheritance 
        class A
        {


          public int a = 10, b = 5;

        }

        class B : A
        {
          public void test()
          {
              Console.WriteLine("value of a :"+a +" and value of B is :"+b);  
          }
        }

        class Inherit
        {
          public static void Main(String[] args)
          {
              B obj = new B();
              obj.test();
              Console.ReadLine();
          }
        }


















        class ParamsMOdifier
        {

         static int sum(params int[] par)
         {
             int sum = 0;

             for(int i= 0; i < par.Length; i++)
             {
                 sum += par[i];

             }
             return sum;


         }

        public   static void Main()
         {
             int total = sum(3, 23, 4, 5, 5, 2, 1, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4);
             Console.WriteLine(total);
         }
        }



        //i am trynig the example of Out
        class OutModifier
        {

        static void Pass(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;

        }

        public static void Main()
        {
           int x, y;
            Pass(1, 2, out x, out y);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();

        }
        }





        // we used arrey to add the elements stored in an array
        class SumOfIntergers
        {
            public static void Main()
            {
                int n, sum = 0 , i;
                int[] a = new int[100];


                Console.WriteLine("Sum of Elements////");
                Console.WriteLine("Enter The number of elementes to be stored in Array:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input- {0} Elements :",n);   

                for(i=0; i<n; i++)
                {
                    Console.Write("Enter- {0} Number:", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                for(i=0; i<n; i++)
                {
                    sum += a[i];
                }

               Console.WriteLine("thotal is : {0}",sum);
                Console.Read();

            }


        }





         * we used getter and setter simple example
        class myClass
        {
           private int x;

           public void SetX(int i)
           {
               x = i + 2;
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
