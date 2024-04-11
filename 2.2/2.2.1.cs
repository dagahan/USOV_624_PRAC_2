using System;

class Student
{
    public string Surname { get; set; }
    public string DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public void ChangeLastName(string newLastName)
    {
        Surname = newLastName;
    }

    public void ChangeBirthDate(string newBirthDate)
    {
        DateOfBirth = newBirthDate;
    }

    public void ChangeGroupNumber(string newGroupNumber)
    {
        GroupNumber = newGroupNumber;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student: {Surname}");
        Console.WriteLine($"Date of Birth: {DateOfBirth}");
        Console.WriteLine($"Group Number: {GroupNumber}");
        Console.WriteLine("Grades:");
        for (int i = 0; i < Grades.Length; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {Grades[i]}");
        }
    }

    static void Main()
    {
        int[] grades = { 5, 4, 3, 5, 4 }; //оценки
        
        //добавляю нового студента
        Student student1 = new Student
        {
            Surname = "Usov",
            DateOfBirth = "27.07.2006",
            GroupNumber = "GR_624",
            Grades = grades
        };
        
        student1.PrintStudentInfo(); //вывод данных о студенте
        
        //измена данных
        student1.ChangeLastName("Menshikov");
        student1.ChangeBirthDate("13.02.2005");
        student1.ChangeGroupNumber("GR_611");
        
        student1.PrintStudentInfo();
    }
}