using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern");
            Console.Write("Enter Your Object type :- "); //print message
            string type = Console.ReadLine();    //take input
            I1 obj=CreateObj.getobject(type); //call method getboject and pass type
            Console.WriteLine(obj.GetName());
            Console.ReadLine();
        }
    }
    class CreateObj  //factory calss CreateObj
    {
        //method to return interface I1
        public static I1 getobject(string typeofobj) //getobj = return a Teacher or Student class object return  //typeofobj = veriable
        {
            // method to return interface
            I1 obj = null; //  initilise interface
            if (typeofobj.ToLower() == "student")
            {
                obj = new Student(); //initilize Student class
            }
            else
            {
                obj = new Teacher(); //initilize Teacher class
            }
            return obj;
        }
    }
    interface I1  //create interface I1
    {
        //Declaring Methods
        string GetName();
        string GetLastName();
    }
    class Teacher : I1  // Inherit I1 interface
    {
        public string GetName()  //Getname method
        {
            return "Dipesh";
        }
        public string GetLastName() //GetLastName method
        {
            return "XYZ";
        }
    }
    class Student : I1 // Inherit I1 interface
    {
        public string GetName()  //Getname method
        {
            return "Omprakash";
        }
        public string GetLastName() //GetLastName method
        {
            return "Khawshi";
        }
    }
}
