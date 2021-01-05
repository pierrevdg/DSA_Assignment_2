using System;
using System.Collections.Generic;

namespace DSA_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            CustomDataList List = new CustomDataList(studentList);
            Student student1 = new Student("John", "Smith", "209", 11.2);
            Student student2 = new Student("Micheal", "Johnson", "304", 7.2);
            Student student3 = new Student("Matthew", "Williams", "182", 13.89);
            Student student4 = new Student("David", "Brown", "117", 17.1);
            Student student5 = new Student("James", "Jones", "078", 14.6);
            List.Add(student1);
            List.Add(student2);
            List.Add(student3);
            List.Add(student4);
            List.Add(student5);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Get an element");
                Console.WriteLine("3. Remove an item");
                Console.WriteLine("4. List all items");
                Console.WriteLine("5. Get the best student");
                Console.WriteLine("6. Get the worst student");
                Console.WriteLine("7. Sort the list");
                Console.WriteLine("8. Exit");
                string result = Console.ReadLine();
                switch (result)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("First name : ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Last name : ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Student number : ");
                        string studentNumber = Console.ReadLine();
                        Console.WriteLine("Average score : ");
                        double averageScore = Convert.ToDouble(Console.ReadLine());
                        Student newStudent = new Student(firstName, lastName, studentNumber, averageScore);
                        List.Add(newStudent);
                        Console.WriteLine();
                        Console.WriteLine("Item successfully added");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Please enter an index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        while (index < 0 || index >= List.length)
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter an valid index");
                            index = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Clear();
                        List.GetElement(index);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("What do you want to remove ?");
                        Console.WriteLine("1. Remove with an index");
                        Console.WriteLine("2. Remove the first item");
                        Console.WriteLine("3. Remove the last item");
                        Console.WriteLine("4. Return to the main menu");
                        string newResult = Console.ReadLine();
                        switch (newResult)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Please enter an index");
                                int index1 = Convert.ToInt32(Console.ReadLine());
                                while (index1 < 0 || index1 >= List.length)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter an valid index");
                                    index1 = Convert.ToInt32(Console.ReadLine());
                                }
                                List.RemoveByIndex(index1);
                                Console.Clear();
                                Console.WriteLine("Item successfully deleted");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.Clear();
                                List.RemoveFirst();
                                Console.WriteLine("First item successfully deleted");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "3":
                                Console.Clear();
                                List.RemoveLast();
                                Console.WriteLine("Last item successfully deleted");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "4":
                                break;
                        }
                        break;

                    case "4":
                        Console.Clear();
                        List.DisplayList();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        List.GetMaxElement();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.Clear();
                        List.GetMinElement();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("How to sort the list ? ");
                        Console.WriteLine("1. Sort in ascending order");
                        Console.WriteLine("2. Sort in descending order");
                        Console.WriteLine("3. Sort by alphabetical order for the first name");
                        Console.WriteLine("4. Sort by alphabetical order for the last name");
                        Console.WriteLine("5. Return to the main menu");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "1":
                                Console.Clear();
                                List.SortByAscendingOrder();
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.Clear();
                                List.SortByDescendingOrder();
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "3":
                                Console.Clear();
                                List.SortByAlphabeticalOrderFirstName();
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "4":
                                Console.Clear();
                                List.SortByAlphabeticalOrderLastName();
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "5":
                                break;
                        }
                        break;

                    case "8":
                        return;
                }
            }
        }
    }
}
