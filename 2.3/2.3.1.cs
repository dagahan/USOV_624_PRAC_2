using System;

class Worker {
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public Worker(string name, string surname, double rate, int days) {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }

    public double GetSalary() {
        return Rate * Days;
    }

    static void Main(string[] args) {
        Worker worker = new Worker("John", "Doe", 20.5, 25);
        Console.WriteLine($"Salary: {worker.GetSalary()}");
    }
}