using System;
using System.IO;

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

        public void Sort()
        {
            Person k;
            for (int j = 0; j < array.Length-1; j++)
            {
                for (int l=0;l< array.Length-1;l++)
                    if (string.Compare(array[l].last_name, array[l + 1].last_name) > 0) //сравнение по первому свойству - фамилия
                    {
                        //Console.WriteLine(array[l].last_name);
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
            Console.ReadKey();
        }
        public void Save()
        {
            StreamWriter sw = new StreamWriter("Person_list.txt");
            foreach (var i in array)
            {
                sw.WriteLine(i.last_name+" "+i.name+" "+i.age);

            }
            sw.Close();
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
                Console.WriteLine($"Ввод {j} элемента: ");
                Console.WriteLine("Введите фамилию: ");
                now.last_name = Console.ReadLine();
                Console.WriteLine("Введите имя: ");
                now.name = Console.ReadLine();
                Console.WriteLine("Введите возраст: ");
                now.age = Console.ReadLine();
                ar.array[j] = now;


            }
            ar.Sort();
            ar.Save();

        }
    }
}
