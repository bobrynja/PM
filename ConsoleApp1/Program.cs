using System;

namespace ConsoleApp1
{
    class Person
    {
        public string last_name;
        public string name;
        public string age;
    }

    class HR
    {
        public Person [] array;

        public void Sort(Person [] a)
        {
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person now;
            string last_name, name, age;
            HR ar = new HR(); 
            Console.WriteLine("Введите количество элементов массива: ");
            int i = Convert.ToInt32(Console.ReadLine());
            ar.array = new Person[i];
            for(int j = 0; j < i; j++)
            {
                now = new Person();
                Console.WriteLine($"Ввод {i} элемента: ");
                Console.WriteLine("Введите фамилию: ");
                now.last_name = Console.ReadLine();
                Console.WriteLine("Введите имя: ");
                now.name = Console.ReadLine();
                Console.WriteLine("Введите возраст: ");
                now.age = Console.ReadLine();
                ar.array[j] = now;


            }

        }
    }
}
