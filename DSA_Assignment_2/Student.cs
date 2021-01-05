using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Assignment_2
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string studentNumber;
        public double averageScore;
        public Student(string firstName, string lastName, string studentNumber, double averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;
        }
        public override string ToString()
        {
            string sentence = firstName + " " + lastName + " student number is " + studentNumber + " and his/her average score is " + averageScore;
            return sentence;
        }
    }
}
