using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_Stas_A_Level
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FIO { get; set; }
    }
    public class Student : Person
    {
        public string Gruppa { set; get; }
    }
    public class Prepod : Person
    {
        public string Predmet { set; get; }
    }
    class Program
    {
        static void Main()
        {

            foreach (Person person in new List<Person>
            {
                new Student
                {
                    Age = int.Parse(Console.ReadLine()),
                    FIO = Console.ReadLine(),
                    Gruppa = Console.ReadLine()
                },

                new Prepod
                {
                    Age = int.Parse(Console.ReadLine()),
                    FIO = Console.ReadLine(),
                    Predmet = Console.ReadLine()
                }
            })
            {
                Console.WriteLine("Имя Фамилия: {0}", person.FIO);
                Console.WriteLine("Возраст: {0}", person.Age);
                Console.WriteLine("Id: {0}", person.Id);
                Console.ReadKey();
            }
        }
    }
}
