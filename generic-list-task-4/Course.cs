
namespace generic_list_task_4
{
    internal class Course
    {
        private List<Student> students = new List<Student>();



        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
                students.Add(student);
            else
                Console.WriteLine($"Student with PIN ({student.Pin}) already exists");

        }

        public void RemoveStudent(string pin)
        {
            var student = students.FirstOrDefault(s => s.Pin == pin);
            if (student != null)
            {
                students.Remove(student);

            }
            else
                Console.WriteLine($"Student PIN ({pin}) doesn't exist");

        }

        public void DisplayAllStudents()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}.Student: {students[i].Name} {students[i].Surname} {students[i].Age} {students[i].Pin}");
            }
        }

        public void SearchStudent(string pin)
        {
           Student student = students.FirstOrDefault(s => s.Pin == pin);

            if (student != null)
                Console.WriteLine($"Student with {pin}: {student.Name} {student.Surname} {student.Age} {student.Pin}");
            else
                Console.WriteLine("Student not found");

        }
        public int CountStudents() => students.Count;
        public int CountStudentsAboveAge() => students.Count(s => s.Age > 18);
    }
}
