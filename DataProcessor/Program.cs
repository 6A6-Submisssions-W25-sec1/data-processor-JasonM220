﻿using DataProcessor.Library;

namespace DataProcessor;

class Program
{
    static async void Main(string[] args)
    {
        var records = await ProcessData();

        Console.WriteLine($"Successfully processed {records.Count()} records");
        foreach (var person in records)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static async Task<IReadOnlyCollection<Person>> ProcessData()
    {
        var loader = new DataLoader();
        IReadOnlyCollection<string> data = loader.LoadData();

        var logger = new FileLogger();
        var parser = new DataParser(logger);
        var records = await parser.ParseData(data);
        return records;
    }
}