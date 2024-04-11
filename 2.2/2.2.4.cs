using System;

class Counter {
    private int _value;

    public int Value {
        get { return _value; }
    }

    public Counter() {
        _value = 0;
    }

    public Counter(int initialValue) {
        _value = initialValue;
    }

    public void Increment() {
        _value++;
    }

    public void Decrement() {
        _value--;
    }

    static void Main(string[] args) {
        Counter counter = new Counter(5);
        Console.WriteLine($"Initial value: {counter.Value}");
        counter.Increment();
        Console.WriteLine($"After increment: {counter.Value}");
        counter.Decrement();
        Console.WriteLine($"After decrement: {counter.Value}");
    }
}