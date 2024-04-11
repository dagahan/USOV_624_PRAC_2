using System;

class Numbers {
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public Numbers(int number1, int number2) {
        Number1 = number1;
        Number2 = number2;
    }

    public void PrintNumbers() {
        Console.WriteLine($"Number 1: {Number1}");
        Console.WriteLine($"Number 2: {Number2}");
    }

    public void UpdateNumbers(int newNumber1, int newNumber2) {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }

    public int Sum() {
        return Number1 + Number2;
    }

    public int Max() {
        return Math.Max(Number1, Number2);
    }

    static void Main(string[] args) {
        Numbers numbers = new Numbers(10, 20);
        numbers.PrintNumbers();
        Console.WriteLine($"Sum: {numbers.Sum()}");
        Console.WriteLine($"Max: {numbers.Max()}");
        numbers.UpdateNumbers(30, 40);
        numbers.PrintNumbers();
    }
}