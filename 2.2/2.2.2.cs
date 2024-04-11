using System;

class Train {
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }

    public Train(string destination, int trainNumber, DateTime departureTime) {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    public void PrintInfo() {
        Console.WriteLine($"Destination: {Destination}");
        Console.WriteLine($"Train Number: {TrainNumber}");
        Console.WriteLine($"Departure Time: {DepartureTime.ToShortTimeString()}");
    }

    static void Main(string[] args) {
        Train train = new Train("City A", 123, new DateTime(2024, 4, 8, 10, 30, 0));
        train.PrintInfo();
    }
}