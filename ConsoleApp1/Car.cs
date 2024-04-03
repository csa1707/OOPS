using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {

        public string model;

        public int a = 10;

        public int b = 20;  

        public Car(string modelName) 
        {
            Console.WriteLine("this is constructor ");
            Console.WriteLine(a+b);   
            model = modelName;
        }


        public string colour = "yellow";

        public int maxSpeed = 150;

        public void drivername(string name)
        {
            Console.WriteLine("this is ajith"+ name);
        }

        public void drivername(string name , int maxspeed)
        {
            Console.WriteLine("this is ajith" + name + maxspeed.ToString());
        }

        //public string colour { get; set; }

        //public int maxSpeed { get; set; }

    }
    public class aeroplane
    {
       public string name = "boing";
        public int modelno = 737; 
    }

    
    public class vegetable
    {
        public string models1;

        public vegetable(string models)
         {
            Console.WriteLine("this is vegetable constructor");
            models1 = models;
         }
    }
    public class student
    {
        public string stuname = "Ravi";
        public int marks = 99;
    }
    //public class animals
    //{
    //    public string models2;
    //    public animals(string models3) 
    //    {
    //        Console.WriteLine("this is animal construtor");
    //        models2 = models3;
    //    }
    //}
    public class laptop
    {
        public string brandname = "hp";
        public int cost = 67999;
    }
}
