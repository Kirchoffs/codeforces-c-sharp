# Notes
## Build & Run
```
>> dotnet new sln
>> dotnet new console -o Codeforces
>> dotnet new mstest -o Codeforces.Tests
>> dotnet sln add ./Codeforces/Codeforces.csproj
>> dotnet sln add ./Codeforces.Tests/Codeforces.Tests.csproj
>> dotnet add ./Codeforces.Tests/Codeforces.Tests.csproj reference ./Codeforces/Codeforces.csproj
```

```
>> cd Codeforces.Tests
>> dotnet test
>> dotnet test --logger:"console;verbosity=detailed"
>> dotnet test --filter:"FullyQualifiedName=Codeforces.construction.Tests.Codeforces_1956_C_Tests.Test"  --logger:"console;verbosity=detailed"
>> dotnet test --filter:"FullyQualifiedName=Codeforces.BinarySearch.Tests.Codeforces_1971_E_Tests.Test"  --logger:"console;verbosity=detailed"
```

## C Sharp Basics
### Boilerplate
```
using System;

namespace HelloWorld;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);
        long a = long.Parse(input[2]);
 
        long flagstonesNeeded = (long) Math.Ceiling((double) n / a) * (long) Math.Ceiling((double) m / a);
 
        Console.WriteLine(flagstonesNeeded);
    }
}
```

```
using System;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            Solve(n);
        }
    }

    static void Solve(int n)
    {
        // res = 1 + 2 * 3 + 3 * 5 + 4 * 7 + ... + n * (2n - 1) = n * (n + 1) * (4n - 1) / 6
        int res = n * (n + 1) * (4 * n - 1) / 6;
        int cnt = n * 2;
        Console.WriteLine($"{res} {cnt}");
        
        for (int i = n; i >= 1; i--)
        {
            Console.Write($"1 {i} ");
            for (int j = 1; j <= n; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
            
            Console.Write($"2 {i} ");
            for (int j = 1; j <= n; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
```
