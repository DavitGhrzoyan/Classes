using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Cars
    {
        public string model;
        public string type;
        public int Horsepower = 0;

        public void getInfo()
        {
            Console.WriteLine(model + "\n" + type + "\n" + "Horse Power is " + Horsepower + "\n");
        }
    }


}
