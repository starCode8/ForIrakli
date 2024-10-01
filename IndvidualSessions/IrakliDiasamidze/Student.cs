using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliDiasamidze
{
    public class Student
    {
        public string name;
        public byte age;
        public string id;
        public float gpa;

        #region Constructors / Constructor Overload
        //არის სპეციალური(განსაკუთრებული) მეთოდი,
        //რომელიც გამოიყენება ობიექტის შესაქმნელად(ინიციალიზაციისთვის).

        public Student()  
        {
            Console.WriteLine("Default Consructor");
        }

        public Student(string name) : this()  
        {
            this.name = name;
        }

        public Student(string name, byte age) : this(name)  
        {
         // უარგუმენტო კონსტრუქტორი - ცარიელი ანუ დეფოლტ კონსტრუქტორი
         // this სიტყვა მიუთითებს ამჟამინდელ, ანუ მიმდინარე ობიექტს.
            this.age = age;
        }

        public Student(string name, byte age, string id) : this(name,age)
        {
            this.id = id;
        }

        public Student(string name, byte age, string id, float gpa) : this(name,age,id)
        { 
            this.gpa = gpa;
        }

        #endregion

        #region Method Overload
        // პროგრამა გადატვირთულ ფუნქციებს
        // განარჩევს არგუმენტების რაოდენობით, ან ტიპით ან თავად ფუნქციის ტიპით.

        public static int Sum(int num1, int num2) 
        { 
           return num1 + num2;
        }

        public static int Sum(int num1)
        {
            return num1+34;
        }

        public static void Sum()
        {
            Console.WriteLine("Sum 3");
        }
        #endregion

        #region Operator Overload

        public static bool operator < (Student st1, Student st2) 
        { 
            return st1.gpa < st2.gpa;
        }

        public static bool operator > (Student st1, Student st2)
        {
            return st1.gpa > st2.gpa;
        }


        public static bool operator <= (Student st1, Student st2)
        {
            return st1.gpa <= st2.gpa;
        }

        public static bool operator >=(Student st1, Student st2)
        {
            return st1.gpa >= st2.gpa;
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.gpa == st2.gpa;
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return st1.gpa != st2.gpa;
        }

        #endregion

        #region Override
        public override string ToString()
            {
                 return $"Student Name: {name}, Student Age: {age} , " +
                         $"Student ID: {id} Student GPA: {gpa}";
            }

        #endregion

    }
}
