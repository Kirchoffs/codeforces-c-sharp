namespace Codeforces.BinarySearch;

public static class Codeforces_1971_E
{
    public static List<object> Solve(int n, int k, int q, List<long> a, List<long> b, List<long> queries)
    {
        List<object> ret = new();

        a.Insert(0, 0);
        b.Insert(0, 0);

        foreach (long query in queries)
        {
            int lastIdx = BinarySearch(a, query);
            if (a[lastIdx] == query)
            {
                ret.Add(b[lastIdx]);
                continue;
            }

            int nextIdx = lastIdx + 1;

            long distToLast = query - a[lastIdx];
            long timeToLast = distToLast * (b[nextIdx] - b[lastIdx]) / (a[nextIdx] - a[lastIdx]);

            ret.Add(b[lastIdx] + timeToLast);
        }
        
        return ret;
    }

    static int BinarySearch(List<long> a, long x)
    {
        int l = 0, r = a.Count;

        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (a[m] <= x)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return l - 1;
    }
}
