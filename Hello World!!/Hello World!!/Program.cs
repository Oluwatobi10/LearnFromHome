using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!"); //this line would give an output of Hello World!!!
            // the next type of comment is the multiple line comment.
            /* i am  oluwatobiloba and 
            i am teaching the buddies how to write multiple lines comments */

            // i am moving to the next topic soon 
            /* the name of the topic is Variables 
            can you that it has changed??? */

            /* C# variables,
            int: stores intergers (whole numbers) without decimals. 44, -2
            double: stores floating point numbers such as decimals. 14.22 -222.99
            char: store a single character such a or B. 'a' or 'B'
            string: stores text in double quotes e.g "Hello World!!!" , " Justus just arrived"
            bool: stores values with two states..... true or false
                 
                how to declare your varibles
                    type variablename = value; */

            // i want to declare my variable
            
            int var1 = 225;
            double stat = 88.999;
            char xyz = 'G';
            string name = "Goodness";

            // i want to print my variables
            Console.WriteLine(var1);
            
            Console.WriteLine(name);
            Console.WriteLine(xyz); 

             const int myVar = 22;
             Console.WriteLine(myVar); 

            string name = "Goodness";
            Console.WriteLine("Good day " + name); //merging of strings

            string lastname = " Reaction";

            string fullname = name + lastname;
            Console.WriteLine(fullname); 

            //Declaring Multiple variables: you can declare mulptiple variables of the same type, by using a comma to separate them
            int a = 50, b = 30, c = -77;
             Console.WriteLine(a + b + c); 

            // Rules for constructing variable names

            /* 
                1. names can contain letters, digit and the underscore character _
                2. names must begin with a letter
                3. names should start with a lowercase 
                4. it can not contain spaces (whitespaces)
                5. names are case sensitive (e.g name is different from Names)
                6. reserved words can be used as names (e.g int, double etc) */

            // working with operators

            int x = 30, y = 27, z = -12; // declared variables
            int sum = y + z; // addition operation
            int sum1 = y - x; // subtraction
            int sum2 = z * x; // multiplication
            double sum3 = y / z; //division
            int mod = x % y; //modulus
            y++; //increment
            x--; //decrement

            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(mod);
            Console.WriteLine(y);
            Console.WriteLine(x); 

            // Taking Inputs

            // type the username & press the enter key
            Console.WriteLine("ENTER USERNAME: ");

            // Create a string variable to receive and store the user's input
            string userName = Console.ReadLine();

            // i want to print the username back 
            Console.WriteLine("The username is: " + userName);

            Console.ReadKey();
        }
    }
}
