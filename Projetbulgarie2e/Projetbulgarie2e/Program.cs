﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace projetbulgarie
{

    public class Student
    {
        public string firstname;
        public string lastname;
        public string studentnumber;
        public float averagescore;

        
        public string Firstnname
        {
            get { return firstname; }
        }

        public string Lastname
        {
            get { return lastname; }
        }

        public string Studentnumber
        {
            get { return studentnumber; }
        }

        public float Averagescore
        {
            get { return averagescore; }
        }


        public Student(string firstname, string lastname, string studentnumber, float averagescore) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.studentnumber = studentnumber;
            this.averagescore = averagescore;
        }

        public override string ToString()

        {
            return "Student number: " + studentnumber + ", Fullname : " + firstname + " " + lastname + ", Average score: " + averagescore + "\n";
        }

    }
     public class NewDataList
    {
        private LinkedList<Student> mydatalist;

        public NewDataList()
        {
            this.mydatalist = new LinkedList<Student>();
        }

        public LinkedList<Student> GetDatalist
        {
            get { return mydatalist; }
        }
        public void PopulateWithSampleStudent()
        {
            Student studentA = new Student("Alice", "Dubois", "735GTE76", 78);
            Student studentB = new Student("Alex", "Bordas", "735YTY65", 54);
            Student studentC = new Student("Aymeric", "Nativel", "735MLK02", 60);
            Student studentD = new Student("Hippo", "Guesdon", "735IEV24", 99);
            Student studentE = new Student("Thomas", "Mouly", "735LKE98", 37);
            Student studentF = new Student("Nico", "Vander", "735FEK02", 86);
            Student studentG = new Student("Mina", "Guesdon", "735IZV24", 100);
             
            mydatalist.AddLast(studentA);
            mydatalist.AddLast(studentB);
            mydatalist.AddLast(studentC);
            mydatalist.AddLast(studentD);
            mydatalist.AddLast(studentE);
            mydatalist.AddLast(studentF);
            mydatalist.AddLast(studentG);
        }
        public void AddStudent(Student student)
        {
            mydatalist.AddLast(student);
        }

        public void GetElementByIndex(int index)
        {
            Console.WriteLine(mydatalist.ElementAt(index));
        }
        public void RemoveElementByIndex(int index)
        {
            mydatalist.Remove(mydatalist.ElementAt(index));
        }
        public void RemoveFirst()
        {
            mydatalist.RemoveFirst();
        }
        public void RemoveLast()
        {
            mydatalist.RemoveLast();
        }

        public void DisplayList()
        {
            if (mydatalist.Count != 0)
            {
                Console.WriteLine("ALl the information about your students : \n");
                foreach (var student in mydatalist)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no student in the list ");
            }
        }
        public float Bestscore()
        {
            int p = 0;
            float bestscore = 0;
            for (int i = 0; i < mydatalist.Count; i++)
            {
                if (mydatalist.ElementAt(i).averagescore > bestscore)
                {
                    bestscore = mydatalist.ElementAt(i).averagescore;
                    p = i;
                }
            }
            return p;
        }
        public float Worstscore()
        {
            int p = 0;
            float worstscore = 100;
            for (int i = 0; i < mydatalist.Count; i++)
            {
                if (mydatalist.ElementAt(i).averagescore < worstscore)
                {
                    worstscore = mydatalist.ElementAt(i).averagescore;
                    p = i;
                }
            }
            return p;
        }
        public void Sort(string direction, string field)
        {
            if (field == "average")
            {
                if (direction == "increasing")
                {
                    IEnumerable<Student> query = mydatalist.OrderBy(Student => Student.averagescore);
                    foreach (Student item in query)
                    {
                        Console.WriteLine(item);
                    }
                }
                if (direction == "decreasing")
                {
                    IEnumerable<Student> query = mydatalist.OrderByDescending(Student => Student.averagescore);
                    foreach (Student item in query)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            if (field == "lastname")
            {
                if (direction == "increasing")
                {
                    IEnumerable<Student> query = mydatalist.OrderBy(Student => Student.lastname);
                    foreach (Student item in query)
                    {
                        Console.WriteLine(item);
                    }
                }
                if (direction == "decreasing")
                {
                    IEnumerable<Student> query = mydatalist.OrderByDescending(Student => Student.lastname);
                    foreach (Student item in query)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            if (field == "firstname")
            {
                if (direction == "increasing")
                {
                    IEnumerable<Student> query = mydatalist.OrderBy(Student => Student.firstname);
                    foreach (Student item in query)
                    {
                        Console.WriteLine(item);
                    }
                }
                if (direction == "decreasing")
                {
                    IEnumerable<Student> query = mydatalist.OrderByDescending(Student => Student.firstname);
                    foreach (Student item in query)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
    public class Program
    {
        static bool Estceunnombre(string nombre)
        {
            bool nbr = false;
            
            for (int i = 0; i < nombre.Length; i++)
            {
                if (char.IsNumber(Convert.ToChar(nombre[i])) || nombre[i] == '-' || nombre[i] == ',')
                    nbr = true;
                else
                {
                    nbr = false;
                    break;
                }
            }
            return nbr;
        }

        static int VoilaUnNombre(string nombre)
        {
            while (Estceunnombre(nombre) == false)
            {
                Console.WriteLine("This is not a number ");
                nombre = Console.ReadLine();
            }
            return Convert.ToInt32(nombre);
        }
        private static void Display(List<Student> student)
        {
            foreach (Student word in student)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            NewDataList mydatalist = new NewDataList();
            bool boucle = false;
            while (boucle == false)
            {
                /*Console.WriteLine("=================================================");
                Console.WriteLine("SELECT AN ACTION ");
                Console.WriteLine("1: Populate with Sample Data ");
                Console.WriteLine("2: Lenght of the Student Data List ");
                Console.WriteLine("3: Get the first student of the Data List ");
                Console.WriteLine("4: Get the last student of the Data List ");
                Console.WriteLine("5: Get the x's element of the Data List (enter x) ");
                Console.WriteLine("6: Add an element ");
                Console.WriteLine("7: Remove by index ");
                Console.WriteLine("8: Remove first element ");
                Console.WriteLine("9: Remove last element ");
                Console.WriteLine("10: Display the list ");
                Console.WriteLine("=================================================");
                */
                Console.WriteLine("=================================================");
                Console.WriteLine("Assignment 2 ");
                Console.WriteLine("1: Populate with Sample Data ");
                Console.WriteLine("11: Who has the best score? ");
                Console.WriteLine("12: who has the lowest score? ");
                Console.WriteLine("13: Sort by ");
                Console.WriteLine("=================================================");
                Console.WriteLine("14: QUIT THE PROGRAM ");

                Console.WriteLine();


                int switchcase2 = VoilaUnNombre(Console.ReadLine());
                switch (switchcase2)
                {
                    case 1:
                        mydatalist.PopulateWithSampleStudent();
                        Console.WriteLine("Students added sccesfully");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("They are " + mydatalist.GetDatalist.Count() + " students in the list. ");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 3:
                        mydatalist.GetElementByIndex(0);
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 4:
                        mydatalist.GetElementByIndex(mydatalist.GetDatalist.Count());
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 5:
                        mydatalist.GetElementByIndex(VoilaUnNombre(Console.ReadLine()));
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("What is his firstname?");
                        string fn = Console.ReadLine();
                        Console.WriteLine("What is his lastname?");
                        string ln = Console.ReadLine();
                        Console.WriteLine("What is his student number?");
                        string sn = Console.ReadLine();
                        Console.WriteLine("What is his average score?");
                        float a = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student(fn, ln, sn, a);
                        mydatalist.AddStudent(student);
                        Console.WriteLine("Student added sccesfully");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("What is the index of the student you want to remove?");
                        mydatalist.RemoveElementByIndex(VoilaUnNombre(Console.ReadLine()));
                        Console.WriteLine("Student removed sccesfully");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 8:
                        mydatalist.RemoveElementByIndex(0);
                        Console.WriteLine("First student removed sccesfully");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 9:
                        mydatalist.RemoveElementByIndex(mydatalist.GetDatalist.Count());
                        Console.WriteLine("Last student removed sccesfully");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 10:
                        mydatalist.DisplayList();
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 11:
                        int g = Convert.ToInt32(mydatalist.Bestscore());
                        Console.WriteLine("The student with the best score is :");
                        mydatalist.GetElementByIndex(g);
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 12:
                        int h = Convert.ToInt32(mydatalist.Worstscore());
                        Console.WriteLine("The student with the worst score is :");
                        mydatalist.GetElementByIndex(h);
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;
                    case 13:
                        
                        Console.WriteLine("You want to sort by: firstname, lastname or average ?");
                        string field = Console.ReadLine();
                        Console.WriteLine("You want to sort by: increasing or decreasing ?");
                        string direction = Console.ReadLine();
                        mydatalist.Sort(direction, field);
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        break;


                    default:
                        boucle = true;
                        break;
                }
            }
        }
    }
}

