
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

int minValue = nums.Min();

Console.WriteLine(minValue);

int maxValue = nums.Max();

Console.WriteLine(maxValue);

IEnumerable <int> maxValue2 = from x in nums where x < 1000 select x;

Console.WriteLine(maxValue2.Max());

IEnumerable<int> value = from y in nums where y > 10 && y < 100 select y;

foreach (int item in value)
{
    Console.WriteLine(item + " ");
}

IEnumerable <int> values = from z in nums where z >= 100000 && z <= 999999 select z;

foreach (int item2 in values)
{
    Console.Write(item2 + ", ");
}

Console.WriteLine();

IEnumerable<int> even = from v in nums where v % 2 == 0 select v;


Console.WriteLine(even.Count());
