
using AdventOfCode2023.Days;

Console.WriteLine("Advent of Code 2023");

string date = "01";

IDay day;
string[] input;

try
{
	day = new Day01();
	input = File.ReadAllLines($"Inputs\\Input{date}.txt");
}
catch (Exception ex)
{
	Console.WriteLine("Problem initilizing day");
	Console.WriteLine(ex.Message);
	return;
}

try
{
	Console.WriteLine("Part 1:");
	Console.WriteLine(day.SolvePart1(input));
}
catch (Exception ex)
{
	Console.WriteLine("Could not solve part 1");
	Console.WriteLine(ex.Message);
}

try
{
	Console.WriteLine("Part 2:");
	Console.WriteLine(day.SolvePart2(input));

}
catch (Exception ex)
{
	Console.WriteLine("Could not solve part 2");
	Console.WriteLine(ex.Message);
}
