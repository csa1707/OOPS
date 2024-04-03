using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public virtual void StudentID()
        {
            Console.WriteLine("Enter a vaild student ID");
        }          
    }
    public class StudentName : Student
    {
        public void IDcard()
        {
            Console.WriteLine("It is issued");
        }
        public override void StudentID()
        {
            Console.WriteLine("Enter a vaild Name");
        }
    }
    public class StudentAge : Student
    {
        public override void StudentID() 
        {
            Console.WriteLine("Enter a vaild age");
        }
    }

}
