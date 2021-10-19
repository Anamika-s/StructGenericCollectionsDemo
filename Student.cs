using System;
using System.Collections.Generic;
using System.Text;

namespace StrutureenumDemos
{
    struct Address
    {
        string streetNo;
        public string city;
        string state;
        string pincode;
        public void GetAddress()
        {
            Console.WriteLine("Enter Address");
            Console.WriteLine("Enter Street No");
            streetNo = Console.ReadLine();
            Console.WriteLine("Enter City No");
            city = Console.ReadLine();
            Console.WriteLine("Enter State");
            state = Console.ReadLine(); 
            Console.WriteLine("Enter Pin Code");
            pincode = Console.ReadLine();
        }
    }
    class Student
    {
        int rn;
        string name;
        int marks;
        string batch;
        Address address;
        public void Get() {
            Console.WriteLine("Enter RollNo");
            rn = Convert.ToByte(Console.ReadLine());
            address.GetAddress();
        }
        public void Display() { }
    }
}
