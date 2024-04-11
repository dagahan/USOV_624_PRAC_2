using System;

class Calculation {
    private string _calculationLine;

    public Calculation(string calculationLine) {
        _calculationLine = calculationLine;
    }

    public void SetCalculationLine(string newLine) {
        _calculationLine = newLine;
    }

    public void SetLastSymbolCalculationLine(char symbol) {
        _calculationLine += symbol;
    }

    public string GetCalculationLine() {
        return _calculationLine;
    }

    public char GetLastSymbol() {
        if (!string.IsNullOrEmpty(_calculationLine))
            return _calculationLine[_calculationLine.Length - 1];
        else
            return '\0';
    }

    public void DeleteLastSymbol() {
        if (!string.IsNullOrEmpty(_calculationLine))
            _calculationLine = _calculationLine.Remove(_calculationLine.Length - 1);
    }

    static void Main(string[] args) {
        Calculation calculation = new Calculation("2 + 3 * 5");
        Console.WriteLine($"Calculation Line: {calculation.GetCalculationLine()}");
        Console.WriteLine($"Last Symbol: {calculation.GetLastSymbol()}");

        calculation.DeleteLastSymbol();
        Console.WriteLine($"Calculation Line after deleting last symbol: {calculation.GetCalculationLine()}");

        calculation.SetLastSymbolCalculationLine('+');
        Console.WriteLine($"Calculation Line after adding '+': {calculation.GetCalculationLine()}");
    }
}