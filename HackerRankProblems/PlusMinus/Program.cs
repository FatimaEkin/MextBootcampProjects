class Result
{


    public static void plusMinus(List<int> arr)
    {
        int countPositive = 0;
        int countNegative = 0;
        int countZero = 0;
        int n = arr.Count;

        foreach (var num in arr)
        {
            if (num > 0)
            {
                countPositive++;
            }
            else if (num < 0)
            {
                countNegative++;
            }
            else
            {
                countZero++;
            }
        }
        double ratioPositive = (double)countPositive / n;
        double ratioNegative = (double)countNegative / n;
        double ratioZero = (double)countZero / n;

        Console.WriteLine(ratioPositive.ToString("F6"));
        Console.WriteLine(ratioNegative.ToString("F6"));
        Console.WriteLine(ratioZero.ToString("F6"));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
