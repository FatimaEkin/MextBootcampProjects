class Result
{


    public static int diagonalDifference(List<List<int>> arr)
    {
        int SumOfLeftToRightDia = 0;
        int SumOfRightToLeftDia = 0;

        int leftToRightDiagonalIndex = 0;
        int rightToLeftDiagonalIndex = arr[0].Count - 1;

        foreach (var list in arr)
        {
            SumOfLeftToRightDia += list[leftToRightDiagonalIndex];
            leftToRightDiagonalIndex++;

            SumOfRightToLeftDia += list[rightToLeftDiagonalIndex];
            rightToLeftDiagonalIndex--;
        }

        return Math.Abs(SumOfLeftToRightDia - SumOfRightToLeftDia);

    }

}

class Solution
{
    public static void Main(string[] args)
    {


        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}
