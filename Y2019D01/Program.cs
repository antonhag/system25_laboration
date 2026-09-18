// See https://aka.ms/new-console-template for more information

using AdventOfCode.Common;
using Y2019D01;

Console.WriteLine("Hello, World!");

var fuelCalculator = new FuelCalculator();

var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
var text = File.ReadAllText(path);

fuelCalculator.CalculateAdvancedFuel(1969);

var massValues = Input.Numbers(text);

Console.WriteLine($"The fuel requirement for all the modules are: {fuelCalculator.CalculateTotalFuel(massValues)}");

fuelCalculator.CalculateAdvancedFuel(1969);