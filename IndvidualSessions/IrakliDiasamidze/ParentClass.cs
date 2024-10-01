using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliDiasamidze
{
    public class ParentClass
    {
        protected int x; 
        public string familyName; 
        public int money;

    }



    public class ChildClass : ParentClass
    {
        public int y;
        public string House;

        public void sum()
        {
            Console.WriteLine(x);
        }


    }

    public class GrandChildClass : ParentClass
    {
        public void sum() 
        {
           
        }
    }

}
