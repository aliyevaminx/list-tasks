using generic_list_task_4;
using System.Reflection.PortableExecutable;

public static class Program
{
    public static void Main(string[] args)
    {
        Course course = new Course();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Remove a student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Search for a student");
            Console.WriteLine("5. Count total students");
            Console.WriteLine("6. Count total students above 18");
            Console.WriteLine("7. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Enter student name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter student surname: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter student age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter student PIN: ");
                    string pin = Console.ReadLine();

                    Student student = new Student(name, surname, age, pin);
                    course.AddStudent(student);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter student PIN to remove: ");
                    pin = Console.ReadLine();
                    course.RemoveStudent(pin);
                    break;
                case "3":
                    Console.WriteLine();
                    course.DisplayAllStudents();
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Enter the student PIN: ");
                    pin = Console.ReadLine();
                    course.SearchStudent(pin);
                    break;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine($"Total students: {course.CountStudents()}");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine($"Total students above 18: {course.CountStudentsAboveAge()}");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Choose right option");
                    break;
            }
        }
    }
}