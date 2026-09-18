// See https://aka.ms/new-console-template for more information

using Y2015D01Console;

Console.WriteLine("Hello, World!");

var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
var text = File.ReadAllText(path);
var floorFinder = new FloorFinder();

Console.WriteLine($"The instructions takes santa to floor: {floorFinder.FindCorrectFloor(text)}");

var pathTwo = Path.Combine(AppContext.BaseDirectory, "inputTwo.txt");
var textTwo = File.ReadAllText(pathTwo);
Console.WriteLine($"Santa enters basement floor at position: {floorFinder.FindBasementFloor(textTwo)}");
