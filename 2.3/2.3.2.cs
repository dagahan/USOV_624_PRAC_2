using System;

class Worker {
    private string _name;
    private string _surname;
    private double _rate;
    private int _days;

    public Worker(string name, string surname, double rate, int days) {
        _name = name;
        _surname = surname;
        _rate = rate;
        _days = days;
    }

    public string GetName() {
        return _name;
    }

    public string GetSurname() {
        return _surname;
    }

    public double GetRate() {
        return _rate;
    }

    public int GetDays() {
        return _days;
    }

    public double GetSalary() {
        return _rate * _days;
    }

    static void Main(string[] args) {
        Worker worker = new Worker("John", "Doe", 20.5, 25);
        Console.WriteLine($"Salary: {worker.GetSalary()}");
    }
}