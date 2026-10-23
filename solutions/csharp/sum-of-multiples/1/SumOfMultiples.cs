public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(1, max - 1)
            .Where(number => multiples.Any(baseValue => baseValue != 0 && number % baseValue == 0))
            .Sum();
    }
}