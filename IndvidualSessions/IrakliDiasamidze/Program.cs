using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliDiasamidze
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region ინკაფსულაცია
            /*          Animal Dog = new Animal();
                        Cat cat1 = new Cat();

                        Dog.x = 12345;

                        Console.WriteLine(Dog.x);
                        Console.WriteLine(cat1.Sum(7));
                        Console.WriteLine(cat1.x);*/
            #endregion

            #region პოლიმორფიზმი / მრავალი სახე
            // overload  და override
            //ორივე ერთი და იგივეა, ოღონდ overload ერთსა და იმავე კლასშია,
            //ხოლო override მშობლიდან შვილობილ კლასში.
            /*
                        Student student1 = new Student();
                        Student student2 = new Student("Qeti");
                        Student student3 = new Student("Qeti", 23); // ნაგულისხმები. უშუალოდ გაწერა არ სჭირდება
                        Student student4 = new Student("Mate", 27, "010127357");
                        Student student5 = new Student("Mate", 27, "010127357", 2.7f);
                        Student student6 = new Student("Nika", 35, "064327357", 3.5f);


                        Console.WriteLine(student6 < student5);
                        Console.WriteLine(student6 > student5);
                        Console.WriteLine(student6 <= student5);
                        Console.WriteLine(student6 >= student5);
                        Console.WriteLine(student6 == student5);
                        Console.WriteLine(student6 != student5);*/

            // სტატიკი ეკუთვნის თვითონ კლასს და არა ამ კლასის ობიექტს
            //student1.Sum()
            //Student.Sum(); 


            /*       Console.WriteLine(student1.ToString());
                   Console.WriteLine(student2.ToString());
                   Console.WriteLine(student3.ToString());
                   Console.WriteLine(student4.ToString());
                   Console.WriteLine(student5.ToString());*/

            /*Console.WriteLine(Student.Sum(5, 23));
              Console.WriteLine(Student.Sum(10));*/




            #endregion

            #region მემკვიდრეობითობა
            GrandChildClass grandChild = new GrandChildClass();



            #endregion

            #region აბსტრაქცია
            Car car = new Car("V8","Audi");

            Console.WriteLine(car.ToString());

            #endregion



            Console.ReadKey();
            

        }
    }
}
