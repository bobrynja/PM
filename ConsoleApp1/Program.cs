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
        public Person [] array; //массив

        public void Sort(Person [] a)
        {
            Person k;
            for (int j = 0; j < a.Length; j++)
            {
                for (int l=0;l<a.Length;l++)
                    if (string.Compare(array[l].last_name, array[l + 1].last_name) > 0) //сравнение по первому свойству - фамилия
                    {
                        k = array[l];
                        array[l] = array[l + 1];
                        array[l + 1] = k;
                    }
                    else if (string.Compare(array[l].last_name, array[l + 1].last_name) == 0) //сравнение по второму свойству - имя
                    {
                        if (string.Compare(array[l].name, array[l + 1].name) > 0)
                        {
                            k = array[l];
                            array[l] = array[l + 1];
                            array[l + 1] = k;
                        }
                    }

            }
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
