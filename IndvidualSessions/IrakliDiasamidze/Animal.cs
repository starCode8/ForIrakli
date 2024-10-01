using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrakliDiasamidze
{
    #region ინკაფსულაცია
    public class Animal
    {
        
        //ინკაფსულაცია -
        //წვდომის მოდიფიკატორებით ინფორმაციის ხელმისაწვდომობის და დანახვადობის მანიპულაცია.

        public int x;    // გარედან წვდომა შეიძლება

        private int y;   // გარედან წვდომა არ შეიძლება, შვილობილი კლასი ვერ წვდება.

        protected int z = 10; // გარედან წვდომა არ შეიძლება, შვილობილი კლასი წვდება.
        

    }


    public class Cat : Animal
    {
        public int Sum(int x) 
        {
            return base.x = x + z;  // base მიუთითებს მშობელ კლასზე
        }    
    }
    #endregion

}
