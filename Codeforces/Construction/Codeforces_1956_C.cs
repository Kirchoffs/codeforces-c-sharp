namespace Codeforces.Construction;

public static class Codeforces_1956_C
{
    public static List<Object> Solve(int n)
    {
        List<Object> ret = new();

        // res = 1 + 2 * 3 + 3 * 5 + 4 * 7 + ... + n * (2n - 1) = n * (n + 1) * (4n - 1) / 6
        int res = n * (n + 1) * (4 * n - 1) / 6;
        int cnt = n * 2;
        ret.Add(res);
        ret.Add(cnt);
        
        for (int i = n; i >= 1; i--)
        {
            ret.Add(1);
            ret.Add(i);
            for (int j = 1; j <= n; j++)
            {
                ret.Add(j);
            }

            ret.Add(2);
            ret.Add(i);
            for (int j = 1; j <= n; j++)
            {
                ret.Add(j);
            }
        }

        return ret;
    }
}
