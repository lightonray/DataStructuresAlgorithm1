﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDataBase dataBase = new CustomDataBase();
            int answer;
            bool escape = false;
            while (escape == false)
            {
                if (dataBase.GetDataBase.Count() != 0)
                {
                    Console.WriteLine("Student list :");
                    Console.WriteLine();
                    int count = 0;
                    foreach (var student in dataBase.GetDataBase)
                    {
                        Console.WriteLine(count + ": " + student.GetFullName);
                        count++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("There is no student in the list ");
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine();
                Console.WriteLine("Tape 1 to POPULATE with sample students");
                Console.WriteLine("Tape 2 to ADD a student");
                Console.WriteLine("Tape 3 to SEARCH and DISPLAY some informations of a student");
                Console.WriteLine("Tape 4 to REMOVE a student by index");
                Console.WriteLine("Tape 5 to REMOVE the first student in the list");
                Console.WriteLine("Tape 6 to REMOVE the last student in the list");
                Console.WriteLine("Tape 7 to DISPLAY all the informations of all your students");
                Console.WriteLine("Tape 0 to STOP the program");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine();
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (answer)
                {
                    case 1: dataBase.PopulateWithSampleStudent(); break;
                    case 2:
                        {
                            Console.WriteLine("First name :");
                            string firstName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Last name :");
                            string lastName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Student number :");
                            string studentNumber = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("How many scores will you enter ?");
                            int numberOfScores = Convert.ToInt32(Console.ReadLine());
                            float[] studentScores = new float[numberOfScores];
                            Console.WriteLine("Enter all the scores pushing enter between all of them ");
                            for (int i = 0; i < numberOfScores; i++)
                            {
                                int score = Convert.ToInt32(Console.ReadLine());
                                studentScores[i] = score;
                            }
                            Student student = new Student(firstName, lastName, studentNumber, studentScores);
                            dataBase.Add(student);
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Give me the index to display some informations about a specific student ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            dataBase.GetElementByIndex(index);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Give me the index to remove a specific student ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            dataBase.RemoveByIndex(index);
                        }
                        ; break;
                    case 5:
                        {
                            dataBase.RemoveFirst();
                        }
                        ; break;
                    case 6:
                        {
                            dataBase.RemoveLast();
                        }
                        ; break;
                    case 7:
                        {
                            dataBase.DisplayList();
                        }
                        ; break;
                    case 0: escape = true; break;
                }
                Console.WriteLine();
            }
        }
    }
}
