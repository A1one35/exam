using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TEST
{
    struct Student
    {
    public string surName;
    public string firstName;
    public string patronymic;
    public string dataOfBirth;
    public int age;
    public string city;

        public Student(string lineWithAllData)
        {
            string[] lineWithDataAboutOneStudent = lineWithAllData.Split(' ');
            this.surName = lineWithDataAboutOneStudent[0];
            this.firstName = lineWithDataAboutOneStudent[1];
            this.patronymic = lineWithDataAboutOneStudent[2];
            this.dataOfBirth = lineWithDataAboutOneStudent[3];
            this.age = Convert.ToInt32(lineWithDataAboutOneStudent[4]);
            this.city = lineWithDataAboutOneStudent[5];
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            string path = @"input.txt";
            Student[] students = ReadData(path);
            Console.WriteLine("Середній вік студентів = " + average(students).ToString());
            runMenu(students);
            Console.ReadKey();
        }
        static double average(Student[] students)
        {

            double sum = 0;
            for (int i = 0; i < students.Length; i++)
                sum += students[i].age;
            return sum / 8;
        }

        static void runMenu(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].age == 16)
                {
                    Console.WriteLine(students[i].surName + " " + students[i].city);
                }
                else if (students[i].city != "Cherkasy")
                {
                    Console.WriteLine(students[i].surName + " " + students[i].city);
                }
            }
        }
        static Student[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            Student[] ArrayOfStudent = new Student[pathForFile.Length];
            for (int i = 0; i < pathForFile.Length; i++)
            {
                ArrayOfStudent[i] = new Student(pathForFile[i]);
            }
            return ArrayOfStudent;
        }
    }
}
