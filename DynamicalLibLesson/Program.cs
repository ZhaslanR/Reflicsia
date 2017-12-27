using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicalLibLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Users\РыспековЖ\source\repos\Reflection");

            Type type = assembly.GetType("reFleCtiOn.seRviCe",true,true);

            MethodInfo methodInfo = type.GetMethod("DestroyWorld");

            object service = Activator.CreateInstance(type);

            var result = methodInfo.Invoke(service, new object[] { "Мир будет уничтожен через ", 15 });

            Console.ReadLine();
        }
    }
}
