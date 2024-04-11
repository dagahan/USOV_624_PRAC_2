using System;

class MyClass {
    private string _property1;
    private int _property2;

    //эт конструктор с входными параметрами
    public MyClass(string property1, int property2) 
    {
        _property1 = property1;
        _property2 = property2;
    }
    
    public MyClass() 
    {
        _property1 = "Default";
        _property2 = 0;
    }
    
    ~MyClass() {
        Console.WriteLine("Object deleted!");
    }
    
    public void PrintProperties() 
    {
        Console.WriteLine($"Property 1: {_property1}");
        Console.WriteLine($"Property 2: {_property2}");
    }

    static void Main(string[] args) 
    { //здесь происходит создание обьекта с использованнием конструктора со входными параметрами
        MyClass myObject1 = new MyClass("Test", 10);
        Console.WriteLine("Object 1:");
        myObject1.PrintProperties();

        //Создание объекта с использованием конструкторнра по умолчанию
        MyClass myObject2 = new MyClass();
        Console.WriteLine("\nObject 2 (default):");
        myObject2.PrintProperties();
    }
}