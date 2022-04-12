using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DSA1
{
    class CustomDataBase
    {
        public LinkedList<Student> dataBase;


        public CustomDataBase()
        {
            this.dataBase = new LinkedList<Student>();
        }

        public LinkedList<Student> GetDataBase
        {
            get { return dataBase; }
        }

        public void PopulateWithSampleStudent()
        {
            float[] score1 = { 40, 60, 70, 80 };
            Student student1 = new Student("Rei", "Kasemi", "2117024", score1);
            float[] score2 = { 10, 20, 30, 40 };
            Student student2 = new Student("Dario", "Lulashi", "2117025", score2);
            float[] score3 = { 70, 80, 90, 100 };
            Student student3 = new Student("Murat", "Dedolli", "2117026", score3);
            float[] score4 = { 24, 67, 32, 44 };
            Student student4 = new Student("Erni", "Cullhaj", "2117027", score4);
            dataBase.AddFirst(student1);
            dataBase.AddFirst(student2);
            dataBase.AddFirst(student3);
            dataBase.AddFirst(student4);
        }

        public void Add(Student student)
        {
            dataBase.AddLast(student);
        }

        public void GetElementByIndex(int index)
        {
            Console.WriteLine(dataBase.ElementAt(index).ToString());
        }

        public void RemoveByIndex(int index)
        {
            dataBase.Remove(dataBase.ElementAt(index));
        }

        public void RemoveFirst()
        {
            dataBase.RemoveFirst();
        }
        public void RemoveLast()
        {
            dataBase.RemoveLast();
        }

        public void DisplayList()
        {
            if (dataBase.Count != 0)
            {
                Console.WriteLine("These are the differents informations about your student :");
                Console.WriteLine();
                foreach (var student in dataBase)
                {
                    Console.WriteLine(student.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no student in the list ");
            }
        }
    }
}
