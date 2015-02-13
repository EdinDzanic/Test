using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSourceControl
{
    class Program
    {

        static void HelloWorld(string stringMessage)
        {
            Console.WriteLine(stringMessage);
            Console.ReadLine();  
        }
        
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
	    string newHello = "New Hello World!";	
            HelloWorld(helloWorld);
	    HelloWordl(newHello);	            
        }
    }
}
