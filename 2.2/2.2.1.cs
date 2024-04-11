using System;

class Student {
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public Student(string lastName, DateTime dateOfBirth, string groupNumber, int[] grades) {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public void PrintInfo() {
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Group Number: {GroupNumber}");
        Console.WriteLine($"Grades: [{string.Join(", ", Grades)}]");
    }

    static void Main(string[] args) {
        int[] grades = { 90, 85, 95, 88, 92 };
        Student student = new Student("Smith", new DateTime(2000, 5, 10), "Group A", grades);
        student.PrintInfo();
    }
}