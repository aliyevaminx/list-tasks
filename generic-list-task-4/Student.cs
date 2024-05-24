namespace generic_list_task_4
{
    internal class Student
    {
        private string name;
        private string surname;
        private int age;
        private string pin;
        

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Pin { get; set; }

        public Student(string name, string surname, int age, string pin)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Pin = pin;
        }
    }
}
