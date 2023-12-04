using System.Text.RegularExpressions;

namespace AdventOfCode2023.Days
{
	public class Day01 : IDay
	{
		public string SolvePart1(string[] input)
		{
			int[] numbers = new int[input.Length];

			for (int i = 0; i < input.Length; i++)
			{
				int d1 = 0;
				int d2 = 0;
				for (var j = 0; j < input[i].Length; j++)
				{
					if (int.TryParse(input[i][j].ToString(), out d1))
					{
						break;
					}
				}

				for (var j = input[i].Length - 1; j >= 0; j--)
				{
					if (int.TryParse(input[i][j].ToString(), out d2))
					{
						break;
					}
				}

				numbers[i] = d1 * 10 + d2;
			}

			var result = numbers.Sum(x => x);

			return result.ToString();
		}

		public string SolvePart2(string[] input)
		{
			var numbers = new List<int>();
			var pattern = @"(?=(\d|one|two|three|four|five|six|seven|eight|nine))";
			var regex = new Regex(pattern);

			foreach (var line in input)
			{
				var matches = regex.Matches(line);

				var d1 = GetDigit(matches.First().Groups[1].ToString());
				var d2 = GetDigit(matches.Last().Groups[1].ToString());
				numbers.Add(int.Parse(d1 + d2));
			}

			var result = numbers.Sum(x => x);
			return result.ToString();
		}

		private static string GetDigit(string input)
		{
			return input switch
			{
				"one" => "1",
				"two" => "2",
				"three" => "3",
				"four" => "4",
				"five" => "5",
				"six" => "6",
				"seven" => "7",
				"eight" => "8",
				"nine" => "9",
				_ => input
			};
		}
	}
}
