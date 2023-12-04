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

			var reslut = numbers.Sum(x => x);

			return reslut.ToString();
		}

		public string SolvePart2(string[] input)
		{
			throw new NotImplementedException();



		}
	}
}
