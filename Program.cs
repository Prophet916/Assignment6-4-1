using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are developing a student management system for your school. As part of the system, 
             * you need to implement a functionality that allows you to search for a student's record 
             * based on their student ID. To achieve this, you decide to write a C# program that performs 
             * a linear search on an array of student IDs.
             */

            // Sample student records and IDs (you can replace this with actual data)
            int[] studentIDs = { 1001, 1002, 1003, 1004, 1005 };
            string[] studentNames = { "John", "Alice", "Bob", "Eve", "Michael" };
            int[] studentGrades = { 85, 92, 78, 95, 88 };

            // Prompt user to enter the student ID to search for
            Console.Write("Enter the student ID to search: ");
            int searchID = int.Parse(Console.ReadLine());

            // Perform linear search to find the student record
            int foundIndex = -1;
            for (int i = 0; i < studentIDs.Length; i++)
            {
                if (studentIDs[i] == searchID)
                {
                    foundIndex = i;
                    break;
                }
            }

            // Check if the student record was found or not
            if (foundIndex != -1)
            {
                // Display the student's record
                Console.WriteLine("Student ID: " + studentIDs[foundIndex]);
                Console.WriteLine("Student Name: " + studentNames[foundIndex]);
                Console.WriteLine("Student Grade: " + studentGrades[foundIndex]);
            }
            else
            {
                Console.WriteLine("Student with ID " + searchID + " not found.");
            }
            Console.ReadKey();
        }
    }
}
