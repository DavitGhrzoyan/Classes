using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Animals dog = new Animals();
            Animals cat = new Animals();
            Animals bird = new Animals();
            Animals fish = new Animals();
            ////////////////////////////

            Cars BMW = new Cars();
            Cars Mercedes = new Cars();
            

            dog.name = "Dog name is Rex";
            dog.voice = "Haf haf";

            cat.name = "Cat name is Murlik";
            cat.voice = "Miau miau";

            bird.name = "Bird name is Rio";
            bird.voice = "Tsiv tsiv";

            fish.name = "Fish name is Nemo";
            fish.voice = "Bul bul";
            //////////////////////////

            BMW.model = "The Car is BMW X6 ";
            BMW.type = "Type is Sedan";
            BMW.Horsepower = 400;

            Mercedes.model = "The Car is Mercedes SLS";
            Mercedes.type = "Type is Coupe";
            Mercedes.Horsepower = 500;

            

            dog.Print();
            cat.Print();
            bird.Print();
            fish.Print();
            /////////////

            BMW.getInfo();
            Mercedes.getInfo();






            
        }
    }
}
