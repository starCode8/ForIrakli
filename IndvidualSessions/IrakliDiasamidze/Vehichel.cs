using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IrakliDiasamidze
{
    public abstract class Vehichel
    {
        public string engine;
        public string manufacturer;


        protected Vehichel(string engine, string manufacturer)
        {
            this.engine = engine;
            this.manufacturer = manufacturer;
            Console.WriteLine("ABSTRACT Class Constructor ACTIVATED");
        }
        public abstract void MakesNoise();
        public void Print() => Console.WriteLine("ჩვეულებრივი ფუნქცია აბსტრაქტ კლასში");
    }

    //აბსტრაქტ კლასი არის გეგმა რომელსაც მიყვებიან ამ აბსტრაქტ კლასის შვილობილი კლასები.

    //თუ აბსტრაქტულ კლასშ გიწერია აბსტრაქტული მეთოდი,
    //მაშინ ყველა შვილობილ კლასში უნდა მოხდეს ამ მეთოდის იმპლემენტაცია.
    public class Car : Vehichel
    {
        public Car(string engine, string manufacturer) : base(engine, manufacturer)
        {
            Console.WriteLine("Car Constructor ACTIVATED");
        }
        public override void MakesNoise()
        {
            Console.WriteLine("Wroom");
        }

        public override string ToString()
        {
            return $"Car Engine: {engine},Car Manufacturer: {manufacturer}";
        }
    }

    public class Plane : Vehichel
    {
        public Plane(string engine, string manufacturer) : base(engine, manufacturer)
        {

        }
        public override void MakesNoise()
        {
            Console.WriteLine("Vshoo");
        }
    }

    public class Train : Vehichel
    {
        public Train(string engine, string manufacturer) : base(engine, manufacturer)
        {

        }
        public override void MakesNoise()
        {
            Console.WriteLine("Choo");
        }
    }

}
