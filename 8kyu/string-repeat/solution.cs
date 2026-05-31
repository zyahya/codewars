namespace Solution
{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
