using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12___Inheritance {
    class Program {
        static void Main(string[] args) {

        }
    }
    class Person {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson() {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    class Student : Person {
        private int[] testScores;
        public Student() { }
        public Student(string firstName, string lastName, int identification, int[] scores) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores = scores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate() {
            double average = 0;
            for (int i = 0; i < testScores.Length; i++){
                average += testScores[i];
            }
            average = average / testScores.Length;
            if (average >= 90) {
                return 'O';
            }
            else if (average >= 80) {
                return 'E';
            }
            else if (average >= 70) {
                return 'A';
            }
            else if (average >= 55) {
                return 'P';
            }
            else if (average >= 40) {
                return 'D';
            }
            else {
                return 'T';
            }
        }
    }
}
