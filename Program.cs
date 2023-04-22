using homework2;

Console.WriteLine("Task 1");
Console.Write("Input a string: ");
string text = Console.ReadLine();
var textProcessor = new TextProcessor(text);
Console.WriteLine("The input text: " + textProcessor);
Console.WriteLine("Digits sum: " + textProcessor.FindDigitsSum());
Console.WriteLine("Max digit: " + textProcessor.FindMaxValue() + Environment.NewLine);

Console.WriteLine("Task 2");
Console.WriteLine("Index of max (not concerning whitespaces): " + textProcessor.FindMaxIndex() + Environment.NewLine);

Console.WriteLine("Task 3");
Console.Write("Enter the possible MIN pages count in a book: ");
UInt32.TryParse(Console.ReadLine(), out uint minB);
Console.Write("Enter the possible MAX pages count in a book: ");
UInt32.TryParse(Console.ReadLine(), out uint maxB);
try
{
    var bookStorage = new BookStorage(minB, maxB);
    Console.WriteLine("Max page count in a randomly generated array: " + bookStorage.FindMaxValue() 
        + Environment.NewLine);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message + Environment.NewLine);
}

Console.WriteLine("Task 4");
Console.Write("Enter the possible MIN speed of a car: ");
UInt32.TryParse(Console.ReadLine(), out uint minC);
Console.Write("Enter the possible MAX speed of a car: ");
UInt32.TryParse(Console.ReadLine(), out uint maxC);
try
{
    var carSpeeds = new SpeedProcessor(minC, maxC);
    Console.WriteLine("Fastest car index (first entry): " + carSpeeds.FindFastestCarIndex());
    Console.WriteLine("Fastest car index (last entry): " + carSpeeds.FindLastFastestCarIndex()
        + Environment.NewLine);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message + Environment.NewLine);
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message + Environment.NewLine);
}
