using OOP_04.Iclonable;
using System.Text;

namespace OOP_04
{
    internal class Program
    {

        public static void PrintNumFromSeries(ISeries series)
        {
            if (series != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(series.cuurent);
                    series.GetNext();
                }
                series.Reset();
            }
        }
        static void Main(string[] args)
            {
            //IMyType myType = new MyTypeClass();
            //myType.id = 10;
            //myType.MyFun(100);
            //myType.Print();

            //    SeriesByTwo seriesByTwo = new SeriesByTwo();

            //    PrintNumFromSeries(seriesByTwo);
            //    Console.WriteLine("\n============================");
            //    SeriesByThree seriesByThree = new SeriesByThree();
            //    PrintNumFromSeries(seriesByThree);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02 = Arr01;
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            //Arr02 = (int[])Arr01.Clone();
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr01[0]= 100;
            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            //string[] Names01 = { "Amr" };
            //string[] Names02 = new string[1];
            //Console.WriteLine(Names01.GetHashCode());
            //Console.WriteLine(Names02.GetHashCode());

            //Names02 = Names01;
            //Console.WriteLine(Names01.GetHashCode());
            //Console.WriteLine(Names02.GetHashCode());

            //Names01[0] = "Ahmed";
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            //deep copy

            //Names02 =(string[]) Names01.Clone();
            //Console.WriteLine(Names01.GetHashCode());
            //Console.WriteLine(Names02.GetHashCode());
            //Names01[0] = "Ahmed";
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);


            //string builder

            //StringBuilder[] Names01 =new StringBuilder[1];
            // Names01[0] = new StringBuilder("amr");
            // StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine(Names01.GetHashCode());
            //Console.WriteLine(Names02.GetHashCode());

            //Names02 = Names01;
            //Console.WriteLine(Names01.GetHashCode());
            //Console.WriteLine(Names02.GetHashCode());
            //Names02[0].Append("Ahmed");
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            //Names02 = (StringBuilder[]) Names01.Clone();
            //Console.WriteLine(Names01.GetHashCode());
            //Console.WriteLine(Names02.GetHashCode());
            //Names02[0].Append("Ahmed");
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            //Employee employee01 = new Employee()
            //{
            //    id = 10,
            //    name = "amr",
            //    salary = 10000
            //};
            //Employee employee02 = new Employee()
            //{
            //    id = 20,
            //    name = "mohamed",
            //    salary = 9000
            //};
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);


            //employee02 = employee01;
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);


            //employee01.id = 100;
            //employee01.name = "nada";
            //employee01.salary = 5000;
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);


            //employee02 = (Employee)employee01.Clone();
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);

            //employee02.id = 200;
            //employee02.name = "aya";
            //employee02.salary = 4000;
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);

            Employee[] employees = new Employee[4]
            {
                new Employee(){id=50,name="aya", salary =7000},
                new Employee(){id=20,name="ahmed", salary =20000},
                new Employee(){id=30,name="nada", salary =9000},
                new Employee(){id=10,name="hossam", salary =1000}
            };

            Array.Sort(employees);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            
        }
    }
}
